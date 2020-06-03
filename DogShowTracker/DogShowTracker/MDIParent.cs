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

        private void dogInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {

            try
            {
                UIMethods.OpenForm(this, new frmDogs());
            }
            catch (Exception ex)
            {
                UIMethods.ErrorHandler(ex);
            }
        }

        private void ownerInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {

            try
            {
                UIMethods.OpenForm(this, new frmOwners());
            }
            catch (Exception ex)
            {
                UIMethods.ErrorHandler(ex);
            }
        }

        private void dogShowInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {

            try
            {
                UIMethods.OpenForm(this, new frmDogShows());
            }
            catch (Exception ex)
            {
                UIMethods.ErrorHandler(ex);
            }
        }

        private void dogBreedInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {

            try
            {
                UIMethods.OpenForm(this, new frmBreeds());
            }
            catch (Exception ex)
            {
                UIMethods.ErrorHandler(ex);
            }
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
    }
}
