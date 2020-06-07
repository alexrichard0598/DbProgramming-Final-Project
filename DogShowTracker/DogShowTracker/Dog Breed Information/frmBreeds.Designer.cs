namespace DogShowTracker
{
    partial class frmBreeds
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
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.cmbClass = new System.Windows.Forms.ComboBox();
            this.cmbPrimary = new System.Windows.Forms.ComboBox();
            this.cmbSecondary = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.grpBreedInfo = new System.Windows.Forms.GroupBox();
            this.grpBreeds = new System.Windows.Forms.GroupBox();
            this.lstBreeds = new System.Windows.Forms.ListBox();
            this.btnNewBreed = new System.Windows.Forms.Button();
            this.btnNewClass = new System.Windows.Forms.Button();
            this.btnNewColour = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDeleteBreed = new System.Windows.Forms.Button();
            this.grpBreedInfo.SuspendLayout();
            this.grpBreeds.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(131, 19);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(121, 20);
            this.txtID.TabIndex = 0;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(131, 55);
            this.txtName.Name = "txtName";
            this.txtName.ReadOnly = true;
            this.txtName.Size = new System.Drawing.Size(121, 20);
            this.txtName.TabIndex = 1;
            // 
            // cmbClass
            // 
            this.cmbClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbClass.Enabled = false;
            this.cmbClass.FormattingEnabled = true;
            this.cmbClass.Location = new System.Drawing.Point(131, 92);
            this.cmbClass.Name = "cmbClass";
            this.cmbClass.Size = new System.Drawing.Size(121, 21);
            this.cmbClass.TabIndex = 2;
            // 
            // cmbPrimary
            // 
            this.cmbPrimary.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPrimary.Enabled = false;
            this.cmbPrimary.FormattingEnabled = true;
            this.cmbPrimary.Location = new System.Drawing.Point(131, 129);
            this.cmbPrimary.Name = "cmbPrimary";
            this.cmbPrimary.Size = new System.Drawing.Size(121, 21);
            this.cmbPrimary.TabIndex = 3;
            // 
            // cmbSecondary
            // 
            this.cmbSecondary.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSecondary.Enabled = false;
            this.cmbSecondary.FormattingEnabled = true;
            this.cmbSecondary.Location = new System.Drawing.Point(131, 166);
            this.cmbSecondary.Name = "cmbSecondary";
            this.cmbSecondary.Size = new System.Drawing.Size(121, 21);
            this.cmbSecondary.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(104, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(87, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(54, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Classification:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Primary Coat Colour:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 169);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Secondary Coat Colour:";
            // 
            // grpBreedInfo
            // 
            this.grpBreedInfo.Controls.Add(this.txtID);
            this.grpBreedInfo.Controls.Add(this.label5);
            this.grpBreedInfo.Controls.Add(this.txtName);
            this.grpBreedInfo.Controls.Add(this.label4);
            this.grpBreedInfo.Controls.Add(this.cmbClass);
            this.grpBreedInfo.Controls.Add(this.label3);
            this.grpBreedInfo.Controls.Add(this.cmbPrimary);
            this.grpBreedInfo.Controls.Add(this.label2);
            this.grpBreedInfo.Controls.Add(this.cmbSecondary);
            this.grpBreedInfo.Controls.Add(this.label1);
            this.grpBreedInfo.Location = new System.Drawing.Point(12, 45);
            this.grpBreedInfo.Name = "grpBreedInfo";
            this.grpBreedInfo.Size = new System.Drawing.Size(279, 201);
            this.grpBreedInfo.TabIndex = 10;
            this.grpBreedInfo.TabStop = false;
            this.grpBreedInfo.Text = "Breed Info";
            // 
            // grpBreeds
            // 
            this.grpBreeds.Controls.Add(this.lstBreeds);
            this.grpBreeds.Location = new System.Drawing.Point(297, 45);
            this.grpBreeds.Name = "grpBreeds";
            this.grpBreeds.Size = new System.Drawing.Size(364, 201);
            this.grpBreeds.TabIndex = 11;
            this.grpBreeds.TabStop = false;
            this.grpBreeds.Text = "Breeds";
            // 
            // lstBreeds
            // 
            this.lstBreeds.FormattingEnabled = true;
            this.lstBreeds.Location = new System.Drawing.Point(6, 19);
            this.lstBreeds.Name = "lstBreeds";
            this.lstBreeds.Size = new System.Drawing.Size(352, 173);
            this.lstBreeds.TabIndex = 0;
            this.lstBreeds.SelectedIndexChanged += new System.EventHandler(this.lstBreeds_SelectedIndexChanged);
            // 
            // btnNewBreed
            // 
            this.btnNewBreed.Location = new System.Drawing.Point(12, 12);
            this.btnNewBreed.Name = "btnNewBreed";
            this.btnNewBreed.Size = new System.Drawing.Size(75, 23);
            this.btnNewBreed.TabIndex = 31;
            this.btnNewBreed.Text = "New Breed";
            this.btnNewBreed.UseVisualStyleBackColor = true;
            this.btnNewBreed.Click += new System.EventHandler(this.btnNewBreed_Click);
            // 
            // btnNewClass
            // 
            this.btnNewClass.Location = new System.Drawing.Point(93, 12);
            this.btnNewClass.Name = "btnNewClass";
            this.btnNewClass.Size = new System.Drawing.Size(75, 23);
            this.btnNewClass.TabIndex = 32;
            this.btnNewClass.Text = "New Class";
            this.btnNewClass.UseVisualStyleBackColor = true;
            this.btnNewClass.Click += new System.EventHandler(this.btnNewClass_Click);
            // 
            // btnNewColour
            // 
            this.btnNewColour.Location = new System.Drawing.Point(174, 12);
            this.btnNewColour.Name = "btnNewColour";
            this.btnNewColour.Size = new System.Drawing.Size(75, 23);
            this.btnNewColour.TabIndex = 33;
            this.btnNewColour.Text = "New Colour";
            this.btnNewColour.UseVisualStyleBackColor = true;
            this.btnNewColour.Click += new System.EventHandler(this.btnNewColour_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(255, 12);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(83, 23);
            this.btnUpdate.TabIndex = 34;
            this.btnUpdate.Text = "Update Breed";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDeleteBreed
            // 
            this.btnDeleteBreed.Location = new System.Drawing.Point(344, 12);
            this.btnDeleteBreed.Name = "btnDeleteBreed";
            this.btnDeleteBreed.Size = new System.Drawing.Size(85, 23);
            this.btnDeleteBreed.TabIndex = 35;
            this.btnDeleteBreed.Text = "Delete Breed";
            this.btnDeleteBreed.UseVisualStyleBackColor = true;
            this.btnDeleteBreed.Click += new System.EventHandler(this.btnDeleteBreed_Click);
            // 
            // frmBreeds
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 259);
            this.Controls.Add(this.btnDeleteBreed);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnNewColour);
            this.Controls.Add(this.btnNewClass);
            this.Controls.Add(this.btnNewBreed);
            this.Controls.Add(this.grpBreeds);
            this.Controls.Add(this.grpBreedInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmBreeds";
            this.Text = "Breed Info";
            this.Load += new System.EventHandler(this.frmBreeds_Load);
            this.grpBreedInfo.ResumeLayout(false);
            this.grpBreedInfo.PerformLayout();
            this.grpBreeds.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.ComboBox cmbClass;
        private System.Windows.Forms.ComboBox cmbPrimary;
        private System.Windows.Forms.ComboBox cmbSecondary;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox grpBreedInfo;
        private System.Windows.Forms.GroupBox grpBreeds;
        private System.Windows.Forms.ListBox lstBreeds;
        private System.Windows.Forms.Button btnNewBreed;
        private System.Windows.Forms.Button btnNewClass;
        private System.Windows.Forms.Button btnNewColour;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDeleteBreed;
    }
}