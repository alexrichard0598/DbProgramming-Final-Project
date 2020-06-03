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
    public partial class frmDogShows : Form
    {
        public frmDogShows()
        {
            InitializeComponent();
        }

        private void PopulateDogShows()
        {
            string sql = "SELECT DogShowID, [Name] FROM DogShows ORDER BY [Name];";
            DataTable dt = DatabaseHelper.GetDataTable(sql);
            UIMethods.FillListControl(cmbDogShows, "Name", "DogShowID", dt);
        }

        private void GetNumDogs()
        {
            int id = Convert.ToInt32(cmbDogShows.SelectedValue);
            string sql = $"SELECT NumDogs FROM DogShows WHERE DogShowID = {id};";
            txtNumDogs.Text = DatabaseHelper.ExecuteScaler(sql).ToString();
        }

        public void Reload()
        {
            PopulateDogShows();
        }

        private void GetDogs()
        {
            int id = Convert.ToInt32(cmbDogShows.SelectedValue);
            string sql = $@"SELECT	COALESCE(CAST([Rank] AS VARCHAR), '-') + '/' + 
		                            CAST(DogShows.NumDogs AS VARCHAR) + ' - ' + 
		                            Dogs.[Name] AS Dog, Dogs.DogID FROM DogShowDetails
	                            LEFT JOIN Dogs
		                            ON Dogs.DogID = DogShowDetails.DogID
	                            LEFT JOIN DogShows
		                            ON DogShows.DogShowID = DogShowDetails.DogShowID
	                            WHERE DogShowDetails.DogShowID = {id}
		                            ORDER BY COALESCE([Rank], 999);";
            DataTable dt = DatabaseHelper.GetDataTable(sql);
            UIMethods.FillListControl(lstDogs, "Dog", "DogID", dt);
        }

        private void GetDates()
        {
            int id = Convert.ToInt32(cmbDogShows.SelectedValue);
            string sql = $"SELECT StartDate, EndDate FROM DogShows WHERE DogShowID = {id};";
            DataRow row = DatabaseHelper.GetDataRow(sql);
            DateTime startDate = Convert.ToDateTime(row["StartDate"]);
            DateTime endDate = Convert.ToDateTime(row["EndDate"]);
            dtStartDate.Value = startDate;
            dtEndDate.Value = endDate;
        }

        private void OpenDogInfo()
        {
            try
            {
                Form form = UIMethods.OpenForm(MdiParent, new frmDogs());
                foreach (Control ctrl in form.Controls)
                {
                    if (ctrl.Name == "grpDogs")
                    {
                        ((ListBox)ctrl.Controls[0]).SelectedValue = lstDogs.SelectedValue;
                        break;
                    }
                }
            }
            catch (Exception ex)
            {
                UIMethods.ErrorHandler(ex);
            }
        }

        private void frmDogShows_Load(object sender, EventArgs e)
        {
            try
            {
                PopulateDogShows();
            }
            catch (Exception ex)
            {
                UIMethods.ErrorHandler(ex);
            }

        }

        private void cmbDogShows_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                GetDogs();
                GetNumDogs();
                GetDates();
            }
            catch (Exception ex)
            {
                UIMethods.ErrorHandler(ex);
            }
        }

        private void lstDogs_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                OpenDogInfo();
            }
            catch (Exception ex)
            {
                UIMethods.ErrorHandler(ex);
            }
        }

        private void btnNewShow_Click(object sender, EventArgs e)
        {
            try
            {
                UIMethods.OpenForm(MdiParent, new frmAddDogShow());
            }
            catch (Exception ex)
            {
                UIMethods.ErrorHandler(ex);
            }
        }

        private void btnAssignDogs_Click(object sender, EventArgs e)
        {
            try
            {
                UIMethods.OpenForm(MdiParent, new frmAssignDogShowDogs());
            }
            catch (Exception ex)
            {
                UIMethods.ErrorHandler(ex);
            }
        }
    }
}
