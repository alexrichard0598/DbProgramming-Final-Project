namespace DogShowTracker
{
    partial class frmAddDogBreed
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
            this.txtBreedName = new System.Windows.Forms.TextBox();
            this.cmbPrimaryCoat = new System.Windows.Forms.ComboBox();
            this.cmbSecondaryCoat = new System.Windows.Forms.ComboBox();
            this.cmbClass = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBreedName
            // 
            this.txtBreedName.Location = new System.Drawing.Point(134, 6);
            this.txtBreedName.Name = "txtBreedName";
            this.txtBreedName.Size = new System.Drawing.Size(126, 20);
            this.txtBreedName.TabIndex = 0;
            // 
            // cmbPrimaryCoat
            // 
            this.cmbPrimaryCoat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPrimaryCoat.FormattingEnabled = true;
            this.cmbPrimaryCoat.Location = new System.Drawing.Point(134, 32);
            this.cmbPrimaryCoat.Name = "cmbPrimaryCoat";
            this.cmbPrimaryCoat.Size = new System.Drawing.Size(126, 21);
            this.cmbPrimaryCoat.TabIndex = 1;
            // 
            // cmbSecondaryCoat
            // 
            this.cmbSecondaryCoat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSecondaryCoat.FormattingEnabled = true;
            this.cmbSecondaryCoat.Location = new System.Drawing.Point(134, 59);
            this.cmbSecondaryCoat.Name = "cmbSecondaryCoat";
            this.cmbSecondaryCoat.Size = new System.Drawing.Size(126, 21);
            this.cmbSecondaryCoat.TabIndex = 2;
            // 
            // cmbClass
            // 
            this.cmbClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbClass.FormattingEnabled = true;
            this.cmbClass.Location = new System.Drawing.Point(134, 86);
            this.cmbClass.Name = "cmbClass";
            this.cmbClass.Size = new System.Drawing.Size(126, 21);
            this.cmbClass.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Breed Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Primary Coat Colour:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Secondary Coat Colour";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(62, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Breed Class:";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(15, 125);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(185, 125);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // frmAddDogBreed
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 177);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbClass);
            this.Controls.Add(this.cmbSecondaryCoat);
            this.Controls.Add(this.cmbPrimaryCoat);
            this.Controls.Add(this.txtBreedName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmAddDogBreed";
            this.Text = "Add Dog Breed";
            this.Load += new System.EventHandler(this.frmAddDogBreed_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBreedName;
        private System.Windows.Forms.ComboBox cmbPrimaryCoat;
        private System.Windows.Forms.ComboBox cmbSecondaryCoat;
        private System.Windows.Forms.ComboBox cmbClass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}