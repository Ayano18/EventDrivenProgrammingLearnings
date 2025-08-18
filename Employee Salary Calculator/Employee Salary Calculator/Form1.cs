using EmployeeApplication.EmployeeNamespace;

namespace Employee_Salary_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
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

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string firstName = textBox1.Text;
                string lastName = textBox2.Text;
                string department = textBox3.Text;
                string jobTitle = textBox4.Text;

                double ratePerHour;
                if (!double.TryParse(textBox5.Text, out ratePerHour))
                {
                    MessageBox.Show("Please enter a valid number for Rate per hour.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBox5.Focus();
                    return;
                }

                double totalHoursWorked;
                if (!double.TryParse(textBox6.Text, out totalHoursWorked))
                {
                    MessageBox.Show("Please enter a valid number for Total hours worked.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBox6.Focus();
                    return;
                }

                PartTimeEmployee employee = new PartTimeEmployee(firstName, lastName, department, jobTitle, ratePerHour, totalHoursWorked);

                employee.computeSalary(employee.RatePerHour, employee.TotalHoursWorked);

                if (label7 != null)
                {
                    label7.Text = "First Name: " + employee.FirstName;
                }

                if (label8 != null)
                {
                    label8.Text = "Last Name: " + employee.LastName;
                }

                if (label9 != null)
                {
                    label9.Text = "Basic Salary: " + employee.getSalary().ToString("C2");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


    }
}
