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
    2020-06-05
*/

namespace DogShowTracker
{
    public partial class frmChangeDogShow : DogShowForm
    {
        public frmChangeDogShow()
        {
            InitializeComponent();
        }

        public override void Reload()
        {
            //TODO: Implement Reload Method
        }

        private void LoadDogShowDetails()
        {
            //TODO: Implement LoadDogShowDetails Method
        }

        private void GetUserData()
        {
            //TODO: Implement GetUserData Method
        }

        private bool VerifyFields()
        {
            //TODO: Implement VerifyFields Method
            throw new NotImplementedException();
        }

        private void UpdateDogShow()
        {
            GetUserData();
            if (VerifyFields())
            {
                //TODO: Implement UpdateOwner Method
            }
        }

        private void frmChangeDogShow_Load(object sender, EventArgs e)
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

        private void cmbSelectedDogShow_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                LoadDogShowDetails();
            }
            catch (Exception ex)
            {
                UIMethods.ErrorHandler(ex);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            try
            {
                Close();
            }
            catch (Exception ex)
            {
                UIMethods.ErrorHandler(ex);
            }
        }

        private void btnAddDogShow_Click(object sender, EventArgs e)
        {
            try
            {
                UpdateDogShow();
            }
            catch (Exception ex)
            {
                UIMethods.ErrorHandler(ex);
            }
        }
    }
}
