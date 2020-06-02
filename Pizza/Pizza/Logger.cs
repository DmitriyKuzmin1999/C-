using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pizza
{
    // логгер
    class Logger
    {
        public Logger(TextBox t)
        {
            tb = t;
        }
        public TextBox tb;

        public void Log(string s)
        {
            tb.Invoke((Action)(() => tb.AppendText(s + "\r\n")));
        }
    }
}
