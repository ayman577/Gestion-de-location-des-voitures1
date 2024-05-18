using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
    public partial class client : Form
    {
        public client()
        {
            InitializeComponent();
        }

        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Dell\Documents\CarRentaldb.mdf;Integrated Security=True;Connect Timeout=30");


        private void guna2CirclePictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void guna2CirclePictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void client_Load(object sender, EventArgs e)
        {
            buffer();
        }
        private void buffer()
        {
            connection.Open();
            string query = "select * from client";
            SqlDataAdapter sda = new SqlDataAdapter(query, connection);
            SqlCommandBuilder scb = new SqlCommandBuilder(sda);
            var dataSet = new DataSet();
            sda.Fill(dataSet);
            aList.DataSource = dataSet.Tables[0];
            connection.Close();
        }
        private void guna2TextBox4_TextChanged(object sender, EventArgs e)
        {
        }

        private void aAjouter_Click(object sender, EventArgs e)
        {
            if (aNumero.Text == "" || aNom.Text == "" || aPrenom.Text == "" || aVille.Text == "" || aAdresse.Text == "" || aTel.Text == "" || aEmail.Text == "")
            {
                MessageBox.Show("Données manquantes");
            }
            else
            {
                try
                {
                    connection.Open();
                    string query = "insert into client values (" + aNumero.Text + ",'" + aNom.Text + "','" + aPrenom.Text + "','" + aVille.Text + "','" + aAdresse.Text + "'," + aTel.Text + ",'" + aEmail.Text + "')";

                    SqlCommand sc = new SqlCommand(query, connection);
                    sc.ExecuteNonQuery();
                    MessageBox.Show("Le client a été ajouté.");
                    connection.Close();
                    buffer();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            if (aNumero.Text == "")
            {
                MessageBox.Show("S'il vous plaît, saisissez le numéro du client que vous souhaitez supprimer.");
            }
            else
            {
                try
                {
                    connection.Open();
                    string query = "delete from client where NumeroCli ='" + aNumero.Text + "'";
                    SqlCommand sc = new SqlCommand(query, connection);
                    sc.ExecuteNonQuery();
                    MessageBox.Show("client supprimé.");
                    connection.Close();
                    buffer();
                    aNom.Text = "";
                    aPrenom.Text = "";
                    aAdresse.Text = "";
                    aNumero.Text = "";
                    aVille.Text = "";
                    aTel.Text = "";
                    aEmail.Text = "";
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            if (aNumero.Text == "" || aNom.Text == "" || aPrenom.Text == "" || aAdresse.Text == "" || aVille.Text == "" || aTel.Text == "" || aEmail.Text == "")
            {
                MessageBox.Show("Données manquantes");
            }
            else
            {
                try
                {
                    connection.Open();
                    string query = "update client set nom='" + aNom.Text + "',prenom='" + aPrenom.Text + "', adresse='" + aAdresse.Text + "',ville='" + aVille.Text + "',tel=" + aTel.Text + ",email='" + aEmail.Text + "' where NumeroCli='" + aNumero.Text + "'";

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

        private void aList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            aNumero.Text = aList.SelectedRows[0].Cells[0].Value.ToString();
            aNom.Text = aList.SelectedRows[0].Cells[1].Value.ToString();
            aPrenom.Text = aList.SelectedRows[0].Cells[2].Value.ToString();
            aAdresse.Text = aList.SelectedRows[0].Cells[3].Value.ToString();
            aVille.Text = aList.SelectedRows[0].Cells[4].Value.ToString();
            aTel.Text = aList.SelectedRows[0].Cells[5].Value.ToString();
            aEmail.Text = aList.SelectedRows[0].Cells[5].Value.ToString();
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainPage mainPage = new MainPage();
            mainPage.Show();
        }
    }
}
