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
                    if(childForm.GetType().IsSubclassOf(typeof(DogShowForm)))
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
                case "addOwner":
                    UIMethods.OpenForm(this, new frmAddOwner());
                    break;
                case "viewOwners":
                    UIMethods.OpenForm(this, new frmOwners());
                    break;
                case "addDogShow":
                    UIMethods.OpenForm(this, new frmAddDogShow());
                    break;
                case "viewDogShows":
                    UIMethods.OpenForm(this, new frmDogShows());
                    break;
                case "addBreed":
                    UIMethods.OpenForm(this, new frmAddDogBreed());
                    break;
                case "viewBreeds":
                    UIMethods.OpenForm(this, new frmBreeds());
                    break;
                case "assignDogs":
                    UIMethods.OpenForm(this, new frmChangeDogShowDogs());
                    break;
            }
        }
    }
}
