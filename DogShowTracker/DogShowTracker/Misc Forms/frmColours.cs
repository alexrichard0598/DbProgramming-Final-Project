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

namespace DogShowTracker
{
    public partial class frmColours : DogShowForm
    {
        public frmColours()
        {
            InitializeComponent();
        }

        private void LoadColours()
        {
            UIMethods.FillListControl(lstColours, "Colour", "ColourID", LoadFormData.ColourNames());
        }

        private void frmColours_Load(object sender, EventArgs e)
        {
            try
            {
                LoadColours();
            }
            catch (Exception ex)
            {
                UIMethods.ErrorHandler(ex);
            }
        }
    }
}
