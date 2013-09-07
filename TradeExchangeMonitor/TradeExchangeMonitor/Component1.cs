using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace TradeExchangeMonitor
{
    public partial class ActionChartBox : Component
    {
        public ActionChartBox()
        {
            InitializeComponent();
        }

        public ActionChartBox(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }

        private void chart_Click(object sender, EventArgs e)
        {

        }
    }
}
