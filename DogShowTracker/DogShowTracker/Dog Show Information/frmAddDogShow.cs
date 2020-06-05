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
        string name, start, end;
        int numDogs;


        private void GetUserData()
        {
            name = DatabaseHelper.SanitizeUserInput(txtDogShowName.Text);
            start = dtpStartDate.Value.ToString("yyyy-MM-dd");
            end = dtpEndDate.Value.ToString("yyyy-MM-dd");
            numDogs = Convert.ToInt32(nudNumDogs.Value);
        }

        /// <summary>
        /// Validate the user provided info
        /// </summary>
        /// <returns></returns>
        private bool ValidateFields()
        {
            GetUserData();
            bool isValid = true;
            errorProvider.Clear();
            if(name.Length < 5 || !name.All(c => char.IsWhiteSpace(c) || char.IsLetter(c)))
            {
                isValid = false;
                errorProvider.SetError(txtDogShowName, "Dog show name must be longer than 5 characters and contain only letters and spaces");
            }
            if(numDogs < 5)
            {
                isValid = false;
                errorProvider.SetError(nudNumDogs, "Dog shows must have a least 5 dogs competing");
            }
            if(DateTime.Parse(end) < DateTime.Parse(start))
            {
                isValid = false;
                errorProvider.SetError(dtpEndDate, "Dog show cannnot end before it starts");
            }
            //TODO: Prevent Adding Duplicates
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
