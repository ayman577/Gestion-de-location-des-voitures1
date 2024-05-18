using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Gestion_de_location_des_voitures1
{
    public partial class Connexion : Form
    {
        public Connexion()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Dell\Documents\CarRentaldb.mdf;Integrated Security=True;Connect Timeout=30");

        private void buffer()
        {
            con.Open();
            string query = "select * from connexion";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            SqlCommandBuilder scb = new SqlCommandBuilder(sda);
            var dataSet = new DataSet();
            sda.Fill(dataSet);
            connexionList.DataSource = dataSet.Tables[0];
            con.Close();
        }
        private void label6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            if (aLogin.Text == "" || aPassword.Text == "" || aProfil.Text == "")
            {
                MessageBox.Show("Données manquantes");
            }
            else
            {
                try
                {
                    con.Open();
                    string query = "insert into connexion values ('" + aLogin.Text + "','" + aPassword.Text + "','" + aProfil.Text + "')";

                    SqlCommand sc = new SqlCommand(query, con);
                    sc.ExecuteNonQuery();
                    MessageBox.Show("L'utilisateur a été ajouté");
                    con.Close();
                    buffer();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void Connexion_Load(object sender, EventArgs e)
        {
            buffer();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void aLogin_TextChanged(object sender, EventArgs e)
        {

        }

        private void connexionList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            aLogin.Text = connexionList.SelectedRows[0].Cells[0].Value.ToString();
            aPassword.Text = connexionList.SelectedRows[0].Cells[1].Value.ToString();
            aProfil.Text = connexionList.SelectedRows[0].Cells[2].Value.ToString();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            if (aLogin.Text == "")
            {
                MessageBox.Show("S'il vous plaît, saisissez le nom de l'utilisateur que vous souhaitez supprimer.");
            }
            else
            {
                try
                {
                    con.Open();
                    string query = "delete from connexion where login ='" + aLogin.Text + "'";
                    SqlCommand sc = new SqlCommand(query, con);
                    sc.ExecuteNonQuery();
                    MessageBox.Show("Utilisateur supprimé.");
                    con.Close();
                    buffer();
                    aLogin.Text = "";
                    aPassword.Text = "";
                    aProfil.Text = "";
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            if (aLogin.Text == "" || aPassword.Text == "" || aProfil.Text == "")
            {
                MessageBox.Show("Données manquantes");
            }
            else
            {
                try
                {
                    con.Open();
                    string query = "update connexion set password='" + aPassword.Text + "',profil='" + aProfil.Text + "' where login='" + aLogin.Text + "'";

                    SqlCommand sc = new SqlCommand(query, con);
                    sc.ExecuteNonQuery();
                    MessageBox.Show("Mise à jour de l'utilisateur effectuée avec succès.\r\n");
                    con.Close();
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
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainPage mainPage = new MainPage();
            mainPage.Show();
        }
    }
}
