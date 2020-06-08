using DogShowTrackerCL;
using System;

/*
    Alex Richard
    Dog Show Tracker
    2020-06-05
*/

namespace DogShowTracker
{
    public partial class frmAddColour : DogShowForm
    {
        public frmAddColour()
        {
            InitializeComponent();
        }

        #region Helper Methods
        /// <summary>
        /// Insert the colour into the database
        /// </summary>
        private void InsertNewColour()
        {
            string colourName = DatabaseHelper.SanitizeUserInput(txtColour.Text);
            string sql = $@"
                        INSERT INTO Colours
                            (Colour)
                            VALUES
                            ('{colourName}');";
            int rowsAffected = DatabaseHelper.SendData(sql);
            txtColour.Clear();
            UIMethods.DisplayStatusMessage(((frmMDIParent)MdiParent).GetStatusLabel(), $"{rowsAffected} row(s) added");
            ((frmMDIParent)MdiParent).ReloadAllChildForms();
        }

        /// <summary>
        /// Validate all user provided data
        /// </summary>
        /// <returns></returns>
        private bool ValidateFields()
        {
            string colourName = DatabaseHelper.SanitizeUserInput(txtColour.Text);
            errorProvider.Clear();
            bool isValid = true;
            if (string.IsNullOrEmpty(colourName))
            {
                errorProvider.SetError(txtColour, "Colour Name cannot be blank");
                isValid = false;
            }
            if (DatabaseHelper.ValueExists("Colour", $"'{colourName}'", "Colours"))
            {
                isValid = false;
                errorProvider.SetError(txtColour, "A colour with that name already exists.");
            }
            return isValid;
        }
        #endregion

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
    }
}
