namespace CashierQueuingP2
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
            label1 = new Label();
            btnCashier = new Button();
            lblQueue = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 33);
            label1.Name = "label1";
            label1.Size = new Size(124, 20);
            label1.TabIndex = 1;
            label1.Text = "Position in Queue";
            // 
            // btnCashier
            // 
            btnCashier.Location = new Point(34, 71);
            btnCashier.Name = "btnCashier";
            btnCashier.Size = new Size(100, 100);
            btnCashier.TabIndex = 3;
            btnCashier.Text = "Cashier";
            btnCashier.UseVisualStyleBackColor = true;
            btnCashier.Click += btnCashier_Click;
            // 
            // lblQueue
            // 
            lblQueue.AutoSize = true;
            lblQueue.Font = new Font("Segoe UI", 30F);
            lblQueue.Location = new Point(137, 91);
            lblQueue.Name = "lblQueue";
            lblQueue.Size = new Size(177, 67);
            lblQueue.TabIndex = 4;
            lblQueue.Text = "output";
            lblQueue.Click += lblQueue_Click;
            // 
            // QueuingForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(382, 253);
            Controls.Add(lblQueue);
            Controls.Add(btnCashier);
            Controls.Add(label1);
            Name = "QueuingForm";
            Text = "QueuingForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCashiers;
        private Label label1;
        private Button btnCashier;
        private Label lblQueue;
    }
}
