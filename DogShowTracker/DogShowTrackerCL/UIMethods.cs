using System;
using System.Data;
using System.Windows.Forms;

namespace DogShowTrackerCL
{
    public static class UIMethods
    {
        public static void ErrorHandler(Exception ex)
        {
            MessageBox.Show(ex.Message, ex.GetType().ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void OpenForm(Form mdiParent, Form newForm)
        {
            foreach (Form siblingForm in mdiParent.MdiChildren)
            {
                if (siblingForm.GetType() == newForm.GetType())
                {
                    siblingForm.Activate();
                    return;
                }
            }

            newForm.MdiParent = mdiParent;
            newForm.Show();
        }

        /// <summary>
        /// Binds a list control to a data table
        /// </summary>
        /// <param name="ctrl">The list control to fill</param>
        /// <param name="displayMember">The display member of the list control</param>
        /// <param name="valueMember">The value member of the list control</param>
        /// <param name="dt">The data table to bind</param>
        /// <param name="insertBlank">Whether the first row should be a blank item default false</param>
        /// <param name="defaultText">The value of the blank row default blank string</param>
        public static void FillListControl(ListControl ctrl, string displayMember, string valueMember,
            DataTable dt, bool insertBlank = false, string defaultText = "")
        {
            if (insertBlank)
            {
                DataRow row = dt.NewRow();
                row[valueMember] = DBNull.Value;
                row[displayMember] = defaultText;
                dt.Rows.InsertAt(row, 0);
            }
            ctrl.DisplayMember = displayMember;
            ctrl.ValueMember = valueMember;
            ctrl.DataSource = dt;
        }
    }
}
