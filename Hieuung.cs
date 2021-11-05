using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Đồ_án
{
    class Hieuung
    {
        public void doimaubutton(int a, int b, int c,Button but)
        {
            but.BackColor = System.Drawing.Color.FromArgb(a, b, c);           
        }
    }
}
