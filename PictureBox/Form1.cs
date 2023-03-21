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
    public partial class Form1 : Form
    {
        public string dosyaYol;

        public Form1()
        {
            InitializeComponent();

        }

        private void btnMove_Click(object sender, EventArgs e)
        {

        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            Form1 frm = new Form1();

            int x = pictureBox1.Location.X;
            int y = pictureBox1.Location.Y;
            Point location = pictureBox1.Location;
            int pwidth = pictureBox1.Width;
            int pheight = pictureBox1.Height;    

            switch (e.KeyCode)
            {
                case Keys.Right:
                    x += 5;
                    break;
                case Keys.Left:
                    x -= 5;
                    break;
                case Keys.Up:
                    y -= 5;
                    break;
                case Keys.Down:
                    y += 5;
                    break;
            }
            if (y<0)
            {
                y = 0;
            }
            if (x<0)
            {
                x = 0;
            }
            //if (pheight + y >= frm.Height || pwidth + x > frm.Width)//(x < 12 || x > 291 || y > 194 || y < 12) //
            //{
            //    MessageBox.Show("Tebrikler");
            //    location = new Point(135, 91);
            //}
            if (pheight + y > this.ClientSize.Height)
            {
                y = this.ClientSize.Height - pictureBox1.Height;
                MessageBox.Show("Sınıra ulaştınız");
                location = new Point(135, 91);
            }
            if (pwidth+x >this.ClientSize.Width)
            {
                x = this.ClientSize.Width - pictureBox1.Width;
                MessageBox.Show("Sınıra ulaştınız");
                location = new Point(135, 91);
            }
            pictureBox1.Location = new Point(x, y);

        }
        
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        //Form1 frm = new Form1();
        pictureBox1.ImageLocation = dosyaYol;
            pictureBox1.Location = new Point(155, 88);
            //MessageBox.Show($"Form yükseklik :  {frm.Width}\r\nForm Genişlik : {frm.Height}");
        }
    }
}
