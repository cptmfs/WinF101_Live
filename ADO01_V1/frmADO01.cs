using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADO01
{

    public partial class frmADO01 : Form
    {
        // Global kısım
        // Aşağıdaki değişken Veritabanına bağlanabilmek için gerekli olan bağlantı cümleciğidir.Şu makinaya ..şu databaseden bağlanmak istiyorum

        string constring = @"Data Source=DESKTOP-V653CLI\SQLEXPRESS01;Initial Catalog=Northwind;Integrated Security=True"; // slash varsa string gibi anlaması için başına "@" koyuyoruz

        public frmADO01()
        {
            InitializeComponent();
        }

      

        private void frmADO01_Load(object sender, EventArgs e)
        {
            //form ilk ekrana geldiğinde DataGrid otomatik dolu gelsin.
            PrepareGrid(); // DataGridimi hazırlıyorum...
            BindGrid(); // DataGridi doldur ve ekrana gelsin...
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        // 
        private void PrepareGrid()
        {
            datagwCustomers.AutoGenerateColumns = true; // datagrid in otomatik olarak database tablosuna bakıp gridin kolonlarını yaratmasını istemiyorum. Manuel
            // Eğer DataGridin en baş taraftaki kolonu 'RowHeader' görmek istemiyorsam

            datagwCustomers.RowHeadersVisible = false;

            // DatagRiddeki kolonları tek tek dolaşmak yerine tek bir satırı ayrıştırma
            datagwCustomers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            // DataGriddeki kolonları DataGridin genişliğine göre ayarlama
            datagwCustomers.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;

            // DataGridin üzerinde elle oynamayı yasaklama 
            datagwCustomers.ReadOnly = true;
            
            // DataGridin üzerinde kullanıcının satır eklemesini ve silmesini yasaklama
            datagwCustomers.AllowUserToAddRows = false;
            datagwCustomers.AllowUserToDeleteRows = false;

            // DataGridin satırlarının yüksekliğini ve genişliğini yasaklama
            datagwCustomers.AllowUserToResizeRows = false;
        }

        private void BindGrid()
        {
            // DataGrid i dolduran bölüm
            // C# ın using kalıbı. ...bunu kullanarak demek

            using (SqlConnection con = new SqlConnection(constring)) // con isminde bir nesne yarat(SqlConnection kütüphanesinden). yaratırken de constringden yararlan.
            {
                using (SqlCommand cmd = new SqlCommand("SELECT CustomerID,CompanyName,ContactName,Country FROM Customers",con)) // con nesnesini kullarak SQL komutunu oluştur
                {
                    // aşağıda cmd nesnesini kullanabileceğim veri geliş/gidişini ayarlayan bir DataAdapter oluşturuyoruz
                    cmd.CommandType = CommandType.Text;
                    using (SqlDataAdapter sqlda = new SqlDataAdapter(cmd))
                    {
                        using (DataSet dataSet = new DataSet())
                        {
                            sqlda.Fill(dataSet); // Adaptörüm yarattığı dataSeti doldursun
                            datagwCustomers.DataSource = dataSet.Tables[0]; // dataSet oluştu..içine table taşındı ve DataGridin içinde görülebilir hale geldi
                        }
                    }

                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ShowData("I"); // metoduma Insert işlemi yapabilmek için I parametresini gönderdim
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            ShowData("U"); //metoduma Update işlemi yapabilmek için U parametresini gönderdim
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // Delete
        }

        private void ShowData(string prmMode)
        {
            // Bu metod üzerine aldığı parametreye göre 2. bir form açacak. 2 .form istenilen işlem (I,U) değerine göre ekrana gelecek. I/U işlemini bu yeni form üzerinde yapacak. "D" işlemi şuan bulunulan formdan yapacak

            frmADO01_Detail frmADO01_Detail = new frmADO01_Detail();

            frmADO01_Detail.Mode = prmMode; // gelen parametreyi direkt olarak detay formuna pasladım

            // gelen parametreye göre diğer detay formun elemanlarını ayarlıyorum

            switch (prmMode)
            {
                case "I":
                    // Initial Değerler veriliyor...
                    frmADO01_Detail.txtCustomerID.Enabled = true;
                    frmADO01_Detail.txtCompanyName.Text = " ";
                    frmADO01_Detail.txtContactName.Text = " ";
                    frmADO01_Detail.txtCountry.Text = " ";

                    frmADO01_Detail.txtCustomerID.Select();

                    break;

                case "U":
                    // Initial Değerler veriliyor...
                    frmADO01_Detail.txtCustomerID.Enabled = false;

                    frmADO01_Detail.txtCustomerID.Text =
                        datagwCustomers.CurrentRow.Cells[0].Value.ToString(); // DataGrid deki seçili satırdaki hücrenin değerini textbox ın içine gönder
                    frmADO01_Detail.txtCompanyName.Text = 
                        datagwCustomers.CurrentRow.Cells[1].Value.ToString(); 
                    frmADO01_Detail.txtContactName.Text =
                        datagwCustomers.CurrentRow.Cells[2].Value.ToString();
                    frmADO01_Detail.txtCountry.Text =
                        datagwCustomers.CurrentRow.Cells[3].Value.ToString();

                    break;

                    
            }

            frmADO01_Detail.ShowDialog();
        }

        private void datagwCustomers_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ShowData("U");
        }
    }
}
