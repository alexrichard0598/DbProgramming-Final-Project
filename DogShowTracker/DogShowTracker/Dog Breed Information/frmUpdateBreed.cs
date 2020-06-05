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
    public partial class frmUpdateBreed : DogShowForm
    {
        public frmUpdateBreed()
        {
            InitializeComponent();
        }

        private void UpdateBreed()
        {
            //TODO: Impliment UpdateBreed Method
        }

        public override void Reload()
        {
            //TODO: Impliment Reload Method
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                UpdateBreed();
            }
            catch (Exception ex)
            {
                UIMethods.ErrorHandler(ex);
            }
        }

        private void frmUpdateBreed_Load(object sender, EventArgs e)
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
    }
}
