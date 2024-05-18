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

namespace Gestion_de_location_des_voitures1
{
    public partial class Control : Form
    {
        public Control()
        {
            InitializeComponent();
        }

        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Dell\Documents\CarRentaldb.mdf;Integrated Security=True;Connect Timeout=30");
        private void Control_Load(object sender, EventArgs e)
        {
            string query = "select Count(*) from voiture";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, connection);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            indV.Text = dataTable.Rows[0][0].ToString();

            string query2 = "select Count(*) from client";
            SqlDataAdapter sqlDataAdapter2 = new SqlDataAdapter(query2, connection);
            DataTable dataTable2 = new DataTable();
            sqlDataAdapter2.Fill(dataTable2);
            indC.Text = dataTable2.Rows[0][0].ToString();

            string query3 = "select Count(*) from reservation";
            SqlDataAdapter sqlDataAdapter3 = new SqlDataAdapter(query3, connection);
            DataTable dataTable3= new DataTable();
            sqlDataAdapter3.Fill(dataTable3);
            indR.Text = dataTable3.Rows[0][0].ToString();
        }

        private void guna2CirclePictureBox5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainPage mainPage = new MainPage();
            mainPage.Show();
        }
    }
}
