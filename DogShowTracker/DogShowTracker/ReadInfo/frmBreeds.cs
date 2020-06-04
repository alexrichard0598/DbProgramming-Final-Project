using DogShowTrackerCL;
using System;
using System.Data;
using System.Windows.Forms;

/*
    Alex Richard
    Dog Show Tracker
    2020-06-03
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
            LoadBreeds();
            LoadClasses();
            LoadColours();
        }

        /// <summary>
        /// Fill the breeds listbox
        /// </summary>
        private void LoadBreeds()
        {
            UIMethods.FillListControl(lstBreeds, "Breed", "BreedID", LoadFormData.BreedNames());
        }

        /// <summary>
        /// Fill the classification combobox
        /// </summary>
        private void LoadClasses()
        {
            UIMethods.FillListControl(cmbClass, "Class", "ClassID", LoadFormData.ClassNames());
        }

        /// <summary>
        /// Fill the primary and secondary coat colour comboboxes
        /// </summary>
        private void LoadColours()
        {
            UIMethods.FillListControl(cmbPrimary, "Colour", "ColourID", LoadFormData.ColourNames());
            UIMethods.FillListControl(cmbSecondary, "Colour", "ColourID", LoadFormData.ColourNames(), true);
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


            int secondaryColourID = 0;
            int.TryParse(row["SecondaryCoatColour"].ToString(), out secondaryColourID);

            txtID.Text = breedID.ToString();
            txtName.Text = breed;
            cmbClass.SelectedValue = classID;
            cmbPrimary.SelectedValue = primaryColourID;
            cmbSecondary.SelectedValue = secondaryColourID;

        }
        #endregion

        private void frmBreeds_Load(object sender, EventArgs e)
        {
            try
            {
                LoadBreeds();
                LoadClasses();
                LoadColours();
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
                UIMethods.OpenForm(MdiParent, new frmUpdateBreed());
            }
            catch (Exception ex)
            {
                UIMethods.ErrorHandler(ex);
            }
        }
    }
}
