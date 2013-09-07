using System;
using System.Windows.Forms;
using System.IO;
namespace TradeExchangeMonitor
{
    public partial class MainForm : Form
    {
        public static MainForm instance;

        delegate void AddDataDelegate(string data);

        public TradeChart trChart;

        public MainForm()
        {
            instance = this;
            new global();
            new ActiveTickFeed();
            InitializeComponent();
            global.ServerLogin();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listBoxData.Items.Insert(0, DateTime.Today.ToString());
        }

        /// <summary>
        /// Функция обрабатывает пришедшие данные от сервера
        /// </summary>
        public void AddData(string data)
        {
            if (this.listBoxData.InvokeRequired)
                BeginInvoke(new AddDataDelegate(AddData), new object[] { data });
            else
                this.listBoxData.Items.Insert(0, data); 
        }

        private void настройкиМониторингаToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Вызываем все деструкторы и закрываем приложение
        /// </summary>
        private void выйтиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            addChart();
        }

        private void addChart()
        {
            if (trChart == null)
            {
                trChart = new TradeChart();
                tabTest.Controls.Add(trChart);
                trChart.Left = 0;
                trChart.Top = 250;
                trChart.Width = 350;
                trChart.Height = 250;
            }
        }

        private void mnuSettingsConnection_Click(object sender, EventArgs e)
        {
            var frmConSet = new SettingsConnection();
            frmConSet.ShowDialog();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            global.ServerLogout();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (chkClearListBefore.Checked) listBoxData.Items.Clear();
            global.GetTickHistory(txtAct.Text);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (chkClearListBefore.Checked) listBoxData.Items.Clear();
            global.GetBarHistory(txtAct.Text);
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            global.g.ConnectionAvailable("http://www.google.com");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            global.ServerLogin();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            global.ServerLogout();
        }

        private void button6_Click(object sender, EventArgs e)
        {
           // trChart.
            trChart.FillRandomValues();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            var f = new SaveFileDialog();
            f.ShowDialog();

            string textout = "";

            // assume the li is a string - will fail if not
            foreach (string li in listBoxData.Items)
            {
                textout = textout + li + Environment.NewLine;
            }

            textout = "extra stuff at the top" + Environment.NewLine + textout + "extra stuff at the bottom";
            File.WriteAllText(f.FileName, textout);

            MessageBox.Show("all saved!");
        }
    }
}
