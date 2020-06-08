using DogShowTrackerCL;
using System;
using System.Data;
using System.Linq;

/*
    Alex Richard
    Dog Show Tracker
    2020-06-07
*/

namespace DogShowTracker
{
    public partial class frmChangeDogShow : DogShowForm
    {
        public frmChangeDogShow()
        {
            InitializeComponent();
        }

        int id, numDogs;
        string name, startDate, endDate;

        #region Helper Methods
        /// <summary>
        /// Load all of the form data
        /// </summary>
        public override void Reload()
        {
            UIMethods.FillListControl(cmbSelectedDogShow, "Name", "DogShowID", LoadFormData.DogShowNames());
        }

        /// <summary>
        /// Load teh infor on the selected dog show
        /// </summary>
        private void LoadDogShowDetails()
        {
            int id = Convert.ToInt32(cmbSelectedDogShow.SelectedValue);
            string sql = $"SELECT [Name], StartDate, EndDate, NumDogs FROM DogShows WHERE DogShowID = {id};";
            DataRow row = DatabaseHelper.GetDataRow(sql);
            string name = row["Name"].ToString();
            DateTime startDate = Convert.ToDateTime(row["StartDate"]);
            DateTime endDate = Convert.ToDateTime(row["EndDate"]);
            int numDogs = Convert.ToInt32(row["NumDogs"]);

            txtDogShowName.Text = name;
            dtpStartDate.Value = startDate;
            dtpEndDate.Value = endDate;
            nudNumDogs.Value = numDogs;
        }

        /// <summary>
        /// Get the number of dogs in the dogs show
        /// </summary>
        /// <returns></returns>
        private int GetDogShowDogsCount()
        {
            string sql = $@"SELECT COUNT(DogID) FROM DogShows
	                            LEFT JOIN DogShowDetails
		                            ON DogShows.DogShowID = DogShowDetails.DogShowID
	                            WHERE DogShows.DogShowID = {id};";
            return Convert.ToInt32(DatabaseHelper.ExecuteScaler(sql));
        }

        /// <summary>
        /// Get all user provider data
        /// </summary>
        private void GetUserData()
        {
            id = Convert.ToInt32(cmbSelectedDogShow.SelectedValue);
            numDogs = Convert.ToInt32(nudNumDogs.Value);
            name = txtDogShowName.Text;
            startDate = dtpStartDate.Value.ToString("yyyy-MM-dd");
            endDate = dtpEndDate.Value.ToString("yyyy-MM-dd");
        }

        /// <summary>
        /// Verify user provided info
        /// </summary>
        /// <returns></returns>
        private bool VerifyFields()
        {
            bool isValid = true;
            errorProvider.Clear();
            if (DatabaseHelper.ValueChanged("Name", $"'{name}'", "DogShows", "DogShowID", id.ToString()) && DatabaseHelper.ValueChanged("StartDate", $"'{startDate}'", "DogShows", "DogShowID", id.ToString())
                && DatabaseHelper.ValueExists("Name + CAST(StartDate AS VARCHAR)", $"'{name + startDate}'", "DogShows"))
            {
                isValid = false;
                errorProvider.SetError(txtDogShowName, "A dog show with that name already starts at that date");
            }
            if (GetDogShowDogsCount() > numDogs)
            {
                isValid = false;
                errorProvider.SetError(nudNumDogs, "The max number of dogs cannot be set lower than the current number of dogs");
            }
            if (name.Length < 5 || !name.All(c => char.IsWhiteSpace(c) || char.IsLetter(c)))
            {
                isValid = false;
                errorProvider.SetError(txtDogShowName, "Dog show name must be longer than 5 characters and contain only letters and spaces");
            }
            if (numDogs < 5)
            {
                isValid = false;
                errorProvider.SetError(nudNumDogs, "Dog shows must have a least 5 dogs competing");
            }
            if (DateTime.Parse(endDate) < DateTime.Parse(startDate))
            {
                isValid = false;
                errorProvider.SetError(dtpEndDate, "Dog show cannnot end before it starts");
            }
            return isValid;
        }

        /// <summary>
        /// Update the dog show
        /// </summary>
        private void UpdateDogShow()
        {
            GetUserData();
            if (VerifyFields())
            {
                string sql = $"UPDATE DogShows SET Name = '{name}', StartDate = '{startDate}', EndDate = '{endDate}', NumDogs = {numDogs} WHERE DogShowID = {id};";
                int rowsAffected = DatabaseHelper.SendData(sql);
                UIMethods.DisplayStatusMessage(((frmMDIParent)MdiParent).GetStatusLabel(), $"{rowsAffected} row(s) affected");
                ((frmMDIParent)MdiParent).ReloadAllChildForms();
            }
        }
        #endregion

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

        private void btnChangeDogShow_Click(object sender, EventArgs e)
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
