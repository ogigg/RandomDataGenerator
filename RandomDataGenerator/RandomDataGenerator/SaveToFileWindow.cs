using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace RandomDataGenerator
{
    public partial class SaveToFileWindow : Form
    {
        Form1 form1 = new Form1();
        string text;

        public SaveToFileWindow()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            SaveFileDialog saveFileDialog = new SaveFileDialog();

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                for (int i = 0; i < (int)numericUpDown1.Value; i++)
                {

                    if (checkB_Name.Checked == true)
                    {
                        text = text + (form1.FirstName_S[rnd.Next(0, 100)].Trim());
                    }
                    if (checkB_LastName.Checked == true)
                    {
                        string LastName= form1.LastName_S[rnd.Next(0, 100)].Trim();

                        if (checkB_PolNames.Checked == true)
                        {
                            if (text.Substring(text.Length - 1)[0] == 'a') //Wykrywa czy ostatnia litera imienia = a -> kobieta
                            {
                                if (LastName.Substring(LastName.Length - 1)[0] == 'i') //Wykrywa czy ostatnia litera nazwiska = i ->nazwisko męskie
                                {
                                    LastName = LastName.Replace("ski", "ska");
                                    LastName = LastName.Replace("cki", "cka");
                                }
                            }
                        }
                    text = text + textB_Spacer.Text.ToString() + LastName.Trim();


                    }
                    if (checkB_Street.Checked == true)
                    {
                        text = text + textB_Spacer.Text.ToString() + form1.Street_S[rnd.Next(0, form1.Street_S.Length - 1)].Trim();
                    }
                    if (checkB_Number.Checked == true)
                    {
                        text = text + textB_Spacer.Text.ToString() + rnd.Next(1, 100).ToString();
                    }
                    if (checkB_City.Checked == true)
                    {
                        text = text + textB_Spacer.Text.ToString() + form1.City_S[rnd.Next(0, form1.City_S.Length - 1)].Trim();
                    }
                    if (checkB_State.Checked == true)
                    {
                        text = text + textB_Spacer.Text.ToString() + form1.State_S[rnd.Next(0, form1.State_S.Length - 1)].Trim();
                    }
                    if (checkB_Zip.Checked == true)
                    {
                        text = text + textB_Spacer.Text.ToString() + rnd.Next(10, 90).ToString() + "-" + rnd.Next(100, 900).ToString();
                    }
                    text = text + Environment.NewLine;
                }
                File.WriteAllText(saveFileDialog.FileName, text);
            }
        }
    }
}
