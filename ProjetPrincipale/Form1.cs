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
            SecondeFenetre f = new SecondeFenetre();
            f.Show();
            this.Hide();

        }
    }
}

