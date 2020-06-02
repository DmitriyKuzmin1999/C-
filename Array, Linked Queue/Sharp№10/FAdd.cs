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
    public partial class FAdd : Form
    {
        public bool isCancel = true;
        public string value = "";


        public FAdd()
        {
            InitializeComponent();
        }


        private void bOK_Click(object sender, EventArgs e)
        {
            if (textAdd.Text != "")
            {
                isCancel = false;
                this.value = textAdd.Text;
                this.Close();
            }

        }

        private void bCancel_Click(object sender, EventArgs e)
        {
            isCancel = true;
            this.Close();
        }
    }
}
