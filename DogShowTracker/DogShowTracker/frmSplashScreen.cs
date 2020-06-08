using DogShowTrackerCL;
using System;
using System.Windows.Forms;

namespace DogShowTracker
{
    public partial class frmSplashScreen : Form
    {
        public frmSplashScreen()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Load program data on from load
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmSplashScreen_Load(object sender, EventArgs e)
        {
            try
            {
                lblName.Text = Application.ProductName;
                lblCompany.Text = Application.CompanyName;
                lblVersion.Text = Application.ProductVersion;
            }
            catch (Exception ex)
            {
                UIMethods.ErrorHandler(ex);
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
