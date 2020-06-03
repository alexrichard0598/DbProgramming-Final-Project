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
    public partial class frmOwners : Form
    {
        public frmOwners()
        {
            InitializeComponent();
        }

        private int currentID = 1;

        #region Helper Methods
        /// <summary>
        /// Load all form info
        /// </summary>
        public void Reload()
        {
            PopulateOwnersList();
            currentID = Convert.ToInt32(OwnerNavigation()["FirstID"]);
            LoadOwnerDetails();
        }

        /// <summary>
        /// Fill the selected owner combobox
        /// </summary>
        private void PopulateOwnersList()
        {
            string sql = "SELECT [OwnerID], FirstName + ' ' + COALESCE(MiddleName + ' ', '') + LastName AS OwnerName FROM Owners ORDER BY LastName;";
            DataTable dt = DatabaseHelper.GetDataTable(sql);
            UIMethods.FillListControl(cmbSelectOwner, "OwnerName", "OwnerID", dt);
        }

        /// <summary>
        /// Fill the ownership datagrid
        /// </summary>
        private void GetOwnership()
        {
            string sql = $@"SELECT	Dogs.DogID AS ID, Dogs.[Name], StartOfOwnership, EndOfOwnership FROM DogOwnership
	                            LEFT JOIN Dogs
		                            ON Dogs.DogID = DogOwnership.DogID
	                             WHERE OwnerID = {currentID}
                                 ORDER BY StartOfOwnership;";
            DataTable dt = DatabaseHelper.GetDataTable(sql);
            dgOwnership.DataSource = dt;
        }

        /// <summary>
        /// Load the info on the selected owner
        /// </summary>
        private void LoadOwnerDetails()
        {
            string sql = $"SELECT FirstName, COALESCE(MiddleName + ' ', '') AS MiddleName, LastName, DOB, DateOfRetirement, Retired FROM Owners WHERE OwnerID = {currentID};";
            DataRow row = DatabaseHelper.GetDataRow(sql);

            string fName = row["FirstName"].ToString();
            string mName = row["MiddleName"].ToString();
            string lName = row["LastName"].ToString();
            DateTime dob = Convert.ToDateTime(row["DOB"]);
            UIMethods.PickDateTimePicker(dtDateOfRetirement, row["DateOfRetirement"]);
            bool retired = Convert.ToBoolean(row["Retired"]);

            txtFName.Text = fName;
            txtMName.Text = mName;
            txtLName.Text = lName;
            dtDOB.Value = dob;
            chkRetired.Checked = retired;

            GetOwnership();
        }

        /// <summary>
        /// Returns a DataRow with the first, previous, current, next, and last owner ids
        /// </summary>
        /// <returns></returns>
        private DataRow OwnerNavigation()
        {
            string sql = $@"
                SELECT * FROM 
                            ( 
	                        SELECT	(SELECT TOP(1) OwnerID FROM Owners ORDER BY LastName) AS FirstID,
			                        COALESCE(LAG(OwnerID) OVER (ORDER BY LastName), -1) AS [PreviousID],
			                        OwnerID AS CurrentID, 
			                        COALESCE(LEAD(OwnerID) OVER (ORDER BY LastName), -1) AS [NextID],
			                        (SELECT TOP(1) OwnerID FROM Owners ORDER BY LastName DESC) AS LastID FROM Owners 
                            ) AS q WHERE CurrentID = {currentID};";
            return DatabaseHelper.GetDataRow(sql);
        }

        /// <summary>
        /// Open the info on the currently selected dog
        /// </summary>
        private void OpenDogInfo()
        {
            try
            {
                int rowIndex = dgOwnership.SelectedCells[0].RowIndex;
                int id = Convert.ToInt32(dgOwnership.Rows[rowIndex].Cells["ID"].Value);

                Form form = UIMethods.OpenForm(this.MdiParent, new frmDogs());
                foreach (Control ctrl in form.Controls)
                {
                    if (ctrl.Name == "grpDogs")
                    {
                        ((ListBox)ctrl.Controls[0]).SelectedValue = id;
                        break;
                    }
                }
            }
            catch (Exception ex)
            {
                UIMethods.ErrorHandler(ex);
            }
        }

        #endregion

        private void frmOwners_Load(object sender, EventArgs e)
        {
            try
            {
                PopulateOwnersList();
                currentID = Convert.ToInt32(OwnerNavigation()["FirstID"]);
                LoadOwnerDetails();
            }
            catch (Exception ex)
            {
                UIMethods.ErrorHandler(ex);
            }

        }

        private void btnNewOwner_Click(object sender, EventArgs e)
        {
            try
            {
                UIMethods.OpenForm(this.MdiParent, new frmAddOwner());
            }
            catch (Exception ex)
            {
                UIMethods.ErrorHandler(ex);
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            try
            {
                int nextId = Convert.ToInt32(OwnerNavigation()["NextID"]);
                currentID = nextId != -1 ? nextId : Convert.ToInt32(OwnerNavigation()["FirstID"]);
                cmbSelectOwner.SelectedValue = currentID;
            }
            catch (Exception ex)
            {
                UIMethods.ErrorHandler(ex);
            }
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            try
            {
                int previousID = Convert.ToInt32(OwnerNavigation()["PreviousID"]);
                currentID = previousID != -1 ? previousID : Convert.ToInt32(OwnerNavigation()["LastID"]);
                cmbSelectOwner.SelectedValue = currentID;
            }
            catch (Exception ex)
            {
                UIMethods.ErrorHandler(ex);
            }
        }

        private void cmbSelectOwner_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                currentID = Convert.ToInt32(cmbSelectOwner.SelectedValue);
                LoadOwnerDetails();
            }
            catch (Exception ex)
            {
                UIMethods.ErrorHandler(ex);
            }
        }

        private void dgOwnership_DoubleClick(object sender, EventArgs e)
        {
            OpenDogInfo();
        }

        private void btnChangeOwnership_Click(object sender, EventArgs e)
        {
            try
            {
                UIMethods.OpenForm(MdiParent, new frmChangeOwnership());
            }
            catch (Exception ex)
            {
                UIMethods.ErrorHandler(ex);
            }
        }
    }
}
