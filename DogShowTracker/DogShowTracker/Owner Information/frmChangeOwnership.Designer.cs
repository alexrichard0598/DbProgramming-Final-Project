namespace DogShowTracker
{
    partial class frmChangeOwnership
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
            this.cmbOwners = new System.Windows.Forms.ComboBox();
            this.grpByOwner = new System.Windows.Forms.GroupBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lstOwnership = new System.Windows.Forms.ListBox();
            this.btnChange = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.grpNames = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbDogs = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.chkDoesEnd = new System.Windows.Forms.CheckBox();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.grpByOwner.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.grpNames.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbOwners
            // 
            this.cmbOwners.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOwners.FormattingEnabled = true;
            this.cmbOwners.Location = new System.Drawing.Point(56, 16);
            this.cmbOwners.Name = "cmbOwners";
            this.cmbOwners.Size = new System.Drawing.Size(266, 21);
            this.cmbOwners.TabIndex = 0;
            this.cmbOwners.SelectedIndexChanged += new System.EventHandler(this.cmbOwners_SelectedIndexChanged);
            // 
            // grpByOwner
            // 
            this.grpByOwner.Controls.Add(this.btnDelete);
            this.grpByOwner.Controls.Add(this.groupBox2);
            this.grpByOwner.Controls.Add(this.btnChange);
            this.grpByOwner.Controls.Add(this.btnAdd);
            this.grpByOwner.Controls.Add(this.grpNames);
            this.grpByOwner.Controls.Add(this.groupBox3);
            this.grpByOwner.Controls.Add(this.groupBox4);
            this.grpByOwner.Location = new System.Drawing.Point(12, 12);
            this.grpByOwner.Name = "grpByOwner";
            this.grpByOwner.Size = new System.Drawing.Size(371, 352);
            this.grpByOwner.TabIndex = 2;
            this.grpByOwner.TabStop = false;
            this.grpByOwner.Text = "By Owner";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(277, 315);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 13;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lstOwnership);
            this.groupBox2.Location = new System.Drawing.Point(6, 175);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(346, 134);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Selected Ownership";
            // 
            // lstOwnership
            // 
            this.lstOwnership.FormattingEnabled = true;
            this.lstOwnership.Location = new System.Drawing.Point(6, 19);
            this.lstOwnership.Name = "lstOwnership";
            this.lstOwnership.Size = new System.Drawing.Size(334, 108);
            this.lstOwnership.TabIndex = 2;
            this.lstOwnership.SelectedIndexChanged += new System.EventHandler(this.lstOwnership_SelectedIndexChanged);
            // 
            // btnChange
            // 
            this.btnChange.Location = new System.Drawing.Point(147, 315);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(75, 23);
            this.btnChange.TabIndex = 12;
            this.btnChange.Text = "Change";
            this.btnChange.UseVisualStyleBackColor = true;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(6, 315);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 11;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // grpNames
            // 
            this.grpNames.Controls.Add(this.label1);
            this.grpNames.Controls.Add(this.cmbOwners);
            this.grpNames.Controls.Add(this.label2);
            this.grpNames.Controls.Add(this.cmbDogs);
            this.grpNames.Location = new System.Drawing.Point(6, 19);
            this.grpNames.Name = "grpNames";
            this.grpNames.Size = new System.Drawing.Size(346, 75);
            this.grpNames.TabIndex = 10;
            this.grpNames.TabStop = false;
            this.grpNames.Text = "Names";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Owner:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Dog:";
            // 
            // cmbDogs
            // 
            this.cmbDogs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDogs.FormattingEnabled = true;
            this.cmbDogs.Location = new System.Drawing.Point(56, 43);
            this.cmbDogs.Name = "cmbDogs";
            this.cmbDogs.Size = new System.Drawing.Size(266, 21);
            this.cmbDogs.TabIndex = 3;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.chkDoesEnd);
            this.groupBox3.Controls.Add(this.dtpEndDate);
            this.groupBox3.Location = new System.Drawing.Point(182, 100);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(170, 69);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "End Date";
            // 
            // chkDoesEnd
            // 
            this.chkDoesEnd.AutoSize = true;
            this.chkDoesEnd.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkDoesEnd.Location = new System.Drawing.Point(6, 45);
            this.chkDoesEnd.Name = "chkDoesEnd";
            this.chkDoesEnd.Size = new System.Drawing.Size(106, 17);
            this.chkDoesEnd.TabIndex = 2;
            this.chkDoesEnd.Text = "Ownership Ends:";
            this.chkDoesEnd.UseVisualStyleBackColor = true;
            this.chkDoesEnd.CheckedChanged += new System.EventHandler(this.chkDoesEnd_CheckedChanged);
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.Enabled = false;
            this.dtpEndDate.Location = new System.Drawing.Point(6, 19);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(140, 20);
            this.dtpEndDate.TabIndex = 1;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dtpStartDate);
            this.groupBox4.Location = new System.Drawing.Point(6, 100);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(170, 69);
            this.groupBox4.TabIndex = 8;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Start Date";
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Location = new System.Drawing.Point(6, 19);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(140, 20);
            this.dtpStartDate.TabIndex = 0;
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // frmChangeOwnership
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 373);
            this.Controls.Add(this.grpByOwner);
            this.Name = "frmChangeOwnership";
            this.Text = "Change Ownership";
            this.Load += new System.EventHandler(this.frmChangeOwnership_Load);
            this.grpByOwner.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.grpNames.ResumeLayout(false);
            this.grpNames.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbOwners;
        private System.Windows.Forms.GroupBox grpByOwner;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbDogs;
        private System.Windows.Forms.ListBox lstOwnership;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.GroupBox grpNames;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox chkDoesEnd;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}