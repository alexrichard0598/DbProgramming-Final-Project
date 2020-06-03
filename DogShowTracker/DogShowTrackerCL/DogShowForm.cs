using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DogShowTrackerCL
{
    public partial class DogShowForm : Form
    {
        public DogShowForm()
        {
            InitializeComponent();
        }

        public virtual void Reload() { }
    }
}
