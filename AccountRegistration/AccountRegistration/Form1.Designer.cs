namespace AccountRegistration
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
            Program = new TextBox();
            First = new TextBox();
            Middle = new TextBox();
            Last = new TextBox();
            Student = new TextBox();
            Age = new TextBox();
            Contact = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            Address = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // Program
            // 
            Program.Location = new Point(172, 105);
            Program.Name = "Program";
            Program.Size = new Size(236, 27);
            Program.TabIndex = 0;
            // 
            // First
            // 
            First.Location = new Point(172, 143);
            First.Name = "First";
            First.Size = new Size(236, 27);
            First.TabIndex = 1;
            // 
            // Middle
            // 
            Middle.Location = new Point(172, 181);
            Middle.Name = "Middle";
            Middle.Size = new Size(236, 27);
            Middle.TabIndex = 2;
            // 
            // Last
            // 
            Last.Location = new Point(172, 219);
            Last.Name = "Last";
            Last.Size = new Size(236, 27);
            Last.TabIndex = 3;
            // 
            // Student
            // 
            Student.Location = new Point(172, 67);
            Student.Name = "Student";
            Student.Size = new Size(236, 27);
            Student.TabIndex = 4;
            // 
            // Age
            // 
            Age.Location = new Point(172, 257);
            Age.Name = "Age";
            Age.Size = new Size(236, 27);
            Age.TabIndex = 5;
            // 
            // Contact
            // 
            Contact.Location = new Point(172, 295);
            Contact.Name = "Contact";
            Contact.Size = new Size(236, 27);
            Contact.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F);
            label1.Location = new Point(72, 70);
            label1.Name = "label1";
            label1.Size = new Size(94, 20);
            label1.TabIndex = 7;
            label1.Text = "Student No. :";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(97, 108);
            label2.Name = "label2";
            label2.Size = new Size(69, 20);
            label2.TabIndex = 8;
            label2.Text = "Program:";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(83, 146);
            label3.Name = "label3";
            label3.Size = new Size(83, 20);
            label3.TabIndex = 9;
            label3.Text = "First Name:";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(66, 184);
            label4.Name = "label4";
            label4.Size = new Size(100, 20);
            label4.TabIndex = 10;
            label4.Text = "Middle Initial:";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(84, 222);
            label5.Name = "label5";
            label5.Size = new Size(82, 20);
            label5.TabIndex = 11;
            label5.Text = "Last Name:";
            label5.Click += label5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(127, 260);
            label6.Name = "label6";
            label6.Size = new Size(39, 20);
            label6.TabIndex = 12;
            label6.Text = "Age:";
            label6.Click += label6_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(72, 298);
            label7.Name = "label7";
            label7.Size = new Size(94, 20);
            label7.TabIndex = 13;
            label7.Text = "Contact No. :";
            label7.Click += label7_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(101, 336);
            label8.Name = "label8";
            label8.Size = new Size(65, 20);
            label8.TabIndex = 15;
            label8.Text = "Address:";
            // 
            // Address
            // 
            Address.Location = new Point(172, 333);
            Address.Name = "Address";
            Address.Size = new Size(236, 27);
            Address.TabIndex = 14;
            // 
            // button1
            // 
            button1.Location = new Point(72, 369);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 16;
            button1.Text = "Next";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(label8);
            Controls.Add(Address);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Contact);
            Controls.Add(Age);
            Controls.Add(Student);
            Controls.Add(Last);
            Controls.Add(Middle);
            Controls.Add(First);
            Controls.Add(Program);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox Program;
        private TextBox First;
        private TextBox Middle;
        private TextBox Last;
        private TextBox Student;
        private TextBox Age;
        private TextBox Contact;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox Address;
        private Button button1;
    }
}
