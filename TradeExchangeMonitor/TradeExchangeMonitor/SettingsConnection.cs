using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TradeExchangeMonitor
{
    public partial class SettingsConnection : Form
    {
        public static SettingsConnection instance;
        public SettingsConnection()
        {
            InitializeComponent();
        }


        private void SaveConnectionSettings()
        {/*Функция сохраняет в пользовательском файле настройки*/
            Properties.Settings.Default["user_pasword"] = this.textBoxPassword.Text.ToString();
            Properties.Settings.Default["user_login_id"] = this.textBoxUserId.Text.ToString();
            Properties.Settings.Default["user_api_id"] = this.textBoxAPIUserId.Text.ToString(); 
            Properties.Settings.Default.Save();
        }


        private void LoadConnectionSettings()
        {/*Функция загружает сохраненные в пользовательском файле настройки*/
            this.textBoxAPIUserId.Text = Properties.Settings.Default["user_api_id"].ToString();
            this.textBoxUserId.Text = Properties.Settings.Default["user_login_id"].ToString();
            this.textBoxPassword.Text = Properties.Settings.Default["user_pasword"].ToString(); 
        }


        private void TestServerConnection()
        {/*function testing connection with server. If any problam happened - show message, else - write SUCCESS TESTING*/

            if (textBoxAPIUserId.TextLength == 0 || textBoxUserId.TextLength == 0 || textBoxPassword.TextLength == 0)
            {
                MessageBox.Show("Пожалуйста, заполните все поля!");
                return;
            }
            global.TestServerConnection(this.textBoxAPIUserId.Text, textBoxUserId.Text, textBoxPassword.Text);
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            this.SaveConnectionSettings();
            lblinfo.Text = "Настройки сохранены!";
        }

        private void SettingsConnection_Shown(object sender, EventArgs e)
        {
            this.LoadConnectionSettings();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            this.TestServerConnection();
        }
    }
}
