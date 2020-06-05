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
    public partial class frmUpdateDog : DogShowForm
    {
        public frmUpdateDog()
        {
            InitializeComponent();
        }

        public override void Reload()
        {
            UIMethods.FillListControl(cmbDogToUpdate, "Name", "DogID", LoadFormData.DogNames());
            UIMethods.FillListControl(cmbBreed, "Breed", "BreedID", LoadFormData.BreedNames());
            UIMethods.FillListControl(cmbOwner, "OwnerName", "OwnerID", LoadFormData.OwnerNamesCombined());
        }

        /// <summary>
        /// Get the information on the selected dog
        /// </summary>
        private void GetDogDetails()
        {
            int id = Convert.ToInt32(cmbDogToUpdate.SelectedValue);
            string sql = $"SELECT * FROM Dogs WHERE DogID = {id};";
            DataRow row = DatabaseHelper.GetDataRow(sql);

            string name = row["Name"].ToString();
            bool isMale = Convert.ToBoolean(row["Sex"]);
            decimal weight = Convert.ToDecimal(row["Weight"]);
            decimal height = Convert.ToDecimal(row["Height"]);
            DateTime dob = Convert.ToDateTime(row["DOB"]);


            UIMethods.PickDateTimePicker(dtpDateOfRetirement, row["DateOfRetirement"]);
            bool retired = Convert.ToBoolean(row["Retired"]);

            bool champion = Convert.ToBoolean(row["Champion"]);
            UIMethods.PickDateTimePicker(dtpChampionshipDate, row["DateOfChampionship"]);

            bool banned = Convert.ToBoolean(row["PermanentlyDisqualified"]);
            UIMethods.PickDateTimePicker(dtpDateBanned, row["DateOfDisqualification"]);

            int breedID = Convert.ToInt32(row["Breed"]);
            int ownerID = LoadFormData.GetCurrentOwnerOfDog(id);

            txtName.Text = name.ToString();
            rdoMale.Checked = isMale;
            rdoFemale.Checked = !isMale;
            nudWeight.Value = weight;
            nudHeight.Value = height;
            dtpDateOfBirth.Value = dob;
            chkRetired.Checked = retired;
            chkChampion.Checked = champion;
            chkBanned.Checked = banned;
            cmbBreed.SelectedValue = breedID;
            cmbOwner.SelectedValue = ownerID;
        }

        private void UpdateDog()
        {
            //TODO: Impliment UpdateDog Method
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                UpdateDog();
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

        private void frmUpdateDog_Load(object sender, EventArgs e)
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

        private void cmbDogToUpdate_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                GetDogDetails();
            }
            catch (Exception ex)
            {
                UIMethods.ErrorHandler(ex);
            }
        }
    }
}
