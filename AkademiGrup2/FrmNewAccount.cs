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
    public partial class FrmNewAccount : Form
    {
        public FrmNewAccount()
        {
            InitializeComponent();
        }

        //Geriye Değer Döndürmeyen Metotlar --> void
        //Geriye Değer Döndüren Metotlar

        //metodun türü metot adı ()
        //{
        //işlemler
        //}

        void CreateCaptcha()
        {
            string[] characters = { "a", "b", "c", "d", "e", "f", "g", "h" };
            string[] symbols = { "*", "/", "+", "?", "#", "%" };
            Random rnd = new Random();
            int s1, s2, s3, s4, s5;
            s1 = rnd.Next(0, 8);
            s2 = rnd.Next(0, 10);
            s3 = rnd.Next(0, 8);
            s4 = rnd.Next(0, 10);
            s5 = rnd.Next(0, 6);
            txtCaptcha.Text = characters[s1] + s2 + characters[s3] + s4 + symbols[s5];
        }

        void ClearTextbox()
        {
            txtCaptcha.Text = "";
            txtCaptcha2.Text = "";
            txtConfirmPassword.Text = "";
            txtPassword.Text = "";
            txtUsername.Text = "";
            txtUsername.Focus();
            CreateCaptcha();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-07T8MF2\MSSQLSERVER01;initial Catalog=DbAkademiGrup2;integrated security=True");

            if (txtPassword.Text == txtConfirmPassword.Text && txtCaptcha.Text == txtCaptcha2.Text && txtUsername.Text!="")
            {
                connection.Open();
                SqlCommand command = new SqlCommand("insert into TblAdmin (Username,Password) values (@p1,@p2)", connection);
                command.Parameters.AddWithValue("@p1", txtUsername.Text);
                command.Parameters.AddWithValue("@p2", txtPassword.Text);
                command.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Kaydınız başarılı bir şekilde oluşturuldu, Login formundan giriş yapabilirsiniz...");
            }
            else
            {
                MessageBox.Show("Lütfen şifreyi kontrol edin veya alanları boş geçmeyin");
                ClearTextbox();
            }
        }

        private void FrmNewAccount_Load(object sender, EventArgs e)
        {
            //a1a1*    SQL--> Prosedür
            CreateCaptcha();
        }

        private void btnCaptcha_Click(object sender, EventArgs e)
        {
            CreateCaptcha();
        }
    }
}
