using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using PictureBox = System.Windows.Forms.PictureBox;


namespace Pizza
{
    interface State
    {
        void Change(Stock stock, Logger log);
    }

    class StateFull : State
    {
        public void Change(Stock stock, Logger log)
        {
            log.Log("Склад требует пополнения");
            stock.state = new StateNotFull();
        }
    }

    class StateLoad : State
    {
        public void Change(Stock stock, Logger log)
        {
            log.Log("Склад полностью пополнен");
            stock.state = new StateFull();
        }
    }

    class StateNotFull : State
    {
        public void Change(Stock stock, Logger log)
        {
            log.Log("Выгрузка товара на склад");
            stock.state = new StateLoad();
        }
    }

    public class StockItem
    {
        // продукт
        Product m_p;
        // количество
        int m_count;
        // норма
        int m_norma;
        

        public StockItem(Product p, int count, int norma)
        {
            m_p = p;
            m_count = count;
            m_norma = norma;
        }

        public int Count { get => m_count; set => m_count = value; }
        public int Norma { get => m_norma; }
        public Product Product { get => m_p; set => m_p = value; }
    }

    class Stock
    {
        public Logger log;
        public State state { get; set; }

        private static Stock st;

        public static Stock getInstance()//паттерн SingleTo
        {
            if (st == null)
                st = new Stock();
            return st;
        }

        public void Change()
        {
            state.Change(this, log);
        }

        public StockItem[] m_SI = new StockItem[6];

        public Stock()
        {
            st = this;
        }

        public Stock(Logger l)
        {
            state = new StateFull();
            log = l;
            SetStock();
            st = this;
        }
        // заполнение склада

        public void SetStock()
        {
            Product p1 = new Product("cheese");
            m_SI[0]= new StockItem(p1, 5, 5);
            Product p2 = new Product("tomato");
            m_SI[1] = new StockItem(p2, 5, 5);
            Product p3 = new Product("cucumber");
            m_SI[2] = new StockItem(p3, 5, 5);
            Product p4 = new Product("chicken");
            m_SI[3] = new StockItem(p4, 5, 5);
            Product p5 = new Product("pineapple");
            m_SI[4] = new StockItem(p5, 5, 5);
            Product p6 = new Product("sausage");
            m_SI[5] = new StockItem(p6, 5, 5);
        }

        public void SetStockItem(int i, Product p)
        {
            m_SI[i] = new StockItem(p, 10, 5);
        }

        public void LoadStock()
        {
            for(int i=0; i<=5; i++)
            {
                m_SI[i].Count = 10;
            }           
        }
    }
}
