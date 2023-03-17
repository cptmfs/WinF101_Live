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
    public partial class Form1 : Form

    {
        public Form1()
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

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SystemExit();
        }

        private void combobox01ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Combobox01.Combobox01 cbx = new Combobox01.Combobox01();
            cbx.ShowDialog();
        }

        private void listBox01ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListBox01.listboxForm lb = new ListBox01.listboxForm();
            lb.ShowDialog();
            this.Hide();
        }

        private void listBox02ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListBox2.Form1 lb = new ListBox2.Form1();
            lb.ShowDialog();
            this.Hide();
             

        }

        private void messageFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            

        }
    }
}
