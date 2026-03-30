
using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Mes_Controles
{
    [ToolboxBitmap(typeof(Button))]
    public class BoutonColore : Button
    {
        private Color cGauche = Color.Blue;
        private Color cDroite = Color.Red;
        private int tGauche = 255;
        private int tDroite = 255;

        [Category("Couleurs")]
        public Color CouleurGauche
        {
            get => cGauche;
            set { cGauche = value; Invalidate(); }
        }

        [Category("Couleurs")]
        public Color CouleurDroite
        {
            get => cDroite;
            set { cDroite = value; Invalidate(); }
        }

        [Category("Couleurs")]
        public int TransparenceGauche
        {
            get => tGauche;
            set
            {
                if (value < 0) value = 0;
                if (value > 255) value = 255;
                tGauche = value;
                Invalidate();
            }
        }

        [Category("Couleurs")]
        public int TransparenceDroite
        {
            get => tDroite;
            set
            {
                if (value < 0) value = 0;
                if (value > 255) value = 255;
                tDroite = value;
                Invalidate();
            }
        }

        protected override void OnPaint(PaintEventArgs pevent)
        {
            using (Bitmap bmp = new Bitmap(Width, Height))
            using (Graphics g = Graphics.FromImage(bmp))
            {
                Color cg = Color.FromArgb(tGauche, cGauche);
                Color cd = Color.FromArgb(tDroite, cDroite);

                using (var br = new LinearGradientBrush(ClientRectangle, cg, cd, 0f))
                {
                    g.FillRectangle(br, ClientRectangle);
                }

                var size = g.MeasureString(Text, Font);
                g.DrawString(Text, Font, new SolidBrush(ForeColor),
                    (Width - size.Width) / 2,
                    (Height - size.Height) / 2);

                pevent.Graphics.DrawImage(bmp, 0, 0);
            }
        }
    }
}
