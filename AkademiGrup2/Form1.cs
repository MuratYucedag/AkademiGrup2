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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //OOP --> Sınıf

        //Sınıflar nesneler aracılığıyla ilgili niteliklerine ulaşılması için kullanılan yapılardır.

        //Apartman - sınıf 

        //Daire - nesne 

        //Oda Sayısı - Oda Tipi - Oda renkleri - Mobilya türleri - --> property

        //ClassName ObjectName = new ClassName();
        private void btnList_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection("Data Source=DESKTOP-07T8MF2\\MSSQLSERVER01;Initial Catalog=DbAkademiGrup2;Integrated Security=True");

            SqlCommand command = new SqlCommand("Select * From TblCustomer", connection);

            SqlDataAdapter adapter = new SqlDataAdapter(command);

            DataTable dt = new DataTable();

            adapter.Fill(dt);

            dataGridView1.DataSource = dt;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection("Data Source=DESKTOP-07T8MF2\\MSSQLSERVER01;Initial Catalog=DbAkademiGrup2;Integrated Security=True");

            connection.Open();

            SqlCommand command = new SqlCommand("insert into TblCustomer (CustomerName,Customersurname,CustomerCity,CustomerBalance) Values (@p1,@p2,@p3,@p4)", connection);
            command.Parameters.AddWithValue("@p1", txtName.Text);
            command.Parameters.AddWithValue("@p2", txtSurname.Text);
            command.Parameters.AddWithValue("@p3", cmbCity.Text);
            command.Parameters.AddWithValue("@p4", txtBalance.Text);

            command.ExecuteNonQuery();

            connection.Close();
            MessageBox.Show("Müşteri başarılı bir şekilde eklendi");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection("Data Source=DESKTOP-07T8MF2\\MSSQLSERVER01;Initial Catalog=DbAkademiGrup2;Integrated Security=True");

            connection.Open();
            SqlCommand command = new SqlCommand("Delete From TblCustomer where CustomerID=@p1", connection);
            command.Parameters.AddWithValue("@p1", txtID.Text);
            command.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Müşteri başarılı bir şekilde silindi");
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection("Data Source=DESKTOP-07T8MF2\\MSSQLSERVER01;Initial Catalog=DbAkademiGrup2;Integrated Security=True");

            connection.Open();
            SqlCommand command = new SqlCommand("Update TblCustomer Set CustomerName=@p1,CustomerSurname=@p2,CustomerCity=@p3,CustomerBalance=@p4 where CustomerId=@p5", connection);
            command.Parameters.AddWithValue("@p1", txtName.Text);
            command.Parameters.AddWithValue("@p2", txtSurname.Text);
            command.Parameters.AddWithValue("@p3", cmbCity.Text);
            command.Parameters.AddWithValue("@p4", txtBalance.Text);
            command.Parameters.AddWithValue("@p5", txtID.Text);
            command.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Veriler Başarılı Bir Şekilde Güncellendi");
        }
    }
}
//Data Source=DESKTOP-07T8MF2\MSSQLSERVER01;Initial Catalog=DbistanbulAkademi;Integrated Security=True