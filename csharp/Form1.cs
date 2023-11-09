using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace DevoirDemainR6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ConnexionSql();
        }
        private bool connection
        { get; set; }
        private void ConnexionSql()
        {
            string connectionlogin = "Server=127.0.0.1;Database=connexion;Uid=root;";
            MySqlConnection connexion = new MySqlConnection(connectionlogin);
            try
            {
                // Ouvrir la connexion
                connexion.Open();
                MessageBox.Show("Connexion réussie");
                connection = true;
                // Fermer la connexion
                connexion.Close();
            }
            catch (Exception ex)
            {
                connection = false; 
                MessageBox.Show("Erreur de connexion : " + ex.Message);
            }
        }
        private bool VerifierIdentifiants(string login, string password)
        {
            string connectionlogin = "Server=127.0.0.1;Database=connexion;Uid=root;";
            MySqlConnection connexion = new MySqlConnection(connectionlogin);

            string query = "SELECT * FROM account WHERE Login = @login AND Password = @password";
            MySqlCommand cmd = new MySqlCommand(query, connexion);
            cmd.Parameters.AddWithValue("@login", login);
            cmd.Parameters.AddWithValue("@password", password);

            try
            {
                connexion.Open();
                MySqlDataReader dataReader = cmd.ExecuteReader();
                if (dataReader.HasRows)
                {
                    dataReader.Close();
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de la vérification : " + ex.Message);
            }
            finally
            {
                connexion.Close();
            }

            return false;
        }
        private async void button1_Click(object sender, EventArgs e)
        {
            if (connection == true)
            {
                if (!VerifierIdentifiants(identifiant.Text, motdepasse.Text))
                {
                    Fail.Visible = true;
                    sucess.Visible = false;

                    Fail.Text = "Identifiant ou mot de passe incorrect";
                }
                else
                {
                    sucess.Visible = true;
                    Fail.Visible = false;
                    sucess.Text = " Vous ètes connecté";
                    waiter();
                }
            }
            else
            {
                Fail.Visible = true;
                Fail.Text = " impossible de vous connecter";
            }
        }
        private async void waiter()
        {
            await Task.Delay(1000);
            sucess.Text = " Vous allez être rediger...";
            await Task.Delay(10000);
            PageHome();
        }
        private void PageHome()
        {
            // page de connexion enlever
            Fail.Visible = false;
            sucess.Visible = false;
            label3.Visible = false;
            identifiant.Visible = false;
            label2.Visible = false;
            label1.Visible = false;
            button1.Visible = false;
            motdepasse.Visible = false;
            // page de home
            label4.Visible = true;
        }
    }
}
