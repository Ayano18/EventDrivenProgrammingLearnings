using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CashierQueuingP2
{
    public partial class CashierQueueForm : Form
    {
        private System.Windows.Forms.Timer timer;
        public CashierQueueForm()
        {
            InitializeComponent();

            DisplayCashierQueue(CashierClass.CashierQueue);

            timer = new System.Windows.Forms.Timer();
            timer.Interval = (1 * 1000); // 1 sec.
            timer.Tick += new EventHandler(timer1_tick);
            timer.Start();
        }
        private void timer1_tick(object sender, EventArgs e)
        {
            DisplayCashierQueue(CashierClass.CashierQueue);
        }
        public void DisplayCashierQueue(IEnumerable CashierList)
        {
            listCashierQueue.Items.Clear();
            foreach (object obj in CashierList)
            {
                listCashierQueue.Items.Add(obj.ToString());
            }
            if (CashierClass.CashierQueue.Count > 0)
            {
                string nextNumber = CashierClass.CashierQueue.Peek();
            } 
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            DisplayCashierQueue(CashierClass.CashierQueue);
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (CashierClass.CashierQueue.Count > 0)
            {

                string nextNumber = CashierClass.CashierQueue.Dequeue();
                MessageBox.Show($"Serving next number: {nextNumber}", "Next Customer");
                DisplayCashierQueue(CashierClass.CashierQueue);
            }
            else
            {
                MessageBox.Show("The queue is currently empty.", "Queue Status");
            }
        }   

        private void listCashierQueue_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
