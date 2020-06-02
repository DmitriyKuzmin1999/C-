using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using PictureBox = System.Windows.Forms.PictureBox;

namespace Pizza
{
    class CurierCar
    {
        public PictureBox picture { get; set; }

        public Point destination { get; set; }

        public CurierCar(PictureBox pic, Point des)
        {
            picture = pic;
            destination = des;
        }
    }
}
