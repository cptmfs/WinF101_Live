using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MLTextBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            

        }

        private void btnIslem_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            double randomSayi = random.NextDouble(); // nextdouble 0,0 ile 1,0 arası sayı üretir
            randomSayi *= 10;  // üretilen sayıyı 10 ile çarptık.

                textBox1.Text = textBox1.Text+randomSayi.ToString()+"\r\n"; // altsatıra geçmek için
        }
    }
}
