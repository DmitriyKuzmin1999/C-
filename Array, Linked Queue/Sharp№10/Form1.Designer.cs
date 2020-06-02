namespace Sharp_10
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.очередьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.создатьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.arrayQueueToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.intToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stringToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.linkedQueueToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.intToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.stringToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ClearTool = new System.Windows.Forms.ToolStripMenuItem();
            this.DelQueueTool = new System.Windows.Forms.ToolStripMenuItem();
            this.ElemTool = new System.Windows.Forms.ToolStripMenuItem();
            this.AddTool = new System.Windows.Forms.ToolStripMenuItem();
            this.DelTool = new System.Windows.Forms.ToolStripMenuItem();
            this.UtilityTool = new System.Windows.Forms.ToolStripMenuItem();
            this.findAllTool = new System.Windows.Forms.ToolStripMenuItem();
            this.forEachTool = new System.Windows.Forms.ToolStripMenuItem();
            this.checkForAllTool = new System.Windows.Forms.ToolStripMenuItem();
            this.listBox = new System.Windows.Forms.ListBox();
            this.textCount = new System.Windows.Forms.TextBox();
            this.labelCount = new System.Windows.Forms.Label();
            this.labelInfo = new System.Windows.Forms.Label();
            this.textInfo = new System.Windows.Forms.TextBox();
            this.конвертироватьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.конвертироватьВLinkedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.очередьToolStripMenuItem,
            this.ElemTool,
            this.UtilityTool});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(376, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // очередьToolStripMenuItem
            // 
            this.очередьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.создатьToolStripMenuItem,
            this.ClearTool,
            this.DelQueueTool,
            this.конвертироватьToolStripMenuItem,
            this.конвертироватьВLinkedToolStripMenuItem});
            this.очередьToolStripMenuItem.Name = "очередьToolStripMenuItem";
            this.очередьToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.очередьToolStripMenuItem.Text = "Очередь";
            // 
            // создатьToolStripMenuItem
            // 
            this.создатьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arrayQueueToolStripMenuItem1,
            this.linkedQueueToolStripMenuItem1});
            this.создатьToolStripMenuItem.Name = "создатьToolStripMenuItem";
            this.создатьToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.создатьToolStripMenuItem.Text = "Создать";
            this.создатьToolStripMenuItem.Click += new System.EventHandler(this.создатьToolStripMenuItem_Click);
            // 
            // arrayQueueToolStripMenuItem1
            // 
            this.arrayQueueToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.intToolStripMenuItem,
            this.stringToolStripMenuItem});
            this.arrayQueueToolStripMenuItem1.Name = "arrayQueueToolStripMenuItem1";
            this.arrayQueueToolStripMenuItem1.Size = new System.Drawing.Size(144, 22);
            this.arrayQueueToolStripMenuItem1.Text = "ArrayQueue";
            // 
            // intToolStripMenuItem
            // 
            this.intToolStripMenuItem.Name = "intToolStripMenuItem";
            this.intToolStripMenuItem.Size = new System.Drawing.Size(104, 22);
            this.intToolStripMenuItem.Text = "int";
            this.intToolStripMenuItem.Click += new System.EventHandler(this.intToolStripMenuItem_Click);
            // 
            // stringToolStripMenuItem
            // 
            this.stringToolStripMenuItem.Name = "stringToolStripMenuItem";
            this.stringToolStripMenuItem.Size = new System.Drawing.Size(104, 22);
            this.stringToolStripMenuItem.Text = "string";
            this.stringToolStripMenuItem.Click += new System.EventHandler(this.stringToolStripMenuItem_Click);
            // 
            // linkedQueueToolStripMenuItem1
            // 
            this.linkedQueueToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.intToolStripMenuItem1,
            this.stringToolStripMenuItem1});
            this.linkedQueueToolStripMenuItem1.Name = "linkedQueueToolStripMenuItem1";
            this.linkedQueueToolStripMenuItem1.Size = new System.Drawing.Size(144, 22);
            this.linkedQueueToolStripMenuItem1.Text = "LinkedQueue";
            // 
            // intToolStripMenuItem1
            // 
            this.intToolStripMenuItem1.Name = "intToolStripMenuItem1";
            this.intToolStripMenuItem1.Size = new System.Drawing.Size(104, 22);
            this.intToolStripMenuItem1.Text = "int";
            this.intToolStripMenuItem1.Click += new System.EventHandler(this.intToolStripMenuItem1_Click);
            // 
            // stringToolStripMenuItem1
            // 
            this.stringToolStripMenuItem1.Name = "stringToolStripMenuItem1";
            this.stringToolStripMenuItem1.Size = new System.Drawing.Size(104, 22);
            this.stringToolStripMenuItem1.Text = "string";
            this.stringToolStripMenuItem1.Click += new System.EventHandler(this.stringToolStripMenuItem1_Click);
            // 
            // ClearTool
            // 
            this.ClearTool.Name = "ClearTool";
            this.ClearTool.Size = new System.Drawing.Size(180, 22);
            this.ClearTool.Text = "Очистить";
            this.ClearTool.Click += new System.EventHandler(this.очиститьToolStripMenuItem_Click);
            // 
            // DelQueueTool
            // 
            this.DelQueueTool.Name = "DelQueueTool";
            this.DelQueueTool.Size = new System.Drawing.Size(180, 22);
            this.DelQueueTool.Text = "Удалить очередь";
            this.DelQueueTool.Click += new System.EventHandler(this.удалитьОчередьToolStripMenuItem_Click);
            // 
            // ElemTool
            // 
            this.ElemTool.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddTool,
            this.DelTool});
            this.ElemTool.Name = "ElemTool";
            this.ElemTool.Size = new System.Drawing.Size(66, 20);
            this.ElemTool.Text = "Элемент";
            // 
            // AddTool
            // 
            this.AddTool.Name = "AddTool";
            this.AddTool.Size = new System.Drawing.Size(126, 22);
            this.AddTool.Text = "Добавить";
            this.AddTool.Click += new System.EventHandler(this.AddTool_Click);
            // 
            // DelTool
            // 
            this.DelTool.Name = "DelTool";
            this.DelTool.Size = new System.Drawing.Size(126, 22);
            this.DelTool.Text = "Удалить";
            this.DelTool.Click += new System.EventHandler(this.DelTool_Click);
            // 
            // UtilityTool
            // 
            this.UtilityTool.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.findAllTool,
            this.forEachTool,
            this.checkForAllTool});
            this.UtilityTool.Name = "UtilityTool";
            this.UtilityTool.Size = new System.Drawing.Size(63, 20);
            this.UtilityTool.Text = "Утилита";
            // 
            // findAllTool
            // 
            this.findAllTool.Name = "findAllTool";
            this.findAllTool.Size = new System.Drawing.Size(138, 22);
            this.findAllTool.Text = "FindAll";
            this.findAllTool.Click += new System.EventHandler(this.findAllTool_Click);
            // 
            // forEachTool
            // 
            this.forEachTool.Name = "forEachTool";
            this.forEachTool.Size = new System.Drawing.Size(138, 22);
            this.forEachTool.Text = "ForEach";
            this.forEachTool.Click += new System.EventHandler(this.forEachTool_Click);
            // 
            // checkForAllTool
            // 
            this.checkForAllTool.Name = "checkForAllTool";
            this.checkForAllTool.Size = new System.Drawing.Size(138, 22);
            this.checkForAllTool.Text = "CheckForAll";
            this.checkForAllTool.Click += new System.EventHandler(this.checkForAllTool_Click);
            // 
            // listBox
            // 
            this.listBox.BackColor = System.Drawing.SystemColors.Info;
            this.listBox.Location = new System.Drawing.Point(12, 33);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(182, 251);
            this.listBox.TabIndex = 1;
            // 
            // textCount
            // 
            this.textCount.BackColor = System.Drawing.SystemColors.Info;
            this.textCount.Location = new System.Drawing.Point(261, 66);
            this.textCount.Name = "textCount";
            this.textCount.ReadOnly = true;
            this.textCount.Size = new System.Drawing.Size(44, 20);
            this.textCount.TabIndex = 2;
            this.textCount.TextChanged += new System.EventHandler(this.textCount_TextChanged);
            // 
            // labelCount
            // 
            this.labelCount.AutoSize = true;
            this.labelCount.Location = new System.Drawing.Point(195, 50);
            this.labelCount.Name = "labelCount";
            this.labelCount.Size = new System.Drawing.Size(180, 13);
            this.labelCount.TabIndex = 3;
            this.labelCount.Text = "Количество элементов в очереди:";
            // 
            // labelInfo
            // 
            this.labelInfo.AutoSize = true;
            this.labelInfo.Location = new System.Drawing.Point(213, 182);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(135, 13);
            this.labelInfo.TabIndex = 4;
            this.labelInfo.Text = "Информация об очереди:";
            // 
            // textInfo
            // 
            this.textInfo.BackColor = System.Drawing.SystemColors.Info;
            this.textInfo.Location = new System.Drawing.Point(203, 198);
            this.textInfo.Name = "textInfo";
            this.textInfo.ReadOnly = true;
            this.textInfo.Size = new System.Drawing.Size(161, 20);
            this.textInfo.TabIndex = 5;
            // 
            // конвертироватьToolStripMenuItem
            // 
            this.конвертироватьToolStripMenuItem.Name = "конвертироватьToolStripMenuItem";
            this.конвертироватьToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.конвертироватьToolStripMenuItem.Text = "Конвертировать в Array";
            this.конвертироватьToolStripMenuItem.Click += new System.EventHandler(this.конвертироватьToolStripMenuItem_Click);
            // 
            // конвертироватьВLinkedToolStripMenuItem
            // 
            this.конвертироватьВLinkedToolStripMenuItem.Name = "конвертироватьВLinkedToolStripMenuItem";
            this.конвертироватьВLinkedToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.конвертироватьВLinkedToolStripMenuItem.Text = "Конвертировать в Linked";
            this.конвертироватьВLinkedToolStripMenuItem.Click += new System.EventHandler(this.конвертироватьВLinkedToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(376, 291);
            this.Controls.Add(this.textInfo);
            this.Controls.Add(this.labelInfo);
            this.Controls.Add(this.labelCount);
            this.Controls.Add(this.textCount);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem очередьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem создатьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ClearTool;
        private System.Windows.Forms.ToolStripMenuItem ElemTool;
        private System.Windows.Forms.ToolStripMenuItem AddTool;
        private System.Windows.Forms.ToolStripMenuItem DelTool;
        private System.Windows.Forms.ToolStripMenuItem UtilityTool;
        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.TextBox textCount;
        private System.Windows.Forms.ToolStripMenuItem arrayQueueToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem intToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stringToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem linkedQueueToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem intToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem stringToolStripMenuItem1;
        private System.Windows.Forms.Label labelCount;
        private System.Windows.Forms.Label labelInfo;
        private System.Windows.Forms.TextBox textInfo;
        private System.Windows.Forms.ToolStripMenuItem DelQueueTool;
        private System.Windows.Forms.ToolStripMenuItem findAllTool;
        private System.Windows.Forms.ToolStripMenuItem forEachTool;
        private System.Windows.Forms.ToolStripMenuItem checkForAllTool;
        private System.Windows.Forms.ToolStripMenuItem конвертироватьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem конвертироватьВLinkedToolStripMenuItem;
    }
}

