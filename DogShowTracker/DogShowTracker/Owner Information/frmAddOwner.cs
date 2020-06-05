using DogShowTrackerCL;
using System;
using System.Linq;
using System.Windows.Forms;

/*
    Alex Richard
    Dog Show Tracker
    2020-06-05
*/

namespace DogShowTracker
{
    public partial class frmAddOwner : DogShowForm
    {
        public frmAddOwner()
        {
            InitializeComponent();
        }

        int age, isRetired;
        string fName, mName, lName, dob, dateOfRetirement;

        private void GetUserData()
        {
            age = Convert.ToInt32(DateTime.Now.Subtract(dtpDOB.Value).TotalDays / 365);
            fName = DatabaseHelper.SanitizeUserInput(txtFirstName.Text);
            mName = DatabaseHelper.SanitizeUserInput(txtMiddleName.Text);
            lName = DatabaseHelper.SanitizeUserInput(txtLastName.Text);
            dob = dtpDOB.Value.ToString("yyyy-MM-dd");
            isRetired = chkRetired.Checked ? 1 : 0;
            dateOfRetirement = chkRetired.Checked ? $"'{dtpDateOfRetirement.Value.ToString("yyyy-MM-dd")}'" : "NULL";
        }
        /// <summary>
        /// Validate the user provided info
        /// </summary>
        /// <returns></returns>
        private bool ValidateFields()
        {
            GetUserData();
            errorProvider.Clear();
            bool isValid = true;
            if (string.IsNullOrEmpty(fName) || !fName.All(c => char.IsLetter(c)))
            {
                errorProvider.SetError(txtFirstName, "First Name must not be empty and contain only letters");
                isValid = false;
            }
            if (mName.Length != 0 && !mName.All(c => char.IsLetter(c)))
            {
                errorProvider.SetError(txtMiddleName, "Middle Name must only contain letters");
                isValid = false;
            }
            if (string.IsNullOrEmpty(lName) || !lName.All(c => char.IsLetter(c)))
            {
                errorProvider.SetError(txtLastName, "Last Name must not be empty and contain only letters");
                isValid = false;
            }
            if (age < 18)
            {
                errorProvider.SetError(dtpDOB, "Owners must be at least 18 years old");
                isValid = false;
            }
            if (isRetired == 1 && DateTime.Parse(dateOfRetirement) < DateTime.Parse(dob).AddYears(18))
            {
                errorProvider.SetError(dtpDateOfRetirement, "Cannot retire before 18 years of age");
                isValid = false;
            }
            if (isValid && DatabaseHelper.ValueExists("FirstName + ' ' + COALESCE(MiddleName + ' ', '') + LastName", $"'{fName + ' ' + mName + ' ' + lName}'", "Owners"))
            {
                if (DialogResult.Yes == MessageBox.Show("A owner with that name already exists, are you sure you wish to add owner?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                    isValid = false;
            }

            return isValid;
        }

        /// <summary>
        /// Insert the owner info into the database
        /// </summary>
        private void InsertOwner()
        {
            string sql = $@"INSERT INTO Owners
	                            (FirstName, MiddleName, LastName, DOB, DateOfRetirement, Retired)
	                            VALUES
	                            ('{fName}', {mName}, '{lName}', '{dob}', {dateOfRetirement}, {isRetired});";
            DatabaseHelper.SendData(sql);
        }

        private void btnAddOwner_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidateFields())
                {
                    InsertOwner();
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

        private void chkRetired_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                dtpDateOfRetirement.Enabled = chkRetired.Checked;
            }
            catch (Exception ex)
            {
                UIMethods.ErrorHandler(ex);
            }
        }
    }
}
