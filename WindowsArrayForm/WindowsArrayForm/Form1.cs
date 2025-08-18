using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
namespace WindowsArrayForm
{
    public partial class Form1 : Form
    {
        private string wordToGuess = "relapse"; 
        private List<string> wrongGuesses = new List<string>(); 

        public Form1()
        {
            InitializeComponent();
            UpdateHintLabel();

        }
        private void UpdateHintLabel()
        {
            StringBuilder hint = new StringBuilder(wordToGuess.Length);
            for (int i = 0; i < wordToGuess.Length; i++)
            {
                if (i == 0 || i == wordToGuess.Length - 1) 
                {
                    hint.Append(wordToGuess[i]);
                }
                else
                {
                    hint.Append('?');
                }
            }
            label1.Text = hint.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string userInput = textBox1.Text.Trim().ToLower();

            if (string.IsNullOrEmpty(userInput))
            {
                MessageBox.Show("Please enter a word.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (userInput == wordToGuess)
            {
                label1.Text = wordToGuess; 
                MessageBox.Show("Correct guess!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (!wrongGuesses.Contains(userInput))
                {
                    listBox1.Items.Add(userInput);
                }
                MessageBox.Show("Wrong guess! Try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            textBox1.Clear();
            textBox1.Focus();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null) 
            {

                string selectedGuess = listBox1.SelectedItem.ToString();
                MessageBox.Show("You selected: " + selectedGuess, "Selected Guess", MessageBoxButtons.OK, MessageBoxIcon.Information);

                
                textBox1.Text = selectedGuess;
            }
        }
    }
}