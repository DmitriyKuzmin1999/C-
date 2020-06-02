using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza
{
    abstract class Cooker
    {
        // фабричный метод
        abstract public APizza Create();
    }

    class CheeseCooker : Cooker
    {
        public CheeseCooker() : base()
        { }

        public override APizza Create()
        {
            return new CheesePizza();
        }
    }

    class ChickenCooker : Cooker
    {
        public ChickenCooker() : base()
        { }

        public override APizza Create()
        {
            return new ChickenPizza();
        }
    }

    class SausageCooker : Cooker
    {
        public SausageCooker() : base()
        { }

        public override APizza Create()
        {
            return new SausagePizza();
        }
    }

    class Pizza
    {
        public int Count { get; set; }

        public Recipe recipe { get; set; }

        public Logger log { get; set; }

        public Stock stock { get; set; }

        public Pizza(int c, Recipe r)
        {
            recipe = r;
            Count = c;
        }
    }

    abstract class APizza
    {

    }

    class CheesePizza : APizza
    {
        public CheesePizza()
        {
            Stock s = Stock.getInstance();
            s.m_SI[0].Count--;
            s.m_SI[1].Count--;
            s.m_SI[2].Count--;
        }
    }

    class ChickenPizza : APizza
    {
        public ChickenPizza()
        {
            Stock s = Stock.getInstance();
            s.m_SI[1].Count--;
            s.m_SI[3].Count--;
            s.m_SI[4].Count--;
        }
    }

    class SausagePizza : APizza
    {
        public SausagePizza()
        {
            Stock s = Stock.getInstance();
            s.m_SI[2].Count--;
            s.m_SI[4].Count--;
            s.m_SI[5].Count--;
        }
    }
}
