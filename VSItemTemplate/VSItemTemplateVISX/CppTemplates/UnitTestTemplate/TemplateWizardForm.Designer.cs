namespace VSItemTemplateVISX.CppTemplates.UnitTestTemplate
{
    partial class TemplateWizardForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbFileName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbTestName = new System.Windows.Forms.TextBox();
            this.rbBaseTestClassDefault = new System.Windows.Forms.RadioButton();
            this.rbBaseTestClassSpecial = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.rbBaseTestClassOther = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.tbAuthor = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbUserName = new System.Windows.Forms.TextBox();
            this.lblEmailDomain = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbDate = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCreate
            // 
            this.btnCreate.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnCreate.Location = new System.Drawing.Point(606, 136);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(75, 23);
            this.btnCreate.TabIndex = 0;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(525, 136);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbBaseTestClassOther);
            this.groupBox1.Controls.Add(this.rbBaseTestClassSpecial);
            this.groupBox1.Controls.Add(this.rbBaseTestClassDefault);
            this.groupBox1.Controls.Add(this.tbTestName);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tbFileName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(323, 150);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Test Configuration";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tbUserName);
            this.groupBox2.Controls.Add(this.lblEmailDomain);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.tbDate);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.tbAuthor);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(341, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(340, 109);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Header Documentation";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "File Name:";
            // 
            // tbFileName
            // 
            this.tbFileName.Location = new System.Drawing.Point(74, 19);
            this.tbFileName.Name = "tbFileName";
            this.tbFileName.ReadOnly = true;
            this.tbFileName.Size = new System.Drawing.Size(243, 20);
            this.tbFileName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Test Name:";
            // 
            // tbTestName
            // 
            this.tbTestName.Location = new System.Drawing.Point(74, 45);
            this.tbTestName.Name = "tbTestName";
            this.tbTestName.Size = new System.Drawing.Size(243, 20);
            this.tbTestName.TabIndex = 1;
            // 
            // rbBaseTestClassDefault
            // 
            this.rbBaseTestClassDefault.AutoSize = true;
            this.rbBaseTestClassDefault.Checked = true;
            this.rbBaseTestClassDefault.Location = new System.Drawing.Point(77, 72);
            this.rbBaseTestClassDefault.Name = "rbBaseTestClassDefault";
            this.rbBaseTestClassDefault.Size = new System.Drawing.Size(70, 17);
            this.rbBaseTestClassDefault.TabIndex = 2;
            this.rbBaseTestClassDefault.TabStop = true;
            this.rbBaseTestClassDefault.Text = "TestCase";
            this.rbBaseTestClassDefault.UseVisualStyleBackColor = true;
            // 
            // rbBaseTestClassSpecial
            // 
            this.rbBaseTestClassSpecial.AutoSize = true;
            this.rbBaseTestClassSpecial.Location = new System.Drawing.Point(77, 95);
            this.rbBaseTestClassSpecial.Name = "rbBaseTestClassSpecial";
            this.rbBaseTestClassSpecial.Size = new System.Drawing.Size(105, 17);
            this.rbBaseTestClassSpecial.TabIndex = 2;
            this.rbBaseTestClassSpecial.Text = "SpecialTestCase";
            this.rbBaseTestClassSpecial.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Inherit From:";
            // 
            // rbBaseTestClassOther
            // 
            this.rbBaseTestClassOther.AutoSize = true;
            this.rbBaseTestClassOther.Location = new System.Drawing.Point(77, 118);
            this.rbBaseTestClassOther.Name = "rbBaseTestClassOther";
            this.rbBaseTestClassOther.Size = new System.Drawing.Size(96, 17);
            this.rbBaseTestClassOther.TabIndex = 2;
            this.rbBaseTestClassOther.Text = "OtherTestCase";
            this.rbBaseTestClassOther.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Author:";
            // 
            // tbAuthor
            // 
            this.tbAuthor.Location = new System.Drawing.Point(55, 19);
            this.tbAuthor.Name = "tbAuthor";
            this.tbAuthor.Size = new System.Drawing.Size(269, 20);
            this.tbAuthor.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Email:";
            // 
            // tbUserName
            // 
            this.tbUserName.Location = new System.Drawing.Point(55, 45);
            this.tbUserName.Name = "tbUserName";
            this.tbUserName.Size = new System.Drawing.Size(153, 20);
            this.tbUserName.TabIndex = 1;
            // 
            // lblEmailDomain
            // 
            this.lblEmailDomain.AutoSize = true;
            this.lblEmailDomain.Location = new System.Drawing.Point(214, 48);
            this.lblEmailDomain.Name = "lblEmailDomain";
            this.lblEmailDomain.Size = new System.Drawing.Size(84, 13);
            this.lblEmailDomain.TabIndex = 0;
            this.lblEmailDomain.Text = "@company.com";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 77);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Date:";
            // 
            // tbDate
            // 
            this.tbDate.Location = new System.Drawing.Point(55, 74);
            this.tbDate.Name = "tbDate";
            this.tbDate.Size = new System.Drawing.Size(153, 20);
            this.tbDate.TabIndex = 1;
            // 
            // TemplateWizardForm
            // 
            this.AcceptButton = this.btnCreate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(693, 171);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnCreate);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TemplateWizardForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Template Wizard";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbBaseTestClassOther;
        private System.Windows.Forms.RadioButton rbBaseTestClassSpecial;
        private System.Windows.Forms.RadioButton rbBaseTestClassDefault;
        private System.Windows.Forms.TextBox tbTestName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbFileName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tbUserName;
        private System.Windows.Forms.Label lblEmailDomain;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbAuthor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbDate;
        private System.Windows.Forms.Label label6;
    }
}