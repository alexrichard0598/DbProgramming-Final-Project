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
    public partial class frmAddClass : Form
    {
        public frmAddClass()
        {
            InitializeComponent();
        }

        private bool classAdded = false;

        private void InsertNewColour()
        {
            string className = txtClass.Text;
            string sql = $@"
                        INSERT INTO Class
                            (Class)
                            VALUES
                            ('{className}');";
            DatabaseHelper.SendData(sql);
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
                errorProvider.Clear();

                if (txtClass.Text == "")
                {
                    errorProvider.SetError(txtClass, "Colour Name cannot be blank");
                }
                else
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

        private void frmAddColour_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (classAdded) MessageBox.Show("Class Added");
        }
    }
}
