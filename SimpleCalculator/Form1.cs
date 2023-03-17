using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            
            if (txtSayi1.Text != "" && txtSayi2.Text != "")
            {
                int sayi1, sayi2;
                string secenek = comboBox1.Text; // combobox'daki değeri okuyor
                double Topla = double.Parse(txtSayi1.Text) + double.Parse(txtSayi2.Text);
                double Cikar = double.Parse(txtSayi1.Text) - double.Parse(txtSayi2.Text);
                double Carp = double.Parse(txtSayi1.Text) * double.Parse(txtSayi2.Text);
                double Bol = double.Parse(txtSayi1.Text) / double.Parse(txtSayi2.Text);

                // Diğer yöntem
                //sayi1 = double.Parse(txtSayi1.Text);
                //sayi2 = double.Parse(txtSayi2.Text);
                switch (secenek) // secenek icin calıs..
                {
                    case "+": // Eğer secenekten gelen değer + ise 
                        
                        MessageBox.Show($"İşlem Sonucu : {Topla.ToString()}","Toplama İşlemi",MessageBoxButtons.OK,MessageBoxIcon.Information);
                        txtSayi1.Clear();
                        txtSayi2.Clear();
                        //lblSonuc.Text = ($"İşlem Sonucu : {Topla.ToString()}");
                        break;

                    case "-": // Eğer secenekten gelen değer - ise 
                        MessageBox.Show($"İşlem Sonucu : {Cikar.ToString()}","Çıkarma İşlemi",MessageBoxButtons.OK,MessageBoxIcon.Information);
                        txtSayi1.Clear();
                        txtSayi2.Clear();
                        //lblSonuc.Text = ($"İşlem Sonucu : {Cikar.ToString()}");

                        break;

                    case "*": // Eğer secenekten gelen değer * ise 
                        MessageBox.Show($"İşlem Sonucu : {Carp.ToString()}","Çarpma İşlemi",MessageBoxButtons.OK,MessageBoxIcon.Information);
                        txtSayi1.Clear();
                        txtSayi2.Clear();
                        //lblSonuc.Text = ($"İşlem Sonucu : {Carp.ToString()}");

                        break;

                    case "/": // Eğer secenekten gelen değer / ise 

                        MessageBox.Show($"İşlem Sonucu : {Bol.ToString()}","Bölme İşlemi",MessageBoxButtons.OK,MessageBoxIcon.Information);
                        txtSayi1.Clear();
                        txtSayi2.Clear();
                        //lblSonuc.Text = ($"İşlem Sonucu : {Bol.ToString()}");
                        break;


                }
            }
            else
            {
                MessageBox.Show("Lütfen Sayı 1 ve Sayı 2 için değer giriniz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            
        }
    }
}
