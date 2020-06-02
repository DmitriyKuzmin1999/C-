using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sharp_10
{
    public partial class FForAll : Form
    {
        public FForAll(IQueue<int> queue)
        {
            InitializeComponent();
            foreach (int i in queue)
            {
                listBox.Items.Add(i);
            }
        }

        public FForAll(IQueue<string> queue)
        {
            InitializeComponent();
            foreach (string i in queue)
            {
                listBox.Items.Add(i);
            }
        }

        private void FForAll_Load(object sender, EventArgs e)
        {

        }

        private void bOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
