using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetPrincipale
{
    public partial class BarreDeProgression : Form
    {
        public BarreDeProgression()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Desactiver les bouto
            button1.Enabled = false;
            button2.Enabled = false;

            // Curseu
            Cursor old = this.Cursor;
            this.Cursor = Cursors.WaitCursor;

            Random rnd = new Random();

            int nbFichiers = rnd.Next(5, 15); // entre 5 et 15 fichiers
            progressBar1.Minimum = 0;
            progressBar1.Maximum = nbFichiers;
            progressBar1.Value = 0;

            for (int i = 0; i < nbFichiers; i++)
            {
                // Taille aleatoire du fichié
                int taille = rnd.Next(200, 1000); // en ms

                label3.Text = $"Copie du fichier {i + 1}/{nbFichiers}";
                label3.Refresh();

                // Barre seondaire
                progressBar2.Minimum = 0;
                progressBar2.Maximum = taille;
                progressBar2.Value = 0;

                for (int j = 0; j < taille; j += 50)
                {
                    progressBar2.Value = j;
                    System.Threading.Thread.Sleep(10);
                }

                progressBar1.Value++;
            }

            // Retablir létat normal
            this.Cursor = old;
            button1.Enabled = true;
            button2.Enabled = true;

            label3.Text = "Copie terminée";

        }
    }
}
