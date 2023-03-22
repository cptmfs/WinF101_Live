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
    public partial class AdoForm : Form
    {
        public AdoForm()
        {
            InitializeComponent();
        }
        string con = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Northwind;Integrated Security=True";
        SqlConnection connection = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Northwind;Integrated Security=True");
        private void AdoForm_Load(object sender, EventArgs e)
        {
            PrepareGrid();
            BindGrid();
            LoadCategories();
            LoadCountry();
            txtIDUpdate.ReadOnly = true;
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void PrepareGrid()
        {
            dgwCustomer.AllowUserToAddRows = false; // Veri girişi yapılmasın
            dgwCustomer.AllowUserToDeleteRows = false; // Veri silinmesin
            dgwCustomer.RowHeadersVisible = false; // satırların solunda başlık olmasın
            //dgwCustomer.AutoGenerateColumns=false; // 
            dgwCustomer.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; // Tüm datagrid ekranını kaplasın tablolar ( 1 tablo olsa bile gri alan bırakmasın )
            dgwCustomer.SelectionMode = DataGridViewSelectionMode.FullRowSelect; // tek tek seçmek yerine tüm satırı seçme
            //dgwCustomer.ReadOnly = true;// sadece okunabilsin..
        }
        private void BindGrid()
        {
            using (SqlConnection connection = new SqlConnection(con))
            {
                using (SqlCommand cmd = new SqlCommand("Select * from Customers", connection))
                {
                    cmd.CommandType = CommandType.Text;
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        using (DataSet ds = new DataSet())
                        {
                            adapter.Fill(ds);
                            dgwCustomer.DataSource = ds.Tables[0];
                        }
                    }
                }
            }
            //SqlConnection connection = new SqlConnection (@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Northwind;Integrated Security=True");
            //SqlCommand cmd = new SqlCommand("Select * from Customers", connection);
            //SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            //DataTable table = new DataTable();
            //adapter.Fill(table);
            //dgwCustomer.DataSource = table;

        }
        private void LoadCategories()
        {
            //SqlCommand cmd2 = new SqlCommand("Select * From Categories", connection);
            //SqlDataAdapter adapter2 = new SqlDataAdapter(cmd2);
            //DataTable ds2 = new DataTable();
            //adapter2.Fill(ds2);

            //cbxKategoriE.DataSource = ds2;
            //cbxKategoriE.DisplayMember = "CategoryName";
            //cbxKategoriE.ValueMember = "CategoryID";
            //cbxKategoriG.DataSource = ds2;
            //cbxKategoriG.DisplayMember = "CategoryName";
            //cbxKategoriG.ValueMember = "CategoryID";
        }
        private void LoadCountry()
        {
            SqlCommand cmd5 = new SqlCommand("Select DISTINCT Country from Customers",connection);
            SqlDataAdapter adapter2 = new SqlDataAdapter(cmd5);
            DataTable dt = new DataTable();
            adapter2.Fill(dt);
            cbxCountry.DataSource = dt;
            cbxCountry.DisplayMember = "Country";
            cbxCountry.ValueMember = "Country";
            
            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand cmd3 = new SqlCommand("Insert into Customers (CustomerID,CompanyName,ContactName,ContactTitle,Address,City,Region,PostalCode,Country,Phone,Fax) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10,@p11)", connection);
            cmd3.Parameters.AddWithValue("@p1", txtIDAdd.Text);
            cmd3.Parameters.AddWithValue("@p2", txtCompanyNameAdd.Text);
            cmd3.Parameters.AddWithValue("@p3", txtContactNameAdd.Text);
            cmd3.Parameters.AddWithValue("@p4", txtTitleAdd.Text);
            cmd3.Parameters.AddWithValue("@p5", txtAddressAdd.Text);
            cmd3.Parameters.AddWithValue("@p6", txtCityAdd.Text);
            cmd3.Parameters.AddWithValue("@p7", txtRegionAdd.Text);
            cmd3.Parameters.AddWithValue("@p8", mskPostalAdd.Text);
            cmd3.Parameters.AddWithValue("@p9", txtCountryAdd.Text);
            cmd3.Parameters.AddWithValue("@p10", mskPhoneAdd.Text);
            cmd3.Parameters.AddWithValue("@p11", mskFaxAdd.Text);
            cmd3.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("New Customer Successfully Added", "Customer Add", MessageBoxButtons.OK, MessageBoxIcon.Information);
            BindGrid();

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand cmd4 = new SqlCommand("Update Customers set CompanyName=@p2,ContactName=@p3,ContactTitle=@p4,Address=@p5,City=@p6,Region=@p7,PostalCode=@p8,Country=@p9,Phone=@p10,Fax=@p11 where CustomerID=@p1",connection);
            
            cmd4.Parameters.AddWithValue("@p2", txtCompanyNameUpdate.Text);
            cmd4.Parameters.AddWithValue("@p3", txtContactNameUpdate.Text);
            cmd4.Parameters.AddWithValue("@p4", txtTitleUpdate.Text);
            cmd4.Parameters.AddWithValue("@p5", txtAddressUpdate.Text);
            cmd4.Parameters.AddWithValue("@p6", txtCityUpdate.Text);
            cmd4.Parameters.AddWithValue("@p7", txtRegionUpdate.Text);
            cmd4.Parameters.AddWithValue("@p8", mskPostalUpdate.Text);
            cmd4.Parameters.AddWithValue("@p9", txtCountryUpdate.Text);
            cmd4.Parameters.AddWithValue("@p10", mskPhoneUpdate.Text);
            cmd4.Parameters.AddWithValue("@p11", mskFaxUpdate.Text);
            cmd4.Parameters.AddWithValue("@p1", txtIDUpdate.Text);
            cmd4.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Customer Update Successfully Completed", "Customer Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
            BindGrid();
        }

        private void dgwCustomer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtIDUpdate.Text = dgwCustomer.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtCompanyNameUpdate.Text = dgwCustomer.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtContactNameUpdate.Text = dgwCustomer.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtTitleUpdate.Text = dgwCustomer.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtAddressUpdate.Text = dgwCustomer.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtCityUpdate.Text = dgwCustomer.Rows[e.RowIndex].Cells[5].Value.ToString();
            txtRegionUpdate.Text = dgwCustomer.Rows[e.RowIndex].Cells[6].Value.ToString();
            mskPostalUpdate.Text = dgwCustomer.Rows[e.RowIndex].Cells[7].Value.ToString();
            txtCountryUpdate.Text = dgwCustomer.Rows[e.RowIndex].Cells[8].Value.ToString();
            mskPhoneUpdate.Text = dgwCustomer.Rows[e.RowIndex].Cells[9].Value.ToString();
            mskFaxUpdate.Text = dgwCustomer.Rows[e.RowIndex].Cells[10].Value.ToString();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Veriyi gerçekten silmek istiyormusunuz ?","İşlem Onayı",MessageBoxButtons.YesNo,MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes)
            {
                SqlCommand cmd6 = new SqlCommand("Delete from Customers where CustomerID=@p1");
                cmd6.Parameters.AddWithValue("@p1", dgwCustomer.CurrentRow.Cells[0].Value.ToString());
            }
        }

        private void cbxCountry_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlCommand cmd7 = new SqlCommand("Select Country from Customers where Country=@Country",connection);
            cmd7.Parameters.AddWithValue("@Country",cbxCountry.SelectedItem);
            cmd7.ExecuteNonQuery();


        }
    }
}
