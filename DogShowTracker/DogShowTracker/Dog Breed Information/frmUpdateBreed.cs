using DogShowTrackerCL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
    Alex Richard
    Dog Show Tracker
    2020-06-05
*/

namespace DogShowTracker
{
    public partial class frmUpdateBreed : DogShowForm
    {
        public frmUpdateBreed()
        {
            InitializeComponent();
        }

        private void UpdateBreed()
        {
            //TODO: Impliment UpdateBreed Method
        }

        private void LoadBreedInfo()
        {
            int breedID = Convert.ToInt32(lstBreeds.SelectedValue);
            string sql = $"SELECT Breed, [Classification], PrimaryCoatColour, SecondaryCoatColour FROM Breeds WHERE BreedID = {breedID};";

            DataRow row = DatabaseHelper.GetDataRow(sql);
            string breed = row["Breed"].ToString();
            int classID = Convert.ToInt32(row["Classification"]);
            int primaryColourID = Convert.ToInt32(row["PrimaryCoatColour"]);


            int secondaryColourID;
            int.TryParse(row["SecondaryCoatColour"].ToString(), out secondaryColourID);

            txtName.Text = breed;
            cmbClass.SelectedValue = classID;
            cmbPrimary.SelectedValue = primaryColourID;
            cmbSecondary.SelectedValue = secondaryColourID;
        }

        public override void Reload()
        {
            UIMethods.FillListControl(cmbClass, "Class", "ClassID", LoadFormData.ClassNames());
            UIMethods.FillListControl(cmbPrimary, "Colour", "ColourID", LoadFormData.ColourNames());
            UIMethods.FillListControl(cmbSecondary, "Colour", "ColourID", LoadFormData.ColourNames(), true);
            UIMethods.FillListControl(lstBreeds, "Breed", "BreedID", LoadFormData.BreedNames());
        }

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
