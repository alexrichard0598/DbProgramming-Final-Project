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
