using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Pizza
{
    public partial class FMain : Form
    {
        Controller con;

        
        public FMain()
        {
            InitializeComponent();
            
        }

        private void START_Click(object sender, EventArgs e)
        {
            con = new Controller(panel1, panel2, tb1, tb2, tb3, tb4, tb5, tb6, tp1, tp2, tp3, textBox1);

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            con.Add();
        }

        private void STOP_Click(object sender, EventArgs e)
        {

        }
    }
}
