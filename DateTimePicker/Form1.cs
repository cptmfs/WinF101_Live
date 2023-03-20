using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DateTimePicker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnYazdir_Click(object sender, EventArgs e)
        {
            DateTime startDate = DateTime.Parse(dtpStart.Text);
            DateTime endDate = DateTime.Parse(dtpEnd.Text);

            TimeSpan sonuc = endDate.Subtract(startDate);  // TimeSpan iki tarih arasındaki işlemde kullanılan veri tipidir.
                                                           // Subtract ise çıkarma işlemi gibidir.


            string year = Math.Round(sonuc.TotalDays / 365,4).ToString()+"Yıl veya";
            string month = Math.Round(sonuc.TotalDays / 30,2).ToString() + "Ay veya";
            string day = Math.Round(sonuc.TotalDays,2).ToString() + "Gün veya";
            string hour = Math.Round(sonuc.TotalHours,2).ToString() + "Saat veya";
            string minute = Math.Round(sonuc.TotalMinutes,2).ToString() + "Dakika";
            listBox1.Items.Clear();
            listBox1.Items.Add(year);  
            listBox1.Items.Add(month);  
            listBox1.Items.Add(day);  
            listBox1.Items.Add(hour);  
            listBox1.Items.Add(minute);





            lblTime.Text = dtpStart.Text;
            lblTime2.Text = dtpStart.Value.ToString();
            label4.Text = dtpEnd.Text;
            label3.Text = dtpEnd.Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
