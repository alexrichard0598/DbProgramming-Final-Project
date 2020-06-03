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

namespace DogShowTracker
{
    public partial class frmBreeds : Form
    {
        public frmBreeds()
        {
            InitializeComponent();
        }

        public void Reload()
        {
            LoadBreeds();
            LoadClasses();
            LoadColours();
        }

        private void LoadBreeds()
        {
            string sql = "SELECT BreedID, Breed FROM Breeds ORDER BY Breed;";

            DataTable dt = DatabaseHelper.GetDataTable(sql);
            UIMethods.FillListControl(lstBreeds, "Breed", "BreedID", dt);
        }

        private void LoadClasses()
        {
            string sql = "SELECT ClassID, Class FROM Classes;";

            DataTable dt = DatabaseHelper.GetDataTable(sql);
            UIMethods.FillListControl(cmbClass, "Class", "ClassID", dt);
        }

        private void LoadColours()
        {
            string sql = "SELECT ColourID, Colour FROM Colours;";

            DataTable dt = DatabaseHelper.GetDataTable(sql);
            UIMethods.FillListControl(cmbPrimary, "Colour", "ColourID", dt);

            DataTable dt2 = DatabaseHelper.GetDataTable(sql);
            UIMethods.FillListControl(cmbSecondary, "Colour", "ColourID", dt2);
        }

        private void LoadBreedInfo()
        {
            int breedID = Convert.ToInt32(lstBreeds.SelectedValue);
            string sql = $"SELECT Breed, [Classification], PrimaryCoatColour, SecondaryCoatColour FROM Breeds WHERE BreedID = {breedID};";

            DataRow row = DatabaseHelper.GetDataRow(sql);
            string breed = row["Breed"].ToString();
            int classID = Convert.ToInt32(row["Classification"]);
            int primaryColourID = Convert.ToInt32(row["PrimaryCoatColour"]);
            int secondaryColourID = Convert.ToInt32(row["SecondaryCoatColour"]);

            txtID.Text = breedID.ToString();
            txtName.Text = breed;
            cmbClass.SelectedValue = classID;
            cmbPrimary.SelectedValue = primaryColourID;
            cmbSecondary.SelectedValue = secondaryColourID;

        }

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
                UIMethods.OpenForm(MdiParent, new frmAddBreed());
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
