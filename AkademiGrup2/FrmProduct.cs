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

namespace AkademiGrup2
{
    public partial class FrmProduct : Form
    {
        public FrmProduct()
        {
            InitializeComponent();
        }
        //overload --> aşırı yükleme 
        //aynı isimli metodun farklı parametrelerle kullanılması
        //Asp.Net Core 
        //Asp.Net Core Api

        SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-07T8MF2\MSSQLSERVER01;initial Catalog=DbAkademiGrup2;integrated security=True");
        private void btnList_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("Select * From TblProduct", connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand command = new SqlCommand("insert into TblProduct (ProductName,ProductStock,ProductPrice,ProductCategory) values (@p1,@p2,@p3,@p4)", connection);
            command.Parameters.AddWithValue("@p1", txtProductName.Text);
            command.Parameters.AddWithValue("@p2", txtProductStock.Text);
            command.Parameters.AddWithValue("@p3", txtProductPrice.Text);
            command.Parameters.AddWithValue("@p4", txtProductCategory.Text);
            command.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Ürün başarılı bir şekilde eklendi");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //Silme işleminden önce bir evet hayır messagebox onay ekranı gelsin kişi evete basarsa veri silinsin
            connection.Open();
            SqlCommand command = new SqlCommand("Delete From TblProduct Where ProductID=@p1", connection);
            command.Parameters.AddWithValue("@p1", txtProductID.Text);
            command.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Veriler başarılı bir şekilde silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand command = new SqlCommand("Update TblProduct Set ProductName=@p1, ProductStock=@p2,ProductPrice=@p3 where ProductID=@p4", connection);
            command.Parameters.AddWithValue("@p1", txtProductName.Text);
            command.Parameters.AddWithValue("@p2", txtProductStock.Text);
            command.Parameters.AddWithValue("@p3", txtProductPrice.Text);
            command.Parameters.AddWithValue("@p4", txtProductID.Text);
            command.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Veriler başarıyla güncellendi", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            SqlCommand command2 = new SqlCommand("Select * From TblProduct", connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command2);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
        }
    }
}
