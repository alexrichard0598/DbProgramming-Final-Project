using DogShowTrackerCL;
using System;
using System.Linq;
using System.Windows.Forms;

/*
    Alex Richard
    Dog Show Tracker
    2020-06-04
*/

namespace DogShowTracker
{
    public partial class frmAddDogShow : DogShowForm
    {
        public frmAddDogShow()
        {
            InitializeComponent();
        }

        bool dogShowAdded = false;

        /// <summary>
        /// Validate the user provided info
        /// </summary>
        /// <returns></returns>
        private bool ValidateFields()
        {
            bool isValid = true;
            errorProvider.Clear();
            if(txtDogShowName.Text.Replace(" ", "").Length < 5 || !txtDogShowName.Text.All(c => char.IsWhiteSpace(c) || char.IsLetter(c)))
            {
                isValid = false;
                errorProvider.SetError(txtDogShowName, "Dog show name must be longer than 5 characters and contain only letters and spaces");
            }
            if(nudNumDogs.Value < 5)
            {
                isValid = false;
                errorProvider.SetError(nudNumDogs, "Dog shows must have a least 5 dogs competing");
            }
            if(dtpEndDate.Value.Date < dtpStartDate.Value.Date)
            {
                isValid = false;
                errorProvider.SetError(dtpEndDate, "Dog show cannnot end before it starts");
            }
            return isValid;
        }

        /// <summary>
        /// Insert dog show info into database
        /// </summary>
        private void InsertDogShow()
        {
            string name = DatabaseHelper.SanitizeUserInput(txtDogShowName.Text);
            string start = dtpStartDate.Value.ToString("yyyy-MM-dd");
            string end = dtpEndDate.Value.ToString("yyyy-MM-dd");
            int numDogs = Convert.ToInt32(nudNumDogs.Value);

            string sql = $@"INSERT INTO DogShows
	                        ([Name], StartDate, EndDate, NumDogs)
	                        VALUES
	                        ('{name}', '{start}', '{end}', {numDogs});";

            DatabaseHelper.SendData(sql);
        }

        private void btnAddDogShow_Click(object sender, System.EventArgs e)
        {
            try
            {
                if(ValidateFields())
                {
                    InsertDogShow();
                    dogShowAdded = true;
                    Close();
                }
            }
            catch (Exception ex)
            {
                UIMethods.ErrorHandler(ex);
            }
        }

        private void frmAddDogShow_FormClosed(object sender, System.Windows.Forms.FormClosedEventArgs e)
        {
            try
            {
                if(dogShowAdded) MessageBox.Show("Dog show added");
            }
            catch (Exception ex)
            {
                UIMethods.ErrorHandler(ex);
            }
        }
    }
}
