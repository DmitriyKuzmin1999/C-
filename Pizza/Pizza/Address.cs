using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza
{
    class Address
    {
        private string m_address;

        public Address(string address)
        {
            m_address = address;
        }

        public override string ToString()
        {
            return m_address;
        }

        public string address { get => m_address; }
    }
}
