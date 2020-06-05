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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            Text = Application.ProductName + " - Login";
            txtUsr.Text = Environment.UserName;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                string user = txtUsr.Text;
                string pass = txtPass.Text;
                if(pass == DatabaseHelper.ExecuteScaler($"SELECT Pass FROM UserLogin WHERE Username = '{user}'").ToString())
                {
                    DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("Login Failed");
                }
            }
            catch (Exception ex)
            {
                UIMethods.ErrorHandler(ex);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {
                UIMethods.ErrorHandler(ex);
            }
        }
    }
}
