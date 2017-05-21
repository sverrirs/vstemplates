using System;
using System.Collections.Generic;
using System.DirectoryServices.AccountManagement;
using System.IO;
using System.Windows.Forms;
using EnvDTE;
using Microsoft.VisualStudio.TemplateWizard;

namespace VSItemTemplateVISX.CppTemplates.UnitTestTemplate
{
    /// <summary>
    /// Template wizard extensions are run when Visual Studio is instantiating a project or item from a template.
    /// Sequence of calls for Items is:
    ///     RunStarted 
    ///         - First call (should collect data from user)
    ///     ShouldAddProjectItem 
    ///         - The template object is passed in (e.g. "unittest.cpp") 
    ///         - Nothing has been done, this is an option to selectively exclude files
    ///     ProjectItemFinishedGenerating 
    ///         - Values have been applied to template and file final result file added to Project
    ///     BeforeOpeningFile 
    ///         - File is being opened in Editor
    ///     RunFinished 
    ///         - The template operation is completed
    /// </summary>
    public class TemplateWizard : IWizard
    {
        /// <summary>
        /// the main Visual Studio core automation
        /// </summary>
        private DTE _dte;

        /// <summary>
        /// Indicates if the user cancelled the wizard
        /// </summary>
        private bool _userCancelled;

        public void RunStarted(
            object automationObject, 
            Dictionary<string, string> values, 
            WizardRunKind runKind,
            object[] customParams)
        {
            // Resolve the main Visual Studio core automation entry point
            // https://msdn.microsoft.com/en-us/library/envdte.aspx
            _dte = (DTE)automationObject;

            /* 
             * Any XML data supplied in the <WizardData> element in the .vstemplate 
             * file will be available under values["$WizardData$"]
             */

            using (var wizard = new TemplateWizardForm())
            {
                string authorName = UserPrincipal.Current.Name;
                string authorDisplayName = UserPrincipal.Current.DisplayName;
                string givenName = UserPrincipal.Current.GivenName;
                string email = UserPrincipal.Current.EmailAddress;

                wizard.FileName = Path.GetFileName(values["$rootname$"]);
                wizard.TestName = values["$safeitemname$"];
                wizard.Author = !string.IsNullOrWhiteSpace(authorDisplayName) ? authorDisplayName : 
                                !string.IsNullOrWhiteSpace(givenName) ? givenName :
                                !string.IsNullOrWhiteSpace(authorName) ? authorName :
                                values["$username$"];
                wizard.UserName = values["$username$"];
                wizard.Date = DateTime.Now.ToString("yyyy-MM-dd");
                wizard.EmailDomain = values["$email_domain$"];

                if (wizard.ShowDialog() != DialogResult.OK)
                {
                    _userCancelled = true;
                    return;
                }

                // Extract the values the user entered and update the template
                values["$test_name$"] = wizard.TestName;
                values["$base_test_class$"] = wizard.BaseTestClass;
                values["$author$"] = wizard.Author;
                values["$username$"] = wizard.UserName;
                values["$date$"] = wizard.Date;
            }
        }

        /// <summary>
        /// Run when a project has finished generating
        /// Only called when creating a Project <see cref="WizardRunKind.AsNewProject"/>. (not for <see cref="WizardRunKind.AsNewItem"/>)
        /// </summary>
        /// <param name="project">The project that finished generating</param>
        public void ProjectFinishedGenerating(Project project)
        {}

        /// <summary>
        /// Run when a project item has finished generating.
        /// </summary>
        /// <param name="projectItem">The project item that finished generating</param>
        public void ProjectItemFinishedGenerating(ProjectItem projectItem)
        {}

        /// <summary>
        /// Indicates whether the specified project item should be added to the project.
        /// </summary>
        /// <param name="filePath">The path to the project item</param>
        /// <returns>true if the project item should be added to the project; otherwise, false.</returns>
        public bool ShouldAddProjectItem(string filePath)
        {
            // Ensure that nothing gets added if the 
            // user clicked the cancel button in the Wizard
            return !_userCancelled;
        }

        /// <summary>
        /// Run before opening an item in the template in the Visual Studio Editor.
        /// </summary>
        /// <param name="projectItem">The project item that will be opened.</param>
        public void BeforeOpeningFile(ProjectItem projectItem)
        {}

        /// <summary>
        /// Run when the wizard has completed all tasks.
        /// </summary>
        public void RunFinished()
        {}
    }
}
