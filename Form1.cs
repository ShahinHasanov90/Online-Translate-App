using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;

namespace Online_TR
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public bool tesst()
        {
            string adress = "http://www.google.com";
            try
            {
                WebRequest wnt = WebRequest.Create(adress);
                WebResponse bag = wnt.GetResponse();
            }
            catch (Exception)
            {

                return false;
            }
            return true;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            if (tesst())
            {
                this.Text = "connected";
            }
            else
            {
                this.Text = "Disconnected";
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(radioButton2.Checked==true)
            {
                richTextBox1.Text = webBrowser1.Document.GetElementById("Result_Box").InnerText;
            }
            if(radioButton1.Checked==true)
            {
                richTextBox2.Text = webBrowser1.Document.GetElementById("Result_Box").InnerText;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://translate.google.com.tr/#tr/en/");
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            webBrowser1.Document.GetElementById("Source").InnerText = richTextBox1.Text;
        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {
            webBrowser1.Document.GetElementById("Source").InnerText = richTextBox2.Text;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://translate.google.com.tr/#en/tr/");
        }
    }
}
