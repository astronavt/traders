using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TradeExchangeMonitor.Properties;
using System.IO;
namespace TradeExchangeMonitor
{
    public partial class Form1 : Form
    {
        public static Form1 instance;

        delegate void AddDataDelegate(string data);
        delegate void UpdateLoggedInStateDelegate(bool bLoggedin);

        public TradeChart trChart;

        public Form1()
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

        public void AddData(string data)
        {/*Функция обрабатывает пришедшие данные от сервера*/
         
            if (this.listBoxData.InvokeRequired)
                BeginInvoke(new AddDataDelegate(AddData), new object[] { data });
            else
                this.listBoxData.Items.Insert(0,/* System.DateTime.Now.ToString() + ": " + */ data); 
        }

        private void настройкиМониторингаToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void выйтиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*Вызываем все деструкторы и закрываем приложение*/
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
                /*TradeChart a = new TradeChart();
                tabTest.Controls.Add(a);
                a.Left = 0;
                a.Top = 0;
                a.Width = 450;
                a.Height = 350;*/
                trChart = new TradeChart();
                tabTest.Controls.Add(trChart);
                trChart.Left = 0;
                trChart.Top = 250;
                trChart.Width = 350;
                trChart.Height = 250;
            }
        }

        private void настройкиПодключенияToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void mnuSettingsConnection_Click(object sender, EventArgs e)
        {
            SettingsConnection frmConSet = new SettingsConnection();
            frmConSet.ShowDialog();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            global.ServerLogout();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

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
            SaveFileDialog f = new SaveFileDialog();

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
