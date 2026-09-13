namespace BasicQueuingCashier
{
    partial class CashierTransactionForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblTitle = new Label();
            lblNextNumber = new Label();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(44, 39);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(195, 32);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "*NOW SERVING";
            // 
            // lblNextNumber
            // 
            lblNextNumber.AutoSize = true;
            lblNextNumber.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNextNumber.Location = new Point(58, 101);
            lblNextNumber.Name = "lblNextNumber";
            lblNextNumber.Size = new Size(164, 40);
            lblNextNumber.TabIndex = 1;
            lblNextNumber.Text = "NO QUEUE";
            // 
            // CashierTransactionForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(275, 180);
            Controls.Add(lblNextNumber);
            Controls.Add(lblTitle);
            Name = "CashierTransactionForm";
            Text = "CashierTransactionForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblNextNumber;
    }
}