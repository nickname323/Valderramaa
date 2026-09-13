using System;
using System.Windows.Forms;

namespace BasicQueuingCashier
{
    public partial class CashierTransactionForm : Form
    {
        public CashierTransactionForm()
        {
            InitializeComponent();

            lblNextNumber.Text = "NO QUEUE";
        }

        public void UpdateNumber(string number)
        {
            lblNextNumber.Text = number;
        }

        public void UpdateNextNumber(string number)
        {
            lblNextNumber.Text = number;
        }
    }
}