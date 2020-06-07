namespace DogShowTracker
{
    partial class frmAddDogShow
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.txtDogShowName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.nudNumDogs = new System.Windows.Forms.NumericUpDown();
            this.btnAddDogShow = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumDogs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dtpEndDate);
            this.groupBox2.Location = new System.Drawing.Point(12, 160);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(236, 55);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "End Date";
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.Location = new System.Drawing.Point(6, 19);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(203, 20);
            this.dtpEndDate.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtpStartDate);
            this.groupBox1.Location = new System.Drawing.Point(12, 99);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(236, 55);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Start Date";
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Location = new System.Drawing.Point(6, 19);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(203, 20);
            this.dtpStartDate.TabIndex = 0;
            // 
            // txtDogShowName
            // 
            this.txtDogShowName.Location = new System.Drawing.Point(103, 13);
            this.txtDogShowName.Name = "txtDogShowName";
            this.txtDogShowName.Size = new System.Drawing.Size(106, 20);
            this.txtDogShowName.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Dog Show Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Number of Dogs:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.nudNumDogs);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.txtDogShowName);
            this.groupBox3.Location = new System.Drawing.Point(12, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(236, 81);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Details";
            // 
            // nudNumDogs
            // 
            this.nudNumDogs.Location = new System.Drawing.Point(103, 47);
            this.nudNumDogs.Name = "nudNumDogs";
            this.nudNumDogs.Size = new System.Drawing.Size(106, 20);
            this.nudNumDogs.TabIndex = 12;
            this.nudNumDogs.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnAddDogShow
            // 
            this.btnAddDogShow.Location = new System.Drawing.Point(12, 225);
            this.btnAddDogShow.Name = "btnAddDogShow";
            this.btnAddDogShow.Size = new System.Drawing.Size(97, 23);
            this.btnAddDogShow.TabIndex = 13;
            this.btnAddDogShow.Text = "Add Dog Show";
            this.btnAddDogShow.UseVisualStyleBackColor = true;
            this.btnAddDogShow.Click += new System.EventHandler(this.btnAddDogShow_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(130, 225);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(97, 23);
            this.btnCancel.TabIndex = 14;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // frmAddDogShow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(256, 260);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAddDogShow);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmAddDogShow";
            this.Text = "Add Dog Show";
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumDogs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.TextBox txtDogShowName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnAddDogShow;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.NumericUpDown nudNumDogs;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}