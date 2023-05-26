using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _320210097_dm_project2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int K = Int16.Parse(textBox1.Text);
            string sentence = textBox2.Text;
            var a = new List<char>();
            if (Char.IsUpper(sentence, 0))
            {
                foreach (char i in sentence)
                {
                    if (i == ' ')
                    { a.Add(' '); }
                    else
                    {
                        int temp = (int)i - 65;
                        int temp2 = (temp + K) % 26;
                        a.Add((char)(temp2 + 65));
                    }
                }
            }
            if (Char.IsLower(sentence, 0))
            {
                foreach (char i in sentence)
                {
                    if (i == ' ')
                    { a.Add(' '); }
                    else
                    {
                        int temp = (int)i - 97;
                        int temp2 = (temp + K) % 26;
                        a.Add((char)(temp2 + 97));
                    }
                }
            }
            string result = string.Join("", a);
            textBox3.Text = result;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int K = Int16.Parse(textBox1.Text);
            string sentence = textBox2.Text;
            var a = new List<char>();
            if (Char.IsUpper(sentence, 0))
            {
                foreach (char i in sentence)
                {
                    if (i == ' ')
                    { a.Add(' '); }
                    else
                    {
                        int temp = (int)i - 65;
                        int temp2 = (temp - K + 26) % 26;
                        a.Add((char)(temp2 + 65));
                    }
                }
            }
            if (Char.IsLower(sentence, 0))
            {
                foreach (char i in sentence)
                {
                    if (i == ' ')
                    { a.Add(' '); }
                    else
                    {
                        int temp = (int)i - 97;
                        int temp2 = (temp - K + 26) % 26;
                        a.Add((char)(temp2 + 97));
                    }
                }
            }
            string result = string.Join("", a);
            textBox3.Text = result;

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
