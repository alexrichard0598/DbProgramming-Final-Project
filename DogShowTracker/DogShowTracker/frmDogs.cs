using System;
using System.Data;
using System.Windows.Forms;
using DogShowTrackerCL;

namespace DogShowTracker
{
    public partial class frmDogs : Form
    {
        public frmDogs()
        {
            InitializeComponent();
        }

        #region Helper Methods
        private void PopulateDogsList()
        {
            string sql = "SELECT [DogID], [Name] FROM Dogs;";
            DataTable dt = DatabaseHelper.GetDataTable(sql);
            UIMethods.FillListControl(lstDogs, "Name", "DogID", dt);
        }

        private void PopulateBreedsList()
        {
            string sql = "SELECT [BreedID], [Breed] FROM Breeds;";
            DataTable dt = DatabaseHelper.GetDataTable(sql);
            UIMethods.FillListControl(cmbBreed, "Breed", "BreedID", dt);
        }

        private void PopulateOwnersList()
        {
            string sql = "SELECT [OwnerID], FirstName + ' ' + COALESCE(MiddleName + ' ', '') + LastName AS OwnerName FROM Owners;";
            DataTable dt = DatabaseHelper.GetDataTable(sql);
            UIMethods.FillListControl(cmbOwner, "OwnerName", "OwnerID", dt);
        }

        private int GetCurrentOwner(int id)
        {
            int ownerID;

            string sql = $"SELECT OwnerID FROM DogOwnership WHERE DogID = {id} AND EndOfOwnership IS NULL;";
            ownerID = Convert.ToInt32(DatabaseHelper.ExecuteScaler(sql));

            return ownerID;
        }


        private void GetDogDetails()
        {
            int id = Convert.ToInt32(lstDogs.SelectedValue);
            string sql = $"SELECT * FROM Dogs WHERE DogID = {id};";
            DataRow row = DatabaseHelper.GetDataRow(sql);

            string name = row["Name"].ToString();
            bool isMale = Convert.ToBoolean(row["Sex"]);
            double weight = Convert.ToDouble(row["Weight"]);
            double height = Convert.ToDouble(row["Height"]);
            DateTime dob = Convert.ToDateTime(row["DOB"]);

            DateTime? dateOfRetirement = null;
            if (row["DateOfRetirement"] != DBNull.Value) dateOfRetirement = Convert.ToDateTime(row["DateOfRetirement"]);
            bool retired = Convert.ToBoolean(row["Retired"]);

            bool champion = Convert.ToBoolean(row["Champion"]);
            DateTime? dateOfChampionship = null;
            if (row["DateOfChampionship"] != DBNull.Value) dateOfChampionship = Convert.ToDateTime(row["DateOfChampionship"]);

            bool banned = Convert.ToBoolean(row["PermanentlyDisqualified"]);
            DateTime? dateOfDisqualification = null;
            if (row["DateOfDisqualification"] != DBNull.Value) dateOfDisqualification = Convert.ToDateTime(row["DateOfDisqualification"]);

            int breedID = Convert.ToInt32(row["Breed"]);
            int ownerID = GetCurrentOwner(id);

            txtID.Text = id.ToString();
            txtName.Text = name.ToString();
            rdoMale.Checked = isMale;
            rdoFemale.Checked = !isMale;
            txtWeight.Text = weight.ToString();
            txtHeight.Text = height.ToString();
            dtDateOfBirth.Value = dob;
            

            chkRetired.Checked = retired;
            if (dateOfRetirement == null)
            {
                dtDateOfRetirement.Format = DateTimePickerFormat.Custom;
            }
            else
            {
                dtDateOfRetirement.Value = Convert.ToDateTime(dateOfRetirement);
                dtDateOfRetirement.Format = DateTimePickerFormat.Long;
            }

            chkChampion.Checked = champion;
            if (dateOfChampionship == null)
            {
                dtChampionshipDate.Format = DateTimePickerFormat.Custom;
            }
            else
            {
                dtChampionshipDate.Value = Convert.ToDateTime(dateOfChampionship);
                dtChampionshipDate.Format = DateTimePickerFormat.Long;
            }

            chkBanned.Checked = banned;
            if (dateOfDisqualification == null)
            {
                dtDateBanned.Format = DateTimePickerFormat.Custom;
            }
            else
            {
                dtDateBanned.Value = Convert.ToDateTime(dateOfDisqualification);
                dtDateBanned.Format = DateTimePickerFormat.Long;
            }

            cmbBreed.SelectedValue = breedID;
            cmbOwner.SelectedValue = ownerID;
        }
        #endregion

        #region Event Handlers
        private void frmDogs_Load(object sender, EventArgs e)
        {
            try
            {
                PopulateBreedsList();
                PopulateOwnersList();
                PopulateDogsList();
            }
            catch (Exception ex)
            {
                UIMethods.ErrorHandler(ex);
            }
        }


        private void btnNewDog_Click(object sender, EventArgs e)
        {
            try
            {
                UIMethods.OpenForm(this.MdiParent, new frmAddDog());
            }
            catch (Exception ex)
            {
                UIMethods.ErrorHandler(ex);
            }
        }
        #endregion

        private void lstDogs_SelectedIndexChanged(object sender, EventArgs e)
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

        private void btnReloadDogs_Click(object sender, EventArgs e)
        {
            try
            {
                PopulateBreedsList();
                PopulateOwnersList();
                PopulateDogsList();
            }
            catch (Exception ex)
            {
                UIMethods.ErrorHandler(ex);
            }
        }
    }
}
