using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;


namespace ProjetPrincipale
{
    public partial class EcranListe : Form
    {
        string NomFichier = "";
        bool modeModification = false;
        int indexEnModification = -1;


        // API Windows
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern IntPtr SendMessage(IntPtr hWnd, int msg, IntPtr wParam, IntPtr lParam);

        private const int smLire = 0x0199;   
        private const int smEcrire = 0x019A; 

        // Compteur pour la donné caché (numéro d'encodage)
        int compteurEncodage = 1;

        public EcranListe()
        {
            InitializeComponent();
            lbPersonne.Sorted = true;


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
                // Mode après confirme
                lbPersonne.Enabled = true;     // actif
                bmodifier.Enabled = true;    

                bAjouter.Enabled = true;
                bSupprimer.Enabled = true;
                bOuvrir.Enabled = false;
                bEnregistrer.Enabled = true;

                
                bConfirmer.Enabled = false;
                bAnnulé.Enabled = false;
            }
            else
            {
                
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
            {
                int index = lbPersonne.SelectedIndex;

                // Lire la donné cache suprime
                int codeSupprime = (int)SendMessage(
                    lbPersonne.Handle,
                    smLire,
                    (IntPtr)index,
                    IntPtr.Zero
                );

                // Supprime lélement
                lbPersonne.Items.RemoveAt(index);

                // Réorganise les donné caché
                for (int i = 0; i < lbPersonne.Items.Count; i++)
                {
                    int code = (int)SendMessage(
                        lbPersonne.Handle,
                        smLire,
                        (IntPtr)i,
                        IntPtr.Zero
                    );

                    if (code > codeSupprime)
                    {
                        SendMessage(
                            lbPersonne.Handle,
                            smEcrire,
                            (IntPtr)i,
                            (IntPtr)(code - 1)
                        );
                    }
                }

                // Metre a jour le compteur
                compteurEncodage--;
            }


        }

        private void bConfirmer_Click(object sender, EventArgs e)
        {
            string nom = tbNom.Text;
            string qualite = cbQualiter.SelectedItem.ToString();
            string ligne = $"{nom} ({qualite})";

            if (modeModification)
            {
                // modifi
                lbPersonne.Items[indexEnModification] = ligne;
            }
            else
            {
                // ajoute
                int index = lbPersonne.Items.Add(ligne);

                // donné cache
                SendMessage(
                    lbPersonne.Handle,
                    smEcrire,
                    (IntPtr)index,
                    (IntPtr)compteurEncodage
                );

                compteurEncodage++;
            }

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

                string[] lignes = System.IO.File.ReadAllLines(NomFichier);

                foreach (string ligne in lignes)
                {
                    int pos = ligne.LastIndexOf("#");

                    string texte = ligne.Substring(0, pos);
                    int code = int.Parse(ligne.Substring(pos + 1));

                    int index = lbPersonne.Items.Add(texte);

                    // Remettre la donné caché
                    SendMessage(
                        lbPersonne.Handle,
                        smEcrire,
                        (IntPtr)index,
                        (IntPtr)code
                    );

                    // Mettre à jour le compteur pour les prochain ajout
                    if (code >= compteurEncodage)
                        compteurEncodage = code + 1;
                }
            }


        }

        private void bEnregistrer_Click(object sender, EventArgs e)
        {
            if (sfdEnregistrer.ShowDialog() == DialogResult.OK)
            {
                NomFichier = sfdEnregistrer.FileName;

                List<string> lignes = new List<string>();

                for (int i = 0; i < lbPersonne.Items.Count; i++)
                {
                    string texte = lbPersonne.Items[i].ToString();

                    // Lire la donné caché
                    int code = (int)SendMessage(
                        lbPersonne.Handle,
                        smLire,
                        (IntPtr)i,
                        IntPtr.Zero
                    );

                    // Ajouter dans le fichier
                    lignes.Add(texte + "#" + code);
                }

                System.IO.File.WriteAllLines(NomFichier, lignes);
            }


        }

        private void lbPersonne_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = lbPersonne.SelectedIndex;
            if (index < 0) return;

            string texte = lbPersonne.SelectedItem.ToString();

            // lire la donné caché
            int code = (int)SendMessage(
                lbPersonne.Handle,
                smLire,
                (IntPtr)index,
                IntPtr.Zero
            );

            MessageBox.Show(
                $"Index : {index}\n" +
                $"Texte : {texte}\n" +
                $"Donnée cachée : {code}"
            );


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
