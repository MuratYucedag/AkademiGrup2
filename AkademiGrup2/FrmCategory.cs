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
    public partial class FrmCategory : Form
    {
        public FrmCategory()
        {
            InitializeComponent();
        }

        //overload

        SqlConnection connection = new SqlConnection("Data Source=DESKTOP-07T8MF2\\MSSQLSERVER01;initial catalog=DbAkademiGrup2;integrated security=true");
        private void btnList_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand command = new SqlCommand("Select * From TblCategory", connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            connection.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtName.Text.Length <= 50)
            {
                connection.Open();
                SqlCommand command = new SqlCommand("insert into TblCategory (CategoryName) values (@p1)", connection);
                command.Parameters.AddWithValue("@p1", txtName.Text);
                command.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Kategori başarılı bir şekilde eklendi");
            }
            else
            {
                MessageBox.Show("Lütfen en fazla 50 karakter veri girişi yapın");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand command = new SqlCommand("Delete From TblCategory where CategoryID=@p1", connection);
            command.Parameters.AddWithValue("@p1", txtID.Text);
            command.ExecuteNonQuery();
            MessageBox.Show("Kategori başarılı bir şekilde silindi");
            connection.Close();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand command = new SqlCommand("Update TblCategory Set CategoryName=@p1 where CategoryID=@p2", connection);
            command.Parameters.AddWithValue("@p1", txtName.Text);
            command.Parameters.AddWithValue("@p2", txtID.Text);
            command.ExecuteNonQuery();
            MessageBox.Show("Kategori başarılı bir şekilde güncellendi");
            connection.Close();
        }

        private void btnStartsWithA_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("Select * From TblCategory where CategoryName like 'a%'", connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void btnEndsWithA_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("Select * From TblCategory where CategoryName like '%a'", connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void btnCreateCode_Click(object sender, EventArgs e)
        {
            //ABCDEFGH 
            //1234567890

            //AAA00
            string[] harfler = { "A", "B", "C", "D", "E", "F", "G", "H" };
            Random rnd = new Random();
            int sayi = rnd.Next(0, 8);
            int sayi2 = rnd.Next(0, 8);
            int sayi3 = rnd.Next(0, harfler.Length);
            int sayi4 = rnd.Next(0, 10);
            int sayi5 = rnd.Next(0, 10);
            txtCode.Text = harfler[sayi] + harfler[sayi2] + harfler[sayi3] + sayi4 + sayi5;
        }
    }
}
