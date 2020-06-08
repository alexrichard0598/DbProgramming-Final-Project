using DogShowTrackerCL;
using System;
using System.Windows.Forms;

/*
    Alex Richard
    Dog Show Tracker
    2020-06-07
*/

namespace DogShowTracker
{
    public partial class frmMDIParent : Form
    {

        public frmMDIParent()
        {
            InitializeComponent();
        }

        #region Helper Methods
        /// <summary>
        /// Handle the opening of the forms
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OpenForm(object sender, EventArgs e)
        {
            try
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
                    case "about":
                        new AboutBox().ShowDialog();
                        break;
                }
            }
            catch (Exception ex)
            {
                UIMethods.ErrorHandler(ex);
            }
        }

        /// <summary>
        /// Return the ToolStripStatusLabel
        /// </summary>
        /// <returns></returns>
        public ToolStripStatusLabel GetStatusLabel()
        {
            return toolStripStatusLabel;
        }

        /// <summary>
        /// Call the reload method all all of the Mdi child forms
        /// </summary>
        public void ReloadAllChildForms()
        {
            foreach (Form childForm in MdiChildren)
            {
                if (childForm.GetType().IsSubclassOf(typeof(DogShowForm)))
                {
                    ((DogShowForm)childForm).Reload();
                }
            }
        }
        #endregion

        private void btnReloadForm_Click(object sender, EventArgs e)
        {
            try
            {
                ReloadAllChildForms();
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

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            try
            {
                new AboutBox().ShowDialog();
            }
            catch (Exception ex)
            {
                UIMethods.ErrorHandler(ex);
            }
        }

        /// <summary>
        /// On form load load, hide the form load the splashscreen and load the login
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MDIParent_Load(object sender, EventArgs e)
        {
            try
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
                if (login.DialogResult == DialogResult.OK)
                {
                    Show();
                }
                else
                {
                    Close();
                }
            }
            catch (Exception ex)
            {
                UIMethods.ErrorHandler(ex);
            }

        }
    }
}
