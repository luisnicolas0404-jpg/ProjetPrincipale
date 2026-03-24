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


namespace ProjetPrincipale
{
    public partial class EcranBDDirect : Form
    {
        public EcranBDDirect()
        {
            InitializeComponent();
        }

        private void EcranBDDirect_Load(object sender, EventArgs e)
        {

        }

        private void bConsulter_Click(object sender, EventArgs e)
        {
            lbconsole.Items.Clear();

            string chaine = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\PROJET_PROGRA_Q2\PROJETPRINCIPALE\PROJETPRINCIPALE\BDD\DATABASE1.MDF;Integrated Security=True";
            SqlConnection cnx = new SqlConnection(chaine);

            cnx.Open();

            SqlCommand cmd = new SqlCommand("SELECT NumCli, Prenom, Nom FROM [Table]", cnx);

            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                string ligne = $"{dr["Prenom"]} {dr["Nom"]} ({dr["NumCli"]})";
                lbconsole.Items.Add(ligne);
            }

            dr.Close();
            cnx.Close();

        }

        private void bDenombrer_Click(object sender, EventArgs e)
        {
            lbconsole.Items.Clear();

            string chaine = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Projet_Progra_Q2\ProjetPrincipale\ProjetPrincipale\BDD\Database1.mdf;Integrated Security=True";
            SqlConnection cnx = new SqlConnection(chaine);

            cnx.Open();

            SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM [Table]", cnx);

            int nb = (int)cmd.ExecuteScalar();

            lbconsole.Items.Add($"Nombre d'enregistrements : {nb}");

            cnx.Close();

        }

        private void bAjouter_Click(object sender, EventArgs e)
        {
            string prenom = tbPrenom.Text;
            string nom = tbNom.Text;

            if (prenom == "" || nom == "")
            {
                MessageBox.Show("Veuillez remplir les deux champs !");
                return;
            }

            string chaine = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Projet_Progra_Q2\ProjetPrincipale\ProjetPrincipale\BDD\Database1.mdf;Integrated Security=True";
            SqlConnection cnx = new SqlConnection(chaine);

            cnx.Open();

            SqlCommand cmd = new SqlCommand(
     "INSERT INTO [Table] (Prenom, Nom) VALUES (@p, @n)", cnx);



            cmd.Parameters.AddWithValue("@p", prenom);
            cmd.Parameters.AddWithValue("@n", nom);

            cmd.ExecuteNonQuery();

            cnx.Close();

            lbconsole.Items.Add($"Ajouté : {prenom} {nom}");

        }
    }
}
