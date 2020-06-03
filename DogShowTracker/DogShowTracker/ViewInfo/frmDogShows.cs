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
    public partial class frmDogShows : Form
    {
        public frmDogShows()
        {
            InitializeComponent();
        }

        #region Helper Methods
        /// <summary>
        /// Load all form info
        /// </summary>
        public void Reload()
        {
            PopulateDogShows();
        }

        /// <summary>
        /// Fill the dogshows combobox
        /// </summary>
        private void PopulateDogShows()
        {
            string sql = "SELECT DogShowID, CAST(StartDate AS VARCHAR) + ' '+ CHAR(151) +' ' + [Name] AS [Name] FROM DogShows ORDER BY [Name];";
            DataTable dt = DatabaseHelper.GetDataTable(sql);
            UIMethods.FillListControl(cmbDogShows, "Name", "DogShowID", dt);
        }

        /// <summary>
        /// Fill the number of dogs textbox with the number of dogs competed in the current dog show
        /// </summary>
        private void GetNumDogs()
        {
            int id = Convert.ToInt32(cmbDogShows.SelectedValue);
            string sql = $"SELECT NumDogs FROM DogShows WHERE DogShowID = {id};";
            txtNumDogs.Text = DatabaseHelper.ExecuteScaler(sql).ToString();
        }

        /// <summary>
        /// Fill the dogs list with the dogs that competed in the selected dog show
        /// </summary>
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

        /// <summary>
        /// Get the start and end dates to the dog show
        /// </summary>
        private void GetDates()
        {
            int id = Convert.ToInt32(cmbDogShows.SelectedValue);
            string sql = $"SELECT StartDate, EndDate FROM DogShows WHERE DogShowID = {id};";
            DataRow row = DatabaseHelper.GetDataRow(sql);
            DateTime startDate = Convert.ToDateTime(row["StartDate"]);
            DateTime endDate = Convert.ToDateTime(row["EndDate"]);
            dtpStartDate.Value = startDate;
            dtpEndDate.Value = endDate;
        }

        /// <summary>
        /// Open the info on the dog that  is currently selected in the dogs list
        /// </summary>
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
        #endregion

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
