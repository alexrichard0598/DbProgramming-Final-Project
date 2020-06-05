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

        public override void Reload()
        {
            UIMethods.FillListControl(lstClasses, "Class", "ClassID", LoadFormData.ClassNames());
        }

        private void GetClassInfo()
        {
            int id = Convert.ToInt32(lstClasses.SelectedValue);
            string sql = $"SELECT Class FROM Classes WHERE ClassID = {id}";
            txtClassName.Text = DatabaseHelper.ExecuteScaler(sql).ToString();
        }

        private void DeleteClass()
        {
            int id = Convert.ToInt32(lstClasses.SelectedValue);
            string sqlCheckForReferences = $"SELECT COUNT(*) FROM Breeds WHERE ClassID = {id};";

            if(Convert.ToInt32(DatabaseHelper.ExecuteScaler(sqlCheckForReferences)) == 0)
            {
                MessageBox.Show("Cannot delete class that is referenced by a breed", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string sql = $"DELETE Classes WHERE ClassID = {id}";

            string sqlClassName = $"SELECT [Class] FROM Classes WHERE ClassID = {id}";
            string className = DatabaseHelper.ExecuteScaler(sqlClassName).ToString();

            if (UIMethods.ConfirmationPrompt($"Are you sure you want to delete {className} breed?"))
            {
                DatabaseHelper.SendData(sql);
            }
               
        }

        private void frmClasses_Load(object sender, EventArgs e)
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

        private void lstClasses_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                GetClassInfo();
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
                DeleteClass();
            }
            catch (Exception ex)
            {
                UIMethods.ErrorHandler(ex);
            }
        }
    }
}
