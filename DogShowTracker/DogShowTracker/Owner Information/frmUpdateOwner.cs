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
    public partial class frmUpdateOwner : DogShowForm
    {
        public frmUpdateOwner()
        {
            InitializeComponent();
        }

        int id, retired, age;
        string fName, mName, lName, dob, dateOfRetirement;

        public override void Reload()
        {
            UIMethods.FillListControl(lstOwners, "OwnerName", "OwnerID", LoadFormData.OwnerNamesCombined());
        }

        private void GetUserData()
        {
            id = Convert.ToInt32(lstOwners.SelectedValue);
            retired = chkRetired.Checked? 1 : 0;
            fName = txtFName.Text;
            mName = txtMName.Text;
            lName = txtLName.Text;
            dob = dtpDOB.Value.ToString("yyyy-MM-dd");
            age = Convert.ToInt32(DateTime.Now.Subtract(dtpDOB.Value).TotalDays / 365);
            dateOfRetirement = retired == 1 ? "NULL" : $"'{dtpDateOfRetirement.Value.ToString("yyyy-MM-dd")}'";
        }

        private bool VerifyFields()
        {
            GetUserData();
            errorProvider.Clear();
            bool isValid = true;
            if (string.IsNullOrEmpty(fName) || !fName.All(c => char.IsLetter(c)))
            {
                errorProvider.SetError(txtFName, "First Name must not be empty and contain only letters");
                isValid = false;
            }
            if (mName.Length != 0 && !mName.All(c => char.IsLetter(c)))
            {
                errorProvider.SetError(txtMName, "Middle Name must only contain letters");
                isValid = false;
            }
            if (string.IsNullOrEmpty(lName) || !lName.All(c => char.IsLetter(c)))
            {
                errorProvider.SetError(txtLName, "Last Name must not be empty and contain only letters");
                isValid = false;
            }
            if (age < 18)
            {
                errorProvider.SetError(dtpDOB, "Owners must be at least 18 years old");
                isValid = false;
            }
            if (retired == 1 && DateTime.Parse(dateOfRetirement) < DateTime.Parse(dob).AddYears(18))
            {
                errorProvider.SetError(dtpDateOfRetirement, "Cannot retire before 18 years of age");
                isValid = false;
            }
            if (isValid && DatabaseHelper.ValueChanged("FirstName + ' ' + COALESCE(MiddleName + ' ', '') + LastName", $"'{fName + ' ' + mName + ' ' + lName}'", "Owners", "OwnerID", id) 
                && DatabaseHelper.ValueExists("FirstName + ' ' + COALESCE(MiddleName + ' ', '') + LastName", $"'{fName + ' ' + mName + ' ' + lName}'", "Owners"))
            {
                if (DialogResult.Yes == MessageBox.Show("A owner with that name already exists, are you sure you wish to change owner name that?", 
                    "", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                    isValid = false;
            }

            return isValid;
        }

        private void UpdateOwner()
        {
            GetUserData();
            if (VerifyFields())
            {
                string sql = $@"UPDATE Owners WHERE OwnerID = {id} SET FirstName = {fName}, MiddleName = {mName}, LastName = {lName}, DOB = '{dob}', 
                            DateOfRetirement = {dateOfRetirement}, Retired = {retired}";
                DatabaseHelper.SendData(sql);
            }
        }

        private void GetOwnerInfo()
        {
            id = Convert.ToInt32(lstOwners.SelectedValue);
            string sql = $@"SELECT  FirstName, COALESCE(MiddleName, '') AS MiddleName, LastName, DOB, 
                                    DateOfRetirement, Retired FROM Owners WHERE OwnerID = {id};";

            DataRow row = DatabaseHelper.GetDataRow(sql);

            txtFName.Text = row["FirstName"].ToString();
            txtMName.Text = row["MiddleName"].ToString();
            txtLName.Text = row["LastName"].ToString();
            dtpDOB.Value = Convert.ToDateTime(row["DOB"]);

            UIMethods.PickDateTimePicker(dtpDateOfRetirement, row["DateOfRetirement"]);
            chkRetired.Checked = Convert.ToBoolean(row["Retired"]);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                UpdateOwner();
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

        private void lstOwners_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                GetOwnerInfo();
            }
            catch (Exception ex)
            {
                UIMethods.ErrorHandler(ex);
            }
        }

        private void chkRetired_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                dtpDateOfRetirement.Enabled = chkRetired.Checked;
            }
            catch (Exception ex)
            {
                UIMethods.ErrorHandler(ex);
            }
        }

        private void frmUpdateOwner_Load(object sender, EventArgs e)
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
    }
}
