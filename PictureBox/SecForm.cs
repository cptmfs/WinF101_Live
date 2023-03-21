using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PictureBox
{
    public partial class SecForm : Form
    {
        string dosyaYolu;
        public SecForm()
        {
            InitializeComponent();
        }



        private void btnSelect_Click(object sender, EventArgs e)
        {
            
            openFileDialog1.Title = "Lütfen Resim Seçiniz ..";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                dosyaYolu = openFileDialog1.FileName;
            }

            Form1 form = new Form1();
            form.dosyaYol = dosyaYolu;
            form.ShowDialog();
            this.Close();



            // Diğer Yöntem..

            //Form1 frm = new Form1();
            //foreach (Control c in frm.Controls)
            //{
            //    if (c.Name=="lblSec")
            //    {
            //        c.Text = openFileDialog1.FileName;

            //    }
            //}

        }
    }
}
