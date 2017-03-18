using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Utilities;

namespace Vjezbe2
{
    public partial class Task03 : Form
    {
        public Task03() {
            InitializeComponent();
            this.TopMost = true;
        }

        private ChildForm cf;

        private void btnChangeColor_Click(object sender, EventArgs e) {
            cf.BackColor = Util.GetRandomColor();
        }

        private void btnChangeState_Click(object sender, EventArgs e) {
            cf.WindowState = Util.GetRandomState(cf.WindowState);
        }

        private void btnAddButton_Click(object sender, EventArgs e) {
            cf.AddButton();
        }

        private void Task03_Load(object sender, EventArgs e) {
            cf = new ChildForm();
            cf.Show();
            cf.Location = new Point(this.Location.X + this.Width + 10, this.Location.Y);
        }
    }
}
