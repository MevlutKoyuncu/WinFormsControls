using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsControls.Model;

namespace WinFormsControls
{
    public partial class DataGridControl : Form
    {
        public DataGridControl()
        {
            InitializeComponent();
        }

        private void DataGridControl_Load(object sender, EventArgs e)

        {
            //KATEGORİ VE ÜRÜNLER İÇİN DATABASEYE EKLEME ÜRÜNLER İÇİN TEDARİKÇİ İSMİNİ DROPDOWNLİST ŞEKİLDE ÇEKİCEZ.
            //DataTableNedir();
            //DataGridDataBind();
            //DataGridDataBind2();
            //DataGridDataBind3();
            DataGridDataBind4();

        }
        private void DataGridDataBind4()
        {
            SqlConnection con = new SqlConnection(@"Data Source=.; Initial Catalog=NORTHWND; Integrated Security=True");
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "SELECT * FROM Categories";
            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("Kategori No");
            dt.Columns.Add("Kategori Adı");
            dt.Columns.Add("Kategori Açıklama");

            while (reader.Read())
            {
                dt.Rows.Add(reader.GetInt32(0), reader.GetString(1), reader.GetString(2));
            }
            dataGridView1.DataSource = dt;

        }

        private void DataGridDataBind3()
        {
           List<Category> categories = new List<Category>();
            SqlConnection con = new SqlConnection(@"Data Source=.; Initial Catalog=NORTHWND; Integrated Security=True");
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "SELECT * FROM Categories";
            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            
            while (reader.Read())
            {
                Category cat = new Category();
                cat.ID = reader.GetInt32(0); 
                cat.Name = reader.GetString(1);
                cat.Description = reader.GetString(2);
                categories.Add(cat);    
            }

            //dt.Load(reader);
            dataGridView1.DataSource = categories;
            dataGridView1.Columns[0].Name = "Kategori No";

        }
        private void DataGridDataBind2()
        {
            SqlConnection conn = new SqlConnection(@"Data Source=.; Initial Catalog=NORTHWND; Integrated Security=True");
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT * FROM Products";

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter();
            SqlCommandBuilder sqlcommand = new SqlCommandBuilder();
            sqlcommand.DataAdapter = da;
            da.SelectCommand = cmd;
            da.Fill(dt);

            dataGridView1.DataSource = dt;
        }

        private void DataGridDataBind()
        {
            //Northwind veri tabanından ürünleri çekelim.
            SqlConnection con = new SqlConnection(@"Data Source=.; Initial Catalog=NORTHWND; Integrated Security=True");
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "SELECT * FROM Products";
            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);
            dataGridView1.DataSource = dt;

        }

        //private void DataTableNedir()
        //{
        //DataTable dataTable = new DataTable();
        //    dataTable.Columns.Add("Kolon 1");
        //    dataTable.Columns.Add("Kolon 2");
        //    dataTable.Columns.Add("Kolon 3");

        //    dataTable.Rows.Add(1, "Kategori 1", "Açıklama 1");
        //    dataTable.Rows.Add(2, "Kategori 2", "Açıklama 2");
        //    dataGridView1.DataSource = dataTable;
        //}

        //params anahtar sözcüğü metodun alacağı parametre sayısı belli olmadığında kullanılabilir. Kendisine gönderilen aynı türdeki parametleri dizi indexlerine otomatik olarak yerleştiri ve dizi olarak kullanıma sunar.
    }
}
