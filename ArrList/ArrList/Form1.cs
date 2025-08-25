using System.Collections;

namespace ArrList
{
    public partial class Form1 : Form
    {
        private ArrayList arrList;
        public Form1()
        {
            InitializeComponent();
            arrList = new ArrayList();
        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        public void DisplayValues(IEnumerable getList)
        {
            listBox1.Clear();
            foreach (Object obj in getList)
            {
                listBox1.Items.Add(obj.ToString());
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            arrList.Add(textBox1.Text.ToString());
            DisplayValues(arrList);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            arrList.Remove(textBox1.Text.ToString());
            DisplayValues(arrList);
        }

        
    }
}
