namespace DogShowTracker
{
    partial class frmUpdateOwner
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtDateOfRetirement = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.chkRetired = new System.Windows.Forms.CheckBox();
            this.txtFName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMName = new System.Windows.Forms.TextBox();
            this.dtpDOB = new System.Windows.Forms.DateTimePicker();
            this.txtLName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lstOwners = new System.Windows.Forms.ListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.groupBox1);
            this.groupBox2.Controls.Add(this.txtFName);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtMName);
            this.groupBox2.Controls.Add(this.dtpDOB);
            this.groupBox2.Controls.Add(this.txtLName);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(281, 217);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Owner Info";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "First Name:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtDateOfRetirement);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.chkRetired);
            this.groupBox1.Location = new System.Drawing.Point(7, 123);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(255, 80);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Retirement Info";
            // 
            // dtDateOfRetirement
            // 
            this.dtDateOfRetirement.CustomFormat = " ";
            this.dtDateOfRetirement.Enabled = false;
            this.dtDateOfRetirement.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtDateOfRetirement.Location = new System.Drawing.Point(110, 19);
            this.dtDateOfRetirement.Name = "dtDateOfRetirement";
            this.dtDateOfRetirement.Size = new System.Drawing.Size(131, 20);
            this.dtDateOfRetirement.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Date of Retirement:";
            // 
            // chkRetired
            // 
            this.chkRetired.AutoSize = true;
            this.chkRetired.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkRetired.Enabled = false;
            this.chkRetired.Location = new System.Drawing.Point(58, 45);
            this.chkRetired.Name = "chkRetired";
            this.chkRetired.Size = new System.Drawing.Size(63, 17);
            this.chkRetired.TabIndex = 0;
            this.chkRetired.Text = "Retired:";
            this.chkRetired.UseVisualStyleBackColor = true;
            this.chkRetired.CheckedChanged += new System.EventHandler(this.chkRetired_CheckedChanged);
            // 
            // txtFName
            // 
            this.txtFName.Location = new System.Drawing.Point(117, 19);
            this.txtFName.Name = "txtFName";
            this.txtFName.Size = new System.Drawing.Size(131, 20);
            this.txtFName.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Date of Birth:";
            // 
            // txtMName
            // 
            this.txtMName.Location = new System.Drawing.Point(117, 45);
            this.txtMName.Name = "txtMName";
            this.txtMName.Size = new System.Drawing.Size(131, 20);
            this.txtMName.TabIndex = 12;
            // 
            // dtpDOB
            // 
            this.dtpDOB.Location = new System.Drawing.Point(117, 97);
            this.dtpDOB.Name = "dtpDOB";
            this.dtpDOB.Size = new System.Drawing.Size(131, 20);
            this.dtpDOB.TabIndex = 17;
            // 
            // txtLName
            // 
            this.txtLName.Location = new System.Drawing.Point(117, 71);
            this.txtLName.Name = "txtLName";
            this.txtLName.Size = new System.Drawing.Size(131, 20);
            this.txtLName.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Last Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Middle Name:";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(36, 235);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(87, 23);
            this.btnUpdate.TabIndex = 22;
            this.btnUpdate.Text = "Update Owner";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(185, 235);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 23;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lstOwners
            // 
            this.lstOwners.FormattingEnabled = true;
            this.lstOwners.Location = new System.Drawing.Point(6, 15);
            this.lstOwners.Name = "lstOwners";
            this.lstOwners.Size = new System.Drawing.Size(355, 225);
            this.lstOwners.TabIndex = 24;
            this.lstOwners.SelectedIndexChanged += new System.EventHandler(this.lstOwners_SelectedIndexChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lstOwners);
            this.groupBox3.Location = new System.Drawing.Point(317, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(367, 246);
            this.groupBox3.TabIndex = 25;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Owners";
            // 
            // frmUpdateOwner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 273);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.groupBox2);
            this.Name = "frmUpdateOwner";
            this.Text = "frmUpdateOwner";
            this.Load += new System.EventHandler(this.frmUpdateOwner_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtDateOfRetirement;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox chkRetired;
        private System.Windows.Forms.TextBox txtFName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMName;
        private System.Windows.Forms.DateTimePicker dtpDOB;
        private System.Windows.Forms.TextBox txtLName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ListBox lstOwners;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}