using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BasicQueuingCashier
{
    public partial class CustomerView : Form
    {
        private System.Windows.Forms.Timer timer;

        public CustomerView()
        {
            InitializeComponent();

            timer = new System.Windows.Forms.Timer();
            timer.Interval = 1000;
            timer.Tick += new EventHandler(timer1_tick);
            timer.Start();
        }

        private void UpdateNowServing()
        {
            if (CashierClass.CashierQueue != null && CashierClass.CashierQueue.Count > 0)
            {
                lblNowServing.Text = CashierClass.CashierQueue.Peek();
            }
        }

        private void timer1_tick(object sender, EventArgs e)
        {
            UpdateNowServing();
        }
    }
}