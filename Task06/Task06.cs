using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task06
{
    public partial class Task06 : Form
    {
        private const string DELETE_MESSAGE = "Really?";
        private const string DELETE_TITLE = "Delete all contacts";

        public Task06() {
            InitializeComponent();
        }

        private void btnClear_Click(object sender, EventArgs e) {
            if (MessageBox.Show(DELETE_MESSAGE, DELETE_TITLE, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) {
                tbContainer.Clear();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e) {
            ContactForm cf = new ContactForm();
            if (cf.ShowDialog() == DialogResult.OK) {
                Contact c = cf.GetCreatedContact();
                tbContainer.AppendText(c.ToString());
                tbContainer.AppendText(Environment.NewLine);
            }
        }
    }
}
