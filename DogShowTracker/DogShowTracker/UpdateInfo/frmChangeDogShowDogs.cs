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

/*
    Alex Richard
    Dog Show Tracker
    2020-06-03
*/

namespace DogShowTracker
{
    public partial class frmChangeDogShowDogs : DogShowForm
    {
        public frmChangeDogShowDogs()
        {
            InitializeComponent();
        }

        public override void Reload()
        {
            UIMethods.FillListControl(cmbDogs, "Name", "DogID", LoadFormData.DogNames(), true);
            UIMethods.FillListControl(cmbDogShow, "Name", "DogShowID", LoadFormData.DogShowNames());
        }

        private void btnAddDog_Click(object sender, EventArgs e)
        {

        }

        private void btnRemoveDogs_Click(object sender, EventArgs e)
        {

        }

        private void frmAssignDogShowDogs_Load(object sender, EventArgs e)
        {
            try
            {
                Reload();
            }
            catch (Exception ex)
            {
                UIMethods.ErrorHandler(ex);
            }
        }

        /// <summary>
        /// Fill the dogs list with the dogs that competed in the selected dog show
        /// </summary>
        private void GetDogs()
        {
            int id = Convert.ToInt32(cmbDogShow.SelectedValue);
            UIMethods.FillListControl(lstDogs, "Dog", "DogID", LoadFormData.DogShowDogs(id));
        }

        private void cmbDogShow_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                GetDogs();
            }
            catch (Exception ex)
            {
                UIMethods.ErrorHandler(ex);
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                nudRank.Enabled = !chkDisqualified.Enabled;
            }
            catch (Exception ex)
            {
                UIMethods.ErrorHandler(ex);
            }
        }
    }
}
