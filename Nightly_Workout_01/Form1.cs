using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nightly_Workout_01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Northwind;Integrated Security=True");
        private void ListOrders()
        {
            // Uzun Sql Sorgumu View Oluşturarak OrderGrid adını verdim.
            //Select OrderID,c.CompanyName as 'CustomerCompanyName',e.FirstName+' '+e.LastName as 'EmployeeNameSurname',s.CompanyName as 'ShipperCompanyName',ShipperID,EmployeeID from Orders o inner join Customers c on c.CustomerID = o.CustomerID                        inner join Shippers s on s.ShipperID = o.ShipVia inner join Employees e on e.EmployeeID = o.EmployeeID
            SqlCommand cmd = new SqlCommand("Select * from OrderGrid", connection);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        private void PrepareGrid()
        {
            dataGridView1.AllowUserToAddRows = false; // Veri girişi yapılmasın
            dataGridView1.AllowUserToDeleteRows = false; // Veri silinmesin
            dataGridView1.RowHeadersVisible = false; // satırların solunda başlık olmasın
            //dataGridView1.AutoGenerateColumns=false; // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; // Tüm datagrid ekranını kaplasın tablolar ( 1 tablo olsa bile gri alan bırakmasın )
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect; // tek tek seçmek yerine tüm satırı seçme
            dataGridView1.ReadOnly = true;// sadece okunabilsin..
            dataGridView1.RowHeadersVisible=false;
        }
        private void LoadComboboxes()
        {

            SqlCommand cmd2 = new SqlCommand("Select * from Shippers", connection);
            SqlDataAdapter adapter2= new SqlDataAdapter(cmd2);  
            DataTable dt2 = new DataTable();
            adapter2.Fill(dt2);
            cbxShipperCN.DataSource= dt2;
            cbxShipperCN.DisplayMember = "CompanyName";
            cbxShipperCN.ValueMember = "ShipperID";

            SqlCommand cmd4 = new SqlCommand("Select FirstName+' ' + LastName as 'Employee',EmployeeID from Employees",connection);
            SqlDataAdapter adapter4 = new SqlDataAdapter(cmd4);
            DataTable dt4 = new DataTable();
            adapter4.Fill(dt4);
            cbxEmployeeSearch.DataSource= dt4;
            cbxEmployeeSearch.DisplayMember = "Employee";
            cbxEmployeeSearch.ValueMember = "EmployeeID";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ListOrders();
            LoadComboboxes();
        }

        private void btnShipperSearch_Click(object sender, EventArgs e)
        {
            SqlCommand cmd3 = new SqlCommand("Select * from OrderGrid where ShipperID="+cbxShipperCN.SelectedValue+"",connection);
            SqlDataAdapter adapter3 = new SqlDataAdapter(cmd3);
            DataTable dt3 = new DataTable();
            adapter3.Fill(dt3);
            dataGridView1.DataSource= dt3;
        }

        private void btnEmployeeSearch_Click(object sender, EventArgs e)
        {
            SqlCommand cmd4 = new SqlCommand("Select * from OrderGrid where EmployeeID=" + cbxEmployeeSearch.SelectedValue + "", connection);
            SqlDataAdapter adapter4 =new SqlDataAdapter(cmd4);
            DataTable dt4 = new DataTable();
            adapter4.Fill(dt4);
            dataGridView1.DataSource= dt4;
        }

        //private void txtSearch_TextChanged(object sender, EventArgs e) // Burada textbox'a veri girildikçe arama yapıyor...
        //{
        //    SqlDataAdapter adapter5 = new SqlDataAdapter("Select * from OrderGrid where CustomerCompanyName like '%"+txtSearch.Text+ "%' or EmployeeNameSurname like '%" + txtSearch.Text+ "%' or ShipperCompanyName like '%"+txtSearch.Text+"%'", connection);
        //    DataTable dt5 = new DataTable();    
        //    adapter5.Fill(dt5); 
        //    dataGridView1.DataSource= dt5;
        //    if (txtSearch.Text=="")
        //    {
        //        ListOrders();
        //    }
        //}

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void SearchAll()
        {
            string query = "Select * from OrderGrid where ShipperID=@ShipperID";
            query += " and EmployeeID=@EmployeeID";
            query += " and CustomerCompanyName like '%" + txtSearch.Text + "%' or EmployeeNameSurname like '%" + txtSearch.Text + "%' or ShipperCompanyName like '%" + txtSearch.Text + "%'";

            SqlCommand cmd5 = new SqlCommand(query,connection);

            cmd5.Parameters.AddWithValue("@ShipperID", cbxShipperCN.SelectedValue);
            cmd5.Parameters.AddWithValue("@EmployeeID", cbxEmployeeSearch.SelectedValue);

            
            SqlDataAdapter adapter6 = new SqlDataAdapter(cmd5);

            DataTable dt6 = new DataTable();
            adapter6.Fill(dt6);
            dataGridView1.DataSource= dt6;
            if (txtSearch.Text=="")
            {
                ListOrders();
            }
            
        }

        private void btnSearchAll_Click(object sender, EventArgs e)
        {
            SearchAll();
        }
    }
}
