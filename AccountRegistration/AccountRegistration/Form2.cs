using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccountRegistration
{
    public partial class Form2 : Form
    {
        private StudentInfoClass.DelegateText DelegateProgram, DelegateLastName, DelegateFirstName, DelegateMiddleName, DelegateAddress;
        private StudentInfoClass.DelegateNumber DelegateNumAge, DelegateNumContactNo, DelegateStudNo;
        public Form2()
        {
            InitializeComponent();
            DelegateProgram = new StudentInfoClass.DelegateText(StudentInfoClass.GetProgram);
            DelegateLastName = new StudentInfoClass.DelegateText(StudentInfoClass.GetLastName);
            DelegateFirstName = new StudentInfoClass.DelegateText(StudentInfoClass.GetFirstName);
            DelegateMiddleName = new StudentInfoClass.DelegateText(StudentInfoClass.GetMiddleName);
            DelegateAddress = new StudentInfoClass.DelegateText(StudentInfoClass.GetAddress);
            DelegateNumAge = new StudentInfoClass.DelegateNumber(StudentInfoClass.GetAge);
            DelegateNumContactNo = new StudentInfoClass.DelegateNumber(StudentInfoClass.GetContactNo);
            DelegateStudNo = new StudentInfoClass.DelegateNumber(StudentInfoClass.GetStudentNo);


            label9.Text = DelegateStudNo(StudentInfoClass.StudentNo).ToString();
            label10.Text = DelegateProgram(StudentInfoClass.Program);
            label11.Text = DelegateLastName(StudentInfoClass.LastName);
            label12.Text = DelegateFirstName(StudentInfoClass.FirstName);
            label13.Text = DelegateMiddleName(StudentInfoClass.MiddleName);
            label14.Text = DelegateNumAge(StudentInfoClass.Age).ToString();
            label15.Text = DelegateNumContactNo(StudentInfoClass.ContactNo).ToString();
            label16.Text = DelegateAddress(StudentInfoClass.Address);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
