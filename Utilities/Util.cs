using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Utilities
{
    
    public static class Util
    {
        private static Random rnd = new Random();
        public static Color GetRandomColor() {
            return Color.FromArgb(rnd.Next(255), rnd.Next(255), rnd.Next(255));
        }

        public static FormWindowState GetRandomState(FormWindowState current) {
            int state;
            do {
                state = rnd.Next(3);
            } while (state == (int)current);

            return (FormWindowState)state;
        }

    }
}
