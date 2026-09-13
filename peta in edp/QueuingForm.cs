using System;
using System.Windows.Forms;

namespace BasicQueuingCashier
{
    public partial class QueuingForm : Form
    {
        private CashierClass cashier;
        private CashierWindowQueueForm cashierWindow;

        public QueuingForm()
        {
            InitializeComponent();

            cashier = new CashierClass();
        }

        private void btnCashier_Click(object sender, EventArgs e)
        {
            lblQueue.Text = cashier.CashierGeneratedNumber("P - ");

            CashierClass.getNumberInQueue = lblQueue.Text;

            CashierClass.CashierQueue.Enqueue(
                CashierClass.getNumberInQueue
            );

            if (cashierWindow == null || cashierWindow.IsDisposed)
            {
                cashierWindow = new CashierWindowQueueForm();
                cashierWindow.Show();
            }
            else
            {
                cashierWindow.Activate();
            }
        }
    }
}