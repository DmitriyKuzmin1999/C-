using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

using PictureBox = System.Windows.Forms.PictureBox;
using Panel = System.Windows.Forms.Panel;
using ListBox = System.Windows.Forms.ListBox;
using System.Threading;

namespace Pizza
{

    //сделать отдельный метод для поворота грузовика
    //заменить все ProgressBar на TextBox
    //добавить TextBox для пиццы

    class Controller
    {
        private Panel panel; //Панель модели
        private Panel panelclient; //Панель модели
        TextBox tb1;
        TextBox tb2;
        TextBox tb3;
        TextBox tb4;
        TextBox tb5;
        TextBox tb6;
        TextBox tp1;
        TextBox tp2;
        TextBox tp3;

        Logger logger;
        //склад
        public Stock stock;
        //складская машина
        public StockCar sCar;
        //продукты
        Product p1;
        Product p2;
        Product p3;
        Product p4;
        Product p5;
        Product p6;
        //рецепты
        public Recipe CheesePizza;
        public Recipe ChickenPizza;
        public Recipe SausagePizza;
        //пиццы
        public Pizza Cheese;
        public Pizza Chicken;
        public Pizza Sausage;
        CheeseCooker cheescook = new CheeseCooker();
        ChickenCooker chikcook = new ChickenCooker();
        SausageCooker sauscook = new SausageCooker();

        public Thread threadStockCar;
        public Thread threadClient;
        public Thread threadUpdate;

        private List<Thread> threads;
        private ManualResetEvent mre;

        //PictureBox boxClient;
        //PictureBox boxCurier;

        Bitmap image1 = new Bitmap("C://Users/Кузя/source/repos/Pizza/Pizza/Resources/грузовик2.png");
        Bitmap image2 = new Bitmap("C://Users/Кузя/source/repos/Pizza/Pizza/Resources/client.png");
        Bitmap image3 = new Bitmap("C://Users/Кузя/source/repos/Pizza/Pizza/Resources/curier.png");


        public Controller(Panel _panel, Panel _panelclient, TextBox tb1, TextBox tb2, TextBox tb3, TextBox tb4, TextBox tb5, TextBox tb6, TextBox tp1, TextBox tp2, TextBox tp3, TextBox textBox1)
        {
            logger = new Logger(textBox1);
            panel = _panel;
            panelclient = _panelclient;
            this.tb1 = tb1;
            this.tb2 = tb2;
            this.tb3 = tb3;
            this.tb4 = tb4;
            this.tb5 = tb5;
            this.tb6 = tb6;
            this.tp1 = tp1;
            this.tp2 = tp2;
            this.tp3 = tp3;

            stock = new Stock(logger);
            threads = new List<Thread>();
            p1 = new Product("cheese");
            p2 = new Product("tomato");
            p3 = new Product("cucumber");
            p4 = new Product("chicken");
            p5 = new Product("pineapple");
            p6 = new Product("sausage");
            CheesePizza = new Recipe(p1, p2, p3);
            ChickenPizza = new Recipe(p2, p4, p5);
            SausagePizza = new Recipe(p3, p5, p6);
            Cheese = new Pizza(1, CheesePizza);
            Chicken = new Pizza(1, ChickenPizza);
            Sausage = new Pizza(1, SausagePizza);
            //создание грузовика
            PictureBox box = new PictureBox
            {
                Size = new Size(120, 80),
                Visible = true,
                Image = image1,
                Location = new Point(80, 45),
                SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
            };
            panel.Controls.Add(box);
            sCar = new StockCar(box, new Point(0, 45));

            tp1.BeginInvoke((Action)(() => tp1.Text = Convert.ToString(Cheese.Count)));
            tp2.BeginInvoke((Action)(() => tp2.Text = Convert.ToString(Chicken.Count)));
            tp3.BeginInvoke((Action)(() => tp3.Text = Convert.ToString(Sausage.Count)));

            UpdateStock();
            //создание потоков
            mre = new ManualResetEvent(false);
            threadStockCar = new Thread(GoStockCar);
            threadClient = new Thread(Clients);
            threadStockCar.Start();
            threadClient.Start();
            mre.Set();
        }

        public void GoStockCar()
        {
            while (true)
            {
                int OK = 0;
                for (int i = 0; i <= 5; i++)
                {
                    if (stock.m_SI[i].Count >= 5)
                    {
                        OK++;
                    }
                }
                if (OK < 6)
                {
                    stock.Change();
                    Move(sCar.picture, sCar.destination.X, sCar.destination.Y, 60);
                    sCar.picture.Image.RotateFlip(RotateFlipType.Rotate180FlipY);
                    sCar.picture.Invoke((Action)(() => sCar.picture.Refresh()));
                    stock.Change();
                    Thread.Sleep(3000);
                    stock.LoadStock();
                    UpdateStock();
                    stock.Change();
                    logger.Log("---------");
                    Move(sCar.picture, 80, 45, 60);
                    sCar.picture.Image.RotateFlip(RotateFlipType.Rotate180FlipY);
                    sCar.picture.Invoke((Action)(() => sCar.picture.Refresh()));
                }
            }
        }

        public void GoCurier()
        {
                //Thread.Sleep(1000);
                Address address;
                Client c;
                CurierCar curier;
                //создание картинки клиента
                PictureBox boxClient = new PictureBox
                {
                    Size = new Size(80, 80),
                    Visible = true,
                    Image = image2,
                    Location = new Point(0, 0),
                    SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
                };
                //создание картинки доставщика
                PictureBox boxCurier = new PictureBox
                {
                    Size = new Size(80, 80),
                    Visible = true,
                    Image = image3,
                    Location = new Point(0, 0),
                    SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
                };
                panelclient.Invoke((Action)(() => panelclient.Controls.Add(boxClient)));
                panelclient.Invoke((Action)(() => panelclient.Controls.Add(boxCurier)));
                Random rnd = new Random();
                int value = rnd.Next(0, 6);
                switch (value)
                {
                    case 0:
                        address = new Address("Левобережный");
                        c = new Client(address, boxClient);
                        MoveC(c.picture, 0, 0, 0);
                        c.picture.Invoke((Action)(() => c.picture.Visible = true));
                        break;
                case 1:
                    address = new Address("Левобережный");
                    c = new Client(address, boxClient);
                    MoveC(c.picture, 80, 0, 0);
                    c.picture.Invoke((Action)(() => c.picture.Visible = true));
                    break;
                case 2:
                        address = new Address("Центральный");
                        c = new Client(address, boxClient);
                        MoveC(c.picture, 0, 250, 0);
                        c.picture.Invoke((Action)(() => c.picture.Visible = true));
                        break;
                case 3:
                    address = new Address("Центральный");
                    c = new Client(address, boxClient);
                    MoveC(c.picture, 100, 250, 0);
                    c.picture.Invoke((Action)(() => c.picture.Visible = true));
                    break;
                case 4:
                        address = new Address("Правобережный");
                        c = new Client(address, boxClient);
                        MoveC(c.picture, 0, 580, 0);
                        c.picture.Invoke((Action)(() => c.picture.Visible = true));
                        break;
                case 5:
                    address = new Address("Правобережный");
                    c = new Client(address, boxClient);
                    MoveC(c.picture, 100, 580, 0);
                    c.picture.Invoke((Action)(() => c.picture.Visible = true));
                    break;
                default:
                        address = new Address("NONE");
                        c = new Client(address, boxClient);
                        MoveC(c.picture, 300, 250, 0);
                        c.picture.Invoke((Action)(() => c.picture.Visible = true));
                        break;
                }
                logger.Log("Район: "+ address);
                //хотение пиццы и вычитание ресурсов для пиццы
                value = rnd.Next(0, 3);
                switch (value)
                {
                    case 0:
                    logger.Log("Заказ: Сырная пицца");
                    if (Cheese.Count > 0)
                        {
                        logger.Log("Доставляем: Сырная пицца");
                            Cheese.Count--;
                            tp1.BeginInvoke((Action)(() => tp1.Text = Convert.ToString(Cheese.Count)));
                        
                        }
                        else
                        {
                        logger.Log("Готовим Сырную пиццу из:");
                        logger.Log("| сыр, помидор, огурец |");
                        logger.Log("Доставляем: Сырная пицца");
                            cheescook.Create();
                        }
                        break;
                    case 1:
                    logger.Log("Заказ: Куриная пицца");
                    if (Chicken.Count > 0)
                        {
                        logger.Log("Доставляем: Куриная пицца");
                            Chicken.Count--;
                            tp2.BeginInvoke((Action)(() => tp2.Text = Convert.ToString(Chicken.Count)));
                        
                        }
                        else
                        {
                        logger.Log("Готовим Куриную пиццу из:");
                        logger.Log("| помидор, курица, ананас |");
                        logger.Log("Доставляем: Куриная пицца");
                        chikcook.Create();
                        }
                        break;
                    case 2:
                    logger.Log("Заказ: Мясная пицца");
                    if (Sausage.Count > 0)
                        {
                        logger.Log("Доставляем: Мясная пицца");
                            Sausage.Count--;
                            tp3.BeginInvoke((Action)(() => tp3.Text = Convert.ToString(Sausage.Count)));
                    }
                    else
                    {
                        logger.Log("Готовим Мясную пиццу из:");
                        logger.Log("| огурец, ананас, колбаса |");
                        logger.Log("Доставляем: Мясная пицца");
                        sauscook.Create();
                    }
                        break;
                    default:

                        break;
                }
            logger.Log("---------");
                UpdateStock();
                curier = new CurierCar(boxCurier, new Point(c.picture.Location.X, c.picture.Location.Y));
                MoveC(curier.picture, 558, 350, 0);
                curier.picture.Invoke((Action)(() => curier.picture.Visible = true));
                MoveC(curier.picture, c.picture.Location.X+80, c.picture.Location.Y, 100);
                curier.picture.Invoke((Action)(() => curier.picture.Dispose()));
                c.picture.Invoke((Action)(() => c.picture.Dispose()));
                


        }

        public void MoveC(PictureBox picture, int dx, int dy, int Delay)
        {
            int x = picture.Location.X, y = picture.Location.Y;
            while (x != dx || y != dy)
            {
                if (Delay != 0)
                {
                    if (y != dy)
                    {
                        if (y < dy)
                            y += 2;
                        if (y > dy)
                            y -= 2;
                    }
                    else
                    {

                        if (x < dx)
                            x += 2;
                        if (x > dx)
                            x -= 2;
                    }
                    try
                    {
                    picture.BeginInvoke((Action)(() => picture.Location = new Point(x, y)));
                    }
                    catch (Exception) { }
                    Thread.Sleep(Delay);
                }
                else
                {
                    x = dx;
                    y = dy;
                    picture.BeginInvoke((Action)(() => picture.Location = new Point(dx, dy)));
                }
            }
        }

        public void Move(PictureBox picture, int dx, int dy, int Delay)
        {
            int x = picture.Location.X, y = picture.Location.Y;
            while (x != dx || y != dy)
            {
               // mre.WaitOne();
                if (x < dx)
                    x+=2;
                if (x > dx)
                    x-=2;
                if (y < dy)
                    y+=2;
                if (y > dy)
                    y-=2;
                try
                {
                    picture.BeginInvoke((Action)(() => picture.Location = new Point(x, y)));
                    if (Delay != 0)
                    {
                        picture.Invoke((Action)(() => picture.Refresh()));
                        Thread.Sleep(Delay);
                    }
                }
                catch (Exception) { }
            }
        }

        

        public void UpdateStock()
        {
            try
            {
                tb1.BeginInvoke((Action)(() => tb1.Text = Convert.ToString(stock.m_SI[0].Count)));
                tb2.BeginInvoke((Action)(() => tb2.Text = Convert.ToString(stock.m_SI[1].Count)));
                tb3.BeginInvoke((Action)(() => tb3.Text = Convert.ToString(stock.m_SI[2].Count)));
                tb4.BeginInvoke((Action)(() => tb4.Text = Convert.ToString(stock.m_SI[3].Count)));
                tb5.BeginInvoke((Action)(() => tb5.Text = Convert.ToString(stock.m_SI[4].Count)));
                tb6.BeginInvoke((Action)(() => tb6.Text = Convert.ToString(stock.m_SI[5].Count)));
            }
            catch (Exception) { }

        }

        public void Add()
        {
            Thread thread = new Thread(GoCurier);
            threads.Add(thread);
            thread.Start();
        }

        public void Clients()
        {
            for(int i = 1; i<10; i++)
            {
                
                Add();
                Thread.Sleep(10000);
            }
        }

        public void Start()
        {
            mre.Set();
        }

        public void Stop()
        {
            mre.Reset();
        }
    }


}
