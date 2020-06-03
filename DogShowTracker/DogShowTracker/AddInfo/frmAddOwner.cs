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
    public partial class frmAddOwner : Form
    {
        public frmAddOwner()
        {
            InitializeComponent();
        }

        private void btnAddOwner_Click(object sender, EventArgs e)
        {
            try
            {

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
                Close()
            }
            catch (Exception ex)
            {
                UIMethods.ErrorHandler(ex);
            }
        }
    }
}
