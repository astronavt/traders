using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TradeExchangeMonitor
{
    public partial class TradeChart : UserControl
    {
        const double step_minutes = 1;
        public TradeChart()
        {
            InitializeComponent();
        }

        public TradeChart(object input_datas)
        {
            InitializeComponent();
        }

        private void chart1_Click(object sender, EventArgs e)
        {
            
        }

        private void setActionTitle(string title = "")
        {/*Функция устанавливает имя акции на графике*/
            chart1.Titles["captionActionSymbol"].Text = title;
        }

        private void setBreakingDaysCount(object number = null)
        {/*Функция устанавливает количество пробитых дней*/
            chart1.Titles["captionBreakingCount"].Text = number.ToString();
        }

        private void addNextBarValue(double high, double low, double open, double close)
        {/*функция добавляет следующий бар на график, а также определяет каким цветом он будет
          все столбики добавляются слева-направо*/
            Object[] yv = new Object[4];
            Color cl = new Color();
            cl = Color.Gray;
            yv[0] = high;
            yv[1] = low;
            yv[2] = open;
            yv[3] = close;
            if (chart1.Series["barseries"].Points.Count > 0)
            {
                double last_close = (double)chart1.Series["barseries"].Points.Last().YValues.GetValue(3);
                if (close > last_close)
                    cl = Color.Lime;
                else if (close < last_close) cl = Color.Red;
                else cl = Color.White;
            }
            chart1.Series["barseries"].Points.AddY(yv);
            chart1.Series["barseries"].Points.Last().Color = cl;

        }


        private void addNextBarValueExt(double high, double low, double open, double close, double x_value, Color bar_color)
        {/*функция добавляет следующий бар на график, а также определяет каким цветом он будет
          все столбики добавляются слева-направо*/
            Object[] yv = new Object[4];
            yv[0] = high;
            yv[1] = low;
            yv[2] = open;
            yv[3] = close;
            chart1.Series["barseries"].Points.AddXY(x_value,yv);
            chart1.Series["barseries"].Points.Last().Color = bar_color;

        }

        private void addNextDayValue()
        {/*функция добавляет следующий бар на график дней, а также определяет каким цветом он будет
          все столбики добавляются слева-направо*/

        }

        public void FillRandomValues()
        {
            Random random = new Random();
            chart1.Series["barseries"].Points.Clear();
            for (int i = 0; i < 10; i++)
            {
                int l = random.Next(100);
                int h = l + random.Next(100 - l);
                addNextBarValue(h, l, l + random.Next(h - l), l + random.Next(h - l));
			}
            
         //   chart1.Series["lineseries"];
        }

        private void chkDisplay_CheckedChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Этот блок графиков должен исчезнуть из наблюдения.");
        }
    }
}
