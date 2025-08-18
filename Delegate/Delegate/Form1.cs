namespace Delegate
{
    public partial class Form1 : Form
    {
        private int getNum1, getNum2;
        public static event CalculateTotal EventTotal;
        public Form1()
        {
            InitializeComponent();
        }
        public delegate void CalculateTotal(int num1, int num2);

        class EventClass
        {
            private static int total;

            public static void GetSum(int num1, int num2)
            {
                total = num1 + num2;
                MessageBox.Show("Sum: " + total.ToString());
            }

            public static void GetDifference(int num1, int num2)
            {
                total = num1 - num2;
                MessageBox.Show("Difference: " + total.ToString());
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            getNum1 = Int32.Parse(textBox1.Text);
            getNum2 = Int32.Parse(textBox2.Text);

            EventTotal += new CalculateTotal(EventClass.GetSum);
            EventTotal += new CalculateTotal(EventClass.GetDifference);
            EventTotal(getNum1, getNum2);

        }
    }
}
