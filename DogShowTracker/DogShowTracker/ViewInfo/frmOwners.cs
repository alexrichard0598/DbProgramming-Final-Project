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
    public partial class frmOwners : Form
    {
        public frmOwners()
        {
            InitializeComponent();
        }

        private int currentID = 1;

        #region Helper Methods

        public void Reload()
        {
            PopulateOwnersList();
            currentID = Convert.ToInt32(OwnerNavigation()["FirstID"]);
            LoadOwnerDetails();
        }

        private void PopulateOwnersList()
        {
            string sql = "SELECT [OwnerID], FirstName + ' ' + COALESCE(MiddleName + ' ', '') + LastName AS OwnerName FROM Owners ORDER BY LastName;";
            DataTable dt = DatabaseHelper.GetDataTable(sql);
            UIMethods.FillListControl(cmbSelectOwner, "OwnerName", "OwnerID", dt);
        }

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

        private void LoadOwnerDetails()
        {
            string sql = $"SELECT FirstName, COALESCE(MiddleName + ' ', '') AS MiddleName, LastName, DOB, DateOfRetirement, Retired FROM Owners WHERE OwnerID = {currentID};";
            DataRow row = DatabaseHelper.GetDataRow(sql);

            string fName = row["FirstName"].ToString();
            string mName = row["MiddleName"].ToString();
            string lName = row["LastName"].ToString();
            DateTime dob = Convert.ToDateTime(row["DOB"]);
            DateTime? dateOfRetirement = null;
            if (row["DateOfRetirement"] != DBNull.Value) dateOfRetirement = Convert.ToDateTime(row["DateOfRetirement"]);
            bool retired = Convert.ToBoolean(row["Retired"]);

            txtFName.Text = fName;
            txtMName.Text = mName;
            txtLName.Text = lName;
            dtDOB.Value = dob;
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
                if (nextId != -1)
                {
                    currentID = nextId;
                }
                else
                {
                    currentID = Convert.ToInt32(OwnerNavigation()["FirstID"]);
                }
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
                if (previousID != -1)
                {
                    currentID = previousID;
                }
                else
                {
                    currentID = Convert.ToInt32(OwnerNavigation()["LastID"]);
                }
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

        private void button1_Click(object sender, EventArgs e)
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
