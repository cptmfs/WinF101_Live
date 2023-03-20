using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CheckedListBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void clb_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            //lbx.Items.Clear();

            //for (int i = 0; i < clb.CheckedItems.Count; i++)
            //{
            //    lbx.Items.Add(clb.CheckedItems[i]);
            //}


            //int checkedOptionIndex; // Tıklanıp seçilen'in indexi
            //string checkedContentText, checkedContentText2; // İçeriğindeki text bilgi
            //checkedOptionIndex=e.Index; // Seçilen elemanın index'ini öğreniyoruz..
            //checkedContentText = clb.Items[checkedOptionIndex].ToString(); // Ondan sonra içindeki texti öğreniyoruz..

            ////listboxdan elemanın var  olup olmadıgını kontrolü

            //if (lbx.Items.IndexOf(checkedContentText)>-1)
            //    return;
            //// >-1 kontrolü araştırdıgım textin oldugunu belirtir. 0. indexden başlayıp 1 2 3 diye ilerlediği için..

            ////Eğer listbox'ımda  seçili değer yoksa demekki ekleyefceğiz
            //// checked list box'ın calısma prensibine göre acaba secitgim satırın checkini isaretledimi kontrolunu yapmam lazım..

            //bool contentChecked = clb.GetItemChecked(checkedOptionIndex);
            //// getItemChecked üzerinde durdugumuz satırı secip secmediğimizi kontrol eder..
            //if (contentChecked==false)// eğer checkboxlistten seçili hale geldiyse..
            //{
            //    lbx.Items.Add(checkedContentText);
            //}

        }

        private void btnAktar_Click(object sender, EventArgs e)
        {
            lbx.Items.Clear();

            for (int i = 0; i < clb.CheckedItems.Count; i++)
            {
                lbx.Items.Add(clb.CheckedItems[i]);
            }
        }
    }
}
