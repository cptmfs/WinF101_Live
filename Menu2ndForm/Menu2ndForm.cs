using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Combobox01;
using System.Windows.Forms;
using ListBox01;
using MessageForm;
using MLTextBox;
using RadioButton;
using SimpleCalculator;

namespace Menu2ndForm
{
    public partial class Menu2ndForm : Form

    {
        public Menu2ndForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            SystemExit();
        }
        private void SystemExit()
        {
            Application.Exit();
        } 
        private void kırmızıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.BackColor = Color.Red;
        }

        private void yeşilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.BackColor = Color.Green;
        }

        private void beyazToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.BackColor = Color.White;
        }

        private void maviToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.BackColor = Color.Blue;
        }

        private void IngilizceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dOsyaToolStripMenuItem.Text = "File";
            açToolStripMenuItem.Text = "Open";
            çıkışToolStripMenuItem.Text = "Exit";
            itemAyarlar.Text = "Settings";
            arkaPlanDeğiştirToolStripMenuItem.Text = "Change Background";
            kırmızıToolStripMenuItem.Text = "Red";
            yesilToolStripMenuItem.Text = "Green";
            maviToolStripMenuItem.Text = "Blue";
            beyazToolStripMenuItem.Text = "White";
            dilToolStripMenuItem.Text = "Language";
            IngilizceToolStripMenuItem.Text = "English";
            IspanyolcaToolStripMenuItem.Text = "Spanish";
            fransizcaToolStripMenuItem.Text = "French";
            TurkceToolStripMenuItem.Text = "Turkish";
            btnExit.Text = "Exit";
        }

        private void IspanyolcaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dOsyaToolStripMenuItem.Text = "Archivo";
            açToolStripMenuItem.Text = "Hambriento";
            çıkışToolStripMenuItem.Text = "Salida";
            itemAyarlar.Text = "Ajustes";
            arkaPlanDeğiştirToolStripMenuItem.Text = "Cambiar color de fondo";
            kırmızıToolStripMenuItem.Text = "Roja";
            yesilToolStripMenuItem.Text = "Verde";
            maviToolStripMenuItem.Text = "Azul";
            beyazToolStripMenuItem.Text = "Blanca";
            dilToolStripMenuItem.Text = "Idioma";
            IngilizceToolStripMenuItem.Text = "Inglesa";
            IspanyolcaToolStripMenuItem.Text = "Española";
            fransizcaToolStripMenuItem.Text = "Francesa";
            TurkceToolStripMenuItem.Text = "Turca";
            btnExit.Text = "Salida";
        }

        private void fransizcaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dOsyaToolStripMenuItem.Text = "Déposer";
            açToolStripMenuItem.Text = "Ouvrir";
            çıkışToolStripMenuItem.Text = "Sortie";
            itemAyarlar.Text = "Paramètres";
            arkaPlanDeğiştirToolStripMenuItem.Text = "Changer la couleur de fond";
            kırmızıToolStripMenuItem.Text = "Rouge";
            yesilToolStripMenuItem.Text = "Verte";
            maviToolStripMenuItem.Text = "Bleue";
            beyazToolStripMenuItem.Text = "Blanche";
            dilToolStripMenuItem.Text = "Langue";
            IngilizceToolStripMenuItem.Text = "Anglaise";
            IspanyolcaToolStripMenuItem.Text = "Espagnole";
            fransizcaToolStripMenuItem.Text = "Français";
            TurkceToolStripMenuItem.Text = "Turque";
            btnExit.Text = "Sortie";
        }


        private void btnExit_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void TurkceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dOsyaToolStripMenuItem.Text = "Dosya";
            açToolStripMenuItem.Text = "Aç";
            çıkışToolStripMenuItem.Text = "Çıkış";
            itemAyarlar.Text = "Ayarlar";
            arkaPlanDeğiştirToolStripMenuItem.Text = "Arka Plan Rengi Değiştir";
            kırmızıToolStripMenuItem.Text = "Kırmızı";
            yesilToolStripMenuItem.Text = "Yeşil";
            maviToolStripMenuItem.Text = "Mavi";
            beyazToolStripMenuItem.Text = "Beyaz";
            dilToolStripMenuItem.Text = "Dil";
            IngilizceToolStripMenuItem.Text = "İngilizce";
            IspanyolcaToolStripMenuItem.Text = "İspanyolca";
            fransizcaToolStripMenuItem.Text = "Fransızca";
            btnExit.Text = "Çıkış";
        }
        private void pnlCbx_Click(object sender, EventArgs e)
        {
            Combobox01.Combobox01 cbx = new Combobox01.Combobox01();
            cbx.Show();
        }

        private void pnlLB1_Click(object sender, EventArgs e)
        {
            ListBox01.listboxForm lb = new ListBox01.listboxForm();
            lb.Show();
        }

        private void pnlLB2_Click(object sender, EventArgs e)
        {
            ListBox2.Form1 lb = new ListBox2.Form1();
            lb.Show();
        }

        private void pnlMsg_Click(object sender, EventArgs e)
        {
            MessageForm.MessageForm msg = new MessageForm.MessageForm();
            msg.Show();
        }

        private void pnlML_Click(object sender, EventArgs e)
        {
            MLTextBox.Form1 ml = new MLTextBox.Form1();
            ml.Show();
        }

        private void pnlRdb_Click(object sender, EventArgs e)
        {
            RadioButton.Form1 radio = new RadioButton.Form1();
            radio.Show();
        }

        private void pnlCalc_Click(object sender, EventArgs e)
        {
            SimpleCalculator.Form1 simpleCalculator = new SimpleCalculator.Form1();
            simpleCalculator.Show();
        }

        private void pnlSupport_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This Project was created by cptmfs.\r\nA Menu Form management project has been developed in the C# Windows Form application.\r\n\r\nFor more information, you can contact me at cpt.mfs@gmail.com.", "Support", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void combobox01ToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Combobox01.Combobox01 cbx = new Combobox01.Combobox01();
            cbx.Show();
        }

        private void listB01ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListBox01.listboxForm lb = new ListBox01.listboxForm();
            lb.Show();
        }

        private void listB02ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListBox2.Form1 lb2 = new ListBox2.Form1();
            lb2.Show();
        }

        private void messageFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageForm.MessageForm msg = new MessageForm.MessageForm();
            msg.Show();
        }

        private void mLTextBoxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MLTextBox.Form1 ml = new MLTextBox.Form1();
            ml.Show();
        }

        private void radioButtonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RadioButton.Form1 radio = new RadioButton.Form1();
            radio.Show();
        }

        private void simpleCalculatorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SimpleCalculator.Form1 simpleCalculator = new SimpleCalculator.Form1();
            simpleCalculator.Show();
        }

        private void çıkışToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            SystemExit();
        }
    }
}
