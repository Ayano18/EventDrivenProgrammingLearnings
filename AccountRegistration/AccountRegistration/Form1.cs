namespace AccountRegistration
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
        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            StudentInfoClass.Program = Program.Text.ToString();
            StudentInfoClass.FirstName = First.Text.ToString();
            StudentInfoClass.LastName = Last.Text.ToString();
            StudentInfoClass.MiddleName = Middle.Text.ToString();
            StudentInfoClass.Address = Address.Text.ToString();
            StudentInfoClass.Age = long.Parse(Age.Text);
            StudentInfoClass.ContactNo = long.Parse(Contact.Text);
            StudentInfoClass.StudentNo = long.Parse(Student.Text);

            
            Form2 FrmConfirm = new Form2();
            FrmConfirm.ShowDialog();


            if (FrmConfirm.DialogResult == DialogResult.OK)
            {
                Student.Clear();
                Program.Text = "";
                Last.Clear();
                First.Clear();
                Middle.Clear();
                Age.Clear();
                Contact.Clear();
                Address.Clear();
            }
        }
    }
}
