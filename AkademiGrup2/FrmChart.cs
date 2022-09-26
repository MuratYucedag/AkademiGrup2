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
    public partial class FrmChart : Form
    {
        public FrmChart()
        {
            InitializeComponent();
        }

        private void FrmChart_Load(object sender, EventArgs e)
        {
            //Statik Chart

            chart1.Series["Series1"].Points.AddXY("Akdeniz", 50);
            chart1.Series["Series1"].Points.AddXY("Ege Bölgesi", 65);
            chart1.Series["Series1"].Points.AddXY("Karadeniz", 40);
            chart1.Series["Series1"].Points.AddXY("Marmara Bölgesi", 77);
            chart1.Series["Series1"].Points.AddXY("Doğu Anadolu", 32);

            //Dinamik Chart
            SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-07T8MF2\MSSQLSERVER01;initial Catalog=DbAkademiGrup2;integrated security=True");

            connection.Open();
            SqlCommand command = new SqlCommand("Select CustomerCity,Count(*) From TblCustomer Group By CustomerCity", connection);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                chart2.Series["Series1"].Points.AddXY(reader[0], reader[1]);
            }
            connection.Close();

            //chart 3
            connection.Open();
            SqlCommand command2 = new SqlCommand("Select CategoryName,Sum(ProductStock) From TblProduct inner join TblCategory on TblProduct.ProductCategory=TblCategory.CategoryID Group By CategoryName", connection);
            SqlDataReader reader2 = command2.ExecuteReader();
            while (reader2.Read())
            {
                chart3.Series["Kategoriler"].Points.AddXY(reader2[0], reader2[1]);
            }
            connection.Close();
        }
    }
}
