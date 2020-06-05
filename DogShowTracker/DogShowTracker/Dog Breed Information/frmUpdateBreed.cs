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
            string name = DatabaseHelper.SanitizeUserInput(txtName.Text);
            int id = Convert.ToInt32(lstBreeds.SelectedValue);

            if (DatabaseHelper.ValueChanged("Breed", name, "Breeds", "BreedID", id) && DatabaseHelper.ValueExists("Breed", name, "Breeds"))
            {
                errorProvider.SetError(txtName, "A breed already exists with that name");
                return;
            }

            int classID = Convert.ToInt32(cmbClass.SelectedValue);
            int primaryCoatID = Convert.ToInt32(cmbPrimary.SelectedValue);
            string secondaryCoatID = cmbSecondary.SelectedIndex <= 0 ? "NULL" : Convert.ToInt32(cmbSecondary.SelectedValue).ToString();

            string sql = $"UPDATE Breeds WHERE BreedID = {id} SET Breed = '{name}' Class = {classID}, PrimaryCoatColour = {primaryCoatID}, SecondaryCoatColour = {secondaryCoatID}; ";
            DatabaseHelper.SendData(sql);
        }

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
