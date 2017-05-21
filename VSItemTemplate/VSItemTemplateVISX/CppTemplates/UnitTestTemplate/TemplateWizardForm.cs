using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VSItemTemplateVISX.CppTemplates.UnitTestTemplate
{
    public partial class TemplateWizardForm : Form
    {
        public TemplateWizardForm()
        {
            InitializeComponent();
        }

        public string FileName
        {
            get => this.tbFileName.Text;
            set => this.tbFileName.Text = value;
        }

        public string TestName
        {
            get => this.tbTestName.Text;
            set => this.tbTestName.Text = value;
        }

        public string BaseTestClass
        {
            get
            {
                return this.rbBaseTestClassSpecial.Checked
                    ? "SpecialTestCase"
                    : this.rbBaseTestClassOther.Checked
                        ? "OtherTestCase"
                        : "TestCase";
            }
            set
            {
                this.rbBaseTestClassDefault.Checked = 
                this.rbBaseTestClassSpecial.Checked =
                this.rbBaseTestClassOther.Checked = false;

                switch (value)
                {
                    case "SpecialTestCase":
                        this.rbBaseTestClassSpecial.Checked = true;
                        break;
                    case "OtherTestCase":
                        this.rbBaseTestClassOther.Checked = true;
                        break;
                    default:
                        this.rbBaseTestClassDefault.Checked = true;
                        break;
                }
            }
        }

        public string Author
        {
            get => this.tbAuthor.Text;
            set => this.tbAuthor.Text = value;
        }

        public string UserName
        {
            get => this.tbUserName.Text;
            set => this.tbUserName.Text = value;
        }

        public string Date
        {
            get => this.tbDate.Text;
            set => this.tbDate.Text = value;
        }

        public string EmailDomain
        {
            get => this.lblEmailDomain.Text;
            set => this.lblEmailDomain.Text = value;
        }
    }
}
