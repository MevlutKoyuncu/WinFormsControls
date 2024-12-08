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
using System.Xml.Linq;
using WinFormsControls.Model;

namespace WinFormsControls
{

    public partial class DataGridControl : Form
    {
        int rowindex = -1;
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
            //UrunleriGetir();
            FillCategory();
        }

        private void UrunleriGetir()
        {
            List<Products> products = new List<Products>();
            SqlConnection con = new SqlConnection(@"Data Source=.; Initial Catalog=NORTHWND; Integrated Security=True");
            SqlCommand cmd = con.CreateCommand();
            //  [ProductName]
            //,[SupplierID]
            //,[CategoryID]
            //,[QuantityPerUnit]
            //,[UnitPrice]
            //,[UnitsInStock]
            //,[UnitsOnOrder]
            //,[ReorderLevel]
            //,[Discontinued]
            cmd.CommandText = "SELECT P.ProductID, P.ProductName, P.SupplierID, S.CompanyName, P.CategoryID, C.CategoryName, P.QuantityPerUnit, P.UnitPrice, P.UnitsInStock, P.UnitsOnOrder, P.ReorderLevel, P.Discontinued FROM Products AS P JOIN Suppliers AS S ON S.SupplierID = P.SupplierID JOIN Categories AS C ON P.CategoryID = C.CategoryID";
            //cmd.CommandText = "SELECT * FROM Products";
            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Products prod = new Products();
                prod.ProductID = reader.GetInt32(0);
                prod.ProductName = reader.GetString(1);
                prod.SupplierID = reader.GetInt32(2);
                prod.Supplier = reader.GetString(3);
                prod.CategoryID = reader.GetInt32(4);
                prod.Category = reader.GetString(5);
                prod.QuantityPerUnit = reader.GetString(6);
                prod.UnitPrice = reader.GetDecimal(7);
                prod.UnitsInStock = reader.GetInt16(8);
                prod.UnitsOnOrder = reader.GetInt16(9);
                prod.Reorderlevel = reader.GetInt16(10);
                prod.Discontinued = reader.GetBoolean(11);
                products.Add(prod);
            }

            //dt.Load(reader);
            dataGridView1.DataSource = products;
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


        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=.; Initial Catalog=NORTHWND; Integrated Security=True");
            SqlCommand cmd = con.CreateCommand();

            try
            {
                string categoryName = textBox1.Text.Trim();
                string description = textBox2.Text.Trim();
                if (string.IsNullOrWhiteSpace(categoryName) || string.IsNullOrWhiteSpace(description))
                {
                    MessageBox.Show("Kategori adı ve açıklama boş bırakılamaz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                cmd.CommandText = "INSERT INTO Categories(CategoryName, Description) VALUES(@name, @description)";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@name", categoryName);
                cmd.Parameters.AddWithValue("@description", description);
                con.Open();
                cmd.ExecuteNonQuery();

            }
            finally
            {
                con.Close();
            }
            DataGridDataBind4();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
        }

        private void btn_urunekle_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=.; Initial Catalog=NORTHWND; Integrated Security=True");
            SqlCommand cmd = con.CreateCommand();

            try
            {
                string productname = tb_productname.Text.Trim();
                string price = tb_price.Text.Trim();
                string quantityperunit = tb_quantityperunit.Text.Trim();
                string reorder = tb_reorder.Text.Trim();
                int disc = rb_evet.Checked ? 1 : 0;
                object suppid = cb_suppliers.SelectedIndex;
                object catid = cb_category.SelectedIndex;


                if (string.IsNullOrWhiteSpace(productname) || string.IsNullOrWhiteSpace(price) || string.IsNullOrWhiteSpace(quantityperunit) || string.IsNullOrWhiteSpace(reorder))
                {
                    MessageBox.Show("Ürün ismi, Fiyat, Kalan Stok ve Ürün Miktarı kısımları boş bırakılamaz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                cmd.CommandText = "INSERT INTO Products(ProductName, UnitPrice, QuantityPerUnit, ReorderLevel, Discontinued, CategoryID, SupplierID) VALUES(@productname, @price, @quantityperunit, @reorder, @discontinued, @catid, @suppid)";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@productname", productname);
                cmd.Parameters.AddWithValue("@price", price);
                cmd.Parameters.AddWithValue("@quantityperunit", quantityperunit);
                cmd.Parameters.AddWithValue("@reorder", reorder);
                cmd.Parameters.AddWithValue("@discontinued", disc);
                cmd.Parameters.AddWithValue("@suppid", suppid);
                cmd.Parameters.AddWithValue("@catid", catid);

                con.Open();
                cmd.ExecuteNonQuery();

            }
            finally
            {
                con.Close();
                DataGridDataBind4();
            }
        }


        private void btn_formutemizle_Click(object sender, EventArgs e)
        {
            tb_price.Clear();
            tb_productname.Clear();
            tb_quantityperunit.Clear();
            tb_reorder.Clear();
        }

        private void FillSuppliers()
        {
            List<Category> categories = new List<Category>();
            SqlConnection con = new SqlConnection(@"Data Source=.; Initial Catalog=NORTHWND; Integrated Security=True");
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "SELECT CompanyName FROM Suppliers";
            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Category cat = new Category();
                cat.Name = reader.GetString(0);
                categories.Add(cat);
            }
            con.Close();
            cb_category.Items.Clear();
            cb_category.DataSource = categories;
            cb_category.ValueMember = "ID";
            cb_category.DisplayMember = "Name";

        }

        private void FillCategory()
        {
            List<Category> categories = new List<Category>();
            SqlConnection con = new SqlConnection(@"Data Source=.; Initial Catalog=NORTHWND; Integrated Security=True");
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "SELECT CategoryName FROM Categories";
            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Category cat = new Category();
                cat.Name = reader.GetString(0);
                categories.Add(cat);
            }
            con.Close();
            cb_category.Items.Clear();
            cb_category.DataSource = categories;
            cb_category.ValueMember = "ID";
            cb_category.DisplayMember = "Name";
        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            //MessageBox.Show("Tıklandı");
            if (e.Button == MouseButtons.Right)
            {
                rowindex = dataGridView1.HitTest(e.X, e.Y).RowIndex;
                if (rowindex != -1)
                {
                    //MessageBox.Show("Sağ buton tıklandı");
                    contextMenuStrip1.Show(dataGridView1, e.X, e.Y);
                    dataGridView1.ClearSelection();
                    dataGridView1.Rows[rowindex].Selected = true;

                }
            }
        }

        private void TSMI_duzenle_Click(object sender, EventArgs e)
        {
            if (rowindex != -1)
            {
                btn_duzenle.Visible = true;
                int id = Convert.ToInt32(dataGridView1.Rows[rowindex].Cells[0].Value);
                //MessageBox.Show(id.ToString(), "Kategori id");
                Category cat = new Category();
                SqlConnection con = new SqlConnection(@"Data Source=.; Initial Catalog=NORTHWND; Integrated Security=True");
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandText = "SELECT CategoryID, CategoryName, Description FROM Categories WHERE CategoryID=@id";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("id", id);
                try
                {
                    con.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        textBox3.Text = reader.GetInt32(0).ToString();
                        textBox1.Text = reader.GetString(1);
                        textBox2.Text = reader.IsDBNull(2) == false ? reader.GetString(2) : "";
                    }
                }
                catch
                {

                }
                finally
                {
                    con.Close();
                }
            }
        }

        private void btn_duzenle_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox1.Text))
            {
                SqlConnection con = new SqlConnection(@"Data Source=.; Initial Catalog=NORTHWND; Integrated Security=True");
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandText = "UPDATE Categories SET CategoryName=@cn, Description=@des WHERE CategoryID=@id";
                cmd.Parameters.AddWithValue("@cn", textBox1.Text);
                cmd.Parameters.AddWithValue("@des", textBox2.Text);
                cmd.Parameters.AddWithValue("@id", textBox3.Text);
                try
                {
                    con.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Kategori başarıyla güncellenmiştir.", "Başarılı");
                }
                catch
                {
                    MessageBox.Show("Kategori güncellenirken bir hata oluştu.", "Hata var");
                }
                finally
                {
                    con.Close();
                }
                btn_duzenle.Visible = false;
                textBox1.Text = textBox2.Text = textBox3.Text = "";
                DataGridDataBind4();
            }

        }

        private void TSMI_sil_Click(object sender, EventArgs e)
        {
            if (rowindex != -1)
            {
                int id = Convert.ToInt32(dataGridView1.Rows[rowindex].Cells[0].Value);
                if (MessageBox.Show($"{id} idli kategori silinecektir.\n Onaylıyor musunuz?", "Kategori Sil", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    SqlConnection con = new SqlConnection(@"Data Source=.; Initial Catalog=NORTHWND; Integrated Security=True");
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandText = "DELETE Categories FROM Categories WHERE CategoryID=@id";
                    cmd.Parameters.AddWithValue("id", id);
                    try { con.Open(); cmd.ExecuteNonQuery(); }
                    finally { con.Close(); }
                    DataGridDataBind4();
                }


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
}
