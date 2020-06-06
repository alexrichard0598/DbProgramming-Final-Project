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
            if(VerifyUserData(true))
            {
                string sql = $@"
                    INSERT INTO DogOwnership
	                    (OwnerID, DogID, StartOfOwnership, EndOfOwnership)
	                    VALUES
	                    ({ownerID},{dogID},'{startDate}', {endDate});";
                int rowsAffected = DatabaseHelper.SendData(sql);
                UIMethods.DisplayStatusMessage(((MDIParent)MdiParent).GetStatusLabel(), $"{rowsAffected} row(s) inserted");
                Reload();
            }
        }

        private bool VerifyUserData(bool createRecord = false)
        {
            bool isValid = true;

            // Check if the end date is before the start date
            if (chkDoesEnd.Checked && dtpEndDate.Value.Date < dtpStartDate.Value.Date)
            {
                isValid = false;
                errorProvider.SetError(dtpEndDate, "End of ownership cannnot be before start of ownership");
            }
            // DOES PREVIOUS OWNERSHIP NOT HAVE END
            string sqlNoEndToPrev = $@"
                SELECT COUNT(*)
	                FROM
	                (
		                SELECT TOP(1) OwnerID FROM DogOwnership 
			                WHERE DogID = {selectedDogID}
			                AND StartOfOwnership < '{startDate}'
			                AND EndOfOwnership IS NULL
			                ORDER BY StartOfOwnership DESC
	                ) AS Q;";

            // DOES PREVIOUS END AFTER START DATE
            string sqlPrevEndAfterStart = $@"
                SELECT COUNT(*)
	                FROM
	                (
		                SELECT TOP(1) OwnerID FROM DogOwnership 
			                WHERE DogID = {selectedDogID}
			                AND StartOfOwnership < '{startDate}'
			                AND EndOfOwnership > '{startDate}'
			                ORDER BY StartOfOwnership DESC
	                ) AS Q;";

            // DOES HAVE NEXT RECORD
            string sqlIsNextDog = $@"
                SELECT COUNT(*)
	                FROM
	                (
		                SELECT OwnerID FROM DogOwnership 
			                WHERE DogID = {selectedDogID}
			                AND StartOfOwnership > '{startDate}'
	                ) AS Q;";

            // IS END AFTER NEXT RECORD START
            string sqlEndsAfterNextDog = $@"
                SELECT COUNT(*)
	                FROM
	                (
		                SELECT OwnerID FROM DogOwnership 
			                WHERE DogID = {selectedDogID}
			                AND StartOfOwnership > '{startDate}'
			                AND StartOfOwnership < '{endDate}'
	                ) AS Q;";

            // DUPLICATE RECORD
            string duplicateRecordEndNotNull = $@"
                SELECT COUNT(*) FROM DogOwnership
	                WHERE DogID = {selectedDogID}
	                AND OwnerID = {ownerID}
	                AND StartOfOwnership = '{startDate}';";

            string duplicateRecordEndISNull = $@"
                SELECT COUNT(*) FROM DogOwnership
	                WHERE DogID = {selectedDogID}
	                AND OwnerID = {ownerID}
	                AND StartOfOwnership = '{startDate}';";

            // Check if duplicate record
            if(Convert.ToInt32(DatabaseHelper.ExecuteScaler(duplicateRecordEndISNull)) > 0 && createRecord)
            {
                isValid = false;
                errorProvider.SetError(cmbOwners, "Ownership record already exists");
            }

            // Check if the previous ownership record doesn't have an end
            if (Convert.ToInt32(DatabaseHelper.ExecuteScaler(sqlNoEndToPrev)) > 0)
            {
                isValid = false;
                errorProvider.SetError(cmbDogs, "Previous dog ownership record does not have an end date");
            } // Else check if the previous ownership record ends after the start date
            else if (Convert.ToInt32(DatabaseHelper.ExecuteScaler(sqlPrevEndAfterStart)) > 0)
            {
                isValid = false;
                errorProvider.SetError(dtpStartDate, "Start date is before previous dog ownership record's end date");
            }

            // Check if there is a next ownership record and
            // the current record doesn't end or ends after the next one starts
            if (
                Convert.ToInt32(DatabaseHelper.ExecuteScaler(sqlIsNextDog)) > 0
                && (!chkDoesEnd.Checked || Convert.ToInt32(DatabaseHelper.ExecuteScaler(sqlEndsAfterNextDog)) > 0)
               )
            {
                isValid = false;
                errorProvider.SetError(dtpEndDate, "Must have an end date before next dog ownership record's end date");
            }


            // Check if the owner is born after the start date
            if(
                DateTime.Parse(startDate).Date < 
                DateTime.Parse(DatabaseHelper.ExecuteScaler($"SELECT DOB FROM Owners WHERE OwnerID = {ownerID};").ToString()).Date
               )
            {
                isValid = false;
                errorProvider.SetError(dtpStartDate, "Ownership cannot start before owner is born");
            }

            // Check if the owner is retired before the start date
            if (
                DatabaseHelper.ExecuteScaler($"SELECT DateOfRetirement FROM Owners WHERE OwnerID = {ownerID};") != DBNull.Value
                && DateTime.Parse(startDate).Date >
                DateTime.Parse(DatabaseHelper.ExecuteScaler($"SELECT DateOfRetirement FROM Owners WHERE OwnerID = {ownerID};").ToString()).Date
               )
            {
                isValid = false;
                errorProvider.SetError(dtpStartDate, "Ownership cannot start after the owner is retired");
            }

            // Check if the dog is born after the start date
            if(
                DateTime.Parse(startDate).Date <
                DateTime.Parse(DatabaseHelper.ExecuteScaler($"SELECT DOB FROM Dogs WHERE DogID = {selectedDogID};").ToString()).Date
              )
            {
                isValid = false;
                errorProvider.SetError(dtpStartDate, "Ownership cannot start before the dog is born");
            }

            // Check if the dog is retired or disqualfied before the start date
            if (
                (
                    DatabaseHelper.ExecuteScaler($"SELECT DateOfRetirement FROM Dogs WHERE DogID = {selectedDogID};") != DBNull.Value
                    && DateTime.Parse(startDate).Date >
                    DateTime.Parse
                    (
                        DatabaseHelper.ExecuteScaler($"SELECT DateOfRetirement FROM Dogs WHERE DogID = {selectedDogID};"
                    ).ToString()).Date
                ) || (
                    DatabaseHelper.ExecuteScaler($"SELECT DateOfDisqualification FROM Dogs WHERE DogID = {selectedDogID};") != DBNull.Value
                    && DateTime.Parse(startDate).Date >
                    DateTime.Parse
                    (
                        DatabaseHelper.ExecuteScaler($"SELECT DateOfDisqualification FROM Dogs WHERE DogID = {selectedDogID};"
                    ).ToString()).Date
                )
               )
            {
                isValid = false;
                errorProvider.SetError(dtpStartDate, "Ownership cannot start after the dog is retired or banned");
            }

            return isValid;
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

            ownerID = Convert.ToInt32(cmbOwners.SelectedValue);
            dogID = Convert.ToInt32(lstOwnership.SelectedValue.ToString().Split(':')[1]);
            startDate = lstOwnership.SelectedValue.ToString().Split(':')[0];
            string dogName = DatabaseHelper.ExecuteScaler($"SELECT Name FROM Dogs WHERE DogID = {dogID}").ToString();
            string ownerName = DatabaseHelper.ExecuteScaler
                (
                $@"
                SELECT FirstName + ' ' + COALESCE(MiddleName + ' ', '') + LastName 
                    FROM Owners 
                    WHERE OwnerID = {ownerID}"
                ).ToString();
            if (UIMethods.ConfirmationPrompt($"Are you sure you wish to delete the ownership record for {ownerName} starting owning {dogName} on {startDate}"))
            {
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
