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
    public partial class ContactForm : Form
    {
        public ContactForm() {
            InitializeComponent();
        }

       public Contact GetCreatedContact() {
            return new Contact() {
                Name = tbName.Text,
                Surname = tbSurname.Text,
                Phone = tbPhone.Text,
                Cellular = tbCellular.Text
            };
        }
    }
}
