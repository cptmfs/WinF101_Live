using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TabControl
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tabcMain_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Burası "+tabcMain.SelectedTab.Text,tabcMain.SelectedTab.Text,MessageBoxButtons.OK,MessageBoxIcon.Information);

            int sayfaNo = tabcMain.SelectedIndex;

            if (sayfaNo==1)
            {
                //MessageBox.Show($"{tabPage2.Text} sayfasına hoşgeldiniz.","Pasaport Bilgileri",MessageBoxButtons.OK,MessageBoxIcon.Information);
                
                for (int i = 0; i <= datPasaport.GetLength(0); i++)
                {
                    txtpNo.Text = datPasaport[0];
                    txtDzTrh.Text = datPasaport[1];
                    txtgcT.Text = datPasaport[2];
                    txtpType.Text = datPasaport[3];
                }
            }
            if (sayfaNo==2)
            {
                //MessageBox.Show($"{tabPage3.Text} sayfasına hoşgeldiniz.", "Pasaport Bilgileri", MessageBoxButtons.OK, MessageBoxIcon.Information);
                for (int i = 0; i <= datUser.GetLength(0); i++)
                {
                    txtTC.Text = datUser[0];
                    txtAd.Text= datUser[1];
                    txtSoyad.Text= datUser[2];
                    txtDogumTarih.Text= datUser[3];
                    txtFatherName.Text= datUser[4];
                    txtMedeniHal.Text = datUser[5];
                }
            }
            if (sayfaNo==0)
            {

                dataGridView1.DataSource = datUser.ToList();
            }

            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public string[] datPasaport = new string[]
        {
            "U198457",
            "15.07.2015",
            "15.07.2025",
            "Hususi Pasaport"
        };
        public string[] datUser = new string[]
        {
            "21316518556",
            "Muhammed Ferit",
            "Şimşek",
            "06.06.1993",
            "Abdulkadir",
            "EVLİ"
        };

        private void btnEkle_Click(object sender, EventArgs e)
        {
            TabPage page = new TabPage("Yeni Sayfa");
            tabcMain.Controls.Add(page);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tabcMain.Controls.Remove(tabcMain.SelectedTab);
        }
    }
}
