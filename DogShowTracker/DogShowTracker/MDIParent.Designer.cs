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
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.closeAllOpenFormsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dogInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addDogToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewDogsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ownerInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addOwnerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewOwnerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dogShowInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addDogShowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewDogShowsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dogBreedInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addBreedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewBreedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.btnReloadForm = new System.Windows.Forms.ToolStripButton();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.assignDogsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.toolStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
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
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.closeAllOpenFormsToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(37, 20);
            this.toolStripMenuItem1.Text = "File";
            // 
            // closeAllOpenFormsToolStripMenuItem
            // 
            this.closeAllOpenFormsToolStripMenuItem.Name = "closeAllOpenFormsToolStripMenuItem";
            this.closeAllOpenFormsToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.closeAllOpenFormsToolStripMenuItem.Text = "Close All Open Forms";
            this.closeAllOpenFormsToolStripMenuItem.Click += new System.EventHandler(this.closeAllOpenFormsToolStripMenuItem_Click);
            // 
            // dogInformationToolStripMenuItem
            // 
            this.dogInformationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addDogToolStripMenuItem,
            this.viewDogsToolStripMenuItem});
            this.dogInformationToolStripMenuItem.Name = "dogInformationToolStripMenuItem";
            this.dogInformationToolStripMenuItem.Size = new System.Drawing.Size(107, 20);
            this.dogInformationToolStripMenuItem.Text = "Dog Information";
            // 
            // addDogToolStripMenuItem
            // 
            this.addDogToolStripMenuItem.Name = "addDogToolStripMenuItem";
            this.addDogToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.addDogToolStripMenuItem.Tag = "addDog";
            this.addDogToolStripMenuItem.Text = "Add Dog";
            this.addDogToolStripMenuItem.Click += new System.EventHandler(this.OpenForm);
            // 
            // viewDogsToolStripMenuItem
            // 
            this.viewDogsToolStripMenuItem.Name = "viewDogsToolStripMenuItem";
            this.viewDogsToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.viewDogsToolStripMenuItem.Tag = "viewDogs";
            this.viewDogsToolStripMenuItem.Text = "View Dogs";
            this.viewDogsToolStripMenuItem.Click += new System.EventHandler(this.OpenForm);
            // 
            // ownerInformationToolStripMenuItem
            // 
            this.ownerInformationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addOwnerToolStripMenuItem,
            this.viewOwnerToolStripMenuItem});
            this.ownerInformationToolStripMenuItem.Name = "ownerInformationToolStripMenuItem";
            this.ownerInformationToolStripMenuItem.Size = new System.Drawing.Size(120, 20);
            this.ownerInformationToolStripMenuItem.Text = "Owner Information";
            // 
            // addOwnerToolStripMenuItem
            // 
            this.addOwnerToolStripMenuItem.Name = "addOwnerToolStripMenuItem";
            this.addOwnerToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.addOwnerToolStripMenuItem.Tag = "addOwner";
            this.addOwnerToolStripMenuItem.Text = "Add Owner";
            this.addOwnerToolStripMenuItem.Click += new System.EventHandler(this.OpenForm);
            // 
            // viewOwnerToolStripMenuItem
            // 
            this.viewOwnerToolStripMenuItem.Name = "viewOwnerToolStripMenuItem";
            this.viewOwnerToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.viewOwnerToolStripMenuItem.Tag = "viewOwners";
            this.viewOwnerToolStripMenuItem.Text = "View Owners";
            this.viewOwnerToolStripMenuItem.Click += new System.EventHandler(this.OpenForm);
            // 
            // dogShowInformationToolStripMenuItem
            // 
            this.dogShowInformationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addDogShowToolStripMenuItem,
            this.viewDogShowsToolStripMenuItem,
            this.assignDogsToolStripMenuItem});
            this.dogShowInformationToolStripMenuItem.Name = "dogShowInformationToolStripMenuItem";
            this.dogShowInformationToolStripMenuItem.Size = new System.Drawing.Size(139, 20);
            this.dogShowInformationToolStripMenuItem.Text = "Dog Show Information";
            // 
            // addDogShowToolStripMenuItem
            // 
            this.addDogShowToolStripMenuItem.Name = "addDogShowToolStripMenuItem";
            this.addDogShowToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.addDogShowToolStripMenuItem.Tag = "addDogShow";
            this.addDogShowToolStripMenuItem.Text = "Add Dog Show";
            this.addDogShowToolStripMenuItem.Click += new System.EventHandler(this.OpenForm);
            // 
            // viewDogShowsToolStripMenuItem
            // 
            this.viewDogShowsToolStripMenuItem.Name = "viewDogShowsToolStripMenuItem";
            this.viewDogShowsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.viewDogShowsToolStripMenuItem.Tag = "viewDogShows";
            this.viewDogShowsToolStripMenuItem.Text = "View Dog Shows";
            this.viewDogShowsToolStripMenuItem.Click += new System.EventHandler(this.OpenForm);
            // 
            // dogBreedInformationToolStripMenuItem
            // 
            this.dogBreedInformationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addBreedToolStripMenuItem,
            this.viewBreedToolStripMenuItem});
            this.dogBreedInformationToolStripMenuItem.Name = "dogBreedInformationToolStripMenuItem";
            this.dogBreedInformationToolStripMenuItem.Size = new System.Drawing.Size(140, 20);
            this.dogBreedInformationToolStripMenuItem.Text = "Dog Breed Information";
            // 
            // addBreedToolStripMenuItem
            // 
            this.addBreedToolStripMenuItem.Name = "addBreedToolStripMenuItem";
            this.addBreedToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.addBreedToolStripMenuItem.Tag = "addBreed";
            this.addBreedToolStripMenuItem.Text = "Add Breed";
            this.addBreedToolStripMenuItem.Click += new System.EventHandler(this.OpenForm);
            // 
            // viewBreedToolStripMenuItem
            // 
            this.viewBreedToolStripMenuItem.Name = "viewBreedToolStripMenuItem";
            this.viewBreedToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.viewBreedToolStripMenuItem.Tag = "viewBreeds";
            this.viewBreedToolStripMenuItem.Text = "View Breed";
            this.viewBreedToolStripMenuItem.Click += new System.EventHandler(this.OpenForm);
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
            // assignDogsToolStripMenuItem
            // 
            this.assignDogsToolStripMenuItem.Name = "assignDogsToolStripMenuItem";
            this.assignDogsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.assignDogsToolStripMenuItem.Tag = "assignDogs";
            this.assignDogsToolStripMenuItem.Text = "Assign Dogs";
            this.assignDogsToolStripMenuItem.Click += new System.EventHandler(this.OpenForm);
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
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem closeAllOpenFormsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addDogToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewDogsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addOwnerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewOwnerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addDogShowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewDogShowsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addBreedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewBreedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem assignDogsToolStripMenuItem;
    }
}



