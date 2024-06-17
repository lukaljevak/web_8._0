using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace web_8._0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            webBrowser1.GoBack();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void btn_f_Click(object sender, EventArgs e)
        {
            webBrowser1.GoForward();

        }

        private void btn_home_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.pocetnastranica.com");
        }

        private void btn_idi_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate(textBox1.Text);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
