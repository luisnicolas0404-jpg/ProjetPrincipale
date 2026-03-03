using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetPrincipale
{
    public partial class EcranClavierSouris : Form
    {

        int nbGauche = 0;
        int nbDroit = 0;

        public EcranClavierSouris()
        {
            InitializeComponent();
            this.KeyPreview = true;
        }



        private void AfficherClic()
        {
            tbxClicGauche.Text = nbGauche.ToString();
            tbxClicDroit.Text = nbDroit.ToString();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            nbGauche = 0;
            nbDroit = 0;
            AfficherClic();

            tbxPositionX.Text = "";
            tbxPositionY.Text = "";

            listBox1.Items.Clear();

        }

        private void pnlSouris_Deplacement(object sender, MouseEventArgs e)
        {
            tbxPositionX.Text = e.X.ToString();
            tbxPositionY.Text = e.Y.ToString();
        }

        private void pnlSouris_Paint(object sender, MouseEventArgs e)
        {


        }

        private void Fenetre_ToucheEnfoncee(object sender, KeyEventArgs e)
        {
            listBox1.Items.Add($"Touche enfoncée : {e.KeyCode}");
        }

        // Touche tapé
        private void Fenetre_ToucheTapee(object sender, KeyPressEventArgs e)
        {
            listBox1.Items.Add($"Touche tapée : '{e.KeyChar}'");
        }

        // Touche relâché
        private void Fenetre_ToucheRelachee(object sender, KeyEventArgs e)
        {
            listBox1.Items.Add($"Touche relâchée : {e.KeyCode}");
        }

        private void pnlSouris_Click(object sender, MouseEventArgs e)
        {
            // Comptage de clic
            if (e.Button == MouseButtons.Left)
                nbGauche++;

            if (e.Button == MouseButtons.Right)
                nbDroit++;

            AfficherClic();

            tbxPositionX.Text = e.X.ToString();
            tbxPositionY.Text = e.Y.ToString();

            // Division en 9 case
            int largeurCase = pnlSouris.Width / 3;
            int hauteurCase = pnlSouris.Height / 3;

            int colonne = e.X / largeurCase;
            int ligne = e.Y / hauteurCase;

            listBox1.Items.Add($"Clic dans la case : ligne {ligne + 1}, colonne {colonne + 1}");
        }





















        private void lblClicGauche_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pnlSouris_Paint(object sender, PaintEventArgs e)
        {

        }

        
    }
}
