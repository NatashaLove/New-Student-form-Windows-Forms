namespace Example_GUI
{
    partial class StudentInformation
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
            this.grpStatus = new System.Windows.Forms.GroupBox();
            this.radSophomore = new System.Windows.Forms.RadioButton();
            this.radFreshman = new System.Windows.Forms.RadioButton();
            this.lblErrors = new System.Windows.Forms.Label();
            this.txtErrors = new System.Windows.Forms.RichTextBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.lblAge = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblMidInit = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtMidInit = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.radJunior = new System.Windows.Forms.RadioButton();
            this.radSenior = new System.Windows.Forms.RadioButton();
            this.radNonDeg = new System.Windows.Forms.RadioButton();
            this.radGrad = new System.Windows.Forms.RadioButton();
            this.lblGPA = new System.Windows.Forms.Label();
            this.txtGPA = new System.Windows.Forms.TextBox();
            this.grpStatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpStatus
            // 
            this.grpStatus.Controls.Add(this.radGrad);
            this.grpStatus.Controls.Add(this.radNonDeg);
            this.grpStatus.Controls.Add(this.radSenior);
            this.grpStatus.Controls.Add(this.radJunior);
            this.grpStatus.Controls.Add(this.radSophomore);
            this.grpStatus.Controls.Add(this.radFreshman);
            this.grpStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpStatus.Location = new System.Drawing.Point(12, 307);
            this.grpStatus.Name = "grpStatus";
            this.grpStatus.Size = new System.Drawing.Size(226, 147);
            this.grpStatus.TabIndex = 30;
            this.grpStatus.TabStop = false;
            this.grpStatus.Text = "Level";
            // 
            // radSophomore
            // 
            this.radSophomore.AutoSize = true;
            this.radSophomore.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radSophomore.Location = new System.Drawing.Point(9, 50);
            this.radSophomore.Name = "radSophomore";
            this.radSophomore.Size = new System.Drawing.Size(97, 20);
            this.radSophomore.TabIndex = 1;
            this.radSophomore.TabStop = true;
            this.radSophomore.Text = "Sophomore";
            this.radSophomore.UseVisualStyleBackColor = true;
            // 
            // radFreshman
            // 
            this.radFreshman.AutoSize = true;
            this.radFreshman.Checked = true;
            this.radFreshman.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radFreshman.Location = new System.Drawing.Point(9, 24);
            this.radFreshman.Name = "radFreshman";
            this.radFreshman.Size = new System.Drawing.Size(86, 20);
            this.radFreshman.TabIndex = 0;
            this.radFreshman.TabStop = true;
            this.radFreshman.Text = "Freshman";
            this.radFreshman.UseVisualStyleBackColor = true;
            // 
            // lblErrors
            // 
            this.lblErrors.AutoSize = true;
            this.lblErrors.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrors.Location = new System.Drawing.Point(16, 464);
            this.lblErrors.Margin = new System.Windows.Forms.Padding(7);
            this.lblErrors.Name = "lblErrors";
            this.lblErrors.Size = new System.Drawing.Size(58, 18);
            this.lblErrors.TabIndex = 29;
            this.lblErrors.Text = "Errors: ";
            // 
            // txtErrors
            // 
            this.txtErrors.Location = new System.Drawing.Point(12, 496);
            this.txtErrors.Margin = new System.Windows.Forms.Padding(7);
            this.txtErrors.Name = "txtErrors";
            this.txtErrors.ReadOnly = true;
            this.txtErrors.Size = new System.Drawing.Size(226, 96);
            this.txtErrors.TabIndex = 28;
            this.txtErrors.Text = "";
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(138, 257);
            this.btnReset.Margin = new System.Windows.Forms.Padding(7);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(100, 40);
            this.btnReset.TabIndex = 27;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(12, 257);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(7);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(100, 40);
            this.btnSubmit.TabIndex = 26;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAge.Location = new System.Drawing.Point(65, 184);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(41, 18);
            this.lblAge.TabIndex = 25;
            this.lblAge.Text = "Age: ";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastName.Location = new System.Drawing.Point(18, 146);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(88, 18);
            this.lblLastName.TabIndex = 24;
            this.lblLastName.Text = "Last Name: ";
            // 
            // lblMidInit
            // 
            this.lblMidInit.AutoSize = true;
            this.lblMidInit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMidInit.Location = new System.Drawing.Point(11, 108);
            this.lblMidInit.Name = "lblMidInit";
            this.lblMidInit.Size = new System.Drawing.Size(95, 18);
            this.lblMidInit.TabIndex = 23;
            this.lblMidInit.Text = "Middle Initial: ";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstName.Location = new System.Drawing.Point(17, 70);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(89, 18);
            this.lblFirstName.TabIndex = 22;
            this.lblFirstName.Text = "First Name: ";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.Location = new System.Drawing.Point(78, 32);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(30, 18);
            this.lblID.TabIndex = 21;
            this.lblID.Text = "ID: ";
            // 
            // txtAge
            // 
            this.txtAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAge.Location = new System.Drawing.Point(116, 181);
            this.txtAge.Margin = new System.Windows.Forms.Padding(7);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(122, 24);
            this.txtAge.TabIndex = 20;
            // 
            // txtLastName
            // 
            this.txtLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLastName.Location = new System.Drawing.Point(116, 143);
            this.txtLastName.Margin = new System.Windows.Forms.Padding(7);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(122, 24);
            this.txtLastName.TabIndex = 19;
            // 
            // txtMidInit
            // 
            this.txtMidInit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMidInit.Location = new System.Drawing.Point(116, 105);
            this.txtMidInit.Margin = new System.Windows.Forms.Padding(7);
            this.txtMidInit.Name = "txtMidInit";
            this.txtMidInit.Size = new System.Drawing.Size(122, 24);
            this.txtMidInit.TabIndex = 18;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFirstName.Location = new System.Drawing.Point(116, 67);
            this.txtFirstName.Margin = new System.Windows.Forms.Padding(7);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(122, 24);
            this.txtFirstName.TabIndex = 17;
            // 
            // txtID
            // 
            this.txtID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.Location = new System.Drawing.Point(116, 29);
            this.txtID.Margin = new System.Windows.Forms.Padding(7);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(122, 24);
            this.txtID.TabIndex = 16;
            // 
            // radJunior
            // 
            this.radJunior.AutoSize = true;
            this.radJunior.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radJunior.Location = new System.Drawing.Point(9, 77);
            this.radJunior.Name = "radJunior";
            this.radJunior.Size = new System.Drawing.Size(62, 20);
            this.radJunior.TabIndex = 2;
            this.radJunior.TabStop = true;
            this.radJunior.Text = "Junior";
            this.radJunior.UseVisualStyleBackColor = true;
            // 
            // radSenior
            // 
            this.radSenior.AutoSize = true;
            this.radSenior.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radSenior.Location = new System.Drawing.Point(9, 106);
            this.radSenior.Name = "radSenior";
            this.radSenior.Size = new System.Drawing.Size(65, 20);
            this.radSenior.TabIndex = 3;
            this.radSenior.TabStop = true;
            this.radSenior.Text = "Senior";
            this.radSenior.UseVisualStyleBackColor = true;
            // 
            // radNonDeg
            // 
            this.radNonDeg.AutoSize = true;
            this.radNonDeg.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radNonDeg.Location = new System.Drawing.Point(117, 24);
            this.radNonDeg.Name = "radNonDeg";
            this.radNonDeg.Size = new System.Drawing.Size(101, 20);
            this.radNonDeg.TabIndex = 4;
            this.radNonDeg.TabStop = true;
            this.radNonDeg.Text = "Non-Degree";
            this.radNonDeg.UseVisualStyleBackColor = true;
            // 
            // radGrad
            // 
            this.radGrad.AutoSize = true;
            this.radGrad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radGrad.Location = new System.Drawing.Point(117, 51);
            this.radGrad.Name = "radGrad";
            this.radGrad.Size = new System.Drawing.Size(82, 20);
            this.radGrad.TabIndex = 5;
            this.radGrad.TabStop = true;
            this.radGrad.Text = "Graduate";
            this.radGrad.UseVisualStyleBackColor = true;
            // 
            // lblGPA
            // 
            this.lblGPA.AutoSize = true;
            this.lblGPA.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGPA.Location = new System.Drawing.Point(65, 222);
            this.lblGPA.Name = "lblGPA";
            this.lblGPA.Size = new System.Drawing.Size(43, 18);
            this.lblGPA.TabIndex = 31;
            this.lblGPA.Text = "GPA:";
            // 
            // txtGPA
            // 
            this.txtGPA.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGPA.Location = new System.Drawing.Point(116, 219);
            this.txtGPA.Margin = new System.Windows.Forms.Padding(7);
            this.txtGPA.Name = "txtGPA";
            this.txtGPA.Size = new System.Drawing.Size(122, 24);
            this.txtGPA.TabIndex = 32;
            // 
            // StudentInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(257, 616);
            this.Controls.Add(this.txtGPA);
            this.Controls.Add(this.lblGPA);
            this.Controls.Add(this.grpStatus);
            this.Controls.Add(this.lblErrors);
            this.Controls.Add(this.txtErrors);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.lblAge);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblMidInit);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtMidInit);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.txtID);
            this.Name = "StudentInformation";
            this.Text = "StudentInformation";
            this.grpStatus.ResumeLayout(false);
            this.grpStatus.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpStatus;
        private System.Windows.Forms.RadioButton radSophomore;
        private System.Windows.Forms.RadioButton radFreshman;
        private System.Windows.Forms.Label lblErrors;
        private System.Windows.Forms.RichTextBox txtErrors;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblMidInit;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtMidInit;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.RadioButton radGrad;
        private System.Windows.Forms.RadioButton radNonDeg;
        private System.Windows.Forms.RadioButton radSenior;
        private System.Windows.Forms.RadioButton radJunior;
        private System.Windows.Forms.Label lblGPA;
        private System.Windows.Forms.TextBox txtGPA;
    }
}