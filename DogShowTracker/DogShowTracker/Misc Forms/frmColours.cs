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
    2020-06-05
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

        public override void Reload()
        {
            UIMethods.FillListControl(lstColours, "Colour", "ColourID", LoadFormData.ColourNames());
            UIMethods.DisplayStatusMessage(((MDIParent)MdiParent).GetStatusLabel(), "Colours loaded");
        }

        private void GetColourInfo()
        {
            int id = Convert.ToInt32(lstColours.SelectedValue);
            string sql = $"Select Colour FROM Colours WHERE ColourID = {id}";
            txtColourName.Text = DatabaseHelper.ExecuteScaler(sql).ToString();
            UIMethods.DisplayStatusMessage(((MDIParent)MdiParent).GetStatusLabel(), "Colour info loaded");
        }

        private void DeleteColour()
        {
            int id = Convert.ToInt32(lstColours.SelectedValue);

            if (DatabaseHelper.ValueExists("ColourID", id.ToString(), "Breeds"))
            {
                MessageBox.Show("Cannot delete colour that is referenced by a breed", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string sql = $"DELETE Colours WHERE ColourID = {id}";

            string sqlColourName = $"SELECT [Colour] FROM Colours WHERE ColourID = {id}";
            string colourName = DatabaseHelper.ExecuteScaler(sqlColourName).ToString();

            if (UIMethods.ConfirmationPrompt($"Are you sure you want to delete {colourName} breed?"))
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
            colourName = DatabaseHelper.SanitizeUserInput(txtColourName.Text);
            if (string.IsNullOrEmpty(colourName))
            {
                errorMsg += "Colour Name cannot be blank. ";
                isValid = false;
            }
            if (DatabaseHelper.ValueExists("Class", $"'{colourName}'", "Classes"))
            {
                isValid = false;
                errorMsg += "A class with that name already exists";
            }
            if (!isValid) MessageBox.Show(errorMsg.Trim(), "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return isValid;
        }

        private void UpdateColour()
        {
            int id = Convert.ToInt32(lstColours.SelectedValue);
            if (!ValidateFields())
            {
                string sql = $"UPDATE Classes WHERE ClassID = {id} SET Class = {colourName}";
                DatabaseHelper.SendData(sql);
            }
        }

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
