namespace DogShowTracker
{
    partial class frmUpdateBreed
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
            this.grpBreeds = new System.Windows.Forms.GroupBox();
            this.lstBreeds = new System.Windows.Forms.ListBox();
            this.grpBreedInfo = new System.Windows.Forms.GroupBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbClass = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbPrimary = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbSecondary = new System.Windows.Forms.ComboBox();
            this.grpBreeds.SuspendLayout();
            this.grpBreedInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpBreeds
            // 
            this.grpBreeds.Controls.Add(this.lstBreeds);
            this.grpBreeds.Location = new System.Drawing.Point(297, 12);
            this.grpBreeds.Name = "grpBreeds";
            this.grpBreeds.Size = new System.Drawing.Size(364, 201);
            this.grpBreeds.TabIndex = 13;
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
            // 
            // grpBreedInfo
            // 
            this.grpBreedInfo.Controls.Add(this.btnUpdate);
            this.grpBreedInfo.Controls.Add(this.label5);
            this.grpBreedInfo.Controls.Add(this.txtName);
            this.grpBreedInfo.Controls.Add(this.label4);
            this.grpBreedInfo.Controls.Add(this.cmbClass);
            this.grpBreedInfo.Controls.Add(this.label3);
            this.grpBreedInfo.Controls.Add(this.cmbPrimary);
            this.grpBreedInfo.Controls.Add(this.label2);
            this.grpBreedInfo.Controls.Add(this.cmbSecondary);
            this.grpBreedInfo.Location = new System.Drawing.Point(12, 12);
            this.grpBreedInfo.Name = "grpBreedInfo";
            this.grpBreedInfo.Size = new System.Drawing.Size(279, 201);
            this.grpBreedInfo.TabIndex = 12;
            this.grpBreedInfo.TabStop = false;
            this.grpBreedInfo.Text = "Breed Info";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(131, 163);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(121, 23);
            this.btnUpdate.TabIndex = 10;
            this.btnUpdate.Text = "Update Breed";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Secondary Coat Colour:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(131, 19);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(121, 20);
            this.txtName.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Primary Coat Colour:";
            // 
            // cmbClass
            // 
            this.cmbClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbClass.FormattingEnabled = true;
            this.cmbClass.Location = new System.Drawing.Point(131, 56);
            this.cmbClass.Name = "cmbClass";
            this.cmbClass.Size = new System.Drawing.Size(121, 21);
            this.cmbClass.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(54, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Classification:";
            // 
            // cmbPrimary
            // 
            this.cmbPrimary.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPrimary.FormattingEnabled = true;
            this.cmbPrimary.Location = new System.Drawing.Point(131, 93);
            this.cmbPrimary.Name = "cmbPrimary";
            this.cmbPrimary.Size = new System.Drawing.Size(121, 21);
            this.cmbPrimary.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(87, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Name:";
            // 
            // cmbSecondary
            // 
            this.cmbSecondary.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSecondary.FormattingEnabled = true;
            this.cmbSecondary.Location = new System.Drawing.Point(131, 130);
            this.cmbSecondary.Name = "cmbSecondary";
            this.cmbSecondary.Size = new System.Drawing.Size(121, 21);
            this.cmbSecondary.TabIndex = 4;
            // 
            // frmUpdateBreed
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 223);
            this.Controls.Add(this.grpBreeds);
            this.Controls.Add(this.grpBreedInfo);
            this.Name = "frmUpdateBreed";
            this.Text = "frmUpdateBreed";
            this.Load += new System.EventHandler(this.frmUpdateBreed_Load);
            this.grpBreeds.ResumeLayout(false);
            this.grpBreedInfo.ResumeLayout(false);
            this.grpBreedInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpBreeds;
        private System.Windows.Forms.ListBox lstBreeds;
        private System.Windows.Forms.GroupBox grpBreedInfo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbClass;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbPrimary;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbSecondary;
        private System.Windows.Forms.Button btnUpdate;
    }
}