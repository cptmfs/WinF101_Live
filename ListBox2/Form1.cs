using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListBox2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            if (txtSayi1.Text != "" && txtSayi2.Text != "")
            {

                int sayi1, sayi2, sayiAdet,toplam = 0, rastgeleSayi;
                sayi1 = int.Parse(txtSayi1.Text);
                sayi2 = int.Parse(txtSayi2.Text);
                if (sayi1 < sayi2)
                {
                    sayiAdet = int.Parse(numericUpDown1.Value.ToString());
                    MessageBox.Show($"{sayi1} - {sayi2} arasında {sayiAdet} adet random sayi üretilmiştir..  ");
                    lblSayi.Text = sayiAdet.ToString();
                    for (int i = 1; i <= sayiAdet; i++)
                    {
                        rastgeleSayi = r.Next(sayi1, sayi2);
                        //listBox1.Items.Add(i + ".sayi :" + r.Next(sayi1, sayi2));
                        listBox1.Items.Add(rastgeleSayi);
                        toplam += rastgeleSayi; // üretilen syıların toplamını aldık.
                    }
                    lblToplam.Text = toplam.ToString(); // lblToplama yazdırdık..

                }
                else
                {
                    MessageBox.Show("Sayi1 değeri Sayi2 den büyük olamaz..\nSayi1 ve Sayi2 değerleri boş olamaz", "Sayi Hatası", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Sayi1 ve Sayi2 değerleri boş olamaz", "Sayi Hatası", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }



        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
