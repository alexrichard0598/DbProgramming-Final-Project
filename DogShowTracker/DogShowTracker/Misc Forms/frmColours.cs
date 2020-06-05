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

        public override void Reload()
        {
            UIMethods.FillListControl(lstColours, "Colour", "ColourID", LoadFormData.ColourNames());
        }

        private void GetColourInfo()
        {
            int id = Convert.ToInt32(lstColours.SelectedValue);
            string sql = $"Select Colour FROM Colours WHERE ColourID = {id}";
            txtColourName.Text = DatabaseHelper.ExecuteScaler(sql).ToString();
        }

        private void DeleteColour()
        {
            int id = Convert.ToInt32(lstColours.SelectedValue);

            if (DatabaseHelper.ValueExists("ColourID", id.ToString(), "Breeds"))
            {
                MessageBox.Show("Cannot delete colour that is referenced by a breed", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string sql = $"DELETE Colours WHERE ColourID = {id}";

            string sqlColourName = $"SELECT [Colour] FROM Colours WHERE ColourID = {id}";
            string colourName = DatabaseHelper.ExecuteScaler(sqlColourName).ToString();

            if (UIMethods.ConfirmationPrompt($"Are you sure you want to delete {colourName} breed?"))
            {
                DatabaseHelper.SendData(sql);
            }

        }

        private void frmColours_Load(object sender, EventArgs e)
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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                DeleteColour();
            }
            catch (Exception ex)
            {
                UIMethods.ErrorHandler(ex);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //TODO: Impliment Update Colour
        }
    }
}
