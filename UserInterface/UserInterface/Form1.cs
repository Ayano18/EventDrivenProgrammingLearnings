namespace UserInterface
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private string studentName = "";
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            studentName = textBox1.Text;
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }
        private double average = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double english = double.Parse(textBox2.Text);
                double math = double.Parse(textBox3.Text);
                double science = double.Parse(textBox4.Text);
                double filipino = double.Parse(textBox5.Text);
                double history = double.Parse(textBox6.Text);

                double average = (english + math + science + filipino + history) / 5;
                string status = (average >= 75) ? " PASSED " : " FAILED ";
                
                displaylabel.Text = "          Student Name: " + studentName + "\nStudent Average: "+ status + average.ToString("F2");
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter valid numeric values.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void displaylabel_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Final Grade: " + average.ToString("F2"));
        }
    }
}
