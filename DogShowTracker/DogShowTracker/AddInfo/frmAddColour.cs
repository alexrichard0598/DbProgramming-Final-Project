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
    public partial class frmAddColour : Form
    {
        public frmAddColour()
        {
            InitializeComponent();
        }

        private bool colourAdded = false;

        private void InsertNewColour()
        {
            string colourName = txtColour.Text;
            string sql = $@"
                        INSERT INTO Colours
                            (Colour)
                            VALUES
                            ('{colourName}');";
            DatabaseHelper.SendData(sql);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                errorProvider.Clear();

                if (txtColour.Text == "")
                {
                    errorProvider.SetError(txtColour, "Colour Name cannot be blank");
                }
                else
                {
                    InsertNewColour();
                    colourAdded = true;
                    Close();
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

        private void frmAddColour_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (colourAdded) MessageBox.Show("Colour Added");
        }
    }
}
