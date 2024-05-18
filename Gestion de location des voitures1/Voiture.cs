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
    public partial class Voiture : Form
    {
        public Voiture()
        {
            InitializeComponent();
        }

        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Dell\Documents\CarRentaldb.mdf;Integrated Security=True;Connect Timeout=30");

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Voiture_Load(object sender, EventArgs e)
        {
            buffer();
        }

        private void buffer()
        {
            connection.Open();
            string query = "select * from voiture";
            SqlDataAdapter sda = new SqlDataAdapter(query, connection);
            SqlCommandBuilder scb = new SqlCommandBuilder(sda);
            var dataSet = new DataSet();
            sda.Fill(dataSet);
            aList.DataSource = dataSet.Tables[0];
            connection.Close();
        }

        private void aAjouter_Click(object sender, EventArgs e)
        {
            if (aMatricule.Text == "" || aModele.Text == "" || aMarque.Text == "" || aKm.Text == "" || aCarburant.Text == "" || aDisponsible.Text == "")
            {
                MessageBox.Show("Données manquantes");
            }
            else
            {
                try
                {
                    connection.Open();
                    string query = "insert into voiture values ('" + aMatricule.Text + "','" + aModele.Text + "','" + aMarque.Text + "'," + aKm.Text + ",'" + aCarburant.Text + "','" + aDisponsible.Text + "')";

                    SqlCommand sc = new SqlCommand(query, connection);
                    sc.ExecuteNonQuery();
                    MessageBox.Show("La voiture a été ajoutée");
                    connection.Close();
                    buffer();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void aList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void aList_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            aMatricule.Text = aList.SelectedRows[0].Cells[0].Value.ToString();
            aMarque.Text = aList.SelectedRows[0].Cells[1].Value.ToString();
            aModele.Text = aList.SelectedRows[0].Cells[2].Value.ToString();
            aKm.Text = aList.SelectedRows[0].Cells[3].Value.ToString();
            aCarburant.Text = aList.SelectedRows[0].Cells[4].Value.ToString();
            aDisponsible.Text = aList.SelectedRows[0].Cells[5].Value.ToString();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            if (aMatricule.Text == "")
            {
                MessageBox.Show("S'il vous plaît, saisissez l'immatriculation de la voiture que vous souhaitez supprimer.");
            }
            else
            {
                try
                {
                    connection.Open();
                    string query = "delete from voiture where Matricule ='" + aMatricule.Text + "'";
                    SqlCommand sc = new SqlCommand(query, connection);
                    sc.ExecuteNonQuery();
                    MessageBox.Show("Voiture supprimé.");
                    connection.Close();
                    buffer();
                    aMatricule.Text = "";
                    aMarque.Text = "";
                    aModele.Text = "";
                    aCarburant.Text = "";
                    aKm.Text = "";
                    aDisponsible.Text = "";
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            if (aMatricule.Text == "" || aModele.Text == "" || aMarque.Text == "" || aKm.Text == "" || aCarburant.Text == "" || aDisponsible.Text == "")
            {
                MessageBox.Show("Données manquantes");
            }
            else
            {
                try
                {
                    connection.Open();
                    string query = "update voiture set Modele='" + aModele.Text + "',marque='" + aMarque.Text + "', km=" + aKm.Text + ",carburant='" + aCarburant.Text + "',disponsible='" + aDisponsible.Text + "' where Matricule='" + aMatricule.Text + "'";

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

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainPage mainPage = new MainPage();
            mainPage.Show();
        }

        private void guna2CirclePictureBox5_Click(object sender, EventArgs e)
        {
            Application.Exit();
            ;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainPage mainPage = new MainPage();
            mainPage.Show();
        }

        private void Label55_Click(object sender, EventArgs e)
        {

        }
    }
}
