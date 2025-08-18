namespace StudentInfoApp
{
    public partial class Form1 : Form
    {
        public class StudentInfo
        {
            private string studentID;
            private string firstName;
            private string lastName;

            // Overloaded constructors
            public StudentInfo() { }

            public StudentInfo(string id, string fname, string lname)
            {
                this.studentID = id;
                this.firstName = fname;
                this.lastName = lname;
            }

            // Properties with encapsulation
            public string StudentID
            {
                get { return studentID; }
                set { studentID = value; }
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
        }
        private void button1_Click(object sender, EventArgs e)
        {

            string id = textBox1.Text;
            string lname = textBox2.Text;
            string fname = textBox3.Text;


            StudentInfo student = new StudentInfo(id, fname, lname);


            listBox1.Items.Add(student.StudentID);
            listBox2.Items.Add(student.FirstName);
            listBox3.Items.Add(student.LastName);


            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
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

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        
    }
}
