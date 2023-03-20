using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MonthDays
{
    public partial class Form1 : Form
    {
        DateTimeFormatInfo formatTR = CultureInfo.GetCultureInfo("tr-TR").DateTimeFormat; // Datetime Kültür bilgisini getirmesini istedik.  Bu değişkene türkçe tarih formatı atandı.
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int yil = Convert.ToInt32(DateTime.Now.Year);
            nudYear.Value = yil;
            for (int i = 0; i < 12; i++)
            {
                cbxMonth.Items.Add(formatTR.MonthNames[i]);
            }
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            lbxDays.Items.Clear();
            int yil = Convert.ToInt32(nudYear.Value); // Yıl bilgisini yil değişkenine atadık
            int ay = cbxMonth.SelectedIndex + 1; // 0 dan başlayacağı için artı bir dedik

            // NumericUpDown ve combobox tan seçilen opsiyonlara göre benim bir tarih bilgisi olarak programa anlatmam gerekir.

            DateTime tarih = new DateTime(yil, ay, 1); // diyelim Ocak 2023 için 1 ocak 2023 diye bellekte bir tarih bilgisi oluşturduk.Elimde artık tarih türünde bir bilgi var..

            // Seçilen ayda kaç tane gün var onu ogrenelim

            int totalDaysCount = DateTime.DaysInMonth(yil, ay);

            for (int i = 1; i <= totalDaysCount; i++)
            {
                lbxDays.Items.Add(tarih.Day + " " + cbxMonth.Text + " " + formatTR.DayNames[(int)tarih.DayOfWeek]);

                tarih = tarih.AddDays(1); // Birer gün olarak ilk tarihten son güne kadar dönmesi için

            }




        }
    }
}
