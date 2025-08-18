using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using UserAccountNamespace;
using CashierApplication;



namespace CashierApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string un = textBox1.Text;
            string pw = textBox2.Text;
            Cashier c = new Cashier("Tim", "Cashier", "Timothy", "Alvarez");

            if (c.validateLogin(un, pw))
            {
                textBox1.Clear();
                textBox2.Clear();
                MessageBox.Show($"Welcome {c.getFullName()} of {c.getDepartment()}");
                Form1 f1 = new Form1();
                f1.Close();
                AnotherForm f = new AnotherForm();
                f.ShowDialog();
            }
            else
            {
                textBox1.Clear();
                textBox2.Clear();
                MessageBox.Show("Invalid Username or Password. Please try again.");
            }
            
        }

    }
}
