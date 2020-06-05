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
    public partial class frmChangeDogShowDogs : DogShowForm
    {
        public frmChangeDogShowDogs()
        {
            InitializeComponent();
        }

        int dogShowID, currentDogID, assignDogID, disqualified;
        string rank;

        #region Helper Methods
        public override void Reload()
        {
            UIMethods.FillListControl(cmbDogs, "Name", "DogID", LoadFormData.DogNames(), true);
            UIMethods.FillListControl(cmbDogShow, "Name", "DogShowID", LoadFormData.DogShowNames());
        }

        private void GetUserData()
        {
            assignDogID = cmbDogs.SelectedValue != DBNull.Value ? Convert.ToInt32(cmbDogs.SelectedValue) : 0;
            currentDogID = Convert.ToInt32(lstDogs.SelectedValue);
            dogShowID = Convert.ToInt32(cmbDogShow.SelectedValue);
            rank = chkDisqualified.Checked? "NULL" : Convert.ToInt32(nudRank.Value).ToString();
            disqualified = chkDisqualified.Checked ? 1 : 0;
        }

        private int GetDogShowDogsCount()
        {
            int id = Convert.ToInt32(cmbDogShow.SelectedValue);
            string sql = $@"SELECT COUNT(DogID) FROM DogShows
	                            LEFT JOIN DogShowDetails
		                            ON DogShows.DogShowID = DogShowDetails.DogShowID
	                            WHERE DogShows.DogShowID = {id};";
            return Convert.ToInt32(DatabaseHelper.ExecuteScaler(sql));
        }

        private int GetMaxDogShowDogs()
        {
            int id = Convert.ToInt32(cmbDogShow.SelectedValue);
            string sql = $@"SELECT NumDogs FROM DogShows WHERE DogShows.DogShowID = {id};";
            return Convert.ToInt32(DatabaseHelper.ExecuteScaler(sql));
        }

        private void LoadDogShowDogsCount()
        {
            txtNumDogs.Text = GetDogShowDogsCount().ToString() + "/" + GetMaxDogShowDogs().ToString();
        }

        /// <summary>
        /// Fill the dogs list with the dogs that competed in the selected dog show
        /// </summary>
        private void LoadDogShowDetails()
        {
            GetUserData();
            UIMethods.FillListControl(lstDogs, "Dog", "DogID", LoadFormData.DogShowDogs(dogShowID));
            LoadDogShowDogsCount();
        }

        private void InsertDogShowDog()
        {
            string sql = $@"INSERT INTO DogShowDetails
	                            (DogID, DogShowID, [Rank], Disqualified)
	                            VALUES
	                            ({assignDogID}, {dogShowID}, {rank}, {disqualified});";
            DatabaseHelper.SendData(sql);
        }

        private void RemoveDogShowDog()
        {
            string sql = $@"DELETE DogShowDetails
            	            WHERE DogID = {currentDogID} AND DogShowID = {dogShowID};";
            DatabaseHelper.SendData(sql);
        }

        private bool ValidateInsert()
        {
            bool isValid = true;
            GetUserData();

            string errorMsg = "";

            errorProvider.Clear();
            if (DatabaseHelper.ValueExists("CAST(DogID AS VARCHAR) + ',' + CAST(DogShowID AS VARCHAR)", $"'{assignDogID},{dogShowID}'", "DogShowDetails"))
            {
                isValid = false;
                errorMsg += "Dog is already in dog show. ";
            }
            if(GetDogShowDogsCount() == GetMaxDogShowDogs())
            {
                isValid = false;
                errorMsg += "Dog show already has max number of dogs.";
            }
            if (disqualified == 0 && Convert.ToInt32(rank) <= 0)
            {
                isValid = false;
                errorProvider.SetError(nudRank, "Rank must be higher than 0 if not disqualified");
            }
            if(disqualified == 0 && Convert.ToInt32(rank) > GetMaxDogShowDogs())
            {
                isValid = false;
                errorProvider.SetError(nudRank, "Rank cannot be higher than the max number of dogs");
            }
            if(int.TryParse(rank, out _) && DatabaseHelper.ValueExists("Rank", rank, "DogShowDetails"))
            {
                isValid = false;
                errorProvider.SetError(nudRank, "A dog already has that rank");
            }

            if(errorMsg.Length > 0) MessageBox.Show(errorMsg.Trim(), "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return isValid;
        }

        private bool ValidateDeletion()
        {
            GetUserData();
            errorProvider.Clear();

            string sqlDogName = $"SELECT [Name] FROM Dogs WHERE DogID = {currentDogID}";
            string dogName = DatabaseHelper.ExecuteScaler(sqlDogName).ToString();

            string dogShowName = cmbDogShow.Text.Split('\u2014')[1];
            DateTime dogShowDate = DateTime.Parse(cmbDogShow.Text.Split('\u2014')[0]);


            return lstDogs.SelectedIndex != -1 
                    && UIMethods.ConfirmationPrompt($"Are you sure you want to remove {dogName} from the " +
                                                    $"{dogShowDate.ToString("yyyy MMMM d")}{dogShowName} dog show?");
        }

        private void UpdateDogShowDog()
        {
            string sql = $@"
                            UPDATE DogShowDetails
	                            SET Rank = {rank},
	                            Disqualified = {disqualified}
	                            WHERE DogID = {assignDogID} AND DogShowID = {dogShowID};";
            DatabaseHelper.SendData(sql);
        }

        private bool VerifyUpdate()
        {
            GetUserData();

            bool isValid = true;
            if (!DatabaseHelper.ValueExists("CAST(DogID AS VARCHAR) + ',' + CAST(DogShowID AS VARCHAR)", $"{assignDogID},{dogShowID}", "DogShowDetails"))
            {
                isValid = false;
                MessageBox.Show("Dog cannot be modified as dog is not in the selected dog show", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            if (disqualified == 0 && Convert.ToInt32(rank) <= 0)
            {
                isValid = false;
                errorProvider.SetError(nudRank, "Rank must be higher than 0 if not disqualified");
            }
            if (disqualified == 0 && Convert.ToInt32(rank) > GetMaxDogShowDogs())
            {
                isValid = false;
                errorProvider.SetError(nudRank, "Rank cannot be higher than the max number of dogs");
            }
            if (DatabaseHelper.ValueExists("CAST(DogID AS VARCHAR) + ',' + CAST(DogShowID AS VARCHAR) + ',' + CAST(Rank AS VARCHAR)", $"{assignDogID},{dogShowID},{rank}", "DogShowDetails"))
            {
                isValid = false;
                errorProvider.SetError(nudRank, "A dog already has that rank");
            }

            return isValid;
        }

        private void LoadDogShowDogDetails()
        {
            GetUserData();
            string sql = $"SELECT [Rank], Disqualified FROM DogShowDetails WHERE DogID = {currentDogID}  AND DogShowID = {dogShowID};";
            DataRow row = DatabaseHelper.GetDataRow(sql);

            cmbDogs.SelectedValue = currentDogID;
            nudRank.Value = row["Rank"] != DBNull.Value? Convert.ToDecimal(row["Rank"]) : 0;
            chkDisqualified.Checked = Convert.ToBoolean(row["Disqualified"]);
        }
        #endregion

        private void btnAddDog_Click(object sender, EventArgs e)
        {
            try
            {
                if(ValidateInsert())
                {
                    InsertDogShowDog();
                    LoadDogShowDetails();
                }
            }
            catch (Exception ex)
            {
                UIMethods.ErrorHandler(ex);
            }
        }

        private void btnRemoveDogs_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidateDeletion())
                {
                    RemoveDogShowDog();
                    LoadDogShowDetails();
                }
            }
            catch (Exception ex)
            {
                UIMethods.ErrorHandler(ex);
            }
        }

        private void btnModifyDog_Click(object sender, EventArgs e)
        {
            try
            {
                if(VerifyUpdate())
                {
                    UpdateDogShowDog();
                    LoadDogShowDetails();
                }
            }
            catch (Exception ex)
            {
                UIMethods.ErrorHandler(ex);
            }
        }

        private void lstDogs_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                LoadDogShowDogDetails();
            }
            catch (Exception ex)
            {
                UIMethods.ErrorHandler(ex);
            }
        }

        private void frmChangeDogShowDogs_Load(object sender, EventArgs e)
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

        private void cmbDogShow_SelectedIndexChanged(object sender, EventArgs e)
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

        private void chkDisqualified_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                nudRank.Enabled = !chkDisqualified.Checked;
            }
            catch (Exception ex)
            {
                UIMethods.ErrorHandler(ex);
            }
        }
    }
}
