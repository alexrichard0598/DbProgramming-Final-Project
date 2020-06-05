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
            this.dogBreedInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addBreedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewBreedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateBreedsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dogInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addDogToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewDogsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateDogsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dogShowInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addDogShowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewDogShowsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateDogShowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.assignDogsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ownerInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addOwnerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewOwnerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateOwnerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateOwnershipToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.miscFormsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addColoursToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewColoursToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewClassesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.btnReloadForm = new System.Windows.Forms.ToolStripButton();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip.SuspendLayout();
            this.toolStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.dogBreedInformationToolStripMenuItem,
            this.dogInformationToolStripMenuItem,
            this.dogShowInformationToolStripMenuItem,
            this.ownerInformationToolStripMenuItem,
            this.miscFormsToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1096, 24);
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
            // dogBreedInformationToolStripMenuItem
            // 
            this.dogBreedInformationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addBreedToolStripMenuItem,
            this.viewBreedToolStripMenuItem,
            this.updateBreedsToolStripMenuItem});
            this.dogBreedInformationToolStripMenuItem.Name = "dogBreedInformationToolStripMenuItem";
            this.dogBreedInformationToolStripMenuItem.Size = new System.Drawing.Size(140, 20);
            this.dogBreedInformationToolStripMenuItem.Text = "Dog Breed Information";
            // 
            // addBreedToolStripMenuItem
            // 
            this.addBreedToolStripMenuItem.Name = "addBreedToolStripMenuItem";
            this.addBreedToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.addBreedToolStripMenuItem.Tag = "addBreed";
            this.addBreedToolStripMenuItem.Text = "Add Breed";
            this.addBreedToolStripMenuItem.Click += new System.EventHandler(this.OpenForm);
            // 
            // viewBreedToolStripMenuItem
            // 
            this.viewBreedToolStripMenuItem.Name = "viewBreedToolStripMenuItem";
            this.viewBreedToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.viewBreedToolStripMenuItem.Tag = "viewBreeds";
            this.viewBreedToolStripMenuItem.Text = "View Breeds";
            this.viewBreedToolStripMenuItem.Click += new System.EventHandler(this.OpenForm);
            // 
            // updateBreedsToolStripMenuItem
            // 
            this.updateBreedsToolStripMenuItem.Name = "updateBreedsToolStripMenuItem";
            this.updateBreedsToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.updateBreedsToolStripMenuItem.Tag = "updateBreeds";
            this.updateBreedsToolStripMenuItem.Text = "Update Breeds";
            this.updateBreedsToolStripMenuItem.Click += new System.EventHandler(this.OpenForm);
            // 
            // dogInformationToolStripMenuItem
            // 
            this.dogInformationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addDogToolStripMenuItem,
            this.viewDogsToolStripMenuItem,
            this.updateDogsToolStripMenuItem});
            this.dogInformationToolStripMenuItem.Name = "dogInformationToolStripMenuItem";
            this.dogInformationToolStripMenuItem.Size = new System.Drawing.Size(107, 20);
            this.dogInformationToolStripMenuItem.Text = "Dog Information";
            // 
            // addDogToolStripMenuItem
            // 
            this.addDogToolStripMenuItem.Name = "addDogToolStripMenuItem";
            this.addDogToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.addDogToolStripMenuItem.Tag = "addDog";
            this.addDogToolStripMenuItem.Text = "Add Dog";
            this.addDogToolStripMenuItem.Click += new System.EventHandler(this.OpenForm);
            // 
            // viewDogsToolStripMenuItem
            // 
            this.viewDogsToolStripMenuItem.Name = "viewDogsToolStripMenuItem";
            this.viewDogsToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.viewDogsToolStripMenuItem.Tag = "viewDogs";
            this.viewDogsToolStripMenuItem.Text = "View Dogs";
            this.viewDogsToolStripMenuItem.Click += new System.EventHandler(this.OpenForm);
            // 
            // updateDogsToolStripMenuItem
            // 
            this.updateDogsToolStripMenuItem.Name = "updateDogsToolStripMenuItem";
            this.updateDogsToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.updateDogsToolStripMenuItem.Tag = "updateDogs";
            this.updateDogsToolStripMenuItem.Text = "Update Dogs";
            this.updateDogsToolStripMenuItem.Click += new System.EventHandler(this.OpenForm);
            // 
            // dogShowInformationToolStripMenuItem
            // 
            this.dogShowInformationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addDogShowToolStripMenuItem,
            this.viewDogShowsToolStripMenuItem,
            this.updateDogShowToolStripMenuItem,
            this.assignDogsToolStripMenuItem});
            this.dogShowInformationToolStripMenuItem.Name = "dogShowInformationToolStripMenuItem";
            this.dogShowInformationToolStripMenuItem.Size = new System.Drawing.Size(139, 20);
            this.dogShowInformationToolStripMenuItem.Text = "Dog Show Information";
            // 
            // addDogShowToolStripMenuItem
            // 
            this.addDogShowToolStripMenuItem.Name = "addDogShowToolStripMenuItem";
            this.addDogShowToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.addDogShowToolStripMenuItem.Tag = "addDogShow";
            this.addDogShowToolStripMenuItem.Text = "Add Dog Show";
            this.addDogShowToolStripMenuItem.Click += new System.EventHandler(this.OpenForm);
            // 
            // viewDogShowsToolStripMenuItem
            // 
            this.viewDogShowsToolStripMenuItem.Name = "viewDogShowsToolStripMenuItem";
            this.viewDogShowsToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.viewDogShowsToolStripMenuItem.Tag = "viewDogShows";
            this.viewDogShowsToolStripMenuItem.Text = "View Dog Shows";
            this.viewDogShowsToolStripMenuItem.Click += new System.EventHandler(this.OpenForm);
            // 
            // updateDogShowToolStripMenuItem
            // 
            this.updateDogShowToolStripMenuItem.Name = "updateDogShowToolStripMenuItem";
            this.updateDogShowToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.updateDogShowToolStripMenuItem.Tag = "updateDogShow";
            this.updateDogShowToolStripMenuItem.Text = "Update Dog Show";
            this.updateDogShowToolStripMenuItem.Click += new System.EventHandler(this.OpenForm);
            // 
            // assignDogsToolStripMenuItem
            // 
            this.assignDogsToolStripMenuItem.Name = "assignDogsToolStripMenuItem";
            this.assignDogsToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.assignDogsToolStripMenuItem.Tag = "assignDogs";
            this.assignDogsToolStripMenuItem.Text = "Change Dog Show Dogs";
            this.assignDogsToolStripMenuItem.Click += new System.EventHandler(this.OpenForm);
            // 
            // ownerInformationToolStripMenuItem
            // 
            this.ownerInformationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addOwnerToolStripMenuItem,
            this.viewOwnerToolStripMenuItem,
            this.updateOwnerToolStripMenuItem,
            this.updateOwnershipToolStripMenuItem});
            this.ownerInformationToolStripMenuItem.Name = "ownerInformationToolStripMenuItem";
            this.ownerInformationToolStripMenuItem.Size = new System.Drawing.Size(120, 20);
            this.ownerInformationToolStripMenuItem.Text = "Owner Information";
            // 
            // addOwnerToolStripMenuItem
            // 
            this.addOwnerToolStripMenuItem.Name = "addOwnerToolStripMenuItem";
            this.addOwnerToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.addOwnerToolStripMenuItem.Tag = "addOwner";
            this.addOwnerToolStripMenuItem.Text = "Add Owner";
            this.addOwnerToolStripMenuItem.Click += new System.EventHandler(this.OpenForm);
            // 
            // viewOwnerToolStripMenuItem
            // 
            this.viewOwnerToolStripMenuItem.Name = "viewOwnerToolStripMenuItem";
            this.viewOwnerToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.viewOwnerToolStripMenuItem.Tag = "viewOwners";
            this.viewOwnerToolStripMenuItem.Text = "View Owners";
            this.viewOwnerToolStripMenuItem.Click += new System.EventHandler(this.OpenForm);
            // 
            // updateOwnerToolStripMenuItem
            // 
            this.updateOwnerToolStripMenuItem.Name = "updateOwnerToolStripMenuItem";
            this.updateOwnerToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.updateOwnerToolStripMenuItem.Tag = "updateOwner";
            this.updateOwnerToolStripMenuItem.Text = "Update Owner";
            this.updateOwnerToolStripMenuItem.Click += new System.EventHandler(this.OpenForm);
            // 
            // updateOwnershipToolStripMenuItem
            // 
            this.updateOwnershipToolStripMenuItem.Name = "updateOwnershipToolStripMenuItem";
            this.updateOwnershipToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.updateOwnershipToolStripMenuItem.Tag = "updateOwnership";
            this.updateOwnershipToolStripMenuItem.Text = "Update Ownership";
            this.updateOwnershipToolStripMenuItem.Click += new System.EventHandler(this.OpenForm);
            // 
            // miscFormsToolStripMenuItem
            // 
            this.miscFormsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addColoursToolStripMenuItem,
            this.viewColoursToolStripMenuItem,
            this.addToolStripMenuItem,
            this.viewClassesToolStripMenuItem});
            this.miscFormsToolStripMenuItem.Name = "miscFormsToolStripMenuItem";
            this.miscFormsToolStripMenuItem.Size = new System.Drawing.Size(83, 20);
            this.miscFormsToolStripMenuItem.Text = "Misc. Forms";
            // 
            // addColoursToolStripMenuItem
            // 
            this.addColoursToolStripMenuItem.Name = "addColoursToolStripMenuItem";
            this.addColoursToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.addColoursToolStripMenuItem.Tag = "addColour";
            this.addColoursToolStripMenuItem.Text = "Add Colour";
            this.addColoursToolStripMenuItem.Click += new System.EventHandler(this.OpenForm);
            // 
            // viewColoursToolStripMenuItem
            // 
            this.viewColoursToolStripMenuItem.Name = "viewColoursToolStripMenuItem";
            this.viewColoursToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.viewColoursToolStripMenuItem.Tag = "viewColours";
            this.viewColoursToolStripMenuItem.Text = "View Colours";
            this.viewColoursToolStripMenuItem.Click += new System.EventHandler(this.OpenForm);
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.addToolStripMenuItem.Tag = "addClass";
            this.addToolStripMenuItem.Text = "Add Class";
            this.addToolStripMenuItem.Click += new System.EventHandler(this.OpenForm);
            // 
            // viewClassesToolStripMenuItem
            // 
            this.viewClassesToolStripMenuItem.Name = "viewClassesToolStripMenuItem";
            this.viewClassesToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.viewClassesToolStripMenuItem.Tag = "viewClasses";
            this.viewClassesToolStripMenuItem.Text = "View Classes";
            this.viewClassesToolStripMenuItem.Click += new System.EventHandler(this.OpenForm);
            // 
            // toolStrip
            // 
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnReloadForm});
            this.toolStrip.Location = new System.Drawing.Point(0, 24);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(1096, 25);
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
            this.statusStrip.Location = new System.Drawing.Point(0, 738);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(1096, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(39, 17);
            this.toolStripStatusLabel.Text = "Status";
            // 
            // MDIParent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1096, 760);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.menuStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "MDIParent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dog Show Tracker";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MDIParent_Load);
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
        private System.Windows.Forms.ToolStripMenuItem updateDogsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateOwnershipToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateBreedsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem miscFormsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addColoursToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewColoursToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewClassesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateDogShowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateOwnerToolStripMenuItem;
    }
}



