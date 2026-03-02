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
    public partial class Horloge : Form
    {
        private System.Windows.Forms.Timer t;

        public Horloge()
        {
            InitializeComponent();
        }

        private void Horloge_Load(object sender, EventArgs e)
        {
            t = new System.Windows.Forms.Timer();
            t.Interval = 50;              // 20 FPS pour aiguilles fluides
            t.Tick += Timer_Tick;         // relie l'événement Tick
            t.Start();                    // démarre le timer
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            Invalidate();                 // redessine l’horloge

        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            int w = ClientSize.Width;
            int h = ClientSize.Height;
            int r = Math.Min(w, h) / 2 - 20;

            int xc = w / 2;
            int yc = h / 2;

            DateTime now = DateTime.Now;

            // Affichage dans la barre de titre
            Text = now.ToString("HH:mm:ss");

            // Aiguilles progressives
            double sec = now.Second + now.Millisecond / 1000.0;
            double min = now.Minute + sec / 60.0;
            double hour = (now.Hour % 12) + min / 60.0;

            double angSec = (sec / 60.0) * 2 * Math.PI - Math.PI / 2;
            double angMin = (min / 60.0) * 2 * Math.PI - Math.PI / 2;
            double angHour = (hour / 12.0) * 2 * Math.PI - Math.PI / 2;

            Pen pSec = new Pen(Color.Red, 2);
            Pen pMin = new Pen(Color.Black, 4);
            Pen pHour = new Pen(Color.Black, 6);

            // Cadran
            e.Graphics.DrawEllipse(Pens.Black, xc - r, yc - r, 2 * r, 2 * r);

            // heure
            e.Graphics.DrawLine(pHour, xc, yc,
                xc + (int)(Math.Cos(angHour) * r * 0.5),
                yc + (int)(Math.Sin(angHour) * r * 0.5));

            // minute
            e.Graphics.DrawLine(pMin, xc, yc,
                xc + (int)(Math.Cos(angMin) * r * 0.75),
                yc + (int)(Math.Sin(angMin) * r * 0.75));

            // seconde
            e.Graphics.DrawLine(pSec, xc, yc,
                xc + (int)(Math.Cos(angSec) * r * 0.9),
                yc + (int)(Math.Sin(angSec) * r * 0.9));
        }

    }
}
