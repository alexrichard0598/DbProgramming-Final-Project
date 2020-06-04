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
    2020-06-03
*/

namespace DogShowTracker
{
    public partial class frmChangeDogShowDogs : DogShowForm
    {
        public frmChangeDogShowDogs()
        {
            InitializeComponent();
        }

        int dogShowID, dogShowDogID, dogID, disqualified;
        string rank;

        public override void Reload()
        {
            UIMethods.FillListControl(cmbDogs, "Name", "DogID", LoadFormData.DogNames(), true);
            UIMethods.FillListControl(cmbDogShow, "Name", "DogShowID", LoadFormData.DogShowNames());
        }

        private void GetUserData()
        {
            dogID = Convert.ToInt32(cmbDogs.SelectedValue);
            dogShowDogID = Convert.ToInt32(lstDogs.SelectedValue);
            dogShowID = Convert.ToInt32(cmbDogShow.SelectedValue);
            rank = chkDisqualified.Checked? "NULL" : Convert.ToInt32(nudRank.Value).ToString();
            disqualified = chkDisqualified.Checked ? 1 : 0;
        }

        private void LoadDogShowDogsCount()
        {
            int id = Convert.ToInt32(cmbDogShow.SelectedValue);
            string sql = $@"SELECT CAST(COUNT(DogID) AS VARCHAR) + '/' + CAST(NumDogs AS VARCHAR) AS NumDogs FROM DogShows
	                            LEFT JOIN DogShowDetails
		                            ON DogShows.DogShowID = DogShowDetails.DogShowID
	                            WHERE DogShows.DogShowID = {id}
	                            GROUP BY DogShows.DogShowID, NumDogs;";
            txtNumDogs.Text = DatabaseHelper.ExecuteScaler(sql).ToString();
        }

        /// <summary>
        /// Fill the dogs list with the dogs that competed in the selected dog show
        /// </summary>
        private void GetDogShowDetails()
        {
            GetUserData();
            UIMethods.FillListControl(lstDogs, "Dog", "DogID", LoadFormData.DogShowDogs(dogShowID));
            LoadDogShowDogsCount();
        }

        private void InsertDogShowDog()
        {
            
        }

        private void RemoveDogShowDog()
        {
            string sql = $@"DELETE DogShowDetails
            	            WHERE DogID = {dogID} AND DogShowID = {dogShowID};";

            DatabaseHelper.SendData(sql);
        }

        private bool ValidateDeletion()
        {
            GetUserData();

            string sqlDogName = $"SELECT [Name] FROM Dogs WHERE DogID = {dogID}";
            string dogName = DatabaseHelper.ExecuteScaler(sqlDogName).ToString();

            string dogShowName = cmbDogShow.Text.Split('\u2014')[1];
            DateTime dogShowDate = DateTime.Parse(cmbDogShow.Text.Split('\u2014')[0]);


            return lstDogs.SelectedIndex != -1 
                    && DialogResult.Yes == MessageBox.Show($"Are you sure you want to remove {dogName} from the {dogShowDate.ToString("yyyy MMMM d")}{dogShowName} dog show?", "", 
                                                            MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }

        private void btnAddDog_Click(object sender, EventArgs e)
        {

        }

        private void btnRemoveDogs_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidateDeletion())
                {
                    RemoveDogShowDog();
                }
            }
            catch (Exception ex)
            {
                UIMethods.ErrorHandler(ex);
            }
        }

        private void frmAssignDogShowDogs_Load(object sender, EventArgs e)
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

        private void cmbDogShow_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                GetDogShowDetails();
            }
            catch (Exception ex)
            {
                UIMethods.ErrorHandler(ex);
            }
        }

        private void chkDisqualified_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                nudRank.Enabled = !chkDisqualified.Checked;
            }
            catch (Exception ex)
            {
                UIMethods.ErrorHandler(ex);
            }
        }
    }
}
