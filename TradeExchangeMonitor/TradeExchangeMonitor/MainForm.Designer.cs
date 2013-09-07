namespace TradeExchangeMonitor
{
    partial class MainForm
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.программаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выйтиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.настройкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSettingsConnection = new System.Windows.Forms.ToolStripMenuItem();
            this.настройкиМониторингаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.цветоваяСхемаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.фильтрыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оконИВкладокToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TABULATOR = new System.Windows.Forms.TabControl();
            this.tabTest = new System.Windows.Forms.TabPage();
            this.SaveToFileBtn = new System.Windows.Forms.Button();
            this.TestGraphBtn = new System.Windows.Forms.Button();
            this.ForceCloseSessionBtn = new System.Windows.Forms.Button();
            this.chkClearListBefore = new System.Windows.Forms.CheckBox();
            this.GetTickHistoryBtn = new System.Windows.Forms.Button();
            this.GetBarHistoryBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAct = new System.Windows.Forms.TextBox();
            this.CheckInternetConnectionBtn = new System.Windows.Forms.Button();
            this.ForceOpenSessionBtn = new System.Windows.Forms.Button();
            this.listBoxData = new System.Windows.Forms.ListBox();
            this.tabH = new System.Windows.Forms.TabPage();
            this.tabL = new System.Windows.Forms.TabPage();
            this.tabFilters = new System.Windows.Forms.TabPage();
            this.menuStrip1.SuspendLayout();
            this.TABULATOR.SuspendLayout();
            this.tabTest.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.программаToolStripMenuItem,
            this.настройкиToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(662, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // программаToolStripMenuItem
            // 
            this.программаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.выйтиToolStripMenuItem});
            this.программаToolStripMenuItem.Name = "программаToolStripMenuItem";
            this.программаToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            this.программаToolStripMenuItem.Text = "Программа";
            // 
            // выйтиToolStripMenuItem
            // 
            this.выйтиToolStripMenuItem.Name = "выйтиToolStripMenuItem";
            this.выйтиToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.выйтиToolStripMenuItem.Text = "Выйти";
            this.выйтиToolStripMenuItem.Click += new System.EventHandler(this.выйтиToolStripMenuItem_Click);
            // 
            // настройкиToolStripMenuItem
            // 
            this.настройкиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuSettingsConnection,
            this.настройкиМониторингаToolStripMenuItem,
            this.цветоваяСхемаToolStripMenuItem,
            this.фильтрыToolStripMenuItem,
            this.оконИВкладокToolStripMenuItem});
            this.настройкиToolStripMenuItem.Name = "настройкиToolStripMenuItem";
            this.настройкиToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.настройкиToolStripMenuItem.Text = "Настройки";
            // 
            // mnuSettingsConnection
            // 
            this.mnuSettingsConnection.Name = "mnuSettingsConnection";
            this.mnuSettingsConnection.Size = new System.Drawing.Size(160, 22);
            this.mnuSettingsConnection.Text = "Подключение";
            this.mnuSettingsConnection.Click += new System.EventHandler(this.mnuSettingsConnection_Click);
            // 
            // настройкиМониторингаToolStripMenuItem
            // 
            this.настройкиМониторингаToolStripMenuItem.Enabled = false;
            this.настройкиМониторингаToolStripMenuItem.Name = "настройкиМониторингаToolStripMenuItem";
            this.настройкиМониторингаToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.настройкиМониторингаToolStripMenuItem.Text = "Мониторинг";
            this.настройкиМониторингаToolStripMenuItem.Click += new System.EventHandler(this.настройкиМониторингаToolStripMenuItem_Click);
            // 
            // цветоваяСхемаToolStripMenuItem
            // 
            this.цветоваяСхемаToolStripMenuItem.Enabled = false;
            this.цветоваяСхемаToolStripMenuItem.Name = "цветоваяСхемаToolStripMenuItem";
            this.цветоваяСхемаToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.цветоваяСхемаToolStripMenuItem.Text = "Цветовая схема";
            // 
            // фильтрыToolStripMenuItem
            // 
            this.фильтрыToolStripMenuItem.Enabled = false;
            this.фильтрыToolStripMenuItem.Name = "фильтрыToolStripMenuItem";
            this.фильтрыToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.фильтрыToolStripMenuItem.Text = "Фильтры";
            // 
            // оконИВкладокToolStripMenuItem
            // 
            this.оконИВкладокToolStripMenuItem.Enabled = false;
            this.оконИВкладокToolStripMenuItem.Name = "оконИВкладокToolStripMenuItem";
            this.оконИВкладокToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.оконИВкладокToolStripMenuItem.Text = "Окон и вкладок";
            // 
            // TABULATOR
            // 
            this.TABULATOR.Controls.Add(this.tabTest);
            this.TABULATOR.Controls.Add(this.tabH);
            this.TABULATOR.Controls.Add(this.tabL);
            this.TABULATOR.Controls.Add(this.tabFilters);
            this.TABULATOR.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TABULATOR.Location = new System.Drawing.Point(0, 24);
            this.TABULATOR.Multiline = true;
            this.TABULATOR.Name = "TABULATOR";
            this.TABULATOR.SelectedIndex = 0;
            this.TABULATOR.Size = new System.Drawing.Size(662, 538);
            this.TABULATOR.TabIndex = 2;
            // 
            // tabTest
            // 
            this.tabTest.Controls.Add(this.SaveToFileBtn);
            this.tabTest.Controls.Add(this.TestGraphBtn);
            this.tabTest.Controls.Add(this.ForceCloseSessionBtn);
            this.tabTest.Controls.Add(this.chkClearListBefore);
            this.tabTest.Controls.Add(this.GetTickHistoryBtn);
            this.tabTest.Controls.Add(this.GetBarHistoryBtn);
            this.tabTest.Controls.Add(this.label1);
            this.tabTest.Controls.Add(this.txtAct);
            this.tabTest.Controls.Add(this.CheckInternetConnectionBtn);
            this.tabTest.Controls.Add(this.ForceOpenSessionBtn);
            this.tabTest.Controls.Add(this.listBoxData);
            this.tabTest.Location = new System.Drawing.Point(4, 22);
            this.tabTest.Name = "tabTest";
            this.tabTest.Size = new System.Drawing.Size(654, 512);
            this.tabTest.TabIndex = 3;
            this.tabTest.Text = "TEST TAB";
            this.tabTest.UseVisualStyleBackColor = true;
            // 
            // SaveToFileBtn
            // 
            this.SaveToFileBtn.Location = new System.Drawing.Point(420, 159);
            this.SaveToFileBtn.Name = "SaveToFileBtn";
            this.SaveToFileBtn.Size = new System.Drawing.Size(130, 50);
            this.SaveToFileBtn.TabIndex = 15;
            this.SaveToFileBtn.Text = "Сохранить в файл";
            this.SaveToFileBtn.UseVisualStyleBackColor = true;
            this.SaveToFileBtn.Click += new System.EventHandler(this.button7_Click);
            // 
            // TestGraphBtn
            // 
            this.TestGraphBtn.Location = new System.Drawing.Point(395, 382);
            this.TestGraphBtn.Name = "TestGraphBtn";
            this.TestGraphBtn.Size = new System.Drawing.Size(167, 91);
            this.TestGraphBtn.TabIndex = 14;
            this.TestGraphBtn.Text = "Тестировать график";
            this.TestGraphBtn.UseVisualStyleBackColor = true;
            this.TestGraphBtn.Click += new System.EventHandler(this.button6_Click);
            // 
            // ForceCloseSessionBtn
            // 
            this.ForceCloseSessionBtn.Location = new System.Drawing.Point(375, 300);
            this.ForceCloseSessionBtn.Name = "ForceCloseSessionBtn";
            this.ForceCloseSessionBtn.Size = new System.Drawing.Size(214, 23);
            this.ForceCloseSessionBtn.TabIndex = 13;
            this.ForceCloseSessionBtn.Text = "Принудительно закрыть сессию";
            this.ForceCloseSessionBtn.UseVisualStyleBackColor = true;
            this.ForceCloseSessionBtn.Click += new System.EventHandler(this.button5_Click);
            // 
            // chkClearListBefore
            // 
            this.chkClearListBefore.AutoSize = true;
            this.chkClearListBefore.Location = new System.Drawing.Point(375, 51);
            this.chkClearListBefore.Name = "chkClearListBefore";
            this.chkClearListBefore.Size = new System.Drawing.Size(236, 17);
            this.chkClearListBefore.TabIndex = 12;
            this.chkClearListBefore.Text = "Очищать поле вывода перед действием?";
            this.chkClearListBefore.UseVisualStyleBackColor = true;
            // 
            // GetTickHistoryBtn
            // 
            this.GetTickHistoryBtn.AutoSize = true;
            this.GetTickHistoryBtn.Location = new System.Drawing.Point(375, 84);
            this.GetTickHistoryBtn.Name = "GetTickHistoryBtn";
            this.GetTickHistoryBtn.Size = new System.Drawing.Size(214, 23);
            this.GetTickHistoryBtn.TabIndex = 5;
            this.GetTickHistoryBtn.Text = "Получить Тиковую историю";
            this.GetTickHistoryBtn.UseVisualStyleBackColor = true;
            this.GetTickHistoryBtn.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // GetBarHistoryBtn
            // 
            this.GetBarHistoryBtn.AutoSize = true;
            this.GetBarHistoryBtn.Location = new System.Drawing.Point(375, 113);
            this.GetBarHistoryBtn.Name = "GetBarHistoryBtn";
            this.GetBarHistoryBtn.Size = new System.Drawing.Size(214, 23);
            this.GetBarHistoryBtn.TabIndex = 11;
            this.GetBarHistoryBtn.Text = "Получить Барную историю";
            this.GetBarHistoryBtn.UseVisualStyleBackColor = true;
            this.GetBarHistoryBtn.Click += new System.EventHandler(this.button4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(372, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Имя акции:";
            // 
            // txtAct
            // 
            this.txtAct.Location = new System.Drawing.Point(462, 20);
            this.txtAct.Name = "txtAct";
            this.txtAct.Size = new System.Drawing.Size(100, 20);
            this.txtAct.TabIndex = 9;
            this.txtAct.Text = "cien";
            // 
            // CheckInternetConnectionBtn
            // 
            this.CheckInternetConnectionBtn.Location = new System.Drawing.Point(375, 242);
            this.CheckInternetConnectionBtn.Name = "CheckInternetConnectionBtn";
            this.CheckInternetConnectionBtn.Size = new System.Drawing.Size(214, 23);
            this.CheckInternetConnectionBtn.TabIndex = 8;
            this.CheckInternetConnectionBtn.Text = "Проверить соединение с интернетом";
            this.CheckInternetConnectionBtn.UseVisualStyleBackColor = true;
            this.CheckInternetConnectionBtn.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // ForceOpenSessionBtn
            // 
            this.ForceOpenSessionBtn.Location = new System.Drawing.Point(375, 271);
            this.ForceOpenSessionBtn.Name = "ForceOpenSessionBtn";
            this.ForceOpenSessionBtn.Size = new System.Drawing.Size(214, 23);
            this.ForceOpenSessionBtn.TabIndex = 7;
            this.ForceOpenSessionBtn.Text = "Принудительно открыть сессию";
            this.ForceOpenSessionBtn.UseVisualStyleBackColor = true;
            this.ForceOpenSessionBtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // listBoxData
            // 
            this.listBoxData.FormattingEnabled = true;
            this.listBoxData.Location = new System.Drawing.Point(8, 14);
            this.listBoxData.Name = "listBoxData";
            this.listBoxData.Size = new System.Drawing.Size(361, 225);
            this.listBoxData.TabIndex = 6;
            // 
            // tabH
            // 
            this.tabH.Location = new System.Drawing.Point(4, 22);
            this.tabH.Name = "tabH";
            this.tabH.Padding = new System.Windows.Forms.Padding(3);
            this.tabH.Size = new System.Drawing.Size(654, 512);
            this.tabH.TabIndex = 0;
            this.tabH.Text = "H";
            this.tabH.UseVisualStyleBackColor = true;
            // 
            // tabL
            // 
            this.tabL.Location = new System.Drawing.Point(4, 22);
            this.tabL.Name = "tabL";
            this.tabL.Padding = new System.Windows.Forms.Padding(3);
            this.tabL.Size = new System.Drawing.Size(654, 512);
            this.tabL.TabIndex = 1;
            this.tabL.Text = "L";
            this.tabL.UseVisualStyleBackColor = true;
            // 
            // tabFilters
            // 
            this.tabFilters.Location = new System.Drawing.Point(4, 22);
            this.tabFilters.Name = "tabFilters";
            this.tabFilters.Size = new System.Drawing.Size(654, 512);
            this.tabFilters.TabIndex = 2;
            this.tabFilters.Text = "tabFilters";
            this.tabFilters.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 562);
            this.Controls.Add(this.TABULATOR);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "TradeExchangeMonitor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.TABULATOR.ResumeLayout(false);
            this.tabTest.ResumeLayout(false);
            this.tabTest.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem программаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выйтиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem настройкиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuSettingsConnection;
        private System.Windows.Forms.ToolStripMenuItem настройкиМониторингаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem цветоваяСхемаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem фильтрыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оконИВкладокToolStripMenuItem;
        private System.Windows.Forms.TabControl TABULATOR;
        private System.Windows.Forms.TabPage tabH;
        private System.Windows.Forms.TabPage tabL;
        private System.Windows.Forms.TabPage tabFilters;
        private System.Windows.Forms.TabPage tabTest;
        private System.Windows.Forms.TextBox txtAct;
        private System.Windows.Forms.Button CheckInternetConnectionBtn;
        private System.Windows.Forms.Button ForceOpenSessionBtn;
        private System.Windows.Forms.ListBox listBoxData;
        private System.Windows.Forms.Button GetTickHistoryBtn;
        private System.Windows.Forms.Button GetBarHistoryBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chkClearListBefore;
        private System.Windows.Forms.Button ForceCloseSessionBtn;
        private System.Windows.Forms.Button TestGraphBtn;
        private System.Windows.Forms.Button SaveToFileBtn;

    }
}

