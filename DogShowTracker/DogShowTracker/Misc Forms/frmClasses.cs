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
    public partial class frmClasses : DogShowForm
    {
        public frmClasses()
        {
            InitializeComponent();
        }

        private void LoadClasses()
        {
            UIMethods.FillListControl(lstClasses, "Class", "ClassID", LoadFormData.ClassNames());
        }

        private void frmClasses_Load(object sender, EventArgs e)
        {
            try
            {
                LoadClasses();
            }
            catch (Exception ex)
            {
                UIMethods.ErrorHandler(ex);
            }
        }
    }
}
