using DogShowTrackerCL;
using System;
using System.Windows.Forms;

namespace DogShowTracker
{
    public partial class frmClasses : DogShowForm
    {
        public frmClasses()
        {
            InitializeComponent();
        }

        string className;
        #region Helper Method
        /// <summary>
        /// Load form Data
        /// </summary>
        public override void Reload()
        {
            UIMethods.FillListControl(lstClasses, "Class", "ClassID", LoadFormData.ClassNames());
            UIMethods.DisplayStatusMessage(((frmMDIParent)MdiParent).GetStatusLabel(), "Classes loaded");
        }

        /// <summary>
        /// Load info on the selected class
        /// </summary>
        private void GetClassInfo()
        {
            int id = Convert.ToInt32(lstClasses.SelectedValue);
            string sql = $"SELECT Class FROM Classes WHERE ClassID = {id}";
            txtClassName.Text = DatabaseHelper.ExecuteScaler(sql).ToString();
            UIMethods.DisplayStatusMessage(((frmMDIParent)MdiParent).GetStatusLabel(), "Class info loaded");
        }

        /// <summary>
        /// Delete the class
        /// </summary>
        private void DeleteClass()
        {
            int id = Convert.ToInt32(lstClasses.SelectedValue);
            if (DatabaseHelper.ValueExists("Classification", id.ToString(), "Breeds"))
            {
                MessageBox.Show("Cannot delete class that is referenced by a breed", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string sql = $"DELETE Classes WHERE ClassID = {id}";

            string sqlClassName = $"SELECT [Class] FROM Classes WHERE ClassID = {id}";
            string className = DatabaseHelper.ExecuteScaler(sqlClassName).ToString();

            if (UIMethods.ConfirmationPrompt($"Are you sure you want to delete {className} class?"))
            {
                int rowsAffected = DatabaseHelper.SendData(sql);
                UIMethods.DisplayStatusMessage(((frmMDIParent)MdiParent).GetStatusLabel(), $"{rowsAffected} row(s) deleted");
                ((frmMDIParent)MdiParent).ReloadAllChildForms();
            }

        }

        /// <summary>
        /// Validate the user provided info
        /// </summary>
        /// <returns></returns>
        private bool ValidateFields()
        {
            bool isValid = true;
            errorProvider.Clear();
            className = DatabaseHelper.SanitizeUserInput(txtClassName.Text);
            if (string.IsNullOrEmpty(className))
            {
                errorProvider.SetError(txtClassName, "Colour Name cannot be blank. ");
                isValid = false;
            }
            else if (DatabaseHelper.ValueExists("Class", $"'{className}'", "Classes"))
            {
                isValid = false;
                errorProvider.SetError(txtClassName, "A class with that name already exists");
            }
            return isValid;
        }

        /// <summary>
        /// Update the class
        /// </summary>
        private void UpdateClass()
        {
            int id = Convert.ToInt32(lstClasses.SelectedValue);
            if (ValidateFields())
            {
                string sql = $"UPDATE Classes SET Class = '{className}' WHERE ClassID = {id};";
                int rowsAffected = DatabaseHelper.SendData(sql);
                UIMethods.DisplayStatusMessage(((frmMDIParent)MdiParent).GetStatusLabel(), $"{rowsAffected} row(s) affected");
                ((frmMDIParent)MdiParent).ReloadAllChildForms();
            }
        }
        #endregion

        private void frmClasses_Load(object sender, EventArgs e)
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

        private void lstClasses_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                GetClassInfo();
            }
            catch (Exception ex)
            {
                UIMethods.ErrorHandler(ex);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                DeleteClass();
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
                UpdateClass();
            }
            catch (Exception ex)
            {
                UIMethods.ErrorHandler(ex);
            }

        }
    }
}
