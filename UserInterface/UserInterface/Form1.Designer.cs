namespace UserInterface
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
            label5 = new Label();
            label6 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            button1 = new Button();
            displaylabel = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(12, 23);
            label1.Name = "label1";
            label1.Size = new Size(62, 35);
            label1.TabIndex = 0;
            label1.Text = "Name:";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(12, 88);
            label2.Name = "label2";
            label2.Size = new Size(62, 25);
            label2.TabIndex = 1;
            label2.Text = "English";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(19, 146);
            label3.Name = "label3";
            label3.Size = new Size(62, 25);
            label3.TabIndex = 2;
            label3.Text = "Math";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(13, 206);
            label4.Name = "label4";
            label4.Size = new Size(62, 25);
            label4.TabIndex = 3;
            label4.Text = "Science";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(13, 261);
            label5.Name = "label5";
            label5.Size = new Size(62, 25);
            label5.TabIndex = 4;
            label5.Text = "Filipino";
            label5.Click += label5_Click;
            // 
            // label6
            // 
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(12, 319);
            label6.Name = "label6";
            label6.Size = new Size(62, 25);
            label6.TabIndex = 5;
            label6.Text = "History";
            label6.Click += label6_Click;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.DarkGray;
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Location = new Point(70, 19);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(231, 35);
            textBox1.TabIndex = 6;
            textBox1.TextAlign = HorizontalAlignment.Center;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.DimGray;
            textBox2.BorderStyle = BorderStyle.FixedSingle;
            textBox2.Location = new Point(80, 83);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 35);
            textBox2.TabIndex = 7;
            textBox2.TextAlign = HorizontalAlignment.Center;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.Gray;
            textBox3.BorderStyle = BorderStyle.FixedSingle;
            textBox3.Location = new Point(80, 141);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 35);
            textBox3.TabIndex = 8;
            textBox3.TextAlign = HorizontalAlignment.Center;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // textBox4
            // 
            textBox4.BackColor = Color.DarkGray;
            textBox4.BorderStyle = BorderStyle.FixedSingle;
            textBox4.Location = new Point(80, 201);
            textBox4.Multiline = true;
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(100, 35);
            textBox4.TabIndex = 9;
            textBox4.TextAlign = HorizontalAlignment.Center;
            textBox4.TextChanged += textBox4_TextChanged;
            // 
            // textBox5
            // 
            textBox5.BackColor = Color.Silver;
            textBox5.BorderStyle = BorderStyle.FixedSingle;
            textBox5.Location = new Point(80, 255);
            textBox5.Multiline = true;
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(100, 35);
            textBox5.TabIndex = 10;
            textBox5.TextAlign = HorizontalAlignment.Center;
            textBox5.TextChanged += textBox5_TextChanged;
            // 
            // textBox6
            // 
            textBox6.BackColor = Color.Gainsboro;
            textBox6.BorderStyle = BorderStyle.FixedSingle;
            textBox6.Location = new Point(80, 314);
            textBox6.Multiline = true;
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(100, 35);
            textBox6.TabIndex = 11;
            textBox6.TextAlign = HorizontalAlignment.Center;
            textBox6.TextChanged += textBox6_TextChanged;
            // 
            // button1
            // 
            button1.AutoSize = true;
            button1.BackColor = Color.White;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.Black;
            button1.Location = new Point(12, 367);
            button1.Name = "button1";
            button1.Size = new Size(168, 56);
            button1.TabIndex = 12;
            button1.Text = "Generate Ave.";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // displaylabel
            // 
            displaylabel.BackColor = Color.Transparent;
            displaylabel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            displaylabel.ForeColor = Color.White;
            displaylabel.Location = new Point(291, 293);
            displaylabel.Name = "displaylabel";
            displaylabel.Size = new Size(252, 72);
            displaylabel.TabIndex = 13;
            displaylabel.Click += displaylabel_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.mc;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(displaylabel);
            Controls.Add(button1);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label6);
            Controls.Add(label5);
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
        private Label label5;
        private Label label6;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private Button button1;
        private Label displaylabel;
    }
}
