using DogShowTrackerCL;
using System;
using System.Data;
using System.Windows.Forms;

/*
    Alex Richard
    Dog Show Tracker
    2020-06-05
*/


namespace DogShowTracker
{
    public partial class frmBreeds : DogShowForm
    {
        public frmBreeds()
        {
            InitializeComponent();
        }

        #region Helper Methods
        /// <summary>
        /// Load all form info
        /// </summary>
        public override void Reload()
        {
            UIMethods.FillListControl(cmbClass, "Class", "ClassID", LoadFormData.ClassNames());
            UIMethods.FillListControl(cmbPrimary, "Colour", "ColourID", LoadFormData.ColourNames());
            UIMethods.FillListControl(cmbSecondary, "Colour", "ColourID", LoadFormData.ColourNames(), true);
            UIMethods.FillListControl(lstBreeds, "Breed", "BreedID", LoadFormData.BreedNames());
            UIMethods.DisplayStatusMessage(((frmMDIParent)MdiParent).GetStatusLabel(), "Breeds info loaded");
        }

        /// <summary>
        /// Load the specific information on the breed
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

            txtID.Text = breedID.ToString();
            txtName.Text = breed;
            cmbClass.SelectedValue = classID;
            cmbPrimary.SelectedValue = primaryColourID;
            cmbSecondary.SelectedValue = secondaryColourID;
            UIMethods.DisplayStatusMessage(((frmMDIParent)MdiParent).GetStatusLabel(), "Breed info loaded");
        }

        private void DeleteBreed()
        {
            int id = Convert.ToInt32(lstBreeds.SelectedValue);

            if (DatabaseHelper.ValueExists("Breed", id.ToString(), "Dogs"))
            {
                MessageBox.Show("Cannot delete breed that is referenced by a dog", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string sqlBreedName = $"SELECT [Breed] FROM Breeds WHERE BreedID = {id}";
            string breedName = DatabaseHelper.ExecuteScaler(sqlBreedName).ToString();

            string sql = $"DELETE Breeds WHERE BreedID = {id};";
            if (UIMethods.ConfirmationPrompt($"Are you sure you want to delete {breedName} breed?"))
            {
                int rowsAffected = DatabaseHelper.SendData(sql);
                UIMethods.DisplayStatusMessage(((frmMDIParent)MdiParent).GetStatusLabel(), $"{rowsAffected} row(s) deleted");
                ((frmMDIParent)MdiParent).ReloadAllChildForms();
            }
        }
        
        #endregion

        private void frmBreeds_Load(object sender, EventArgs e)
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

        private void btnNewBreed_Click(object sender, EventArgs e)
        {
            try
            {
                UIMethods.OpenForm(MdiParent, new frmAddDogBreed());
            }
            catch (Exception ex)
            {
                UIMethods.ErrorHandler(ex);
            }
        }

        private void btnNewClass_Click(object sender, EventArgs e)
        {
            try
            {
                UIMethods.OpenForm(MdiParent, new frmAddClass());
            }
            catch (Exception ex)
            {
                UIMethods.ErrorHandler(ex);
            }
        }

        private void btnNewColour_Click(object sender, EventArgs e)
        {
            try
            {
                UIMethods.OpenForm(MdiParent, new frmAddColour());
            }
            catch (Exception ex)
            {
                UIMethods.ErrorHandler(ex);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                Form form = UIMethods.OpenForm(MdiParent, new frmUpdateBreed());

                ((ListBox)form.Controls["grpBreeds"].Controls["lstBreeds"]).SelectedValue = lstBreeds.SelectedValue;
            }
            catch (Exception ex)
            {
                UIMethods.ErrorHandler(ex);
            }
        }

        private void btnDeleteBreed_Click(object sender, EventArgs e)
        {
            try
            {
                DeleteBreed();
            }
            catch (Exception ex)
            {
                UIMethods.ErrorHandler(ex);
            }
        }
    }
}
