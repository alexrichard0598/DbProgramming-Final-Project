using DogShowTrackerCL;
using System;
using System.Windows.Forms;

/*
    Alex Richard
    Dog Show Tracker
    2020-06-07
*/

namespace DogShowTracker
{
    public partial class frmColours : DogShowForm
    {
        public frmColours()
        {
            InitializeComponent();
        }

        string colourName;

        #region Helper Methods
        /// <summary>
        /// Load all of the form data
        /// </summary>
        public override void Reload()
        {
            UIMethods.FillListControl(lstColours, "Colour", "ColourID", LoadFormData.ColourNames());
            UIMethods.DisplayStatusMessage(((frmMDIParent)MdiParent).GetStatusLabel(), "Colours loaded");
        }

        /// <summary>
        /// Get the info on the selected colour
        /// </summary>
        private void GetColourInfo()
        {
            int id = Convert.ToInt32(lstColours.SelectedValue);
            string sql = $"Select Colour FROM Colours WHERE ColourID = {id}";
            txtColourName.Text = DatabaseHelper.ExecuteScaler(sql).ToString();
            UIMethods.DisplayStatusMessage(((frmMDIParent)MdiParent).GetStatusLabel(), "Colour info loaded");
        }

        /// <summary>
        /// Delete the colour from the database
        /// </summary>
        private void DeleteColour()
        {
            int id = Convert.ToInt32(lstColours.SelectedValue);

            if (DatabaseHelper.ValueExists("PrimaryCoatColour", id.ToString(), "Breeds") || DatabaseHelper.ValueExists("SecondaryCoatColour", id.ToString(), "Breeds"))
            {
                MessageBox.Show("Cannot delete colour that is referenced by a breed", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string sql = $"DELETE Colours WHERE ColourID = {id}";

            string sqlColourName = $"SELECT [Colour] FROM Colours WHERE ColourID = {id}";
            string colourName = DatabaseHelper.ExecuteScaler(sqlColourName).ToString();

            if (UIMethods.ConfirmationPrompt($"Are you sure you want to delete {colourName} breed?"))
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
            colourName = DatabaseHelper.SanitizeUserInput(txtColourName.Text);
            if (string.IsNullOrEmpty(colourName))
            {
                errorProvider.SetError(txtColourName, "Colour Name cannot be blank. ");
                isValid = false;
            }
            else if (DatabaseHelper.ValueExists("Colour", $"'{colourName}'", "Colours"))
            {
                isValid = false;
                errorProvider.SetError(txtColourName, "A class with that name already exists");
            }
            return isValid;
        }

        /// <summary>
        /// Update the colour
        /// </summary>
        private void UpdateColour()
        {
            int id = Convert.ToInt32(lstColours.SelectedValue);
            if (ValidateFields())
            {
                string sql = $"UPDATE Colours SET Colour = '{colourName}' WHERE ColourID = {id};";
                int rowsAffected = DatabaseHelper.SendData(sql);
                UIMethods.DisplayStatusMessage(((frmMDIParent)MdiParent).GetStatusLabel(), $"{rowsAffected} row(s) affected");
                ((frmMDIParent)MdiParent).ReloadAllChildForms();
            }
        }
        #endregion

        private void frmColours_Load(object sender, EventArgs e)
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

        private void lstColours_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                GetColourInfo();
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
                DeleteColour();
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
                UpdateColour();
            }
            catch (Exception ex)
            {
                UIMethods.ErrorHandler(ex);
            }
        }
    }
}
