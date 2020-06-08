using System;
using System.Data;
using System.Windows.Forms;

/*
    Alex Richard
    Dog Show Tracker
    2020-06-05
*/

namespace DogShowTrackerCL
{
    public static class UIMethods
    {
        /// <summary>
        /// Display a messagebox that shows the details of the error provided
        /// </summary>
        /// <param name="ex">The error to display details of</param>
        public static void ErrorHandler(Exception ex)
        {
            MessageBox.Show(ex.Message, ex.GetType().ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        /// <summary>
        /// Opens a form in the MDIparent provided or
        /// if a form of that type is already open brin it to the front
        /// </summary>
        /// <param name="mdiParent">The MDIparent to bind the form to</param>
        /// <param name="newForm">The new form to create</param>
        public static Form OpenForm(Form mdiParent, Form newForm)
        {
            foreach (Form siblingForm in mdiParent.MdiChildren)
            {
                if (siblingForm.GetType() == newForm.GetType())
                {
                    siblingForm.Activate();
                    return siblingForm;
                }
            }

            newForm.MdiParent = mdiParent;
            newForm.Show();
            return newForm;
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

        /// <summary>
        /// Tries to set the value of a DateTimePicker to the value of the object passed through.
        /// If it can't, it instead sets the DateTimePicker to display empty
        /// </summary>
        /// <param name="dateTimePicker">The DateTimePicker to set</param>
        /// <param name="dateObject">The object to set the DateTimePicker to</param>
        public static void PickDateTimePicker(DateTimePicker dateTimePicker, object dateObject, bool nullIsBlank = true)
        {


            if (DateTime.TryParse(dateObject.ToString(), out DateTime date))
            {
                dateTimePicker.Value = date;
                dateTimePicker.Format = DateTimePickerFormat.Long;
            }
            else if (nullIsBlank)
            {
                dateTimePicker.Value = DateTime.Now;
                dateTimePicker.CustomFormat = " ";
                dateTimePicker.Format = DateTimePickerFormat.Custom;
            }
        }

        /// <summary>
        /// Prompts the user to confirm their choice
        /// </summary>
        /// <param name="msg"></param>
        /// <returns></returns>
        public static bool ConfirmationPrompt(string msg)
        {
            return DialogResult.Yes == MessageBox.Show(msg, "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }

        /// <summary>
        /// Display the status message in the toolstripstatuslabels provided
        /// </summary>
        /// <param name="label"></param>
        /// <param name="msg"></param>
        public static void DisplayStatusMessage(ToolStripStatusLabel label, string msg)
        {
            label.Text = msg;
        }

        /// <summary>
        /// Clear all of the controls in a ControlCollection
        /// </summary>
        /// <param name="controls"></param>
        public static void ClearControls(Control.ControlCollection controls)
        {
            foreach (Control ctrl in controls)
            {
                if (ctrl is GroupBox)
                {
                    ClearControls(ctrl.Controls);
                }
                else if (ctrl is TextBox)
                {
                    ((TextBox)ctrl).Clear();
                }
                else if (ctrl is CheckBox)
                {
                    ((CheckBox)ctrl).Checked = false;
                }
                else if (ctrl is DateTimePicker)
                {
                    ((DateTimePicker)ctrl).Value = DateTime.Now;
                }
                else if (ctrl is NumericUpDown)
                {
                    ((NumericUpDown)ctrl).Value = 0;
                }
                if (ctrl is ComboBox)
                {
                    ((ComboBox)ctrl).SelectedIndex = 0;
                }
            }
        }
    }
}
