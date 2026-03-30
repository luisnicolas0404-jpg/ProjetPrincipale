using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace principale_seance11
{
    public partial class Form1 : Form
    {
        ArrayList alData = new ArrayList();
        Random rnd = new Random();
        private HistogrammeControl HistogrammeControl1;
        public Form1()
        {
            InitializeComponent();


            histogrammeControl1 = new HistogrammeControl();
            histogrammeControl1.Location = new Point(10, 250);   // position sur le Form
            histogrammeControl1.Size = new Size(500, 200);       // taille du contrôle
            this.Controls.Add(histogrammeControl1);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            alData.Clear();
            lbMonpoint.Items.Clear();

            int nbPoints = rnd.Next(5, 15);
            int x = 0;

            for (int i = 0; i < nbPoints; i++)
            {
                x += rnd.Next(10, 30);
                int y = rnd.Next(-100, 101);

                MonPoint p = new MonPoint(x, y);
                alData.Add(p);
                lbMonpoint.Items.Add(p);
            }

            pDessin.Invalidate();

        }

        private void bDessiner_Click(object sender, EventArgs e)
        {


            List<HistoPoint> L = new List<HistoPoint>();
            L.Add(new HistoPoint(0, 5));
            L.Add(new HistoPoint(10, 15));
            L.Add(new HistoPoint(20, -8));
            L.Add(new HistoPoint(30, 40));

            histogrammeControl1.Data = L;

            histogrammeControl1.MinX = 0;
            histogrammeControl1.MaxX = 30;
            histogrammeControl1.MinY = -10;
            histogrammeControl1.MaxY = 40;

            histogrammeControl1.Invalidate();


        }

        private void pDessin_Paint(object sender, PaintEventArgs e)
        {
            if (alData.Count < 2) return;

            Graphics g = e.Graphics;
            g.Clear(Color.White);

            
            int minX = ((MonPoint)alData[0]).X;
            int maxX = ((MonPoint)alData[alData.Count - 1]).X;

            int minY = int.MaxValue;
            int maxY = int.MinValue;

            foreach (MonPoint p in alData)
            {
                if (p.Y < minY) minY = p.Y;
                if (p.Y > maxY) maxY = p.Y;
            }

            float scaleX = pDessin.Width / (float)(maxX - minX);
            float scaleY = pDessin.Height / (float)(maxY - minY);

            Pen pen = new Pen(Color.Navy, 2);

            for (int i = 0; i < alData.Count - 1; i++)
            {
                MonPoint p1 = (MonPoint)alData[i];
                MonPoint p2 = (MonPoint)alData[i + 1];

                float x1 = (p1.X - minX) * scaleX;
                float y1 = pDessin.Height - (p1.Y - minY) * scaleY;

                float x2 = (p2.X - minX) * scaleX;
                float y2 = pDessin.Height - (p2.Y - minY) * scaleY;

                // Trait horizontal
                g.DrawLine(pen, x1, y1, x2, y1);
                // Trait vertical
                g.DrawLine(pen, x2, y1, y2, y2);
            }

            
            if (minY < 0 && maxY > 0)
            {
                float y0 = pDessin.Height - ((0 - minY) * scaleY);
                g.DrawLine(Pens.Red, 0, y0, pDessin.Width, y0);
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

