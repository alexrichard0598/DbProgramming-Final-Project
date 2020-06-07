using DogShowTrackerCL;
using System;

/*
    Alex Richard
    Dog Show Tracker
    2020-06-05
*/

namespace DogShowTracker
{
    public partial class frmAddDogBreed : DogShowForm
    {
        public frmAddDogBreed()
        {
            InitializeComponent();
        }

        string breedName, primaryId, secondaryId, classId;

        #region Helper Methods

        private void GetUserData()
        {
            breedName = DatabaseHelper.SanitizeUserInput(txtBreedName.Text);
            primaryId = cmbPrimaryCoat.SelectedValue.ToString();
            secondaryId = cmbSecondaryCoat.SelectedValue != DBNull.Value
                                ? cmbSecondaryCoat.SelectedValue.ToString()
                                : "NULL";
            classId = cmbClass.SelectedValue.ToString();
        }

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
            string sql = $@"
                        INSERT INTO Breeds
	                        (Breed, PrimaryCoatColour, SecondaryCoatColour, [Classification])
	                        Values
	                        ('{breedName}', {primaryId}, {secondaryId}, {classId});";
            int rowsAffected = DatabaseHelper.SendData(sql);
            UIMethods.DisplayStatusMessage(((frmMDIParent)MdiParent).GetStatusLabel(), $"{rowsAffected} row(s) added");
            UIMethods.ClearControls(Controls);
            ((frmMDIParent)MdiParent).ReloadAllChildForms();
        }

        /// <summary>
        /// Validate user provided data
        /// </summary>
        /// <returns></returns>
        private bool ValidateFields()
        {
            GetUserData();
            errorProvider.Clear();
            bool isValid = true;
            if (string.IsNullOrEmpty(breedName))
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
            if (DatabaseHelper.ValueExists("Breed", $"'{breedName}'", "Breeds"))
            {
                isValid = false;
                errorProvider.SetError(txtBreedName, "A breed with that name already exists");
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
    }
}
