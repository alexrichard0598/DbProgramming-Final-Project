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

        private void GetColourInfo()
        {
            int id = Convert.ToInt32(lstColours.SelectedValue);
            string sql = $"Select Colour FROM Colours WHERE ColourID = {id}";
            txtColourName.Text = DatabaseHelper.ExecuteScaler(sql).ToString();
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

        private void lstColours_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                GetColourInfo();
            }
            catch (Exception ex)
            {
                UIMethods.ErrorHandler(ex);
            }
        }
    }
}
