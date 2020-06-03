using DogShowTrackerCL;
using System;
using System.Data;

/*
    Alex Richard
    Dog Show Tracker
    2020-06-03
*/

namespace DogShowTracker
{
    public partial class frmAddDogBreed : DogShowForm
    {
        public frmAddDogBreed()
        {
            InitializeComponent();
        }
        #region Helper Methods
        /// <summary>
        /// Load all form info
        /// </summary>
        public override void Reload()
        {
            LoadClasses();
            LoadColours();
        }

        /// <summary>
        /// Fill the classification combobox
        /// </summary>
        private void LoadClasses()
        {
            string sql = "SELECT ClassID, Class FROM Classes;";

            DataTable dt = DatabaseHelper.GetDataTable(sql);
            UIMethods.FillListControl(cmbClass, "Class", "ClassID", dt, true);
        }

        /// <summary>
        /// Fill the primary and secondary coat colour comboboxes
        /// </summary>
        private void LoadColours()
        {
            string sql = "SELECT ColourID, Colour FROM Colours;";

            DataTable dt = DatabaseHelper.GetDataTable(sql);
            UIMethods.FillListControl(cmbPrimaryCoat, "Colour", "ColourID", dt, true);

            DataTable dt2 = DatabaseHelper.GetDataTable(sql);
            UIMethods.FillListControl(cmbSecondaryCoat, "Colour", "ColourID", dt2, true);
        }

        private void AddBreed()
        {
            string breedName = txtBreedName.Text;
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
    }
}
