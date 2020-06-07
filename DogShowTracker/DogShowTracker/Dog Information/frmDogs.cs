using System;
using System.Data;
using System.Windows.Forms;
using DogShowTrackerCL;

/*
    Alex Richard
    Dog Show Tracker
    2020-06-05
*/

namespace DogShowTracker
{
    public partial class frmDogs : DogShowForm
    {
        public frmDogs()
        {
            InitializeComponent();
        }

        #region Helper Methods
        /// <summary>
        /// Load all form info
        /// </summary>
        public override void Reload()
        {
            UIMethods.FillListControl(cmbBreed, "Breed", "BreedID", LoadFormData.BreedNames());
            UIMethods.FillListControl(cmbSearchBreed, "Breed", "BreedID", LoadFormData.BreedNames(), true);
            UIMethods.FillListControl(cmbOwner, "OwnerName", "OwnerID", LoadFormData.OwnerNamesCombined());
            UIMethods.FillListControl(lstDogs, "Name", "DogID", LoadFormData.DogNames());
            UIMethods.DisplayStatusMessage(((frmMDIParent)MdiParent).GetStatusLabel(), "Dogs info loaded");
        }

        /// <summary>
        /// Fills the datagrid of competions with competitions the selected dog has done
        /// </summary>
        private void PopulateDogShows()
        {
            int id = Convert.ToInt32(lstDogs.SelectedValue);
            string sql = $@"SELECT DogShows.DogShowID AS ID, [Name], Disqualified, 
                                    COALESCE(CAST([Rank] AS VARCHAR), '-') + '/' + 
                                    CAST(DogShows.NumDogs AS VARCHAR) AS Placed FROM DogShowDetails
	                            LEFT JOIN DogShows
		                            ON DogShowDetails.DogShowID = DogShows.DogShowID
	                            WHERE DogID = {id};";
            DataTable dt = DatabaseHelper.GetDataTable(sql);
            dgCompetitions.DataSource = dt;
        }

        /// <summary>
        /// Get the information on the selected dog
        /// </summary>
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


            UIMethods.PickDateTimePicker(dtpDateOfRetirement, row["DateOfRetirement"]);
            bool retired = Convert.ToBoolean(row["Retired"]);

            bool champion = Convert.ToBoolean(row["Champion"]);
            UIMethods.PickDateTimePicker(dtpChampionshipDate, row["DateOfChampionship"]);

            bool banned = Convert.ToBoolean(row["PermanentlyDisqualified"]);
            UIMethods.PickDateTimePicker(dtpDateBanned, row["DateOfDisqualification"]);

            int breedID = Convert.ToInt32(row["Breed"]);
            int ownerID = LoadFormData.GetCurrentOwnerOfDog(id);

            txtID.Text = id.ToString();
            txtName.Text = name.ToString();
            rdoMale.Checked = isMale;
            rdoFemale.Checked = !isMale;
            txtWeight.Text = weight.ToString("N1");
            txtHeight.Text = height.ToString("N1");
            dtpDateOfBirth.Value = dob;
            chkRetired.Checked = retired;
            chkChampion.Checked = champion;
            chkBanned.Checked = banned;
            cmbBreed.SelectedValue = breedID;
            cmbOwner.SelectedValue = ownerID;

            PopulateDogShows();
            UIMethods.DisplayStatusMessage(((frmMDIParent)MdiParent).GetStatusLabel(), "Dog info loaded");
        }

        /// <summary>
        /// Search the dogs using any of the provided search terms.
        /// If a search term is blank will filter that field by all possiblites
        /// </summary>
        private void QueryDogs()
        {
            string dogName = DatabaseHelper.SanitizeUserInput(txtSearchName.Text);

            // If no breed is selected set to a wild card
            string breedID = cmbSearchBreed.SelectedIndex <= 0 ? "%%" : cmbSearchBreed.SelectedValue.ToString();

            // If the rdo male is check set a 1 if rdo female is checked set to 0 else set to 1, 0 which will show both
            string sex = rdoSearchMale.Checked ? "1" : rdoSearchFemale.Checked ? "0" : "1, 0";
            string ownerName = DatabaseHelper.SanitizeUserInput(txtSearchOwner.Text);

            // If max weight is 0 set to filter max by 999
            decimal maxWeight = nudMaxWeight.Value == 0 ? 999 : nudMaxWeight.Value;
            decimal minWeight = nudMinWeight.Value;

            // If max height is 0 set to filter max by 999
            decimal maxHeight = nudMaxHeight.Value == 0 ? 999 : nudMaxHeight.Value;
            decimal minHeight = nudMinHeight.Value;

            string sql = $@"SELECT DISTINCT Dogs.DogID, [Name] FROM Dogs 
	                            LEFT JOIN DogOwnership
		                            ON Dogs.DogID = DogOwnership.DogID
	                            LEFT JOIN Owners
		                            ON DogOwnership.OwnerID = Owners.OwnerID
	                            WHERE	Dogs.[Name] LIKE '%{dogName}%' AND
			                            Breed LIKE '{breedID}' AND
			                            SEX IN({sex}) AND
			                            FirstName + ' ' + COALESCE(MiddleName + ' ', '') + LastName LIKE '%{ownerName}%' AND
			                            {minHeight} < Height AND Height < {maxHeight} AND
			                            {minWeight} < [Weight] AND [Weight] < {maxWeight}
                                ORDER BY [Name];";
            DataTable dt = DatabaseHelper.GetDataTable(sql);
            UIMethods.FillListControl(lstDogs, "Name", "DogID", dt);
        }

        /// <summary>
        /// Open the info of the currently selected dog show (if any)
        /// </summary>
        private void OpenDogShowInfo()
        {
            if (dgCompetitions.SelectedCells.Count == 0) return;
            int rowIndex = dgCompetitions.SelectedCells[0].RowIndex;
            int id = Convert.ToInt32(dgCompetitions.Rows[rowIndex].Cells["ID"].Value);
            int dogId = Convert.ToInt32(lstDogs.SelectedValue);

            Form form = UIMethods.OpenForm(MdiParent, new frmDogShows());
            ((ComboBox)form.Controls["grpDogShows"].Controls["cmbDogShows"]).SelectedValue = id;
            ((ListBox)form.Controls["lstDogs"]).SelectedValue = dogId;
        }

        /// <summary>
        /// Open the info on the current owner of the selected dog
        /// </summary>
        private void OpenOwnerInfo()
        {
            int id = Convert.ToInt32(cmbOwner.SelectedValue);

            Form form = UIMethods.OpenForm(MdiParent, new frmOwners());
            ((ComboBox)form.Controls["cmbSelectOwner"]).SelectedValue = id;
        }

        /// <summary>
        /// Open the info on the breed of the selected dog
        /// </summary>
        private void OpenBreedInfo()
        {
            int id = Convert.ToInt32(cmbBreed.SelectedValue);

            Form form = UIMethods.OpenForm(MdiParent, new frmBreeds());
            ((ListBox)form.Controls["grpBreeds"].Controls["lstBreeds"]).SelectedValue = id;
        }

        private void DeleteDog()
        {
            int id = Convert.ToInt32(txtID.Text);
            string errorMsg = "";

            if (DatabaseHelper.ValueExists("DogID", id.ToString(), "DogShowDetails"))
            {
                errorMsg += "Cannot remove a dog that is in a dog show results\r\n";
            }
            if (DatabaseHelper.ValueExists("DogID", id.ToString(), "DogOwnership"))
            {
                errorMsg += "Cannot remove a dog that is in an ownership record";
            }

            if (errorMsg.Length != 0) errorProvider.SetError(btnDeleteDog, errorMsg.Trim());
            else
            {
                string sql = $"DELETE FROM Dogs WHERE DogID = {id};";
                int rowsAffected = DatabaseHelper.SendData(sql);
                UIMethods.DisplayStatusMessage(((frmMDIParent)MdiParent).GetStatusLabel(), $"{rowsAffected} row(s) deleted");
            }
        }
        #endregion

        #region Event Handlers
        private void frmDogs_Load(object sender, EventArgs e)
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


        private void btnNewDog_Click(object sender, EventArgs e)
        {
            try
            {
                UIMethods.OpenForm(MdiParent, new frmAddDog());
            }
            catch (Exception ex)
            {
                UIMethods.ErrorHandler(ex);
            }
        }
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
                Reload();
            }
            catch (Exception ex)
            {
                UIMethods.ErrorHandler(ex);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            UIMethods.ClearControls(Controls);
            rdoSexEither.Checked = true;
            Reload();
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                QueryDogs();
            }
            catch (Exception ex)
            {
                UIMethods.ErrorHandler(ex);
            }
        }

        private void dgCompetitions_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                OpenDogShowInfo();
            }
            catch (Exception ex)
            {
                UIMethods.ErrorHandler(ex);
            }
        }

        private void btnViewOwner_Click(object sender, EventArgs e)
        {
            try
            {
                OpenOwnerInfo();
            }
            catch (Exception ex)
            {
                UIMethods.ErrorHandler(ex);
            }
        }


        private void btnViewBreed_Click(object sender, EventArgs e)
        {
            try
            {
                OpenBreedInfo();
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
                Form form = UIMethods.OpenForm(MdiParent, new frmUpdateDog());
                ((ComboBox)form.Controls["grpDogInfo"].Controls["cmbDogToUpdate"]).SelectedValue = lstDogs.SelectedValue;
            }
            catch (Exception ex)
            {
                UIMethods.ErrorHandler(ex);
            }
        }

        private void btnDeleteDog_Click(object sender, EventArgs e)
        {
            try
            {
                DeleteDog();
            }
            catch (Exception ex)
            {
                UIMethods.ErrorHandler(ex);
            }
        }
        #endregion
    }
}
