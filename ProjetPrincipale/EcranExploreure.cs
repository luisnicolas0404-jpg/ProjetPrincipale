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
    public partial class EcranExploreure : Form
    {
        public EcranExploreure()
        {
            InitializeComponent();
            RemplirTreeView();

        }

        private void RemplirTreeView()
        {
            tvRepertoire.Nodes.Clear();
            LireDisques();
        }

        private void LireDisques()
        {
            string[] disques = Environment.GetLogicalDrives();

            foreach (string d in disques)
            {
                TreeNode noeudDisque = new TreeNode(d);
                noeudDisque.Tag = d;
                tvRepertoire.Nodes.Add(noeudDisque);

                LireRepertoires(noeudDisque, d);
            }
        }

        private void LireRepertoires(TreeNode parent, string chemin)
        {
            try
            {
                string[] repertoires = Directory.GetDirectories(chemin);

                foreach (string rep in repertoires)
                {
                    string nom = Path.GetFileName(rep);
                    TreeNode noeud = new TreeNode(nom);
                    noeud.Tag = rep;
                    parent.Nodes.Add(noeud);

                    LireRepertoires(noeud, rep);
                }
            }
            catch { /* accès refusé → on ignore */ }
        }


        private void tvRepertoire_AfterSelect(object sender, TreeViewEventArgs e)
        {
            string chemin = e.Node.Tag.ToString();

            
            if (chemin == "Poste de travail")
                return;

            LireFichiers(chemin);
        }

        private void LireFichiers(string chemin)
        {
            lvFichier.Items.Clear();

            try
            {
                string[] fichiers = Directory.GetFiles(chemin);

                foreach (string f in fichiers)
                {
                    FileInfo info = new FileInfo(f);

                    ListViewItem item = new ListViewItem(info.Name);
                    item.SubItems.Add(info.Length.ToString());
                    item.SubItems.Add(info.CreationTime.ToString());
                    item.SubItems.Add(info.LastWriteTime.ToString());

                    lvFichier.Items.Add(item);
                }
            }
            catch { /* accès refusé → on ignore */ }
        }


        private void petitIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lvFichier.View = View.SmallIcon;
        }

        private void splitContainer2_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void grandIconesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lvFichier.View = View.LargeIcon;
        }

        private void listeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lvFichier.View = View.List;

        }

        private void detailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lvFichier.View = View.Details;

        }

        private string NomFichier(string chemin)
        {
            return Path.GetFileName(chemin);
        }

        private void tsbQuitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
