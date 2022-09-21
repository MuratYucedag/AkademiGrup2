using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
            if (textBox1.Text == "admin" && textBox2.Text == "1234")
            {
                MessageBox.Show("Stok Takip Programı Admin Paneline Hoş Geldiniz");
            }
            else
            {
                MessageBox.Show("Hatalı kullanıcı adı veya şifre!");
            }
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
                textBox2.UseSystemPasswordChar = false;
                button2.Text = "Şifreyi Gizle";
            }
            if (sayac == 2)
            {
                textBox2.UseSystemPasswordChar = true;
                button2.Text = "Şifreyi Göster";
                sayac = 0;
            }
        }
    }
}
