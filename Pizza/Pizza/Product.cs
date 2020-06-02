using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza
{
    public class Product
    {
        // название продукта
        string m_name;

        public string Name { get => m_name; set => m_name = value; }

        public Product()
        {

        }

        public Product(string name)
        {
            m_name = name;
        }

        public override string ToString()
        {
            return "\"" + m_name + "\"";
        }
    }
}
