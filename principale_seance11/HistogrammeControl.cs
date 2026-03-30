using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace principale_seance11
{
    public partial class HistogrammeControl : UserControl
    {
        private List<HistoPoint> data = new List<HistoPoint>();

        private int minX = 0;
        private int maxX = 100;
        private int minY = -100;
        private int maxY = 100;

        private Color trait = Color.Navy;

        public HistogrammeControl()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
        }


        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Browsable(false)]
        [Category("Données")]
        public List<HistoPoint> Data
        {
            get => data;
            set { data = value; Invalidate(); }
        }

        [Category("Affichage")]
        public int MinX
        {
            get => minX;
            set { minX = value; Invalidate(); }
        }

        [Category("Affichage")]
        public int MaxX
        {
            get => maxX;
            set { maxX = value; Invalidate(); }
        }

        [Category("Affichage")]
        public int MinY
        {
            get => minY;
            set { minY = value; Invalidate(); }
        }

        [Category("Affichage")]
        public int MaxY
        {
            get => maxY;
            set { maxY = value; Invalidate(); }
        }

        [Category("Affichage")]
        public Color Trait
        {
            get => trait;
            set { trait = value; Invalidate(); }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            if (data == null || data.Count < 2)
                return;

            Graphics g = e.Graphics;
            g.Clear(Color.White);

            float scaleX = (float)Width / (MaxX - MinX);
            float scaleY = (float)Height / (MaxY - MinY);

            Pen p = new Pen(trait, 2);

            for (int i = 0; i < data.Count - 1; i++)
            {
                HistoPoint p1 = data[i];
                HistoPoint p2 = data[i + 1];

                float x1 = (p1.X - MinX) * scaleX;
                float y1 = Height - (p1.Y - MinY) * scaleY;

                float x2 = (p2.X - MinX) * scaleX;
                float y2 = Height - (p2.Y - MinY) * scaleY;

                g.DrawLine(p, x1, y1, x2, y1);
                g.DrawLine(p, x2, y1, x2, y2);
            }

            if (MinY < 0 && MaxY > 0)
            {
                float y0 = Height - ((0 - MinY) * scaleY);
                g.DrawLine(Pens.Red, 0, y0, Width, y0);
            }
        }
    }
}