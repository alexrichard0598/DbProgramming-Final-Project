using DogShowTrackerCL;
using System;
using System.Windows.Forms;

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
            DatabaseHelper.SendData(sql);
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
            if (className == "")
            {
                errorProvider.SetError(txtClass, "Colour Name cannot be blank");
                isValid = false;
            }
            if (DatabaseHelper.ValueExists("Class", $"'{className}'", "Classes"))
            {
                isValid = false;
                MessageBox.Show("A class with that name already exists", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return isValid;
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
