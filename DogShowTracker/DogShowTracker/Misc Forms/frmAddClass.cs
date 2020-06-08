using DogShowTrackerCL;
using System;

/*
    Alex Richard
    Dog Show Tracker
    2020-06-05
*/

namespace DogShowTracker
{
    public partial class frmAddClass : DogShowForm
    {
        public frmAddClass()
        {
            InitializeComponent();
        }

        string className;

        #region Helper Methods
        /// <summary>
        /// Get the user input
        /// </summary>
        private void GetUserInput()
        {
            className = DatabaseHelper.SanitizeUserInput(txtClass.Text);
        }

        /// <summary>
        /// Insert the colour into the database
        /// </summary>
        private void InsertNewColour()
        {
            GetUserInput();
            string sql = $@"
                        INSERT INTO Classes
                            (Class)
                            VALUES
                            ('{className}');";
            int rowsAffected = DatabaseHelper.SendData(sql);
            UIMethods.DisplayStatusMessage(((frmMDIParent)MdiParent).GetStatusLabel(), $"{rowsAffected} row(s) added");
            txtClass.Clear();
            ((frmMDIParent)MdiParent).ReloadAllChildForms();
        }

        /// <summary>
        /// Validate the user provided info
        /// </summary>
        /// <returns></returns>
        private bool ValidateFields()
        {
            bool isValid = true;
            errorProvider.Clear();
            GetUserInput();
            if (string.IsNullOrEmpty(className))
            {
                errorProvider.SetError(txtClass, "Colour Name cannot be blank");
                isValid = false;
            }
            if (DatabaseHelper.ValueExists("Class", $"'{className}'", "Classes"))
            {
                isValid = false;
                errorProvider.SetError(txtClass, "A class with that name already exists");
            }
            return isValid;
        }
        #endregion
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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidateFields())
                {
                    InsertNewColour();
                }
            }
            catch (Exception ex)
            {
                UIMethods.ErrorHandler(ex);
            }
        }
    }
}
