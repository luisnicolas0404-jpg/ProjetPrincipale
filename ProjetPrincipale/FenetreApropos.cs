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
    public partial class FenetreApropos : Form
    {
        public FenetreApropos()
        {
            InitializeComponent();
        }

        Cursor oldCursor;

        private void panel1_MouseEnter(object sender, EventArgs e)
        {
            oldCursor = this.Cursor;
            this.Cursor = Cursors.Hand;
        }

        private void panel1_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = oldCursor;
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            oldCursor = this.Cursor;      // on garde le curseur actuel
            this.Cursor = Cursors.Hand;   // on met un curseur spécial

        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = oldCursor;
        }
    }
}
