namespace DogShowTracker
{
    partial class frmAddDog
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
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.nudHeight = new System.Windows.Forms.NumericUpDown();
            this.txtName = new System.Windows.Forms.TextBox();
            this.nudWeight = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.grpSex = new System.Windows.Forms.GroupBox();
            this.rdoFemale = new System.Windows.Forms.RadioButton();
            this.rdoMale = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbBreed = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpDateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label20 = new System.Windows.Forms.Label();
            this.chkBanned = new System.Windows.Forms.CheckBox();
            this.dtpDateBanned = new System.Windows.Forms.DateTimePicker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label21 = new System.Windows.Forms.Label();
            this.chkChampion = new System.Windows.Forms.CheckBox();
            this.dtpChampionshipDate = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtpDateOfRetirement = new System.Windows.Forms.DateTimePicker();
            this.chkRetired = new System.Windows.Forms.CheckBox();
            this.label17 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.grpDogInfo.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudWeight)).BeginInit();
            this.grpSex.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // grpDogInfo
            // 
            this.grpDogInfo.Controls.Add(this.groupBox4);
            this.grpDogInfo.Controls.Add(this.groupBox3);
            this.grpDogInfo.Controls.Add(this.groupBox2);
            this.grpDogInfo.Controls.Add(this.groupBox1);
            this.grpDogInfo.Location = new System.Drawing.Point(12, 12);
            this.grpDogInfo.Name = "grpDogInfo";
            this.grpDogInfo.Size = new System.Drawing.Size(516, 285);
            this.grpDogInfo.TabIndex = 17;
            this.grpDogInfo.TabStop = false;
            this.grpDogInfo.Text = "Dog Information";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.nudHeight);
            this.groupBox4.Controls.Add(this.txtName);
            this.groupBox4.Controls.Add(this.nudWeight);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.grpSex);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.cmbBreed);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.dtpDateOfBirth);
            this.groupBox4.Location = new System.Drawing.Point(9, 19);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(232, 251);
            this.groupBox4.TabIndex = 20;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Required Info";
            // 
            // nudHeight
            // 
            this.nudHeight.DecimalPlaces = 1;
            this.nudHeight.Location = new System.Drawing.Point(81, 132);
            this.nudHeight.Name = "nudHeight";
            this.nudHeight.Size = new System.Drawing.Size(132, 20);
            this.nudHeight.TabIndex = 36;
            this.nudHeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(81, 19);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(132, 20);
            this.txtName.TabIndex = 27;
            // 
            // nudWeight
            // 
            this.nudWeight.DecimalPlaces = 1;
            this.nudWeight.Location = new System.Drawing.Point(81, 106);
            this.nudWeight.Name = "nudWeight";
            this.nudWeight.Size = new System.Drawing.Size(132, 20);
            this.nudWeight.TabIndex = 35;
            this.nudWeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(37, 213);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Breed:";
            // 
            // grpSex
            // 
            this.grpSex.Controls.Add(this.rdoFemale);
            this.grpSex.Controls.Add(this.rdoMale);
            this.grpSex.Location = new System.Drawing.Point(81, 45);
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
            this.rdoMale.Checked = true;
            this.rdoMale.Location = new System.Drawing.Point(6, 19);
            this.rdoMale.Name = "rdoMale";
            this.rdoMale.Size = new System.Drawing.Size(48, 17);
            this.rdoMale.TabIndex = 0;
            this.rdoMale.TabStop = true;
            this.rdoMale.Text = "Male";
            this.rdoMale.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 178);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Date of Birth:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 134);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Height:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Weight:";
            // 
            // cmbBreed
            // 
            this.cmbBreed.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBreed.FormattingEnabled = true;
            this.cmbBreed.Location = new System.Drawing.Point(81, 210);
            this.cmbBreed.Name = "cmbBreed";
            this.cmbBreed.Size = new System.Drawing.Size(132, 21);
            this.cmbBreed.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Name:";
            // 
            // dtpDateOfBirth
            // 
            this.dtpDateOfBirth.Location = new System.Drawing.Point(81, 171);
            this.dtpDateOfBirth.Name = "dtpDateOfBirth";
            this.dtpDateOfBirth.Size = new System.Drawing.Size(132, 20);
            this.dtpDateOfBirth.TabIndex = 16;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label20);
            this.groupBox3.Controls.Add(this.chkBanned);
            this.groupBox3.Controls.Add(this.dtpDateBanned);
            this.groupBox3.Location = new System.Drawing.Point(247, 111);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(258, 70);
            this.groupBox3.TabIndex = 34;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Banned";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(34, 41);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(73, 13);
            this.label20.TabIndex = 29;
            this.label20.Text = "Date Banned:";
            // 
            // chkBanned
            // 
            this.chkBanned.AutoSize = true;
            this.chkBanned.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkBanned.Location = new System.Drawing.Point(62, 15);
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
            this.dtpDateBanned.Enabled = false;
            this.dtpDateBanned.Location = new System.Drawing.Point(113, 35);
            this.dtpDateBanned.Name = "dtpDateBanned";
            this.dtpDateBanned.Size = new System.Drawing.Size(132, 20);
            this.dtpDateBanned.TabIndex = 28;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label21);
            this.groupBox2.Controls.Add(this.chkChampion);
            this.groupBox2.Controls.Add(this.dtpChampionshipDate);
            this.groupBox2.Location = new System.Drawing.Point(247, 197);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(258, 73);
            this.groupBox2.TabIndex = 33;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Championship";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(6, 41);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(102, 13);
            this.label21.TabIndex = 31;
            this.label21.Text = "Championship Date:";
            // 
            // chkChampion
            // 
            this.chkChampion.AutoSize = true;
            this.chkChampion.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkChampion.Location = new System.Drawing.Point(52, 12);
            this.chkChampion.Name = "chkChampion";
            this.chkChampion.Size = new System.Drawing.Size(76, 17);
            this.chkChampion.TabIndex = 26;
            this.chkChampion.Text = "Champion:";
            this.chkChampion.UseVisualStyleBackColor = true;
            this.chkChampion.CheckedChanged += new System.EventHandler(this.EnableDateTimePickers);
            // 
            // dtpChampionshipDate
            // 
            this.dtpChampionshipDate.CustomFormat = " ";
            this.dtpChampionshipDate.Enabled = false;
            this.dtpChampionshipDate.Location = new System.Drawing.Point(114, 35);
            this.dtpChampionshipDate.Name = "dtpChampionshipDate";
            this.dtpChampionshipDate.Size = new System.Drawing.Size(132, 20);
            this.dtpChampionshipDate.TabIndex = 30;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtpDateOfRetirement);
            this.groupBox1.Controls.Add(this.chkRetired);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Location = new System.Drawing.Point(247, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(258, 77);
            this.groupBox1.TabIndex = 32;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Retirement";
            // 
            // dtpDateOfRetirement
            // 
            this.dtpDateOfRetirement.Checked = false;
            this.dtpDateOfRetirement.CustomFormat = " ";
            this.dtpDateOfRetirement.Enabled = false;
            this.dtpDateOfRetirement.Location = new System.Drawing.Point(114, 36);
            this.dtpDateOfRetirement.Name = "dtpDateOfRetirement";
            this.dtpDateOfRetirement.Size = new System.Drawing.Size(132, 20);
            this.dtpDateOfRetirement.TabIndex = 17;
            // 
            // chkRetired
            // 
            this.chkRetired.AutoSize = true;
            this.chkRetired.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkRetired.Location = new System.Drawing.Point(65, 13);
            this.chkRetired.Name = "chkRetired";
            this.chkRetired.Size = new System.Drawing.Size(63, 17);
            this.chkRetired.TabIndex = 21;
            this.chkRetired.Text = "Retired:";
            this.chkRetired.UseVisualStyleBackColor = true;
            this.chkRetired.CheckedChanged += new System.EventHandler(this.EnableDateTimePickers);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(21, 42);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(87, 13);
            this.label17.TabIndex = 22;
            this.label17.Text = "Retirement Date:";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(35, 309);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 18;
            this.btnAdd.Text = "Add Dog";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(142, 309);
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
            // frmAddDog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 344);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.grpDogInfo);
            this.Name = "frmAddDog";
            this.Text = "Add Dog";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmAddDog_FormClosed);
            this.Load += new System.EventHandler(this.frmAddDog_Load);
            this.grpDogInfo.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudWeight)).EndInit();
            this.grpSex.ResumeLayout(false);
            this.grpSex.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpDogInfo;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.CheckBox chkBanned;
        private System.Windows.Forms.DateTimePicker dtpDateBanned;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.CheckBox chkChampion;
        private System.Windows.Forms.DateTimePicker dtpChampionshipDate;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtpDateOfRetirement;
        private System.Windows.Forms.CheckBox chkRetired;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.ComboBox cmbBreed;
        private System.Windows.Forms.DateTimePicker dtpDateOfBirth;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox grpSex;
        private System.Windows.Forms.RadioButton rdoFemale;
        private System.Windows.Forms.RadioButton rdoMale;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.NumericUpDown nudHeight;
        private System.Windows.Forms.NumericUpDown nudWeight;
        private System.Windows.Forms.GroupBox groupBox4;
    }
}