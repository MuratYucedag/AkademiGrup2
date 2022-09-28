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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-07T8MF2\MSSQLSERVER01;initial Catalog=DbAkademiGrup2;integrated security=True");

            connection.Open();
            SqlCommand command = new SqlCommand("Select * From TblAdmin where Username=@p1 and Password=@p2", connection);
            command.Parameters.AddWithValue("@p1", txtUsername.Text);
            command.Parameters.AddWithValue("@p2", txtPassword.Text);
            SqlDataReader dataReader = command.ExecuteReader();
            if (dataReader.Read())
            {
                FrmNavigation frm = new FrmNavigation();
                frm.Show();
            }
            else
            {
                MessageBox.Show("Hatalı kullanıcı adı veya şifre girdiniz");
            }
            connection.Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Şifremi Unuttum Sayfasına Yönlendiriliyorsunuz...");
        }

        int sayac = 0;
        private void button2_Click(object sender, EventArgs e)
        {
            sayac++;
            if (sayac == 1)
            {
                txtPassword.UseSystemPasswordChar = false;
                button2.Text = "Şifreyi Gizle";
            }
            if (sayac == 2)
            {
                txtPassword.UseSystemPasswordChar = true;
                button2.Text = "Şifreyi Göster";
                sayac = 0;
            }
        }

        private void lnlNewAccount_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmNewAccount frm = new FrmNewAccount();
            frm.Show();
        }
    }
}
