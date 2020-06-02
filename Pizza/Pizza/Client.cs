using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using PictureBox = System.Windows.Forms.PictureBox;

namespace Pizza
{
    class Client
    {
        Address m_address;
        Recipe m_pizza;
        public PictureBox picture { get; set; }

        
        public Client(Address address, PictureBox image)
        {
            m_address = address;
            picture = image;
        }

        public void GetPizza(Recipe pizza)
        {
            m_pizza = pizza;
        }

        public override string ToString()
        {
            return "\nАдрес: " + m_address.ToString();
        }
    }
}
