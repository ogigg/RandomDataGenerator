using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace RandomDataGenerator
{
    public partial class Form1 : Form
    {
        string[] FirstName_S = File.ReadAllText("FirstNames.txt", Encoding.Default).Split('\n');
        string[] LastName_S = File.ReadAllText("LastNames.txt", Encoding.Default).Split('\n');
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textB_FirstName_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_RandAll_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            textB_FirstName.Text = FirstName_S[rnd.Next(0,100)];
            textB_LastName.Text = LastName_S[rnd.Next(0, 100)];
            if (textB_FirstName.Text.ToString().Substring(textB_FirstName.Text.ToString().Length - 2)[0] == 'a') //Wykrywa czy ostatnia litera imienia = a ->kobieta //działa!
            {
                if (textB_LastName.Text.ToString().Substring(textB_LastName.Text.ToString().Length - 2)[0] == 'i')
                {
                    textB_LastName.Text = textB_LastName.Text.ToString().Replace("ski","ska");
                    textB_LastName.Text = textB_LastName.Text.ToString().Replace("cki", "cka");
                }
            }
        }

        private void textB_FirstName_MouseClick(object sender, MouseEventArgs e)
        {
            if (textB_FirstName.Text!="")
                Clipboard.SetText(textB_FirstName.Text);
        }

        private void textB_LastName_MouseClick(object sender, MouseEventArgs e)
        {
            if (textB_FirstName.Text != "")
                Clipboard.SetText(textB_LastName.Text);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
