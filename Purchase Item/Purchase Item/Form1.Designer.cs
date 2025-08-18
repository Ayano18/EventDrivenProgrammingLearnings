namespace Purchase_Item
{
    partial class Form1
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            button1 = new Button();
            label5 = new Label();
            label6 = new Label();
            textBox5 = new TextBox();
            button2 = new Button();
            label7 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(31, 35);
            label1.Name = "label1";
            label1.Size = new Size(42, 20);
            label1.TabIndex = 0;
            label1.Text = "Item:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(31, 105);
            label2.Name = "label2";
            label2.Size = new Size(92, 20);
            label2.TabIndex = 0;
            label2.Text = "Discount(%):";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(31, 167);
            label3.Name = "label3";
            label3.Size = new Size(44, 20);
            label3.TabIndex = 0;
            label3.Text = "Price:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(31, 235);
            label4.Name = "label4";
            label4.Size = new Size(68, 20);
            label4.TabIndex = 0;
            label4.Text = "Quantity:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(31, 58);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(271, 34);
            textBox1.TabIndex = 1;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(31, 128);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 34);
            textBox2.TabIndex = 1;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(31, 190);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(125, 34);
            textBox3.TabIndex = 1;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(31, 258);
            textBox4.Multiline = true;
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(125, 34);
            textBox4.TabIndex = 1;
            textBox4.TextChanged += textBox4_TextChanged;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ScrollBar;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(31, 317);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 2;
            button1.Text = "Compute";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11F);
            label5.Location = new Point(31, 376);
            label5.Name = "label5";
            label5.Size = new Size(128, 25);
            label5.TabIndex = 3;
            label5.Text = "Total Amount:";
            label5.Click += label5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(347, 35);
            label6.Name = "label6";
            label6.Size = new Size(132, 20);
            label6.TabIndex = 4;
            label6.Text = "Payment Received:";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(347, 58);
            textBox5.Multiline = true;
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(271, 34);
            textBox5.TabIndex = 1;
            textBox5.TextChanged += textBox1_TextChanged;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ScrollBar;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Location = new Point(641, 58);
            button2.Name = "button2";
            button2.Size = new Size(94, 34);
            button2.TabIndex = 5;
            button2.Text = "Submit";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 11F);
            label7.Location = new Point(347, 105);
            label7.Name = "label7";
            label7.Size = new Size(81, 25);
            label7.TabIndex = 6;
            label7.Text = "Change:";
            label7.Click += label7_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label7);
            Controls.Add(button2);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(button1);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox5);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private Button button1;
        private Label label5;
        private Label label6;
        private TextBox textBox5;
        private Button button2;
        private Label label7;
    }
}
