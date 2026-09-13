using System;
using System.Collections;
using System.Windows.Forms;

namespace BasicQueuingCashier
{
    public partial class CashierWindowQueueForm : Form
    {
        private System.Windows.Forms.Timer timer;
        private CashierTransactionForm transactionForm;

        public CashierWindowQueueForm()
        {
            InitializeComponent();

            listCashierQueue.View = View.List;

            transactionForm = new CashierTransactionForm();
            transactionForm.Show();

            timer = new System.Windows.Forms.Timer();
            timer.Interval = 1000;
            timer.Tick += new EventHandler(timer1_Tick);
            timer.Start();

            DisplayCashierQueue(CashierClass.CashierQueue);

            if (CashierClass.CashierQueue != null &&
                CashierClass.CashierQueue.Count > 0)
            {
                string nextNumber = CashierClass.CashierQueue.Peek();

                transactionForm.UpdateNumber(nextNumber);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            DisplayCashierQueue(CashierClass.CashierQueue);

            if (CashierClass.CashierQueue != null &&
                CashierClass.CashierQueue.Count > 0)
            {
                string nextNumber = CashierClass.CashierQueue.Peek();

                transactionForm.UpdateNumber(nextNumber);
            }
            else
            {
                transactionForm.UpdateNumber("NO QUEUE");
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (CashierClass.CashierQueue != null &&
                CashierClass.CashierQueue.Count > 0)
            {
                string nextNumber = CashierClass.CashierQueue.Peek();

                if (CashierClass.CashierQueue.Contains(nextNumber))
                {
                    transactionForm.UpdateNumber(nextNumber);

                    CashierClass.CashierQueue.Dequeue();

                    DisplayCashierQueue(CashierClass.CashierQueue);

                    if (CashierClass.CashierQueue.Count > 0)
                    {
                        string followingNumber =
                            CashierClass.CashierQueue.Peek();

                       
                    }
                }
            }
            else
            {
                MessageBox.Show(
                    "There are no customers in the queue.",
                    "Queue Empty",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                transactionForm.UpdateNumber("NO QUEUE");
            }
        }

        public void DisplayCashierQueue(IEnumerable CashierList)
        {
            listCashierQueue.Items.Clear();

            foreach (Object obj in CashierList)
            {
                listCashierQueue.Items.Add(obj.ToString());
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DisplayCashierQueue(CashierClass.CashierQueue);

            if (CashierClass.CashierQueue != null &&
                CashierClass.CashierQueue.Count > 0)
            {
                string nextNumber = CashierClass.CashierQueue.Peek();

                transactionForm.UpdateNumber(nextNumber);
            }
            else
            {
                transactionForm.UpdateNumber("NO QUEUE");
            }
        }

        private void CashierWindowQueueForm_FormClosed(
            object sender,
            FormClosedEventArgs e)
        {
            timer.Stop();

            if (transactionForm != null &&
                !transactionForm.IsDisposed)
            {
                transactionForm.Close();
            }
        }
    }
}