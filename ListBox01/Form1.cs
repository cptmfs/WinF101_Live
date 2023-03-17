using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListBox01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text!="" && int.Parse(textBox1.Text)>0)
            {
                int sayi = int.Parse(textBox1.Text);
                for (int i = 1; i <= sayi; i++)
                {
                    listBox1.Items.Add(i + ".sayi");
                }
                listBox1.SelectedIndex = 0;
            }
            else
            {
                MessageBox.Show("Lütfen geçerli bir değer giriniz..");
            }

            
            
        }
    }
}
