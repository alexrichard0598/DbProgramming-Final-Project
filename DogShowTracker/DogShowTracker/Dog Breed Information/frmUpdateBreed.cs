using DogShowTrackerCL;
using System;
using System.Data;

/*
    Alex Richard
    Dog Show Tracker
    2020-06-07
*/

namespace DogShowTracker
{
    public partial class frmUpdateBreed : DogShowForm
    {
        public frmUpdateBreed()
        {
            InitializeComponent();
        }

        #region Helper Methods
        /// <summary>
        /// Update the breed with the user provided info
        /// </summary>
        private void UpdateBreed()
        {
            string name = DatabaseHelper.SanitizeUserInput(txtName.Text);
            int id = Convert.ToInt32(lstBreeds.SelectedValue);

            if (DatabaseHelper.ValueChanged("Breed", $"'{name}'", "Breeds", "BreedID", id.ToString()) && DatabaseHelper.ValueExists("Breed", $"'{name}'", "Breeds"))
            {
                errorProvider.SetError(txtName, "A breed already exists with that name");
                return;
            }

            int classID = Convert.ToInt32(cmbClass.SelectedValue);
            int primaryCoatID = Convert.ToInt32(cmbPrimary.SelectedValue);
            string secondaryCoatID = cmbSecondary.SelectedIndex <= 0 ? "NULL" : Convert.ToInt32(cmbSecondary.SelectedValue).ToString();

            string sql = $"UPDATE Breeds SET Breed = '{name}', [Classification] = {classID}, PrimaryCoatColour = {primaryCoatID}, SecondaryCoatColour = {secondaryCoatID} WHERE BreedID = {id};";
            int rowsAffected = DatabaseHelper.SendData(sql);
            UIMethods.DisplayStatusMessage(((frmMDIParent)MdiParent).GetStatusLabel(), $"{rowsAffected} row(s) affected");
            ((frmMDIParent)MdiParent).ReloadAllChildForms();
        }

        /// <summary>
        /// Load info on the selected breed
        /// </summary>
        private void LoadBreedInfo()
        {
            int breedID = Convert.ToInt32(lstBreeds.SelectedValue);
            string sql = $"SELECT Breed, [Classification], PrimaryCoatColour, SecondaryCoatColour FROM Breeds WHERE BreedID = {breedID};";

            DataRow row = DatabaseHelper.GetDataRow(sql);
            string breed = row["Breed"].ToString();
            int classID = Convert.ToInt32(row["Classification"]);
            int primaryColourID = Convert.ToInt32(row["PrimaryCoatColour"]);
            _ = int.TryParse(row["SecondaryCoatColour"].ToString(), out int secondaryColourID);

            txtName.Text = breed;
            cmbClass.SelectedValue = classID;
            cmbPrimary.SelectedValue = primaryColourID;
            cmbSecondary.SelectedValue = secondaryColourID;
        }

        /// <summary>
        /// Load all form info
        /// </summary>
        public override void Reload()
        {
            UIMethods.FillListControl(cmbClass, "Class", "ClassID", LoadFormData.ClassNames());
            UIMethods.FillListControl(cmbPrimary, "Colour", "ColourID", LoadFormData.ColourNames());
            UIMethods.FillListControl(cmbSecondary, "Colour", "ColourID", LoadFormData.ColourNames(), true);
            UIMethods.FillListControl(lstBreeds, "Breed", "BreedID", LoadFormData.BreedNames());
        }
        #endregion
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                UpdateBreed();
            }
            catch (Exception ex)
            {
                UIMethods.ErrorHandler(ex);
            }
        }

        private void frmUpdateBreed_Load(object sender, EventArgs e)
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

        private void lstBreeds_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                LoadBreedInfo();
            }
            catch (Exception ex)
            {
                UIMethods.ErrorHandler(ex);
            }
        }
    }
}
