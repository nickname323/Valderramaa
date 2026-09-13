namespace BasicQueuingCashier
{
    partial class QueuingForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnCashier = new Button();
            lblQueue = new Label();
            SuspendLayout();
            // 
            // btnCashier
            // 
            btnCashier.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCashier.Location = new Point(12, 35);
            btnCashier.Name = "btnCashier";
            btnCashier.Size = new Size(128, 86);
            btnCashier.TabIndex = 0;
            btnCashier.Text = "Cashier";
            btnCashier.UseVisualStyleBackColor = true;
            btnCashier.Click += btnCashier_Click;
            // 
            // lblQueue
            // 
            lblQueue.AutoSize = true;
            lblQueue.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblQueue.Location = new Point(165, 47);
            lblQueue.Name = "lblQueue";
            lblQueue.Size = new Size(242, 65);
            lblQueue.TabIndex = 1;
            lblQueue.Text = "P - 10000";
            // 
            // QueuingForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            ClientSize = new Size(448, 169);
            Controls.Add(btnCashier);
            Controls.Add(lblQueue);
            Name = "QueuingForm";
            Text = "QueingForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCashier;
        private Label lblQueue;
    }
}
