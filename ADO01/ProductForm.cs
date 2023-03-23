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
    public partial class ProductForm : Form
    {

        public ProductForm()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Northwind;Integrated Security=True");
        private void ProductForm_Load(object sender, EventArgs e)
        {
            ListProducts();
            LoadCombobox();
            PrepareGrid();
        }
        private void ListProducts()
        {
            //Select ProductID,c.CategoryName,ProductName,s.CompanyName as 'SupplierCompany',UnitPrice,UnitsInStock,QuantityPerUnit,UnitsOnOrder,ReorderLevel,Discontinued,p.SupplierID,p.CategoryID From Products p inner join Categories c on c.CategoryID=p.CategoryID inner join Suppliers s on s.SupplierID=p.SupplierID
            SqlCommand cmd = new SqlCommand("Select * from [viewSearch]", connection);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgwProduct.DataSource = dt;
            dgwProduct.Columns[11].Visible = false;
            dgwProduct.Columns[10].Visible = false;
        }
        private void PrepareGrid()
        {
            dgwProduct.AllowUserToAddRows = false; // Veri girişi yapılmasın
            dgwProduct.AllowUserToDeleteRows = false; // Veri silinmesin
            dgwProduct.RowHeadersVisible = false; // satırların solunda başlık olmasın
            //dgwProduct.AutoGenerateColumns=false; // 
            dgwProduct.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; // Tüm datagrid ekranını kaplasın tablolar ( 1 tablo olsa bile gri alan bırakmasın )
            dgwProduct.SelectionMode = DataGridViewSelectionMode.FullRowSelect; // tek tek seçmek yerine tüm satırı seçme
            dgwProduct.ReadOnly = true;// sadece okunabilsin..
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void LoadCombobox()
        {
            connection.Open();
            SqlCommand cmd3 = new SqlCommand("Select * From Suppliers", connection);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd3);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            cbxSupplierAdd.DataSource = dt;
            cbxSupplierAdd.DisplayMember = "CompanyName";
            cbxSupplierAdd.ValueMember = "SupplierID";

            cbxSupplierU.DataSource = dt;
            cbxSupplierU.DisplayMember = "CompanyName";
            cbxSupplierU.ValueMember = "SupplierID";

            SqlCommand cmd4 = new SqlCommand("Select * From Categories", connection);
            SqlDataAdapter adapter2 = new SqlDataAdapter(cmd4);
            DataTable dt2 = new DataTable();
            adapter2.Fill(dt2);

            cbxCategoryAdd.DataSource = dt2;
            cbxCategoryAdd.DisplayMember = "CategoryName";
            cbxCategoryAdd.ValueMember = "CategoryId";

            cbxCategoryU.DataSource = dt2;
            cbxCategoryU.DisplayMember = "CategoryName";
            cbxCategoryU.ValueMember = "CategoryID";

            cbxCategory.DataSource = dt2;
            cbxCategory.DisplayMember = "CategoryName";
            cbxCategory.ValueMember = "CategoryID";

            #region cbox'a Hepsi Yazdırma
            //cbox içine ilk index'e -- HEPSİ -- yazan bi satır eklemek istiyoruz..

            // Data tablolarında olmayan bir satırı olusturmak icin kullanılan bir class var (DataRow class'ı) combo içine ilk olarak onun gözükmesini saglayacagız..
            DataRow newRow = dt2.NewRow(); // yeni satır acıyoruz.

            newRow["CategoryID"] = 0;
            newRow["CategoryName"] = "--- HEPSİ ---";
            dt2.Rows.InsertAt(newRow, 0);

            cbxCategory.DataSource = dt2;
            cbxCategory.DisplayMember = "CompanyName";
            cbxCategory.ValueMember = "CategoryID";

            #endregion
            connection.Close();

            




        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand cmd2 = new SqlCommand("Insert into Products (ProductName,SupplierID,CategoryID,QuantityPerUnit,UnitPrice,UnitsInStock,UnitsOnOrder,ReorderLevel,Discontinued) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9)", connection);
            cmd2.Parameters.AddWithValue("@p1", txtProductNameAdd.Text);
            cmd2.Parameters.AddWithValue("@p2", cbxSupplierAdd.SelectedValue);
            cmd2.Parameters.AddWithValue("@p3", cbxCategoryAdd.SelectedValue);
            cmd2.Parameters.AddWithValue("@p4", txtQuantityPerUnitAdd.Text);
            cmd2.Parameters.AddWithValue("@p5", txtUnitPriceAdd.Text);
            cmd2.Parameters.AddWithValue("@p6", txtUnitsInStockAdd.Text);
            cmd2.Parameters.AddWithValue("@p7", txtUnitsOnOrderAdd.Text);
            cmd2.Parameters.AddWithValue("@p8", txtReorderLevelAdd.Text);
            cmd2.Parameters.AddWithValue("@p9", nudDisconAdd.Value);
            cmd2.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("New Product Successfully Added", "Product Add", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ListProducts();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand cmd3 = new SqlCommand("Update Products set ProductName=@p1,SupplierID=@p2,CategoryID=@p3,QuantityPerUnit=@p4,UnitPrice=@p5,UnitsInStock=@p6,UnitsOnOrder=@p7,ReorderLevel=@p8,Discontinued=@p9 where ProductID=@p10", connection);
            cmd3.Parameters.AddWithValue("@p1", txtProductNameU.Text);
            cmd3.Parameters.AddWithValue("@p2", cbxSupplierU.SelectedValue);
            cmd3.Parameters.AddWithValue("@p3", cbxCategoryU.SelectedValue);
            cmd3.Parameters.AddWithValue("@p4", txtQuantityPerUnitU.Text);
            cmd3.Parameters.AddWithValue("@p5", txtUnitPriceU.Text);
            cmd3.Parameters.AddWithValue("@p6", txtUnitStockU.Text);
            cmd3.Parameters.AddWithValue("@p7", txtUnitsOnOrderU.Text);
            cmd3.Parameters.AddWithValue("@p8", txtReorderLevelU.Text);
            cmd3.Parameters.AddWithValue("@p9", nudDisconU.Value);
            cmd3.Parameters.AddWithValue("@p10", txtProductIDU.Text);
            cmd3.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Product Update Successfully Completed", "Product Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ListProducts();
        }

        private void dgwProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtProductIDU.Text = dgwProduct.Rows[e.RowIndex].Cells[0].Value.ToString();
                cbxCategoryU.SelectedValue = int.Parse(dgwProduct.Rows[e.RowIndex].Cells[11].Value.ToString());
                txtProductNameU.Text = dgwProduct.Rows[e.RowIndex].Cells[2].Value.ToString();
                cbxSupplierU.SelectedValue = int.Parse(dgwProduct.Rows[e.RowIndex].Cells[10].Value.ToString());
                txtUnitPriceU.Text = dgwProduct.Rows[e.RowIndex].Cells[4].Value.ToString();
                txtUnitStockU.Text = dgwProduct.Rows[e.RowIndex].Cells[5].Value.ToString();
                txtQuantityPerUnitU.Text = dgwProduct.Rows[e.RowIndex].Cells[6].Value.ToString();
                txtUnitsOnOrderU.Text = dgwProduct.Rows[e.RowIndex].Cells[7].Value.ToString();
                txtReorderLevelU.Text = dgwProduct.Rows[e.RowIndex].Cells[8].Value.ToString();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            connection.Open();
            SqlDataAdapter ad = new SqlDataAdapter("Select * from [viewSearch] where Productname like '%" + txtSearch.Text+"%'",connection);
            DataTable dataTable = new DataTable();
            ad.Fill(dataTable);
            dgwProduct.DataSource = dataTable;
            connection.Close();
            if (txtSearch.Text=="")
            {
                ListProducts();
            }

        }

        private void menuCustomers_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Kategori işlemleri menüsüne geçmek istediğinize eminmisiniz ?", "İşlem Menüsü", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                AdoForm ad = new AdoForm();
                
                ad.ShowDialog();
                this.Close();

            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Veriyi gerçekten silmek istiyormusunuz ?", "İşlem Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes)
            {
                connection.Open();
                SqlCommand cmd6 = new SqlCommand("Delete from Products where ProductID=@p1",connection);
                cmd6.Parameters.AddWithValue("@p1", dgwProduct.CurrentRow.Cells[0].Value.ToString());
                cmd6.ExecuteNonQuery();
                MessageBox.Show("Delete Product Successfully Completed","Delete Product",MessageBoxButtons.OK, MessageBoxIcon.Information);
                connection.Close();
                ListProducts();
            }
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            SqlCommand cmd6 = new SqlCommand("Select * from [viewSearch] where CategoryID = @p1", connection);
            cmd6.Parameters.AddWithValue("@p1", cbxCategory.SelectedIndex);
            SqlDataAdapter adapter2 = new SqlDataAdapter(cmd6);
            DataTable dt2 = new DataTable();
            adapter2.Fill(dt2);
            dgwProduct.DataSource = dt2;
        }

    }
}
