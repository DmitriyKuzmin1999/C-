using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using PictureBox = System.Windows.Forms.PictureBox;
using Panel = System.Windows.Forms.Panel;

namespace Pizza
{
    class StockCar
    {
        // грузовик
        public PictureBox picture { get; set; }

        public Point destination { get; set; }

        public State state { get; set; }

        public StockCar(PictureBox pic, Point dest)
        {
            picture = pic;
            destination = dest;
        }

        public void Change()
        {
            
        }
    }


}
