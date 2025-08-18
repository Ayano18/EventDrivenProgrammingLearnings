using System;
using System.Globalization;
using System.Windows.Forms;

namespace Purchase_Item
{
    public partial class Form1 : Form
    {
        DiscountedItem discountedItem;

        public Form1()
        {
            InitializeComponent();
            label5.Text = "Total Amount: ";
            label7.Text = "Change: ";
        }
        public class Item
        {
            protected string item_name;
            protected double item_price;
            protected int item_quantity;
            protected double total_price;

            public Item(string name, double price, int quantity)
            {
                item_name = name;
                item_price = price;
                item_quantity = quantity;
            }

            public virtual double getTotalPrice()
            {
                total_price = item_price * item_quantity;
                return total_price;
            }

            public virtual void setPayment(double amount)
            {
            
            }
        }
        public class DiscountedItem : Item
        {
            private double item_discount; 
            private double discounted_price; 
            private double payment_amount;
            private double change;

            public DiscountedItem(string name, double price, int quantity, double discount)
                : base(name, price, quantity)
            {
                item_discount = discount * 0.01;
            }

            public override double getTotalPrice()
            {
                discounted_price = item_price - (item_price * item_discount);
                total_price = discounted_price * item_quantity;
                return total_price;
            }

            public override void setPayment(double amount)
            {
                payment_amount = amount;
                change = payment_amount - total_price;
            }

            public double getChange()
            {
                return change;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string name = textBox1.Text;
                double price = Convert.ToDouble(textBox3.Text);
                int quantity = Convert.ToInt32(textBox4.Text);
                double discount = Convert.ToDouble(textBox2.Text);

                discountedItem = new DiscountedItem(name, price, quantity, discount);
                double totalAmount = discountedItem.getTotalPrice();

                label5.Text = "Total Amount: " + totalAmount.ToString("F2");
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter valid numeric values for Price, Quantity, and Discount.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (discountedItem == null)
            {
                MessageBox.Show("Please compute the total amount first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                double payment = Convert.ToDouble(textBox5.Text); 
                discountedItem.setPayment(payment);

                double change = discountedItem.getChange();
                label7.Text = "Change: " + change.ToString("F2"); 
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter a valid numeric value for Payment Received.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e) {}
        private void textBox2_TextChanged(object sender, EventArgs e) {}
        private void textBox3_TextChanged(object sender, EventArgs e) {}
        private void textBox4_TextChanged(object sender, EventArgs e) {}
        private void textBox5_TextChanged(object sender, EventArgs e) {}
        private void label5_Click(object sender, EventArgs e) {}
        private void label7_Click(object sender, EventArgs e) {}
    }
}