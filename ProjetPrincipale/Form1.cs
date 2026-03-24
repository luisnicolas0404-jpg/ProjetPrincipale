namespace ProjetPrincipale
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Image temp = pictureBox1.Image;
            pictureBox1.Image = pictureBox2.Image;
            pictureBox2.Image = temp;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.Show();
            this.Hide();

        }

        //travaille 2

        private void MethodeNonImpl(object sender, EventArgs e)
        {
            MessageBox.Show("Cette fonctionnalité n'est pas encore implémentée.");
        }


        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void listeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EcranListe f = new EcranListe();
            f.ShowDialog();


        }

        private void barreDeProgressionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BarreDeProgression f = new BarreDeProgression();
            f.ShowDialog();


        }

        private void editeurToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EcranEditeur f = new EcranEditeur();
            f.Show();


        }

        private void aProposToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FenetreApropos f = new FenetreApropos();
            f.ShowDialog();

        }

        private void spirographeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Spirographe f = new Spirographe();
            f.ShowDialog();
        }

        private void horlogeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Horloge f = new Horloge();
            f.ShowDialog();
        }

        private void monitoringToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EcranClavierSouris f = new EcranClavierSouris();
            f.ShowDialog();
        }

        private void exploreureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EcranExploreure f = new EcranExploreure();
            f.ShowDialog();
        }

        private void basseDeDonnéesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EcranBDDirect f = new EcranBDDirect();
            f.ShowDialog();
        }
    }
}

