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
    public partial class frmChangeOwnership : DogShowForm
    {
        public frmChangeOwnership()
        {
            InitializeComponent();
        }

        int ownerID, dogID;
        string startDate, endDate;

        public override void Reload()
        {
            UIMethods.FillListControl(cmbDogs, "Name", "DogID", LoadFormData.DogNames());
            UIMethods.FillListControl(cmbOwners, "OwnerName", "OwnerID", LoadFormData.OwnerNamesCombined());
        }

        private void LoadUserData()
        {
            ownerID = Convert.ToInt32(cmbOwners.SelectedValue);
            dogID = Convert.ToInt32(cmbDogs.SelectedValue);
            startDate = dtpStartDate.Value.ToString("yyyy-MM-dd");
            endDate = dtpEndDate.Value.ToString("yyyy-MM-dd");
        }

        private void LoadOwnership()
        {
            ownerID = Convert.ToInt32(cmbOwners.SelectedValue);
            string sql = $@"SELECT	Dogs.DogID AS ID, Dogs.[Name] FROM DogOwnership
	                            LEFT JOIN Dogs
		                            ON Dogs.DogID = DogOwnership.DogID
	                             WHERE OwnerID = {ownerID}
                                 ORDER BY StartOfOwnership;";
            DataTable dt = DatabaseHelper.GetDataTable(sql);
            UIMethods.FillListControl(lstOwnership, "Name", "ID", dt);
        }

        private void LoadOwnershipDetails()
        {
            ownerID = Convert.ToInt32(cmbOwners.SelectedValue);
            dogID = Convert.ToInt32(cmbDogs.SelectedValue = lstOwnership.SelectedValue);
            string sql = $@"SELECT	Dogs.DogID AS ID, Dogs.[Name], StartOfOwnership, EndOfOwnership FROM DogOwnership
	                            LEFT JOIN Dogs
		                            ON Dogs.DogID = DogOwnership.DogID
	                             WHERE OwnerID = {ownerID} AND Dogs.DogID = {dogID}
                                 ORDER BY StartOfOwnership;";
            DataRow dt = DatabaseHelper.GetDataRow(sql);
            
            UIMethods.PickDateTimePicker(dtpStartDate, dt["StartOfOwnership"]);
            UIMethods.PickDateTimePicker(dtpEndDate, dt["EndOfOwnership"], false);
            chkDoesEnd.Checked = dt["EndOfOwnership"] != DBNull.Value;
        }

        private void InsertOwnership()
        {
            // TODO: Insert Ownership
        }

        private void ModifyOwnership()
        {
            // TODO: Modify Ownership
        }

        private void DeleteOwnership()
        {
            // TODO: Delete Ownership
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                InsertOwnership();
            }
            catch (Exception ex)
            {
                UIMethods.ErrorHandler(ex);
            }
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            try
            {
                ModifyOwnership();
            }
            catch (Exception ex)
            {
                UIMethods.ErrorHandler(ex);
            }
        }

        private void frmChangeOwnership_Load(object sender, EventArgs e)
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

        private void lstOwnership_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                LoadOwnershipDetails();
            }
            catch (Exception ex)
            {
                UIMethods.ErrorHandler(ex);
            }
        }

        private void chkDoesEnd_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                dtpEndDate.Enabled = chkDoesEnd.Checked;
            }
            catch (Exception ex)
            {
                UIMethods.ErrorHandler(ex);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                DeleteOwnership();
            }
            catch (Exception ex)
            {
                UIMethods.ErrorHandler(ex);
            }
        }

        private void cmbOwners_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                LoadOwnership();
            }
            catch (Exception ex)
            {
                UIMethods.ErrorHandler(ex);
            }
        }
    }
}
