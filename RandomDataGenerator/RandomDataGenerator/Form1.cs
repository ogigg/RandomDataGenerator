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
        public string[] FirstName_S = File.ReadAllText("FirstNames.txt", Encoding.Default).Split('\n');
        public string[] LastName_S = File.ReadAllText("LastNames.txt", Encoding.Default).Split('\n');
        public string[] Street_S = File.ReadAllText("Streets.txt", Encoding.Default).Split('\n');
        public string[] City_S = File.ReadAllText("Cities.txt", Encoding.Default).Split('\n');
        public string[] State_S = File.ReadAllText("States.txt", Encoding.Default).Split('\n');
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
            textB_Number.Text = rnd.Next(1, 100).ToString();
            textB_Street.Text = Street_S[rnd.Next(0, Street_S.Length-1)];
            textB_City.Text = City_S[rnd.Next(0, City_S.Length - 1)];
            textB_State.Text = State_S[rnd.Next(0, State_S.Length - 1)];
            textB_Zip.Text = rnd.Next(10,90).ToString()+"-"+rnd.Next(100, 900).ToString();
            if (checkB_PolNames.Checked == true)
            {
                if (textB_FirstName.Text.ToString().Substring(textB_FirstName.Text.ToString().Length - 2)[0] == 'a') //Wykrywa czy ostatnia litera imienia = a ->kobieta //działa!
                {
                    if (textB_LastName.Text.ToString().Substring(textB_LastName.Text.ToString().Length - 2)[0] == 'i')
                    {
                        textB_LastName.Text = textB_LastName.Text.ToString().Replace("ski", "ska");
                        textB_LastName.Text = textB_LastName.Text.ToString().Replace("cki", "cka");
                    }
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

        private void textB_Number_MouseClick(object sender, MouseEventArgs e)
        {
            if (textB_Number.Text != "")
                Clipboard.SetText(textB_Number.Text);
        }

        private void textB_Street_MouseClick(object sender, MouseEventArgs e)
        {
            if (textB_Street.Text != "")
                Clipboard.SetText(textB_Street.Text);
        }

        private void textB_City_MouseClick(object sender, MouseEventArgs e)
        {
            if (textB_City.Text != "")
                Clipboard.SetText(textB_City.Text);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textB_State_MouseClick(object sender, MouseEventArgs e)
        {
            if (textB_State.Text != "")
                Clipboard.SetText(textB_State.Text);
        }

        private void textB_Zip_MouseClick(object sender, MouseEventArgs e)
        {
            if (textB_Zip.Text != "")
                Clipboard.SetText(textB_Zip.Text);
        }

        private void wincyjToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void zapiszDoPlikuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveToFileWindow saveToFileWindow = new SaveToFileWindow();
            saveToFileWindow.Show();
        }
    }
}
