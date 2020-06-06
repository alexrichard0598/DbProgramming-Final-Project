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

        private void LoadUserInfo()
        {
            ownerID = Convert.ToInt32(cmbOwners.SelectedValue);
            dogID = Convert.ToInt32(cmbDogs.SelectedValue);
            startDate = dtpStartDate.Value.ToString("yyyy-MM-dd");
            endDate = chkDoesEnd.Checked ? $"'{dtpEndDate.Value.ToString("yyyy-MM-dd")}'" : "NULL";
        }

        public override void Reload()
        {
            UIMethods.FillListControl(cmbDogs, "Name", "DogID", LoadFormData.DogNames(), true);
            UIMethods.FillListControl(cmbOwners, "OwnerName", "OwnerID", LoadFormData.OwnerNamesCombined());
        }

        private bool VerifyUserInfo()
        {
            // TODO: Implement Verification of User Input
            throw new NotImplementedException();
        }

        private void LoadOwnership()
        {
            ownerID = Convert.ToInt32(cmbOwners.SelectedValue);
            string sql = $@"SELECT Dogs.DogID, [Name] FROM DogOwnership
	                            LEFT JOIN Dogs
		                            ON Dogs.DogID = DogOwnership.DogID
	                            WHERE OwnerID = {ownerID};";
            UIMethods.FillListControl(lstOwnership, "Name", "DogID", DatabaseHelper.GetDataTable(sql));
        }

        private void CreateOwnership()
        {
            LoadUserInfo();
            string sql = $@"
                            INSERT INTO DogOwnership
                            (OwnerID, DogID, StartDate, EndDate)
                            VALUES
                            ({Owner}, {dogID}, '{startDate}', {endDate})
                            ";
            int rowsAffected = DatabaseHelper.SendData(sql);
            UIMethods.DisplayStatusMessage(((MDIParent)MdiParent).GetStatusLabel(), $"{rowsAffected} row(s) added");
        }

        private void UpdateOwnership()
        {
            LoadUserInfo();
            // TODO: Implement UpdateOwnership Method
        }

        private void DeleteOwnership()
        {
            // TODO: Implement Delete Ownership
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (VerifyUserInfo())
                    CreateOwnership();
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
                if (VerifyUserInfo())
                    DeleteOwnership();
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
                if (VerifyUserInfo())
                    UpdateOwnership();
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


        private void cmbOwnerOwners_SelectedIndexChanged(object sender, EventArgs e)
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
