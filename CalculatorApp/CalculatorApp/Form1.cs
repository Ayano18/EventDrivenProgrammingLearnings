namespace CalculatorApp
{
    public partial class Form1 : Form
    {
        CalculatorClass cal;
        public Form1()
        {
            InitializeComponent();
            cal = new CalculatorClass();
            comboBox1.Items.Add("+");
            comboBox1.Items.Add("-");
            comboBox1.Items.Add("*");
            comboBox1.Items.Add("/");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double num1 = Convert.ToDouble(textBox1.Text);
            double num2 = Convert.ToDouble(textBox2.Text);

            if (comboBox1.SelectedItem != null)
            {
                string selectedOperator = comboBox1.SelectedItem.ToString();
                double result = 0;

                switch (selectedOperator)
                {
                    case "+":
                        cal.CalculateEvent += new Formula<double>(cal.GetSum);
                        result = cal.GetSum(num1, num2);
                        cal.CalculateEvent -= new Formula<double>(cal.GetSum);
                        break;
                    case "-":
                        cal.CalculateEvent += new Formula<double>(cal.GetDifference);
                        result = cal.GetDifference(num1, num2);
                        cal.CalculateEvent -= new Formula<double>(cal.GetDifference);
                        break;
                    case "*":
                        cal.CalculateEvent += new Formula<double>(cal.GetProduct);
                        result = cal.GetProduct(num1, num2);
                        cal.CalculateEvent -= new Formula<double>(cal.GetProduct);
                        break;
                    case "/":
                        cal.CalculateEvent += new Formula<double>(cal.GetQuotient);
                        result = cal.GetQuotient(num1, num2);
                        cal.CalculateEvent -= new Formula<double>(cal.GetQuotient);
                        break;
                }

                label4.Text = result.ToString();
            }
            else
            {
                label4.Text = "Select an operator.";
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
