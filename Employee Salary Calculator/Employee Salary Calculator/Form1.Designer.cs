namespace Employee_Salary_Calculator
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
            label5 = new Label();
            label6 = new Label();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            button1 = new Button();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F);
            label1.Location = new Point(56, 27);
            label1.Name = "label1";
            label1.Size = new Size(106, 25);
            label1.TabIndex = 0;
            label1.Text = "First Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F);
            label2.Location = new Point(56, 106);
            label2.Name = "label2";
            label2.Size = new Size(116, 25);
            label2.TabIndex = 0;
            label2.Text = "Department:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F);
            label3.Location = new Point(420, 106);
            label3.Name = "label3";
            label3.Size = new Size(86, 25);
            label3.TabIndex = 0;
            label3.Text = "Job Title:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11F);
            label4.Location = new Point(420, 27);
            label4.Name = "label4";
            label4.Size = new Size(104, 25);
            label4.TabIndex = 0;
            label4.Text = "Last Name:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(56, 55);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(287, 34);
            textBox1.TabIndex = 1;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(420, 55);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(287, 34);
            textBox2.TabIndex = 1;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(56, 134);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(287, 34);
            textBox3.TabIndex = 1;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(420, 134);
            textBox4.Multiline = true;
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(287, 34);
            textBox4.TabIndex = 1;
            textBox4.TextChanged += textBox4_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11F);
            label5.Location = new Point(56, 214);
            label5.Name = "label5";
            label5.Size = new Size(132, 25);
            label5.TabIndex = 0;
            label5.Text = "Rate Per Hour:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11F);
            label6.Location = new Point(420, 214);
            label6.Name = "label6";
            label6.Size = new Size(181, 25);
            label6.TabIndex = 0;
            label6.Text = "Total Hours Worked:";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(56, 242);
            textBox5.Multiline = true;
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(287, 34);
            textBox5.TabIndex = 1;
            textBox5.TextChanged += textBox5_TextChanged;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(420, 242);
            textBox6.Multiline = true;
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(287, 34);
            textBox6.TabIndex = 1;
            textBox6.TextChanged += textBox6_TextChanged;
            // 
            // button1
            // 
            button1.Location = new Point(314, 304);
            button1.Name = "button1";
            button1.Size = new Size(125, 38);
            button1.TabIndex = 2;
            button1.Text = "Compute Salary";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(56, 353);
            label7.Name = "label7";
            label7.Size = new Size(87, 20);
            label7.TabIndex = 3;
            label7.Text = "First Name: ";
            label7.Click += label7_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(56, 392);
            label8.Name = "label8";
            label8.Size = new Size(86, 20);
            label8.TabIndex = 3;
            label8.Text = "Last Name: ";
            label8.Click += label8_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(56, 429);
            label9.Name = "label9";
            label9.Size = new Size(94, 20);
            label9.TabIndex = 3;
            label9.Text = "Basic Salary: ";
            label9.Click += label9_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 469);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(button1);
            Controls.Add(textBox6);
            Controls.Add(textBox4);
            Controls.Add(textBox2);
            Controls.Add(textBox5);
            Controls.Add(textBox3);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label6);
            Controls.Add(label5);
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
        private Label label5;
        private Label label6;
        private TextBox textBox5;
        private TextBox textBox6;
        private Button button1;
        private Label label7;
        private Label label8;
        private Label label9;
    }
}
