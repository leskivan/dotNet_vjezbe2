using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vjezbe2
{
    public partial class ChildForm : Form {
        public ChildForm() {
            InitializeComponent();
        }

        private int btnCount = 1;
        private const string BTN_NAME = "btnNr{0}";
        private const string BTN_TEXT = "butongz {0}";

        public void AddButton() {
            Button b = new Button();

            b.Name = string.Format(BTN_NAME, btnCount);
            b.Text = string.Format(BTN_TEXT, btnCount++);

            flpContainer.Controls.Add(b);
        }
    }
}
