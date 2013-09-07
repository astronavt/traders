using System;
using System.Windows.Forms;
using System.Net;

namespace TradeExchangeMonitor
{
    /// <summary>
    /// статтический класс global содержит все глобальные методы и настройки котоыре использует программа для работы и взаимодействия между окнами и прочим
    /// </summary>
    class global
    {
        public static global g;
        public static bool ConnectionStatus = false; //Есть подключение к серверу или нет

        /*Переменные относящиеся к тестированю подключения*/
        private bool testingConnection = false; //Тестирование подключения к и-нету
        private string preAPIid = "";
        private string preLoginid = "";
        private string preLoginPassword = "";

        public global()
        {
            g = this;
        }

        public static void GetTickHistory(string symbol)
        {
            ServerLogin(false); /*connect to server if we aren't already connected*/
            DateTime to_date = DateTime.Now;
            DateTime from_date = DateTime.Now - TimeSpan.FromDays(2);
            trace("[tick history] date from: " + from_date + ", date to: " + to_date);
            trace(ActiveTickFeed.feed.SendTickHistoryRequest(symbol.ToUpper(), true, false, from_date, to_date).ToString());
        }

        public static void GetBarHistory(string symbol)
        {
            ServerLogin(false); /*connect to server if we aren't already connected*/
            DateTime to_date = DateTime.Now;
            DateTime from_date = DateTime.Now - TimeSpan.FromDays(10);
            trace("[bar history] date from: " + from_date + ", date to: " + to_date);
            ActiveTickFeed.feed.SendBarHistoryRequest(symbol.ToUpper(), (short)Defines.ATBarHistoryType.BarHistoryIntraday, 1, from_date, to_date);
        }

        /// <summary>
        /// функция обрабатывает входящие данные
        /// </summary>
        public static void procceed(string s, bool tracedata = true, object param = null)
        {
            string s2 = "";
            if (g.testingConnection) s2 = "[testing connection]: ";
            if (tracedata) MainForm.instance.AddData(s2 + s);
        }


        public static void trace(string s, bool tracedata = true, object param = null)
        {
            string s2 = "";
            if (g.testingConnection) s2 = "[testing connection]: ";
            if (tracedata) MainForm.instance.AddData(s2 + s);
        }

        /// <summary>
        /// Открывает соеденение с сервером и входит
        /// </summary>
        public static void ServerLogin(bool DisconnectIfConnected = true)
        {
            if (Properties.Settings.Default["user_pasword"].ToString().Trim() == "" ||
            Properties.Settings.Default["user_login_id"].ToString().Trim() == "" ||
            Properties.Settings.Default["user_api_id"].ToString().Trim() == "")
            {
                MessageBox.Show("Please fill out all fields!");
                return;
            }

            if (ConnectionStatus == false || (ConnectionStatus && DisconnectIfConnected))
            {
                ActiveTickFeed.feed.APIUserId = Properties.Settings.Default["user_api_id"].ToString();

                int rc = ActiveTickFeed.feed.StopServerSession();
                rc = ActiveTickFeed.feed.StartServerSession();
            }
        }

        /// <summary>
        /// Завершает соеденение с сервером
        /// </summary>
        public static void ServerLogout()
        {
            ActiveTickFeed.feed.StopServerSession();
        }

        /// <summary>
        /// Function testing connection with parameters
        /// </summary>
        public static void TestServerConnection(string test_apilogin,string test_userlogin,string test_userpass)
        {
            g.testingConnection = true;
            g.preAPIid = Properties.Settings.Default["user_api_id"].ToString();
            g.preLoginid = Properties.Settings.Default["user_login_id"].ToString();
            g.preLoginPassword = Properties.Settings.Default["user_pasword"].ToString();
            /*создаем тестируемые параметры*/
            Properties.Settings.Default["user_pasword"] = test_userpass;
            Properties.Settings.Default["user_login_id"] = test_userlogin;
            Properties.Settings.Default["user_api_id"] = test_apilogin;
            
            /*Подключаемся*/
            ServerLogin();
        }

        /// <summary>
        /// Function testing connection with parameters
        /// </summary>
        public static void TestServerConnectionResponse(short loginStatus,string s = "")
        {
            g.testingConnection = false;
            /*создаем тестируемые параметры*/
            Properties.Settings.Default["user_api_id"]   = g.preAPIid;
            Properties.Settings.Default["user_login_id"] = g.preLoginid;
            Properties.Settings.Default["user_pasword"]  = g.preLoginPassword;
            MessageBox.Show(s);
        }


        public static void UpdateLoggedInState(bool bLoggedin, short loginStatus = 0, string s = "")
        {
            if (g.testingConnection)
            {/*При тестовом подключении*/
                TestServerConnectionResponse(loginStatus, s);
            }
            else
            {/*Если это было не тестовое подключение*/
                trace(s);
                ConnectionStatus = bLoggedin;
            }
        }


        public bool ConnectionAvailable(string strServer = "http://www.activetick.com")
        {
            WebClient Client = new WebClient();
            String Response="";
            trace("Checking internet connection status...");

            try
            {
                Response = Client.DownloadString(strServer);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Нет подключения к интернету\nПроверьте ваш фаервол или настройки сетевого подключения\nОшибка: " + ex.ToString());

            }

            if (Response.Length > 0)
            {
                trace("Internet connection available!");
                return true;
            }
            else
            {
                trace("[WARNING!] No internet connection!");
                return false;
            }
        }
    }
}
