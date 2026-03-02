using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetPrincipale
{


    public partial class Spirographe : Form
    {
        Color cFond;
        Color cTrait;
        GraphicsPath gpSauvegarde;
        public Spirographe()
        {
            InitializeComponent();
        }

        private void EcranSpirographe_Load(object sender, EventArgs e)
        {
            cFond = Color.Black;
            cTrait = Color.Cyan;
            gpSauvegarde = null;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            if (gpSauvegarde != null)
            {
                e.Graphics.FillRectangle(
                    new SolidBrush(cFond),
                    new Rectangle(new Point(248, 0), ClientSize)
                );

                e.Graphics.DrawPath(new Pen(cTrait), gpSauvegarde);
            }
        }




        private void lProfondeur_Click(object sender, EventArgs e)
        {

        }

        private void Spirographe_Load(object sender, EventArgs e)
        {

        }

        private void bFond_Click(object sender, EventArgs e)
        {
            if (cdCouleur.ShowDialog() == DialogResult.OK)
            {
                cFond = cdCouleur.Color;
                Invalidate(); // redessine
            }

        }

        private void bTrait_Click(object sender, EventArgs e)
        {
            if (cdCouleur.ShowDialog() == DialogResult.OK)
            {
                cTrait = cdCouleur.Color;
                Invalidate();
            }

        }

        private void bGo_Click(object sender, EventArgs e)
        {
            int iSommets = tbSommets.Value;
            int iDensite = tbDensite.Value;
            int iProfondeur = tbProfondeur.Value;

            // Zone de dessin
            int x0 = 248;
            int largeur = ClientSize.Width - x0;
            int hauteur = ClientSize.Height;

            int xc = x0 + largeur / 2;
            int yc = hauteur / 2;
            int rayon = Math.Min(largeur, hauteur) / 2 - 10;

            double[] sx = new double[iSommets + 1];
            double[] sy = new double[iSommets + 1];

            // Calcul des sommets initiaux
            for (int i = 0; i < iSommets; i++)
            {
                sx[i] = xc + rayon * Math.Cos(2 * Math.PI * i / iSommets);
                sy[i] = yc + rayon * Math.Sin(2 * Math.PI * i / iSommets);
            }
            sx[iSommets] = sx[0];
            sy[iSommets] = sy[0];

            gpSauvegarde = new GraphicsPath();

            // Boucle de profondeur
            while (Distance(xc, yc, sx[0], sy[0]) > rayon * iProfondeur / 100.0)
            {
                // Dessiner le polygone
                for (int i = 0; i < iSommets; i++)
                    gpSauvegarde.AddLine((float)sx[i], (float)sy[i], (float)sx[i + 1], (float)sy[i + 1]);

                // Calcul des nouveaux sommets
                for (int i = 0; i < iSommets; i++)
                {
                    sx[i] = sx[i] + (sx[i + 1] - sx[i]) / iDensite;
                    sy[i] = sy[i] + (sy[i + 1] - sy[i]) / iDensite;
                }
                sx[iSommets] = sx[0];
                sy[iSommets] = sy[0];
            }

            Invalidate();
        }

        private double Distance(double x1, double y1, double x2, double y2)
        {
            return Math.Sqrt((x1 - x2) * (x1 - x2) + (y1 - y2) * (y1 - y2));

        }
    }
}
