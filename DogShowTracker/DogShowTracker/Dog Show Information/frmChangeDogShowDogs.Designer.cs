namespace DogShowTracker
{
    partial class frmChangeDogShowDogs
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
            this.cmbDogShow = new System.Windows.Forms.ComboBox();
            this.grpDogShow = new System.Windows.Forms.GroupBox();
            this.lstDogs = new System.Windows.Forms.ListBox();
            this.cmbDogs = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnModifyDog = new System.Windows.Forms.Button();
            this.chkDisqualified = new System.Windows.Forms.CheckBox();
            this.nudRank = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAddDog = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnRemoveDogs = new System.Windows.Forms.Button();
            this.txtNumDogs = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.grpDogShow.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudRank)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbDogShow
            // 
            this.cmbDogShow.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDogShow.FormattingEnabled = true;
            this.cmbDogShow.Location = new System.Drawing.Point(6, 19);
            this.cmbDogShow.Name = "cmbDogShow";
            this.cmbDogShow.Size = new System.Drawing.Size(291, 21);
            this.cmbDogShow.TabIndex = 0;
            this.cmbDogShow.SelectedIndexChanged += new System.EventHandler(this.cmbDogShow_SelectedIndexChanged);
            // 
            // grpDogShow
            // 
            this.grpDogShow.Controls.Add(this.cmbDogShow);
            this.grpDogShow.Location = new System.Drawing.Point(12, 12);
            this.grpDogShow.Name = "grpDogShow";
            this.grpDogShow.Size = new System.Drawing.Size(303, 52);
            this.grpDogShow.TabIndex = 1;
            this.grpDogShow.TabStop = false;
            this.grpDogShow.Text = "Dog Show";
            // 
            // lstDogs
            // 
            this.lstDogs.FormattingEnabled = true;
            this.lstDogs.Location = new System.Drawing.Point(6, 48);
            this.lstDogs.Name = "lstDogs";
            this.lstDogs.Size = new System.Drawing.Size(291, 160);
            this.lstDogs.TabIndex = 2;
            this.lstDogs.SelectedIndexChanged += new System.EventHandler(this.lstDogs_SelectedIndexChanged);
            // 
            // cmbDogs
            // 
            this.cmbDogs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDogs.FormattingEnabled = true;
            this.cmbDogs.Location = new System.Drawing.Point(6, 19);
            this.cmbDogs.Name = "cmbDogs";
            this.cmbDogs.Size = new System.Drawing.Size(186, 21);
            this.cmbDogs.TabIndex = 3;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnModifyDog);
            this.groupBox2.Controls.Add(this.chkDisqualified);
            this.groupBox2.Controls.Add(this.nudRank);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.btnAddDog);
            this.groupBox2.Controls.Add(this.cmbDogs);
            this.groupBox2.Location = new System.Drawing.Point(12, 74);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(303, 81);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Assign Dogs";
            // 
            // btnModifyDog
            // 
            this.btnModifyDog.Location = new System.Drawing.Point(222, 50);
            this.btnModifyDog.Name = "btnModifyDog";
            this.btnModifyDog.Size = new System.Drawing.Size(75, 23);
            this.btnModifyDog.TabIndex = 10;
            this.btnModifyDog.Text = "Modify Dog";
            this.btnModifyDog.UseVisualStyleBackColor = true;
            this.btnModifyDog.Click += new System.EventHandler(this.btnModifyDog_Click);
            // 
            // chkDisqualified
            // 
            this.chkDisqualified.AutoSize = true;
            this.chkDisqualified.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkDisqualified.Location = new System.Drawing.Point(6, 51);
            this.chkDisqualified.Name = "chkDisqualified";
            this.chkDisqualified.Size = new System.Drawing.Size(83, 17);
            this.chkDisqualified.TabIndex = 9;
            this.chkDisqualified.Text = "Disqualified:";
            this.chkDisqualified.UseVisualStyleBackColor = true;
            this.chkDisqualified.CheckedChanged += new System.EventHandler(this.chkDisqualified_CheckedChanged);
            // 
            // nudRank
            // 
            this.nudRank.Location = new System.Drawing.Point(146, 50);
            this.nudRank.Name = "nudRank";
            this.nudRank.Size = new System.Drawing.Size(46, 20);
            this.nudRank.TabIndex = 8;
            this.nudRank.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(104, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Rank:";
            // 
            // btnAddDog
            // 
            this.btnAddDog.Location = new System.Drawing.Point(222, 17);
            this.btnAddDog.Name = "btnAddDog";
            this.btnAddDog.Size = new System.Drawing.Size(75, 23);
            this.btnAddDog.TabIndex = 5;
            this.btnAddDog.Text = "Add Dog";
            this.btnAddDog.UseVisualStyleBackColor = true;
            this.btnAddDog.Click += new System.EventHandler(this.btnAddDog_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnRemoveDogs);
            this.groupBox3.Controls.Add(this.txtNumDogs);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.lstDogs);
            this.groupBox3.Location = new System.Drawing.Point(12, 161);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(303, 220);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Current Dogs";
            // 
            // btnRemoveDogs
            // 
            this.btnRemoveDogs.Location = new System.Drawing.Point(6, 19);
            this.btnRemoveDogs.Name = "btnRemoveDogs";
            this.btnRemoveDogs.Size = new System.Drawing.Size(82, 23);
            this.btnRemoveDogs.TabIndex = 3;
            this.btnRemoveDogs.Text = "Remove Dog";
            this.btnRemoveDogs.UseVisualStyleBackColor = true;
            this.btnRemoveDogs.Click += new System.EventHandler(this.btnRemoveDogs_Click);
            // 
            // txtNumDogs
            // 
            this.txtNumDogs.Location = new System.Drawing.Point(236, 21);
            this.txtNumDogs.Name = "txtNumDogs";
            this.txtNumDogs.ReadOnly = true;
            this.txtNumDogs.Size = new System.Drawing.Size(42, 20);
            this.txtNumDogs.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(143, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Number of Dogs:";
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // frmChangeDogShowDogs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 393);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.grpDogShow);
            this.Name = "frmChangeDogShowDogs";
            this.Text = "Change Dog Show Dogs";
            this.Load += new System.EventHandler(this.frmChangeDogShowDogs_Load);
            this.grpDogShow.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudRank)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbDogShow;
        private System.Windows.Forms.GroupBox grpDogShow;
        private System.Windows.Forms.ListBox lstDogs;
        private System.Windows.Forms.ComboBox cmbDogs;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnAddDog;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtNumDogs;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRemoveDogs;
        private System.Windows.Forms.CheckBox chkDisqualified;
        private System.Windows.Forms.NumericUpDown nudRank;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.Button btnModifyDog;
    }
}