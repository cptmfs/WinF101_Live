using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Combobox01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayi = int.Parse(textBox1.Text);
            for (int i = 1; i <= sayi; i++)
            {
                 comboBox1.Items.Add(i + ".sayi");
            }
            comboBox1.Enabled = true; // combobox aktif olsun.. 
            comboBox1.SelectedIndex = 0; // combobox seçili(görünen) eleman 0. indexdeki olsun..


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Select(); // ilk yazılacak yeri textbox1 seçili gelsin.
            comboBox1.Enabled=false; // combobox başta veri işlenemez olsun
        }
    }
}
