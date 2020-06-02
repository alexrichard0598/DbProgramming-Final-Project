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

        #region
        private void PopulateOwnersList()
        {
            string sql = "SELECT [OwnerID], FirstName + ' ' + COALESCE(MiddleName + ' ', '') + LastName AS OwnerName FROM Owners;";
            DataTable dt = DatabaseHelper.GetDataTable(sql);
            UIMethods.FillListControl(lstOwners, "OwnerName", "OwnerID", dt);
        }

        private void LoadOwnerDetails()
        {
            int id = Convert.ToInt32(lstOwners.SelectedValue);
            string sql = $"SELECT FirstName, COALESCE(MiddleName + ' ', '') AS MiddleName, LastName, DOB, DateOfRetirement, Retired FROM Owners WHERE OwnerID = {id};";
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

        }
        #endregion

        private void frmOwners_Load(object sender, EventArgs e)
        {
            try
            {
                PopulateOwnersList();
            }
            catch (Exception ex)
            {
                UIMethods.ErrorHandler(ex);
            }
            
        }

        private void lstOwners_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
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
    }
}
