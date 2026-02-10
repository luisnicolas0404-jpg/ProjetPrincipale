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
    public partial class EcranListe : Form
    {
        string NomFichier = "";
        bool modeModification = false;
        int indexEnModification = -1;


        public EcranListe()
        {
            InitializeComponent();

        }

        private void gbDetail_Enter(object sender, EventArgs e)
        {

            cbQualiter.Items.Add("Madame");
            cbQualiter.Items.Add("Mademoiselle");
            cbQualiter.Items.Add("Monsieur");
            cbQualiter.Items.Add("Mondamoiseau");
            cbQualiter.Items.Add("Indéfini");
        }

        private void Activer(bool etat)
        {
            if (etat)
            {
                // Mode après CONFIRMER
                lbPersonne.Enabled = true;     // actif
                bmodifier.Enabled = true;      // actif

                bAjouter.Enabled = false;
                bSupprimer.Enabled = false;
                bOuvrir.Enabled = false;
                bEnregistrer.Enabled = false;

                
                bConfirmer.Enabled = false;
                bAnnulé.Enabled = false;
            }
            else
            {
                // Mode AJOUTER ou MODIFIER
                lbPersonne.Enabled = false;
                bmodifier.Enabled = false;

                bAjouter.Enabled = false;
                bSupprimer.Enabled = false;
                bOuvrir.Enabled = false;
                bEnregistrer.Enabled = false;

                gbDetail.Enabled = true;
                bConfirmer.Enabled = true;
                bAnnulé.Enabled = true;
            }


        }

        private void bAjouter_Click(object sender, EventArgs e)
        {
            tbNom.Text = "";
            cbQualiter.SelectedIndex = 0;
            Activer(false);

        }

        private void bSupprimer_Click(object sender, EventArgs e)
        {
            if (lbPersonne.SelectedIndex >= 0)
                lbPersonne.Items.RemoveAt(lbPersonne.SelectedIndex);

        }

        private void bConfirmer_Click(object sender, EventArgs e)
        {
            string nom = tbNom.Text;
            string qualite = cbQualiter.SelectedItem.ToString();
            string ligne = $"{nom} ({qualite})";

            if (modeModification)
            {
                // MODIFIER
                lbPersonne.Items[indexEnModification] = ligne;
            }
            else
            {
                // AJOUTER
                lbPersonne.Items.Add(ligne);
            }

            // Réinitialiser le mode
            modeModification = false;
            indexEnModification = -1;

            Activer(true);


        }

        private void bAnnulé_Click(object sender, EventArgs e)
        {
            Activer(true);
        }

        private void bOuvrir_Click(object sender, EventArgs e)
        {
            if (ofdOuvrir.ShowDialog() == DialogResult.OK)
            {
                NomFichier = ofdOuvrir.FileName;
                lbPersonne.Items.Clear();
                lbPersonne.Items.AddRange(System.IO.File.ReadAllLines(NomFichier));
            }

        }

        private void bEnregistrer_Click(object sender, EventArgs e)
        {
            if (sfdEnregistrer.ShowDialog() == DialogResult.OK)
            {
                NomFichier = sfdEnregistrer.FileName;

                List<string> lignes = new List<string>();
                foreach (var item in lbPersonne.Items)
                    lignes.Add(item.ToString());

                System.IO.File.WriteAllLines(NomFichier, lignes);
            }

        }

        private void lbPersonne_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbPersonne.SelectedIndex >= 0)
            {
                string texte = lbPersonne.SelectedItem.ToString();
                int index = lbPersonne.SelectedIndex;

                MessageBox.Show($"Ligne {index} : {texte}");
            }

        }

        private void bmodifier_Click(object sender, EventArgs e)
        {
            if (lbPersonne.SelectedIndex >= 0)
            {
                modeModification = true;
                indexEnModification = lbPersonne.SelectedIndex;

                string ligne = lbPersonne.SelectedItem.ToString();

                int pos = ligne.IndexOf("(");
                string nom = ligne.Substring(0, pos).Trim();
                string qualite = ligne.Substring(pos + 1).Replace(")", "").Trim();

                tbNom.Text = nom;
                cbQualiter.SelectedItem = qualite;

                Activer(false);
            }

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            gbDetail.Enabled = false;

        }
    }
}
