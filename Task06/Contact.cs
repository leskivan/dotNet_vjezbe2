using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task06
{
    public class Contact
    {
        private const string CNT_FORMAT = "{0} {1}, phone: {2}, cellular: {3}";

        public string Name { get; set; }
        public string Surname { get; set; }
        public string Phone { get; set; }
        public string Cellular { get; set; }

        public override string ToString() {
            return string.Format(CNT_FORMAT, Name, Surname, Phone, Cellular);
        }
    }
}
