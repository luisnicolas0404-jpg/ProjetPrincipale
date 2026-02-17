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
    public partial class EcranEditeur : Form
    {

        string sFichier = "";
        bool bModifier = false;
        public EcranEditeur()
        {
            InitializeComponent();
            rtbTexte.TextChanged += (s, e) => bModifier = true;

        }
        private void FichierEnregistrer()
        {
            if (sFichier == "")
            {
                if (sfdenregistrer.ShowDialog() == DialogResult.OK)
                    sFichier = sfdenregistrer.FileName;
                else
                    return;
            }

            System.IO.File.WriteAllText(sFichier, rtbTexte.Rtf);
            bModifier = false;
        }

        private bool VerifierSauver()
        {
            if (!bModifier)
                return true;

            DialogResult rep = MessageBox.Show(
                "Le document a été modifié. Voulez-vous enregistrer ?",
                "Attention",
                MessageBoxButtons.YesNoCancel
            );

            if (rep == DialogResult.Yes)
            {
                FichierEnregistrer();
                return true;
            }
            if (rep == DialogResult.No)
                return true;

            return false; // Fermer
        }


        // FICHIER
        private void nouveauToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!VerifierSauver()) return;

            rtbTexte.Clear();
            sFichier = "";
            bModifier = false;

        }

        private void ouvrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!VerifierSauver()) return;

            if (ofdOuvrir.ShowDialog() == DialogResult.OK)
            {
                sFichier = ofdOuvrir.FileName;
                rtbTexte.Rtf = System.IO.File.ReadAllText(sFichier);
                bModifier = false;
            }
        }

        private void enregistrerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FichierEnregistrer();

        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (VerifierSauver())
                this.Close();
        }

        // EDITER

        private void editerToolStripMenuItem_Click(object sender, EventArgs e)
        {


        }

        private void copierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtbTexte.Copy();
        }

        private void collerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtbTexte.Cut();

        }

        private void collerToolStripMenuItem1_Click(object sender, EventArgs e)
        {

            rtbTexte.Paste();

        }

        // FORMAT : JUSTIFICATION
        private void gaucheToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtbTexte.SelectionAlignment = HorizontalAlignment.Left;

        }

        private void centreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtbTexte.SelectionAlignment = HorizontalAlignment.Center;

        }

        private void droiteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtbTexte.SelectionAlignment = HorizontalAlignment.Right;
        }

        // FORMAT : POLICE
        private void policeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fdPolice.ShowDialog() == DialogResult.OK)
                rtbTexte.SelectionFont = fdPolice.Font;

        }

        // FORMA

        private void ToggleStyle(FontStyle style)
        {
            Font current = rtbTexte.SelectionFont;

            if (current == null) return;

            FontStyle newStyle;

            if (current.Style.HasFlag(style))
                newStyle = current.Style & ~style;   // enleve
            else
                newStyle = current.Style | style;    // ajoute

            rtbTexte.SelectionFont = new Font(current, newStyle);
        }

        private void grasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToggleStyle(FontStyle.Bold);

        }

        private void italiqueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToggleStyle(FontStyle.Italic);
        }

        private void soulignéToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToggleStyle(FontStyle.Underline);
        }

        private void barrerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToggleStyle(FontStyle.Strikeout);

        }

       
    }
}

