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
    public partial class frmUpdateOwner : DogShowForm
    {
        public frmUpdateOwner()
        {
            InitializeComponent();
        }

        public override void Reload()
        {
            //TODO: Implement Reload Method
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

        private void UpdateOwner()
        {
            GetUserData();
            if(VerifyFields())
            {
                //TODO: Implement UpdateOwner Method
            }
        }

        private void GetOwnerInfo()
        {
            //TODO: Implement GetOwnerInfo Method
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                UpdateOwner();
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

        private void lstOwners_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                GetOwnerInfo();
            }
            catch (Exception ex)
            {
                UIMethods.ErrorHandler(ex);
            }
        }

        private void chkRetired_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                //TODO: Implement Retired Checkbox Checked Changed
            }
            catch (Exception ex)
            {
                UIMethods.ErrorHandler(ex);
            }
        }

        private void frmUpdateOwner_Load(object sender, EventArgs e)
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
    }
}
