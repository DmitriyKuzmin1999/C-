using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza
{
    // рецепт
    class Recipe
    {
        // ингридиенты
        public Product[] m_Ing = new Product[3];

        // добавление ингридиентов
        public Recipe(Product p1, Product p2, Product p3)
        {
            m_Ing[0] = p1;
            m_Ing[1] = p2;
            m_Ing[2] = p3;
        }

        public Product[] Recipe_Items { get => m_Ing; }
    }
}
