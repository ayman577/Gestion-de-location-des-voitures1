using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Guna.UI2.Native.WinApi;

namespace Gestion_de_location_des_voitures1
{
    public partial class Reservation : Form
    {
        public Reservation()
        {
            InitializeComponent();
        }

        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Dell\Documents\CarRentaldb.mdf;Integrated Security=True;Connect Timeout=30");

        private void NumData()
        {
            connection.Open();
            string query = "SELECT NumeroCli from client";
            SqlCommand sc = new SqlCommand(query, connection);
            SqlDataReader sDataReader;
            sDataReader = sc.ExecuteReader();
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("NumeroCli", typeof(int));
            dataTable.Load(sDataReader);
            aNumero.ValueMember = "NumeroCli";
            aNumero.DataSource = dataTable;
            connection.Close();
        }

        private void MatData()
        {
            connection.Open();
            string query = "SELECT Matricule from voiture";
            SqlCommand sc = new SqlCommand(query, connection);
            SqlDataReader sDataReader;
            sDataReader = sc.ExecuteReader();
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("Matricule", typeof(string));
            dataTable.Load(sDataReader);
            aMatricule.ValueMember = "Matricule";
            aMatricule.DataSource = dataTable;
            connection.Close();
        }

        private void guna2DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void guna2CirclePictureBox5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainPage mainPage = new MainPage();
            mainPage.Show();
        }

        private void aList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            aNumero.Text = aList.SelectedRows[0].Cells[0].Value.ToString();
            aMatricule.Text = aList.SelectedRows[0].Cells[1].Value.ToString();
            aDateD.Text = aList.SelectedRows[0].Cells[2].Value.ToString();
            aDate.Text = aList.SelectedRows[0].Cells[3].Value.ToString();
            aMontant.Text = aList.SelectedRows[0].Cells[4].Value.ToString();
            aStatus.Text = aList.SelectedRows[0].Cells[5].Value.ToString();
        }

        private void Reservation_Load(object sender, EventArgs e)
        {
            NumData();
            MatData();
            buffer();
        }

        private void SetDisponibleNon()
        {
            connection.Open();
            string query = "update voiture set disponsible='" + "Non" + "' where Matricule='" + aMatricule.Text + "'";

            SqlCommand sc = new SqlCommand(query, connection);
            sc.ExecuteNonQuery();
            connection.Close();
            buffer();
        }

        private void SetDisponibleOui()
        {
            connection.Open();
            string query = "update voiture set disponsible='" + "Oui" + "' where Matricule='" + aMatricule.Text + "'";

            SqlCommand sc = new SqlCommand(query, connection);
            sc.ExecuteNonQuery();
            connection.Close();
            buffer();
        }
        private void buffer()
        {
            connection.Open();
            string query = "select * from reservation";
            SqlDataAdapter sda = new SqlDataAdapter(query, connection);
            SqlCommandBuilder scb = new SqlCommandBuilder(sda);
            var dataSet = new DataSet();
            sda.Fill(dataSet);
            aList.DataSource = dataSet.Tables[0];
            connection.Close();
        }

        private void aNumero_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void guna2CirclePictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void aAjouter_Click(object sender, EventArgs e)
        {
            if (aNumero.Text == "" || aMatricule.Text == "" || aDateD.Text == "" || aDateF.Text == "" || aMontant.Text == "" || aStatus.Text == "")
            {
                MessageBox.Show("Données manquantes");
            }
            else
            {
                try
                {
                    connection.Open();
                    string query = "insert into reservation values (" + aNumero.Text + ",'" + aMatricule.Text + "','" + DateTime.Parse(aDateD.Text).ToString("yyyy-MM-dd") + "','" + DateTime.Parse(aDate.Text).ToString("yyyy-MM-dd") + "'," + aMontant.Text + ",'" + aStatus.Text + "')";

                    SqlCommand sc = new SqlCommand(query, connection);
                    sc.ExecuteNonQuery();
                    MessageBox.Show("La voiture a été réservée avec succès");
                    connection.Close();
                    buffer();
                    SetDisponibleNon();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            if (aMatricule.Text == "")
            {
                MessageBox.Show("S'il vous plaît, saisissez l'immatriculation de la voiture que vous souhaitez annuler la location.");
            }
            else
            {
                try
                {
                    connection.Open();
                    string query = "delete from reservation where matricule ='" + aMatricule.Text + "'";
                    SqlCommand sc = new SqlCommand(query, connection);
                    sc.ExecuteNonQuery();
                    MessageBox.Show("La location de la voiture a été annulée.");
                    connection.Close();
                    buffer();
                    SetDisponibleOui();
                    aMatricule.Text = "";
                    aNumero.Text = "";
                    aDateD.Text = "";
                    aDate.Text = "";
                    aStatus.Text = "";
                    aMontant.Text = "";
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            if (aMatricule.Text == "" || aNumero.Text == "" || aDateD.Text == "" || aDate.Text == "" || aMontant.Text == "" || aStatus.Text == "")
            {
                MessageBox.Show("Données manquantes");
            }
            else
            {
                try
                {
                    connection.Open();
                    string query = "update reservation set Matricule='" + aMatricule.Text + "',NumeroCli='" + aNumero.Text + "', date_D_Reservation='" + DateTime.Parse(aDateD.Text).ToString("yyyy-MM-dd") + "',date_F_Reservation='" + DateTime.Parse(aDateD.Text).ToString("yyyy-MM-dd") + "',status='" + aStatus.Text + "', Montant=" + aMontant.Text + " where Matricule='" + aMatricule.Text + "'";

                    SqlCommand sc = new SqlCommand(query, connection);
                    sc.ExecuteNonQuery();
                    MessageBox.Show("Mise à jour de la voiture effectuée avec succès.");
                    connection.Close();
                    buffer();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainPage mainPage = new MainPage();
            mainPage.Show();
        }
    }
}
