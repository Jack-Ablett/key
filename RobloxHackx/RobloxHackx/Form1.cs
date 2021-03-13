using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RobloxHackx
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void siticoneButton3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void siticoneButton4_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void siticoneButton2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://discord.gg/fKqkGUBtns");
        }

        private void siticoneButton1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://link-to.net/227189/CipheriumKey");
        }

        private void siticoneButton5_Click(object sender, EventArgs e)
        {
            string gettext = textbox.Text;
            int gettext_amount = gettext.Length;

            if (gettext_amount > 29)
            {
                WebClient wc = new WebClient();
                string ks = wc.DownloadString("https://raw.githubusercontent.com/Jack-Ablett/key/main/Key%20System");

                if (ks.Contains(textbox.Text))
                {
                    this.Hide();
                    Form2 f2 = new Form2();
                    f2.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Enter A Valid Key. ", "Invalid Key");

                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
}