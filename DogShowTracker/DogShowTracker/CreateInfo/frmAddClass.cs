using DogShowTrackerCL;
using System;
using System.Windows.Forms;

/*
    Alex Richard
    Dog Show Tracker
    2020-06-04
*/

namespace DogShowTracker
{
    public partial class frmAddClass : DogShowForm
    {
        public frmAddClass()
        {
            InitializeComponent();
        }

        private bool classAdded = false;

        /// <summary>
        /// Insert the colour into the database
        /// </summary>
        private void InsertNewColour()
        {
            string className = txtClass.Text;
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
            if (txtClass.Text == "")
            {
                errorProvider.SetError(txtClass, "Colour Name cannot be blank");
                isValid = false;
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
                if(ValidateFields())
                {
                    InsertNewColour();
                    classAdded = true;
                    Close();
                }
            }
            catch (Exception ex)
            {
                UIMethods.ErrorHandler(ex);
            }
        }

        private void frmAddClass_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (classAdded) MessageBox.Show("Class Added");
        }
    }
}
