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
        public Form1()
        {
            InitializeComponent();
            textB_FirstName.Text = File.ReadAllText("FirstNames.txt");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
