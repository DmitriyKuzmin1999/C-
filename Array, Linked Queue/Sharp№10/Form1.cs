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
    public partial class Form1 : Form
    {
        public bool IsInt;
        public IQueue<string> Qs = null;
        public IQueue<int> Q = null;

        public Form1()
        {
            InitializeComponent();
            refresh();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public void refresh()
        {
            listBox.Items.Clear();
            
            if (Q != null)
            {
                if (Q.Count != 0) DelTool.Enabled = true;
                textCount.Text = Convert.ToString(Q.Count());//!!!
                foreach (int i in Q)
                {
                    listBox.Items.Add(i);
                }

            }
            else if(Qs != null)
            {
                textCount.Text = Convert.ToString(Qs.Count());//!!!
                if (Qs.Count != 0) DelTool.Enabled = true;
                foreach (string i in Qs)
                {
                    listBox.Items.Add(i);
                }
            }
            else
            {
                textCount.Text = "";
                textInfo.Text = "Очереди не существует!";
            }
            bool IsEnabled = ((Qs != null) && (Qs.Count != 0)) || ((Q != null) && (Q.Count != 0));
            bool IsCreate = (Qs != null) || (Q != null);
            ClearTool.Enabled = IsEnabled;
            DelQueueTool.Enabled = IsCreate;
            ElemTool.Enabled = IsCreate;
            UtilityTool.Enabled = IsEnabled;

        }

        private void создатьToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void AddTool_Click(object sender, EventArgs e)
        {
            FAdd add = new FAdd();
            add.ShowDialog();
            try
            {
                if (!add.isCancel)
                {
                    if (IsInt)
                        Q.Push(int.Parse(add.value));
                    else
                        Qs.Push(add.value);
                }
                refresh();
            }
            catch (QueueException)
            {
                MessageBox.Show("Невозможно добавить!", "Ошибка!");
            }
        }


        private void arrayQueueToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void intToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Qs = null;
            Q = new ArrayQueue<int>();
            IsInt = true;
            textInfo.Text = "Очередь на основе массива";
            refresh();
        }

        private void stringToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Q = null;
            Qs = new ArrayQueue<string>();
            IsInt = false;
            textInfo.Text = "Очередь на основе массива";
            refresh();
        }

        private void intToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Qs = null;
            Q = new LinkedQueue<int>();
            IsInt = true;
            textInfo.Text = "Очередь на основе списка";
            refresh();
        }

        private void stringToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Q = null;
            Qs = new LinkedQueue<string>();
            IsInt = false;
            textInfo.Text = "Очередь на основе списка";
            refresh();
        }

        private void очиститьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (IsInt) Q.Clear();
            else if (Qs != null) Qs.Clear();
            refresh();
        }

        private void DelTool_Click(object sender, EventArgs e)
        {
            try
            {
                if (IsInt) Q.Pop();
                else if (Qs != null) Qs.Pop();
                refresh();
            }
            catch (QueueException)
            {
                MessageBox.Show("Очередь пуста!");
            }
        }

        private void textCount_TextChanged(object sender, EventArgs e)
        {

        }

        private void удалитьОчередьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Q = null;
            Qs = null;
            refresh();
        }



        public bool Check(int value)
        {
            return value % 2 == 0;
        }

        public bool Check(string value)
        {
            return value.Length > 5;
        }

        void showres(IQueue<int> queue)
        {
            FForAll showlist = new FForAll(queue);
            showlist.ShowDialog();
        }

        void showres(IQueue<string> queue)
        {
            FForAll showlist = new FForAll(queue);
            showlist.ShowDialog();
        }

        public int Action(int value)
        {
            return value * 10;
        }

        public string Action(string value)
        {
            return "Задание: " + value;
        }


        private void findAllTool_Click(object sender, EventArgs e)
        {
            if (Q != null)
            {
                IQueue<int> res = QueueUtils.FindAll(Q, Check, QueueUtils.getArrayQueue<int>);
                if (res.Count != 0)
                    showres(res);
                else
                    MessageBox.Show("Нет подходящих элементов!");
                return;
            }
            if (Qs != null)
            {
                IQueue<string> res = QueueUtils.FindAll(Qs, Check, QueueUtils.getArrayQueue<string>);
                if (res.Count != 0)
                    showres(res);
                else
                    MessageBox.Show("Нет подходящих элементов!");
                return;
            }

        }

        private void forEachTool_Click(object sender, EventArgs e)
        {
            if (Q != null)
            {
                QueueUtils.ForEach(Q, Action);
                refresh();
                return;
            }
            if (Qs != null)
            {
                QueueUtils.ForEach(Qs, Action);
                refresh();
                return;
            }

        }

        private void checkForAllTool_Click(object sender, EventArgs e)
        {
            if (Q != null)
            {
                if (QueueUtils.CheckForAll(Q, Check))
                    MessageBox.Show("Очередь содержит только чётные числа!");
                else
                    MessageBox.Show("Очередь содержит НЕ ТОЛЬКО чётные числа!");
                return;
            }
            if (Qs != null)
            {
                if (QueueUtils.CheckForAll(Qs, Check))
                    MessageBox.Show("Очередь НЕ содержит строк длиной <= 5!");
                else
                    MessageBox.Show("Очередь содержит строки длиной <= 5!");
                return;
            }

        }

        private void конвертироватьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Q != null)
            {
                Q = QueueUtils.ConvertAll(Q, QueueUtils.getArrayQueue<int>);
                textInfo.Text = "Очередь на основе массива";
                return;
            }
            if (Qs != null)
            {
                Qs = QueueUtils.ConvertAll(Qs, QueueUtils.getArrayQueue<string>);
                textInfo.Text = "Очередь на основе массива";
                return;
            }
        }

        private void конвертироватьВLinkedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Q != null)
            {
                Q = QueueUtils.ConvertAll(Q, QueueUtils.getLinkedQueue<int>);
                textInfo.Text = "Очередь на основе списка";
                return;
            }
            if (Qs != null)
            {
                Qs = QueueUtils.ConvertAll(Qs, QueueUtils.getLinkedQueue<string>);
                textInfo.Text = "Очередь на основе списка";
                return;
            }

        }
    }
}
