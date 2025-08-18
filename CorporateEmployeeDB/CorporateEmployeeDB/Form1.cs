namespace CorporateEmployeeDB
{
    public partial class Form1 : Form
    {
        public class Employee
        {
            private string id;
            private string firstName;
            private string lastName;
            private string position;

            public string ID
            {
                get { return id; }
                set { id = value; }
            }
            public string FirstName
            {
                get { return firstName; }
                set { firstName = value; }
            }
            public string LastName
            {
                get { return lastName; }
                set { lastName = value; }
            }
            public string Position
            {
                get { return position; }
                set { position = value; }
            }
            public Employee()
            {
                this.id = "";
                this.firstName = "";
                this.lastName = "";
                this.position = "";
            }
            public Employee(string id, string firstName, string lastName, string position)
            {
                this.id = id;
                this.firstName = firstName;
                this.lastName = lastName;
                this.position = position;
            }
        }
        public Form1()
        {
            InitializeComponent();

            dataGridView1.ColumnCount = 4;
            dataGridView1.Columns[0].Name = "ID";
            dataGridView1.Columns[1].Name = "FirstName";
            dataGridView1.Columns[2].Name = "LastName";
            dataGridView1.Columns[3].Name = "Position";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            
            string id = textBox1.Text;
            string firstName = textBox2.Text;
            string lastName = textBox3.Text;
            string position = textBox4.Text;

            Employee emp = new Employee(id, firstName, lastName, position);

            dataGridView1.Rows.Add(emp.ID, emp.FirstName, emp.LastName, emp.Position);

            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
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

        

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
