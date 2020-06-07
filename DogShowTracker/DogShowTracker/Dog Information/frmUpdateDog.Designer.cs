namespace DogShowTracker
{
    partial class frmUpdateDog
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
            this.components = new System.ComponentModel.Container();
            this.grpDogInfo = new System.Windows.Forms.GroupBox();
            this.nudHeight = new System.Windows.Forms.NumericUpDown();
            this.nudWeight = new System.Windows.Forms.NumericUpDown();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.chkBanned = new System.Windows.Forms.CheckBox();
            this.dtpDateBanned = new System.Windows.Forms.DateTimePicker();
            this.label20 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label21 = new System.Windows.Forms.Label();
            this.chkChampion = new System.Windows.Forms.CheckBox();
            this.dtpChampionshipDate = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkRetired = new System.Windows.Forms.CheckBox();
            this.dtpDateOfRetirement = new System.Windows.Forms.DateTimePicker();
            this.label17 = new System.Windows.Forms.Label();
            this.cmbDogToUpdate = new System.Windows.Forms.ComboBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.cmbBreed = new System.Windows.Forms.ComboBox();
            this.dtpDateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.grpSex = new System.Windows.Forms.GroupBox();
            this.rdoFemale = new System.Windows.Forms.RadioButton();
            this.rdoMale = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.grpDogInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudWeight)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.grpSex.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // grpDogInfo
            // 
            this.grpDogInfo.Controls.Add(this.nudHeight);
            this.grpDogInfo.Controls.Add(this.nudWeight);
            this.grpDogInfo.Controls.Add(this.groupBox3);
            this.grpDogInfo.Controls.Add(this.groupBox2);
            this.grpDogInfo.Controls.Add(this.groupBox1);
            this.grpDogInfo.Controls.Add(this.cmbDogToUpdate);
            this.grpDogInfo.Controls.Add(this.txtName);
            this.grpDogInfo.Controls.Add(this.cmbBreed);
            this.grpDogInfo.Controls.Add(this.dtpDateOfBirth);
            this.grpDogInfo.Controls.Add(this.label1);
            this.grpDogInfo.Controls.Add(this.label2);
            this.grpDogInfo.Controls.Add(this.label4);
            this.grpDogInfo.Controls.Add(this.label5);
            this.grpDogInfo.Controls.Add(this.label6);
            this.grpDogInfo.Controls.Add(this.grpSex);
            this.grpDogInfo.Controls.Add(this.label8);
            this.grpDogInfo.Location = new System.Drawing.Point(12, 12);
            this.grpDogInfo.Name = "grpDogInfo";
            this.grpDogInfo.Size = new System.Drawing.Size(544, 258);
            this.grpDogInfo.TabIndex = 17;
            this.grpDogInfo.TabStop = false;
            this.grpDogInfo.Text = "Dog Information";
            // 
            // nudHeight
            // 
            this.nudHeight.DecimalPlaces = 1;
            this.nudHeight.Location = new System.Drawing.Point(96, 158);
            this.nudHeight.Name = "nudHeight";
            this.nudHeight.Size = new System.Drawing.Size(132, 20);
            this.nudHeight.TabIndex = 36;
            this.nudHeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // nudWeight
            // 
            this.nudWeight.DecimalPlaces = 1;
            this.nudWeight.Location = new System.Drawing.Point(96, 132);
            this.nudWeight.Name = "nudWeight";
            this.nudWeight.Size = new System.Drawing.Size(132, 20);
            this.nudWeight.TabIndex = 35;
            this.nudWeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.chkBanned);
            this.groupBox3.Controls.Add(this.dtpDateBanned);
            this.groupBox3.Controls.Add(this.label20);
            this.groupBox3.Location = new System.Drawing.Point(263, 174);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(263, 73);
            this.groupBox3.TabIndex = 20;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Disqualification";
            // 
            // chkBanned
            // 
            this.chkBanned.AutoSize = true;
            this.chkBanned.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkBanned.Location = new System.Drawing.Point(64, 19);
            this.chkBanned.Name = "chkBanned";
            this.chkBanned.Size = new System.Drawing.Size(66, 17);
            this.chkBanned.TabIndex = 25;
            this.chkBanned.Text = "Banned:";
            this.chkBanned.UseVisualStyleBackColor = true;
            this.chkBanned.CheckedChanged += new System.EventHandler(this.EnableDateTimePickers);
            // 
            // dtpDateBanned
            // 
            this.dtpDateBanned.Checked = false;
            this.dtpDateBanned.CustomFormat = " ";
            this.dtpDateBanned.Location = new System.Drawing.Point(115, 42);
            this.dtpDateBanned.Name = "dtpDateBanned";
            this.dtpDateBanned.Size = new System.Drawing.Size(116, 20);
            this.dtpDateBanned.TabIndex = 28;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(36, 42);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(73, 13);
            this.label20.TabIndex = 29;
            this.label20.Text = "Date Banned:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label21);
            this.groupBox2.Controls.Add(this.chkChampion);
            this.groupBox2.Controls.Add(this.dtpChampionshipDate);
            this.groupBox2.Location = new System.Drawing.Point(263, 98);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(263, 70);
            this.groupBox2.TabIndex = 34;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Championship";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(7, 42);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(102, 13);
            this.label21.TabIndex = 31;
            this.label21.Text = "Championship Date:";
            // 
            // chkChampion
            // 
            this.chkChampion.AutoSize = true;
            this.chkChampion.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkChampion.Location = new System.Drawing.Point(54, 19);
            this.chkChampion.Name = "chkChampion";
            this.chkChampion.Size = new System.Drawing.Size(76, 17);
            this.chkChampion.TabIndex = 26;
            this.chkChampion.Text = "Champion:";
            this.chkChampion.UseVisualStyleBackColor = true;
            this.chkChampion.CheckedChanged += new System.EventHandler(this.EnableDateTimePickers);
            // 
            // dtpChampionshipDate
            // 
            this.dtpChampionshipDate.Checked = false;
            this.dtpChampionshipDate.CustomFormat = " ";
            this.dtpChampionshipDate.Location = new System.Drawing.Point(115, 42);
            this.dtpChampionshipDate.Name = "dtpChampionshipDate";
            this.dtpChampionshipDate.Size = new System.Drawing.Size(116, 20);
            this.dtpChampionshipDate.TabIndex = 30;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkRetired);
            this.groupBox1.Controls.Add(this.dtpDateOfRetirement);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Location = new System.Drawing.Point(263, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(263, 73);
            this.groupBox1.TabIndex = 33;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Retirement";
            // 
            // chkRetired
            // 
            this.chkRetired.AutoSize = true;
            this.chkRetired.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkRetired.Location = new System.Drawing.Point(67, 19);
            this.chkRetired.Name = "chkRetired";
            this.chkRetired.Size = new System.Drawing.Size(63, 17);
            this.chkRetired.TabIndex = 21;
            this.chkRetired.Text = "Retired:";
            this.chkRetired.UseVisualStyleBackColor = true;
            this.chkRetired.CheckedChanged += new System.EventHandler(this.EnableDateTimePickers);
            // 
            // dtpDateOfRetirement
            // 
            this.dtpDateOfRetirement.Checked = false;
            this.dtpDateOfRetirement.CustomFormat = " ";
            this.dtpDateOfRetirement.Location = new System.Drawing.Point(115, 42);
            this.dtpDateOfRetirement.Name = "dtpDateOfRetirement";
            this.dtpDateOfRetirement.Size = new System.Drawing.Size(116, 20);
            this.dtpDateOfRetirement.TabIndex = 17;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(22, 42);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(87, 13);
            this.label17.TabIndex = 22;
            this.label17.Text = "Retirement Date:";
            // 
            // cmbDogToUpdate
            // 
            this.cmbDogToUpdate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDogToUpdate.FormattingEnabled = true;
            this.cmbDogToUpdate.Location = new System.Drawing.Point(96, 22);
            this.cmbDogToUpdate.Name = "cmbDogToUpdate";
            this.cmbDogToUpdate.Size = new System.Drawing.Size(132, 21);
            this.cmbDogToUpdate.TabIndex = 32;
            this.cmbDogToUpdate.SelectedIndexChanged += new System.EventHandler(this.cmbDogToUpdate_SelectedIndexChanged);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(96, 50);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(132, 20);
            this.txtName.TabIndex = 27;
            // 
            // cmbBreed
            // 
            this.cmbBreed.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBreed.FormattingEnabled = true;
            this.cmbBreed.Location = new System.Drawing.Point(96, 219);
            this.cmbBreed.Name = "cmbBreed";
            this.cmbBreed.Size = new System.Drawing.Size(132, 21);
            this.cmbBreed.TabIndex = 18;
            // 
            // dtpDateOfBirth
            // 
            this.dtpDateOfBirth.Location = new System.Drawing.Point(96, 187);
            this.dtpDateOfBirth.Name = "dtpDateOfBirth";
            this.dtpDateOfBirth.Size = new System.Drawing.Size(132, 20);
            this.dtpDateOfBirth.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Dog To Update:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(46, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Weight:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(49, 161);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Height:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 191);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Date of Birth:";
            // 
            // grpSex
            // 
            this.grpSex.Controls.Add(this.rdoFemale);
            this.grpSex.Controls.Add(this.rdoMale);
            this.grpSex.Location = new System.Drawing.Point(96, 76);
            this.grpSex.Name = "grpSex";
            this.grpSex.Size = new System.Drawing.Size(132, 50);
            this.grpSex.TabIndex = 9;
            this.grpSex.TabStop = false;
            this.grpSex.Text = "Sex";
            // 
            // rdoFemale
            // 
            this.rdoFemale.AutoSize = true;
            this.rdoFemale.Location = new System.Drawing.Point(67, 19);
            this.rdoFemale.Name = "rdoFemale";
            this.rdoFemale.Size = new System.Drawing.Size(59, 17);
            this.rdoFemale.TabIndex = 1;
            this.rdoFemale.TabStop = true;
            this.rdoFemale.Text = "Female";
            this.rdoFemale.UseVisualStyleBackColor = true;
            // 
            // rdoMale
            // 
            this.rdoMale.AutoSize = true;
            this.rdoMale.Location = new System.Drawing.Point(6, 19);
            this.rdoMale.Name = "rdoMale";
            this.rdoMale.Size = new System.Drawing.Size(48, 17);
            this.rdoMale.TabIndex = 0;
            this.rdoMale.TabStop = true;
            this.rdoMale.Text = "Male";
            this.rdoMale.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(52, 222);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Breed:";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(180, 276);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 18;
            this.btnUpdate.Text = "Update Dog";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(300, 276);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 19;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // frmUpdateDog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 307);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.grpDogInfo);
            this.Name = "frmUpdateDog";
            this.Text = "Update Dog";
            this.Load += new System.EventHandler(this.frmUpdateDog_Load);
            this.grpDogInfo.ResumeLayout(false);
            this.grpDogInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudWeight)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grpSex.ResumeLayout(false);
            this.grpSex.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpDogInfo;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.DateTimePicker dtpChampionshipDate;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.DateTimePicker dtpDateBanned;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.CheckBox chkChampion;
        private System.Windows.Forms.CheckBox chkBanned;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.CheckBox chkRetired;
        private System.Windows.Forms.ComboBox cmbBreed;
        private System.Windows.Forms.DateTimePicker dtpDateOfRetirement;
        private System.Windows.Forms.DateTimePicker dtpDateOfBirth;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox grpSex;
        private System.Windows.Forms.RadioButton rdoFemale;
        private System.Windows.Forms.RadioButton rdoMale;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ComboBox cmbDogToUpdate;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown nudHeight;
        private System.Windows.Forms.NumericUpDown nudWeight;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}