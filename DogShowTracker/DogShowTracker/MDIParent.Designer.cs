namespace DogShowTracker
{
    partial class MDIParent
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
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.btnReloadForm = new System.Windows.Forms.ToolStripButton();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.dogInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ownerInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dogShowInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dogBreedInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.toolStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dogInformationToolStripMenuItem,
            this.ownerInformationToolStripMenuItem,
            this.dogShowInformationToolStripMenuItem,
            this.dogBreedInformationToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(984, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // toolStrip
            // 
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnReloadForm});
            this.toolStrip.Location = new System.Drawing.Point(0, 24);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(984, 25);
            this.toolStrip.TabIndex = 1;
            this.toolStrip.Text = "ToolStrip";
            // 
            // btnReloadForm
            // 
            this.btnReloadForm.Image = global::DogShowTracker.Properties.Resources.Reload_Icon;
            this.btnReloadForm.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnReloadForm.Name = "btnReloadForm";
            this.btnReloadForm.Size = new System.Drawing.Size(99, 22);
            this.btnReloadForm.Text = "Reload Forms";
            this.btnReloadForm.Click += new System.EventHandler(this.btnReloadForm_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 939);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(984, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(39, 17);
            this.toolStripStatusLabel.Text = "Status";
            // 
            // dogInformationToolStripMenuItem
            // 
            this.dogInformationToolStripMenuItem.Name = "dogInformationToolStripMenuItem";
            this.dogInformationToolStripMenuItem.Size = new System.Drawing.Size(107, 20);
            this.dogInformationToolStripMenuItem.Text = "Dog Information";
            this.dogInformationToolStripMenuItem.Click += new System.EventHandler(this.dogInformationToolStripMenuItem_Click);
            // 
            // ownerInformationToolStripMenuItem
            // 
            this.ownerInformationToolStripMenuItem.Name = "ownerInformationToolStripMenuItem";
            this.ownerInformationToolStripMenuItem.Size = new System.Drawing.Size(120, 20);
            this.ownerInformationToolStripMenuItem.Text = "Owner Information";
            this.ownerInformationToolStripMenuItem.Click += new System.EventHandler(this.ownerInformationToolStripMenuItem_Click);
            // 
            // dogShowInformationToolStripMenuItem
            // 
            this.dogShowInformationToolStripMenuItem.Name = "dogShowInformationToolStripMenuItem";
            this.dogShowInformationToolStripMenuItem.Size = new System.Drawing.Size(139, 20);
            this.dogShowInformationToolStripMenuItem.Text = "Dog Show Information";
            this.dogShowInformationToolStripMenuItem.Click += new System.EventHandler(this.dogShowInformationToolStripMenuItem_Click);
            // 
            // dogBreedInformationToolStripMenuItem
            // 
            this.dogBreedInformationToolStripMenuItem.Name = "dogBreedInformationToolStripMenuItem";
            this.dogBreedInformationToolStripMenuItem.Size = new System.Drawing.Size(140, 20);
            this.dogBreedInformationToolStripMenuItem.Text = "Dog Breed Information";
            this.dogBreedInformationToolStripMenuItem.Click += new System.EventHandler(this.dogBreedInformationToolStripMenuItem_Click);
            // 
            // MDIParent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(984, 961);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.menuStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "MDIParent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dog Show Tracker";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripButton btnReloadForm;
        private System.Windows.Forms.ToolStripMenuItem dogInformationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ownerInformationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dogShowInformationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dogBreedInformationToolStripMenuItem;
    }
}



