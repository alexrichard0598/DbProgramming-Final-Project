using DogShowTrackerCL;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

/*
    Alex Richard
    Dog Show Tracker
    2020-06-03
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
        bool dogAdded = false;


        /// <summary>
        /// Fill the breed and search breed comboboxes
        /// </summary>
        private void PopulateBreedsList()
        {
            string sql = "SELECT [BreedID], [Breed] FROM Breeds ORDER BY [Breed];";
            DataTable dt = DatabaseHelper.GetDataTable(sql);
            UIMethods.FillListControl(cmbBreed, "Breed", "BreedID", dt);
        }


        public override void Reload()
        {
            PopulateBreedsList();
        }

        private void GetValues()
        {
            name = txtName.Text.Trim();
            while (name.Contains("  "))
            {
                name = name.Replace("  ", " ");
            }
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

        private bool ValidateFields()
        {
            bool isValid = true;
            errorProvider.Clear();
            GetValues();
            if (name == "" || !name.All(c => char.IsLetter(c) || char.IsWhiteSpace(c)))
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

                if (errorMsg != "")
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
            return isValid;
        }

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
                    dogAdded = true;
                    Close();
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


        private void frmAddDog_FormClosed(object sender, System.Windows.Forms.FormClosedEventArgs e)
        {
            try
            {
                if(dogAdded) MessageBox.Show("Dog added");
            }
            catch (Exception ex)
            {
                UIMethods.ErrorHandler(ex);
            }
        }
    }
}
