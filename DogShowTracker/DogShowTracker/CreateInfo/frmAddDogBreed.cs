using DogShowTrackerCL;
using System;
using System.Data;
using System.Windows.Forms;

/*
    Alex Richard
    Dog Show Tracker
    2020-06-04
*/

namespace DogShowTracker
{
    public partial class frmAddDogBreed : DogShowForm
    {
        public frmAddDogBreed()
        {
            InitializeComponent();
        }

        bool breedAdded = false;

        #region Helper Methods
        /// <summary>
        /// Load all form info
        /// </summary>
        public override void Reload()
        {
            UIMethods.FillListControl(cmbClass, "Class", "ClassID", LoadFormData.ClassNames(), true);
            UIMethods.FillListControl(cmbPrimaryCoat, "Colour", "ColourID", LoadFormData.ColourNames(), true);
            UIMethods.FillListControl(cmbSecondaryCoat, "Colour", "ColourID", LoadFormData.ColourNames(), true);
        }

        /// <summary>
        /// Insert the breed info into the database
        /// </summary>
        private void AddBreed()
        {
            string breedName = DatabaseHelper.SanitizeUserInput(txtBreedName.Text);
            string primaryId = cmbPrimaryCoat.SelectedValue.ToString();
            string secondaryId = cmbSecondaryCoat.SelectedValue != DBNull.Value
                                ? cmbSecondaryCoat.SelectedValue.ToString()
                                : "NULL";
            string classId = cmbClass.SelectedValue.ToString();
            string sql = $@"
                        INSERT INTO Breeds
	                        (Breed, PrimaryCoatColour, SecondaryCoatColour, [Classification])
	                        Values
	                        ('{breedName}', {primaryId}, {secondaryId}, {classId});";
            DatabaseHelper.SendData(sql);
        }

        /// <summary>
        /// Validate user provided data
        /// </summary>
        /// <returns></returns>
        private bool ValidateFields()
        {
            errorProvider.Clear();
            bool isValid = true;
            if (txtBreedName.Text == "")
            {
                errorProvider.SetError(txtBreedName, "Breed Name cannot be empty");
                isValid = false;
            }
            if (cmbPrimaryCoat.SelectedIndex == 0)
            {
                errorProvider.SetError(cmbPrimaryCoat, "Breed must have a primary coat colour selected");
                isValid = false;
            }
            if (cmbClass.SelectedIndex == 0)
            {
                errorProvider.SetError(cmbClass, "Breed must have a class");
                isValid = false;
            }
            return isValid;
        }
        #endregion

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidateFields())
                {
                    AddBreed();
                    breedAdded = true;
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

        private void frmAddDogBreed_Load(object sender, EventArgs e)
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

        private void frmAddDogBreed_FormClosed(object sender, System.Windows.Forms.FormClosedEventArgs e)
        {
            try
            {
                if (breedAdded) MessageBox.Show("Dog Breed Added");
            }
            catch (Exception ex)
            {
                UIMethods.ErrorHandler(ex);
            }
        }
    }
}
