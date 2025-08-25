namespace CashierQueuingP2
{
    public partial class QueuingForm : Form
    {
        private CashierClass cashier;
        public QueuingForm()
        {
            InitializeComponent();

            cashier = new CashierClass();
            lblQueue.Text = "P - 10000";


            CashierQueueForm cashierWindow = new CashierQueueForm();
            cashierWindow.Show();
        }

        private void btnCashier_Click(object sender, EventArgs e)
        {
            CashierClass.getNumberInQueue = cashier.CashierGeneratedNumber(CashierClass.getNumberInQueue);
            lblQueue.Text = CashierClass.getNumberInQueue;
            CashierClass.CashierQueue.Enqueue(CashierClass.getNumberInQueue);
        }

        private void lblQueue_Click(object sender, EventArgs e)
        {

        }
    }
}
