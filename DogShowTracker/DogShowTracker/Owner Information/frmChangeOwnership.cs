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

        int ownerID, dogID, selectedDogID;
        string startDate, selectedStartDate, endDate;

        public override void Reload()
        {
            UIMethods.FillListControl(cmbDogs, "Name", "DogID", LoadFormData.DogNames());
            UIMethods.FillListControl(cmbOwners, "OwnerName", "OwnerID", LoadFormData.OwnerNamesCombined());
        }

        private void LoadUserData()
        {
            ownerID = Convert.ToInt32(cmbOwners.SelectedValue);
            dogID = Convert.ToInt32(lstOwnership.SelectedValue.ToString().Split(':')[1]);
            selectedDogID = Convert.ToInt32(cmbDogs.SelectedValue);
            startDate = lstOwnership.SelectedValue.ToString().Split(':')[0];
            selectedStartDate = dtpStartDate.Value.ToString("yyyy-MM-dd");
            endDate = chkDoesEnd.Checked ? dtpEndDate.Value.ToString("yyyy-MM-dd") : "NULL";
        }

        private void LoadOwnership()
        {
            ownerID = Convert.ToInt32(cmbOwners.SelectedValue);
            string sql = $@"SELECT	CAST(StartOfOwnership AS VARCHAR) + ':' + CAST(Dogs.DogID AS VARCHAR) AS ID, 
                                    CAST(StartOfOwnership AS VARCHAR) + ' ' + CHAR(151) + ' ' + CAST(Dogs.[Name] AS VARCHAR) AS Dog 
                            FROM DogOwnership
	                            LEFT JOIN Dogs
		                            ON Dogs.DogID = DogOwnership.DogID
	                             WHERE OwnerID = {ownerID}
                                 ORDER BY StartOfOwnership;";
            DataTable dt = DatabaseHelper.GetDataTable(sql);
            UIMethods.FillListControl(lstOwnership, "Dog", "ID", dt);
        }

        private void LoadOwnershipDetails()
        {
            LoadUserData();
            cmbDogs.SelectedValue = dogID;
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

        private bool VerifyUserData()
        {
            bool isValid = true;
            // TODO: Verify User Data
            throw new NotImplementedException();
        }

        private void ModifyOwnership()
        {
            if (VerifyUserData())
            {
                LoadUserData();
                string sql = $@"
                            UPDATE DogOwnership
	                            SET DogID = {selectedDogID},
		                            StartOfOwnership = '{selectedStartDate}',
		                            EndOfOwnership = '{endDate}'
	                            WHERE OwnerID = {ownerID}
	                            AND DogID = {dogID}
	                            AND StartOfOwnership = '{startDate}';
                            ";
                int rowsAffected = DatabaseHelper.SendData(sql);
                UIMethods.DisplayStatusMessage(((MDIParent)MdiParent).GetStatusLabel(), $"{rowsAffected} row(s) updated");
                Reload();
            }

        }

        private void DeleteOwnership()
        {
            if(VerifyUserData())
            {
                ownerID = Convert.ToInt32(cmbOwners.SelectedValue);
                dogID = Convert.ToInt32(lstOwnership.SelectedValue.ToString().Split(':')[1]);
                startDate = lstOwnership.SelectedValue.ToString().Split(':')[0];
                string sql = $@"
                            DELETE DogOwnership
	                            WHERE OwnerID = {ownerID}
	                            AND DogID = {dogID}
	                            AND StartOfOwnership = '{startDate}';
                            ";
                int rowsAffected = DatabaseHelper.SendData(sql);
                UIMethods.DisplayStatusMessage(((MDIParent)MdiParent).GetStatusLabel(), $"{rowsAffected} row(s) deleted");
                Reload();
            }
            
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
