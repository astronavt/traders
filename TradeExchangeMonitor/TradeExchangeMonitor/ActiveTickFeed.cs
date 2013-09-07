using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace TradeExchangeMonitor
{
    class ActiveTickFeed
    {
        public static ActiveTickFeedLib.Feed feed;
        public static ActiveTickFeed instance;

        public ActiveTickFeed()
        {
            //create new instance of IFeed
            feed = new ActiveTickFeedLib.Feed();

            feed.PrimaryServerHostname = "activetick1.activetick.com";
            feed.BackupServerHostname = "activetick2.activetick.com";
            feed.ServerPort = 443;

            //connect all IFeedEvents events to local methods
            feed.OnBarHistoryResponse += new ActiveTickFeedLib.IFeedEvents_OnBarHistoryResponseEventHandler(feed_OnBarHistoryResponse);
            feed.OnLoginResponse += new ActiveTickFeedLib.IFeedEvents_OnLoginResponseEventHandler(feed_OnLoginResponse);
            feed.OnMarketMoversDbResponse += new ActiveTickFeedLib.IFeedEvents_OnMarketMoversDbResponseEventHandler(feed_OnMarketMoversDbResponse);
            feed.OnMarketMoversStreamResponse += new ActiveTickFeedLib.IFeedEvents_OnMarketMoversStreamResponseEventHandler(feed_OnMarketMoversStreamResponse);
            feed.OnQuoteDbResponse += new ActiveTickFeedLib.IFeedEvents_OnQuoteDbResponseEventHandler(feed_OnQuoteDbResponse);
            feed.OnQuoteStreamResponse += new ActiveTickFeedLib.IFeedEvents_OnQuoteStreamResponseEventHandler(feed_OnQuoteStreamResponse);
            feed.OnRequestTimeout += new ActiveTickFeedLib.IFeedEvents_OnRequestTimeoutEventHandler(feed_OnRequestTimeout);
            feed.OnServerSessionStateChange += new ActiveTickFeedLib.IFeedEvents_OnServerSessionStateChangeEventHandler(feed_OnServerSessionStateChange);
            feed.OnStreamMarketMovers += new ActiveTickFeedLib.IFeedEvents_OnStreamMarketMoversEventHandler(feed_OnStreamMarketMovers);
            feed.OnStreamQuote += new ActiveTickFeedLib.IFeedEvents_OnStreamQuoteEventHandler(feed_OnStreamQuote);
            feed.OnStreamTrade += new ActiveTickFeedLib.IFeedEvents_OnStreamTradeEventHandler(feed_OnStreamTrade);
            feed.OnTickHistoryResponse += new ActiveTickFeedLib.IFeedEvents_OnTickHistoryResponseEventHandler(feed_OnTickHistoryResponse);
            feed.OnConstituentListResponse += feed_OnConstituentListResponse;
        }

        void feed_OnConstituentListResponse(int originalRequestId, object symbols)
        {
            string[] symbolsArray = (string[])symbols;
            foreach (string s in symbolsArray)
            {
                global.trace(s);
            }
        }

        void feed_OnTickHistoryResponse(int originalRequestId, short tickHistoryResponseCode, string symbol, short symbolStatusCode, object records)
        {
            //MessageBox.Show(records.GetType().ToString());
            global.trace("originalRequestId:  " + originalRequestId.ToString());
            global.trace("tickHistoryResponseCode:  " + tickHistoryResponseCode.ToString());
            global.trace("symbol:  " + symbol.ToString());
            global.trace("symbolStatusCode:  " + symbolStatusCode.ToString());
            global.trace("records:  " + records.ToString());


            string[] recordsArray = (string[])records;
            foreach (var item in (recordsArray))
            {
                global.trace(item);
            }
            global.trace("input_end");
            throw new NotImplementedException();
        }

        void feed_OnStreamTrade(string symbol, int tradeFlags, object tradeConditions, byte tradeExchange, double tradePrice, int tradeSize, DateTime tradeDatetime)
        {
            //tradeconditions is an array of 4 bytes
            byte[] tradeConditionsArray = (byte[])tradeConditions;

            //create data string
            string data = "Stream Trade: " + symbol + "," + tradeFlags + "," + tradeConditionsArray[0] + "-" + tradeConditionsArray[1] + "-" + tradeConditionsArray[2] + "-" + tradeConditionsArray[3] + "," +
                tradeExchange + "," + tradePrice + "," + tradeSize + "," + tradeDatetime.ToString();

            //show on data string on the screen
            Form1.instance.AddData(data);
        }

        void feed_OnStreamQuote(string symbol, byte quoteCondition, byte bidExchange, byte askExchange, double bidPrice, double askPrice, int bidSize, int askSize, DateTime quoteDatetime)
        {
            //create data string
            string data = "Stream Quote: " + symbol + "," + quoteCondition + "," + bidExchange + "," + askExchange + "," + bidPrice + "," + askPrice + "," + bidSize + "," + askSize + "," + quoteDatetime.ToString();

            //show on data string on the screen
            Form1.instance.AddData(data);
        }

        void feed_OnStreamMarketMovers(string symbol, object records)
        {
            throw new NotImplementedException();
        }

        void feed_OnServerSessionStateChange(short prevSessionState, short newSessionState)
        {
            //handle session changes

            switch ((Defines.ATSessionStatusType)newSessionState)
            {
                case Defines.ATSessionStatusType.SessionStatusConnected:
                    {
                        Form1.instance.AddData("Session change: Connected");
                        Form1.instance.AddData("Logging in..." + "login: " + Properties.Settings.Default["user_login_id"].ToString() + " / password: " + Properties.Settings.Default["user_pasword"].ToString());

                        feed.SendLoginRequest(Properties.Settings.Default["user_login_id"].ToString(), Properties.Settings.Default["user_pasword"].ToString());
                    }
                    break;
                case Defines.ATSessionStatusType.SessionStatusDisconnected:
                    global.procceed("Session change: Disconnected");
                    global.UpdateLoggedInState(false);
                    break;
                case Defines.ATSessionStatusType.SessionStatusDisconnectedDuplicateLogin:
                    global.procceed("Session change: Disconnected duplicate login");
                    global.UpdateLoggedInState(false);
                    break;
            }
        }

        void feed_OnRequestTimeout(int originalRequestId)
        {
            Form1.instance.AddData(string.Format("Request id {0} timed out", originalRequestId));
        }

        void feed_OnQuoteStreamResponse(int originalRequestId, short streamResponseCode, short symbolStatusCode, string symbol, short currentSymbol, short totalSymbols)
        {
            Form1.instance.AddData("Processing OnQuoteStreamResponse........");

            string data = "OrigRequestId:" + originalRequestId + "," + ((Defines.ATStreamResponseType)streamResponseCode).ToString();

            //show on data string on the screen
            Form1.instance.AddData(data);
        }

        void feed_OnQuoteDbResponse(int originalRequestId, short quoteDbResponseCode, short symbolStatusCode, string symbol, short currentSymbol, short totalSymbols, object records)
        {
            Form1.instance.AddData("Processing OnQuoteDbResponse........");

            string responseString = "";

            switch ((Defines.ATQuoteDbResponseType)quoteDbResponseCode)
            {
                case Defines.ATQuoteDbResponseType.QuoteDbResponseSuccess:
                    {
                        switch ((Defines.ATSymbolStatus)symbolStatusCode)
                        {
                            case Defines.ATSymbolStatus.SymbolStatusSuccess:
                                {
                                    Form1.instance.AddData("ATSymbolStatus: SymbolStatusSuccess");

                                    string[] recordsArray = (string[])records;

                                    foreach (string s in recordsArray)
                                    {
                                        Defines.ATDataType dataType = (Defines.ATDataType)Enum.Parse(typeof(Defines.ATDataType), s.Substring(0, 2));
                                        Defines.ATQuoteFieldType quoteFieldType = (Defines.ATQuoteFieldType)Enum.Parse(typeof(Defines.ATQuoteFieldType), s.Substring(2, 3));
                                        Defines.ATFieldStatus fieldStatusType = (Defines.ATFieldStatus)Enum.Parse(typeof(Defines.ATFieldStatus), s.Substring(5, 2));

                                        int dataIndex = s.IndexOf(',');
                                        if (dataIndex > 0)
                                        {
                                            string data = quoteFieldType.ToString() + "," + dataType.ToString() + "," + fieldStatusType.ToString() + "," + s.Substring(dataIndex + 1);
                                            Form1.instance.AddData(data);
                                        }
                                    }

                                    responseString = "";
                                }
                                break;
                            case Defines.ATSymbolStatus.SymbolStatusInvalid:
                                responseString = "ATSymbolStatus: SymbolStatusInvalid";
                                break;
                            case Defines.ATSymbolStatus.SymbolStatusNoPermission:
                                responseString = "ATSymbolStatus: SymbolStatusNoPermission";
                                break;
                            case Defines.ATSymbolStatus.SymbolStatusUnavailable:
                                responseString = "ATSymbolStatus: SymbolStatusUnavailable";
                                break;
                        }
                    }
                    break;
                case Defines.ATQuoteDbResponseType.QuoteDbResponseDenied:
                    responseString = "ATQuoteDbResponseType: QuoteDbResponseDenied";
                    break;
                case Defines.ATQuoteDbResponseType.QuoteDbResponseInvalidRequest:
                    responseString = "ATQuoteDbResponseType: QuoteDbResponseInvalidRequest";
                    break;
            }

            //show on data string on the screen
            if (responseString.Length > 0)
                Form1.instance.AddData(responseString);
        }

        void feed_OnMarketMoversStreamResponse(int originalRequestId, short streamResponseCode)
        {
            throw new NotImplementedException();
        }

        void feed_OnMarketMoversDbResponse(int originalRequestId, short marketMoversResponseCode, string symbol, object records)
        {
            Form1.instance.AddData("Processing OnMarketMoversDbResponse........");

            if (records != null)
            {
                records.GetType();
                string[] recordsArray = (string[])records;
                foreach (string s in recordsArray)
                {
                    global.trace(s);
                }
            }
            else
                //show on data string on the screen
                global.trace("No records available.");
        }

        void feed_OnLoginResponse(short loginStatus)
        {
            string s = "";
            bool rslt = false;
            switch ((Defines.ATLoginResponseType)loginStatus)
            {
                case Defines.ATLoginResponseType.LoginResponseSuccess:
                    s = "Successfully logged in";
                    rslt = true;
                    break;
                case Defines.ATLoginResponseType.LoginResponseInvalidPassword: s = "Invalid pwd"; break;
                case Defines.ATLoginResponseType.LoginResponseInvalidRequest: s = "Invalid request"; break;
                case Defines.ATLoginResponseType.LoginResponseInvalidUserid: s = "Invalid Userid"; break;
                case Defines.ATLoginResponseType.LoginResponseLoginDenied: s = "Login denied"; break;
                case Defines.ATLoginResponseType.LoginResponseServerError: s = "Server error"; break;
            }
            global.UpdateLoggedInState(rslt, loginStatus,s);

        }

        void feed_OnBarHistoryResponse(int originalRequestId, short barHistoryResponseCode, string symbol, short symbolStatusCode, object records)
        {
            Form1.instance.AddData("Processing OnBarHistoryResponse........");

            Form1.instance.AddData("ATBarHistoryResponseType: " + ((Defines.ATBarHistoryResponseType)barHistoryResponseCode).ToString());
            Form1.instance.AddData("ATSymbolStatus: " + ((Defines.ATSymbolStatus)symbolStatusCode).ToString());
               if (records != null)
                            {
                                string[] recordsArray = (string[])records;
                                foreach (string s in recordsArray)
                                    global.trace(s);
                            }

            switch ((Defines.ATBarHistoryResponseType)barHistoryResponseCode)
            {
                case Defines.ATBarHistoryResponseType.BarHistoryResponseSuccess:
                case Defines.ATBarHistoryResponseType.BarHistoryResponseMaxLimitReached:
                    {
                        if ((Defines.ATSymbolStatus)symbolStatusCode == Defines.ATSymbolStatus.SymbolStatusSuccess)
                        {
                            if (records != null)
                            {
                                string[] recordsArray = (string[])records;
                                foreach (string s in recordsArray)
                                    global.trace(s);
                            }
                        }
                    }
                    break;
                case Defines.ATBarHistoryResponseType.BarHistoryResponseDenied:
                    break;
                case Defines.ATBarHistoryResponseType.BarHistoryResponseInvalidRequest:
                    break;
            }
        }
    }
}
