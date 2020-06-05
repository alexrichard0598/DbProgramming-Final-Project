using DogShowTrackerCL;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

/*
    Alex Richard
    Dog Show Tracker
    2020-06-05
*/

namespace DogShowTracker
{
    public partial class frmAddDog : DogShowForm
    {
        public frmAddDog()
        {
            InitializeComponent();
        }

        string name, dob, dateRetired, dateBanned, dateChampionship;
        int sex, retired, banned, champion, breedId;
        decimal weight, height;


        /// <summary>
        /// Fill the breed and search breed comboboxes
        /// </summary>
        private void PopulateBreedsList()
        {
            UIMethods.FillListControl(cmbBreed, "Breed", "BreedID", LoadFormData.BreedNames());
        }

        /// <summary>
        /// Reload the database info
        /// </summary>
        public override void Reload()
        {
            PopulateBreedsList();
        }

        /// <summary>
        /// Get the user provided info
        /// </summary>
        private void GetValues()
        {
            name = DatabaseHelper.SanitizeUserInput(txtName.Text);
            sex = Convert.ToInt32(rdoMale.Checked);
            weight = Math.Round(nudWeight.Value, 1);
            height = Math.Round(nudHeight.Value, 1);
            dob = dtpDateOfBirth.Value.ToString("yyyy-MM-dd");

            retired = Convert.ToInt32(chkRetired.Checked);
            dateRetired = chkRetired.Checked ? $"'{dtpDateOfRetirement.Value.ToString("yyyy-MM-dd")}'" : "NULL";

            banned = Convert.ToInt32(chkBanned.Checked);
            dateBanned = chkBanned.Checked ? $"'{dtpDateBanned.Value.ToString("yyyy-MM-dd")}'" : "NULL";

            champion = Convert.ToInt32(chkChampion.Checked);
            dateChampionship = chkChampion.Checked ? $"'{dtpChampionshipDate.Value.ToString("yyyy-MM-dd")}'" : "NULL";

            breedId = cmbBreed.SelectedValue != DBNull.Value ? Convert.ToInt32(cmbBreed.SelectedValue) : 0;
        }

        /// <summary>
        /// Validate user provided info
        /// </summary>
        /// <returns></returns>
        private bool ValidateFields()
        {
            bool isValid = true;
            errorProvider.Clear();
            GetValues();
            if (string.IsNullOrEmpty(name) || !name.All(c => char.IsLetter(c) || char.IsWhiteSpace(c)))
            {
                isValid = false;
                errorProvider.SetError(txtName, "Name must not be empty and can only contain letters and spaces");
            }
            if (weight < 1)
            {
                isValid = false;
                errorProvider.SetError(nudWeight, "Weight must be at least 1kg");
            }
            if (height < 5)
            {
                isValid = false;
                errorProvider.SetError(nudHeight, "Height must be at least 5cm");
            }
            if (dtpDateOfBirth.Value.Date > DateTime.Now)
            {
                isValid = false;
                errorProvider.SetError(dtpDateOfBirth, "Date of birth can't be in the future");
            }
            if (chkRetired.Checked && dtpDateOfRetirement.Value.Date < dtpDateOfBirth.Value)
            {
                isValid = false;
                errorProvider.SetError(dtpDateOfRetirement, "Date of Retirement cannot be before Date of Birth");
            }
            if (chkBanned.Checked && dtpDateBanned.Value.Date < dtpDateOfBirth.Value)
            {
                isValid = false;
                errorProvider.SetError(dtpDateBanned, "Date Banned cannot be before Date of Birth");
            }
            if (chkBanned.Checked && chkRetired.Checked)
            {
                isValid = false;
                errorProvider.SetError(chkBanned, "Cannot ban a retired dog");
                errorProvider.SetError(chkRetired, "A banned dog cannot retired");
            }
            if (chkChampion.Checked)
            {
                string errorMsg = "";
                if (dtpChampionshipDate.Value.Date < dtpDateOfBirth.Value.Date)
                    errorMsg += "Date of championship cannot be before date of birth\r\n";
                if (dtpChampionshipDate.Value.Date > dtpDateBanned.Value.Date && chkBanned.Checked)
                    errorMsg += "Date of championship cannot be after date banned\r\n";
                if (dtpChampionshipDate.Value.Date > dtpDateOfRetirement.Value.Date && chkRetired.Checked)
                    errorMsg += "Date of championship cannot be after date retired";

                if (errorMsg.Length != 0)
                {
                    isValid = false;
                    errorProvider.SetError(dtpChampionshipDate, errorMsg);
                }

            }
            if (breedId == 0)
            {
                isValid = false;
                errorProvider.SetError(cmbBreed, "Dog breed must be selected");
            }
            if (DatabaseHelper.ValueExists("Name", $"'{name}'", "Dogs"))
            {
                if (isValid && DialogResult.Yes == MessageBox.Show("A dog with that name already exists, are you sure you wish to add this dog?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                    isValid = false;
            }
            return isValid;
        }

        /// <summary>
        /// Insert dog info into database
        /// </summary>
        private void InsertDog()
        {
            string sql = $@"INSERT INTO Dogs
	                            ([Name], Sex, [Weight], Height, DOB, DateOfRetirement, Retired, DateOfChampionship, 
                                Champion, DateOfDisqualification, PermanentlyDisqualified, Breed)
	                            VALUES
	                            ('{name}', {sex}, {weight}, {height}, '{dob}', {dateRetired}, {retired}, 
                                {dateChampionship}, {champion}, {dateBanned}, {banned}, {breedId});";
            DatabaseHelper.SendData(sql);
        }

        /// <summary>
        /// Set the enabled property of the datetimepickers to the equivelent checkbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EnableDateTimePickers(object sender, EventArgs e)
        {
            try
            {
                dtpChampionshipDate.Enabled = chkChampion.Checked;
                dtpDateBanned.Enabled = chkBanned.Checked;
                dtpDateOfRetirement.Enabled = chkRetired.Checked;
            }
            catch (Exception ex)
            {
                UIMethods.ErrorHandler(ex);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidateFields())
                {
                    InsertDog();
                }
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


        private void frmAddDog_Load(object sender, EventArgs e)
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
