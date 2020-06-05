using DogShowTrackerCL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DogShowTracker
{
    public partial class MDIParent : Form
    {

        public MDIParent()
        {
            InitializeComponent();
        }

        private void btnReloadForm_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (Form childForm in MdiChildren)
                {
                    if (childForm.GetType().IsSubclassOf(typeof(DogShowForm)))
                    {
                        ((DogShowForm)childForm).Reload();
                    }
                }
            }
            catch (Exception ex)
            {
                UIMethods.ErrorHandler(ex);
            }
        }

        private void closeAllOpenFormsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (Form form in MdiChildren)
                {
                    form.Close();
                }
            }
            catch (Exception ex)
            {
                UIMethods.ErrorHandler(ex);
            }
        }

        private void OpenForm(object sender, EventArgs e)
        {
            switch (((ToolStripMenuItem)sender).Tag)
            {
                case "addDog":
                    UIMethods.OpenForm(this, new frmAddDog());
                    break;
                case "viewDogs":
                    UIMethods.OpenForm(this, new frmDogs());
                    break;
                case "updateDogs":
                    UIMethods.OpenForm(this, new frmUpdateDog());
                    break;
                case "addOwner":
                    UIMethods.OpenForm(this, new frmAddOwner());
                    break;
                case "viewOwners":
                    UIMethods.OpenForm(this, new frmOwners());
                    break;
                case "updateOwner":
                    UIMethods.OpenForm(this, new frmUpdateOwner());
                    break;
                case "updateOwnership":
                    UIMethods.OpenForm(this, new frmChangeOwnership());
                    break;
                case "addDogShow":
                    UIMethods.OpenForm(this, new frmAddDogShow());
                    break;
                case "viewDogShows":
                    UIMethods.OpenForm(this, new frmDogShows());
                    break;
                case "updateDogShow":
                    UIMethods.OpenForm(this, new frmChangeDogShow());
                    break;
                case "assignDogs":
                    UIMethods.OpenForm(this, new frmChangeDogShowDogs());
                    break;
                case "addBreed":
                    UIMethods.OpenForm(this, new frmAddDogBreed());
                    break;
                case "viewBreeds":
                    UIMethods.OpenForm(this, new frmBreeds());
                    break;
                case "updateBreeds":
                    UIMethods.OpenForm(this, new frmUpdateBreed());
                    break;
                case "addColour":
                    UIMethods.OpenForm(this, new frmAddColour());
                    break;
                case "viewColours":
                    UIMethods.OpenForm(this, new frmColours());
                    break;
                case "addClass":
                    UIMethods.OpenForm(this, new frmAddClass());
                    break;
                case "viewClasses":
                    UIMethods.OpenForm(this, new frmClasses());
                    break;
            }
        }

        private void MDIParent_Load(object sender, EventArgs e)
        {
            Hide();

            frmSplashScreen splashScreen = new frmSplashScreen();
            splashScreen.ShowDialog();
            frmLogin login = new frmLogin();

            if (splashScreen.DialogResult != DialogResult.OK)
            {
                Close();
            }
            else
            {
                login.ShowDialog();
            }
            if(login.DialogResult == DialogResult.OK)
            {
                Show();
            }
            else
            {
                Close();
            }
        }

        public ToolStripStatusLabel GetStatusLabel()
        {
            return toolStripStatusLabel;
        }
    }
}
