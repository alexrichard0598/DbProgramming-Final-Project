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
    public partial class frmClasses : DogShowForm
    {
        public frmClasses()
        {
            InitializeComponent();
        }

        string className;

        public override void Reload()
        {
            UIMethods.FillListControl(lstClasses, "Class", "ClassID", LoadFormData.ClassNames());
            UIMethods.DisplayStatusMessage(((MDIParent)MdiParent).GetStatusLabel(), "Classes loaded");
        }

        private void GetClassInfo()
        {
            int id = Convert.ToInt32(lstClasses.SelectedValue);
            string sql = $"SELECT Class FROM Classes WHERE ClassID = {id}";
            txtClassName.Text = DatabaseHelper.ExecuteScaler(sql).ToString();
            UIMethods.DisplayStatusMessage(((MDIParent)MdiParent).GetStatusLabel(), "Class info loaded");
        }

        private void DeleteClass()
        {
            int id = Convert.ToInt32(lstClasses.SelectedValue);
            if (DatabaseHelper.ValueExists("ClassID", id.ToString(), "Breeds"))
            {
                MessageBox.Show("Cannot delete class that is referenced by a breed", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string sql = $"DELETE Classes WHERE ClassID = {id}";

            string sqlClassName = $"SELECT [Class] FROM Classes WHERE ClassID = {id}";
            string className = DatabaseHelper.ExecuteScaler(sqlClassName).ToString();

            if (UIMethods.ConfirmationPrompt($"Are you sure you want to delete {className} breed?"))
            {
                DatabaseHelper.SendData(sql);
            }

        }

        /// <summary>
        /// Validate the user provided info
        /// </summary>
        /// <returns></returns>
        private bool ValidateFields()
        {
            bool isValid = true;
            string errorMsg = "";
            className = DatabaseHelper.SanitizeUserInput(txtClassName.Text);
            if (string.IsNullOrEmpty(className))
            {
                errorMsg += "Colour Name cannot be blank. ";
                isValid = false;
            }
            if (DatabaseHelper.ValueExists("Class", $"'{className}'", "Classes"))
            {
                isValid = false;
                errorMsg += "A class with that name already exists";
            }
            if (!isValid) MessageBox.Show(errorMsg.Trim(), "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return isValid;
        }

        private void UpdateClass()
        {
            int id = Convert.ToInt32(lstClasses.SelectedValue);
            if (!ValidateFields())
            {
                string sql = $"UPDATE Classes WHERE ClassID = {id} SET Class = {className}";
                int rowsAffected = DatabaseHelper.SendData(sql);
                UIMethods.DisplayStatusMessage(((MDIParent)MdiParent).GetStatusLabel(), $"{rowsAffected} row(s) affected");
            }
        }

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
