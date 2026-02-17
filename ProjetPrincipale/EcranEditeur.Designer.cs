namespace ProjetPrincipale
{
    partial class EcranEditeur
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EcranEditeur));
            menuStrip1 = new MenuStrip();
            fichierToolStripMenuItem = new ToolStripMenuItem();
            nouveauToolStripMenuItem = new ToolStripMenuItem();
            ouvrirToolStripMenuItem = new ToolStripMenuItem();
            enregistrerToolStripMenuItem = new ToolStripMenuItem();
            quitterToolStripMenuItem = new ToolStripMenuItem();
            editerToolStripMenuItem = new ToolStripMenuItem();
            copierToolStripMenuItem = new ToolStripMenuItem();
            couperToolStripMenuItem = new ToolStripMenuItem();
            collerToolStripMenuItem1 = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripMenuItem();
            justifierToolStripMenuItem = new ToolStripMenuItem();
            gaucheToolStripMenuItem = new ToolStripMenuItem();
            centreToolStripMenuItem = new ToolStripMenuItem();
            droiteToolStripMenuItem = new ToolStripMenuItem();
            policeToolStripMenuItem = new ToolStripMenuItem();
            caractèreToolStripMenuItem = new ToolStripMenuItem();
            grasToolStripMenuItem = new ToolStripMenuItem();
            italiqueToolStripMenuItem = new ToolStripMenuItem();
            soulignéToolStripMenuItem = new ToolStripMenuItem();
            barrerToolStripMenuItem = new ToolStripMenuItem();
            pMenu = new Panel();
            Nouveau = new PictureBox();
            Ouvrir = new PictureBox();
            Quitter = new PictureBox();
            Enregistrer = new PictureBox();
            rtbTexte = new RichTextBox();
            ofdOuvrir = new OpenFileDialog();
            sfdenregistrer = new SaveFileDialog();
            fdPolice = new FontDialog();
            menuStrip1.SuspendLayout();
            pMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Nouveau).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Ouvrir).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Quitter).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Enregistrer).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fichierToolStripMenuItem, editerToolStripMenuItem, toolStripMenuItem1 });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 33);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // fichierToolStripMenuItem
            // 
            fichierToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { nouveauToolStripMenuItem, ouvrirToolStripMenuItem, enregistrerToolStripMenuItem, quitterToolStripMenuItem });
            fichierToolStripMenuItem.Name = "fichierToolStripMenuItem";
            fichierToolStripMenuItem.Size = new Size(78, 29);
            fichierToolStripMenuItem.Text = "Fichier";
            // 
            // nouveauToolStripMenuItem
            // 
            nouveauToolStripMenuItem.Name = "nouveauToolStripMenuItem";
            nouveauToolStripMenuItem.Size = new Size(198, 34);
            nouveauToolStripMenuItem.Text = "Nouveau";
            nouveauToolStripMenuItem.Click += nouveauToolStripMenuItem_Click;
            // 
            // ouvrirToolStripMenuItem
            // 
            ouvrirToolStripMenuItem.Name = "ouvrirToolStripMenuItem";
            ouvrirToolStripMenuItem.Size = new Size(198, 34);
            ouvrirToolStripMenuItem.Text = "Ouvrir";
            ouvrirToolStripMenuItem.Click += ouvrirToolStripMenuItem_Click;
            // 
            // enregistrerToolStripMenuItem
            // 
            enregistrerToolStripMenuItem.Name = "enregistrerToolStripMenuItem";
            enregistrerToolStripMenuItem.Size = new Size(198, 34);
            enregistrerToolStripMenuItem.Text = "Enregistrer";
            enregistrerToolStripMenuItem.Click += enregistrerToolStripMenuItem_Click;
            // 
            // quitterToolStripMenuItem
            // 
            quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            quitterToolStripMenuItem.Size = new Size(198, 34);
            quitterToolStripMenuItem.Text = "Quitter";
            quitterToolStripMenuItem.Click += quitterToolStripMenuItem_Click;
            // 
            // editerToolStripMenuItem
            // 
            editerToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { copierToolStripMenuItem, couperToolStripMenuItem, collerToolStripMenuItem1 });
            editerToolStripMenuItem.Name = "editerToolStripMenuItem";
            editerToolStripMenuItem.Size = new Size(73, 29);
            editerToolStripMenuItem.Text = "Editer";
            editerToolStripMenuItem.Click += editerToolStripMenuItem_Click;
            // 
            // copierToolStripMenuItem
            // 
            copierToolStripMenuItem.Name = "copierToolStripMenuItem";
            copierToolStripMenuItem.Size = new Size(172, 34);
            copierToolStripMenuItem.Text = "Copier";
            copierToolStripMenuItem.Click += copierToolStripMenuItem_Click;
            // 
            // couperToolStripMenuItem
            // 
            couperToolStripMenuItem.Name = "couperToolStripMenuItem";
            couperToolStripMenuItem.Size = new Size(172, 34);
            couperToolStripMenuItem.Text = "Couper";
            couperToolStripMenuItem.Click += collerToolStripMenuItem_Click;
            // 
            // collerToolStripMenuItem1
            // 
            collerToolStripMenuItem1.Name = "collerToolStripMenuItem1";
            collerToolStripMenuItem1.Size = new Size(172, 34);
            collerToolStripMenuItem1.Text = "Coller";
            collerToolStripMenuItem1.Click += collerToolStripMenuItem1_Click;
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { justifierToolStripMenuItem, policeToolStripMenuItem, caractèreToolStripMenuItem });
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(85, 29);
            toolStripMenuItem1.Text = "Format";
            // 
            // justifierToolStripMenuItem
            // 
            justifierToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { gaucheToolStripMenuItem, centreToolStripMenuItem, droiteToolStripMenuItem });
            justifierToolStripMenuItem.Name = "justifierToolStripMenuItem";
            justifierToolStripMenuItem.Size = new Size(187, 34);
            justifierToolStripMenuItem.Text = "Justifier";
            // 
            // gaucheToolStripMenuItem
            // 
            gaucheToolStripMenuItem.Name = "gaucheToolStripMenuItem";
            gaucheToolStripMenuItem.Size = new Size(172, 34);
            gaucheToolStripMenuItem.Text = "Gauche";
            gaucheToolStripMenuItem.Click += gaucheToolStripMenuItem_Click;
            // 
            // centreToolStripMenuItem
            // 
            centreToolStripMenuItem.Name = "centreToolStripMenuItem";
            centreToolStripMenuItem.Size = new Size(172, 34);
            centreToolStripMenuItem.Text = "Centre";
            centreToolStripMenuItem.Click += centreToolStripMenuItem_Click;
            // 
            // droiteToolStripMenuItem
            // 
            droiteToolStripMenuItem.Name = "droiteToolStripMenuItem";
            droiteToolStripMenuItem.Size = new Size(172, 34);
            droiteToolStripMenuItem.Text = "Droite";
            droiteToolStripMenuItem.Click += droiteToolStripMenuItem_Click;
            // 
            // policeToolStripMenuItem
            // 
            policeToolStripMenuItem.Name = "policeToolStripMenuItem";
            policeToolStripMenuItem.Size = new Size(187, 34);
            policeToolStripMenuItem.Text = "Police";
            policeToolStripMenuItem.Click += policeToolStripMenuItem_Click;
            // 
            // caractèreToolStripMenuItem
            // 
            caractèreToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { grasToolStripMenuItem, italiqueToolStripMenuItem, soulignéToolStripMenuItem, barrerToolStripMenuItem });
            caractèreToolStripMenuItem.Name = "caractèreToolStripMenuItem";
            caractèreToolStripMenuItem.Size = new Size(187, 34);
            caractèreToolStripMenuItem.Text = "Caractère";
            // 
            // grasToolStripMenuItem
            // 
            grasToolStripMenuItem.Name = "grasToolStripMenuItem";
            grasToolStripMenuItem.Size = new Size(183, 34);
            grasToolStripMenuItem.Text = "Gras";
            grasToolStripMenuItem.Click += grasToolStripMenuItem_Click;
            // 
            // italiqueToolStripMenuItem
            // 
            italiqueToolStripMenuItem.Name = "italiqueToolStripMenuItem";
            italiqueToolStripMenuItem.Size = new Size(183, 34);
            italiqueToolStripMenuItem.Text = "Italique";
            italiqueToolStripMenuItem.Click += italiqueToolStripMenuItem_Click;
            // 
            // soulignéToolStripMenuItem
            // 
            soulignéToolStripMenuItem.Name = "soulignéToolStripMenuItem";
            soulignéToolStripMenuItem.Size = new Size(183, 34);
            soulignéToolStripMenuItem.Text = "Souligné";
            soulignéToolStripMenuItem.Click += soulignéToolStripMenuItem_Click;
            // 
            // barrerToolStripMenuItem
            // 
            barrerToolStripMenuItem.Name = "barrerToolStripMenuItem";
            barrerToolStripMenuItem.Size = new Size(183, 34);
            barrerToolStripMenuItem.Text = "Barrer";
            barrerToolStripMenuItem.Click += barrerToolStripMenuItem_Click;
            // 
            // pMenu
            // 
            pMenu.Controls.Add(Nouveau);
            pMenu.Dock = DockStyle.Top;
            pMenu.Location = new Point(0, 33);
            pMenu.Name = "pMenu";
            pMenu.Size = new Size(800, 67);
            pMenu.TabIndex = 1;
            // 
            // Nouveau
            // 
            Nouveau.Image = (Image)resources.GetObject("Nouveau.Image");
            Nouveau.Location = new Point(12, 12);
            Nouveau.Name = "Nouveau";
            Nouveau.Size = new Size(76, 47);
            Nouveau.SizeMode = PictureBoxSizeMode.StretchImage;
            Nouveau.TabIndex = 3;
            Nouveau.TabStop = false;
            // 
            // Ouvrir
            // 
            Ouvrir.Image = (Image)resources.GetObject("Ouvrir.Image");
            Ouvrir.Location = new Point(94, 45);
            Ouvrir.Name = "Ouvrir";
            Ouvrir.Size = new Size(76, 46);
            Ouvrir.SizeMode = PictureBoxSizeMode.StretchImage;
            Ouvrir.TabIndex = 2;
            Ouvrir.TabStop = false;
            // 
            // Quitter
            // 
            Quitter.Image = (Image)resources.GetObject("Quitter.Image");
            Quitter.Location = new Point(258, 44);
            Quitter.Name = "Quitter";
            Quitter.Size = new Size(76, 47);
            Quitter.SizeMode = PictureBoxSizeMode.StretchImage;
            Quitter.TabIndex = 4;
            Quitter.TabStop = false;
            // 
            // Enregistrer
            // 
            Enregistrer.Image = (Image)resources.GetObject("Enregistrer.Image");
            Enregistrer.Location = new Point(176, 45);
            Enregistrer.Name = "Enregistrer";
            Enregistrer.Size = new Size(76, 46);
            Enregistrer.SizeMode = PictureBoxSizeMode.StretchImage;
            Enregistrer.TabIndex = 5;
            Enregistrer.TabStop = false;
            // 
            // rtbTexte
            // 
            rtbTexte.Dock = DockStyle.Fill;
            rtbTexte.Location = new Point(0, 100);
            rtbTexte.Name = "rtbTexte";
            rtbTexte.Size = new Size(800, 350);
            rtbTexte.TabIndex = 6;
            rtbTexte.Text = "";
            // 
            // ofdOuvrir
            // 
            ofdOuvrir.FileName = "openFileDialog1";
            // 
            // EcranEditeur
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(rtbTexte);
            Controls.Add(Enregistrer);
            Controls.Add(Quitter);
            Controls.Add(Ouvrir);
            Controls.Add(pMenu);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "EcranEditeur";
            Text = "EcranEditeur";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            pMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)Nouveau).EndInit();
            ((System.ComponentModel.ISupportInitialize)Ouvrir).EndInit();
            ((System.ComponentModel.ISupportInitialize)Quitter).EndInit();
            ((System.ComponentModel.ISupportInitialize)Enregistrer).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fichierToolStripMenuItem;
        private ToolStripMenuItem nouveauToolStripMenuItem;
        private ToolStripMenuItem ouvrirToolStripMenuItem;
        private ToolStripMenuItem enregistrerToolStripMenuItem;
        private ToolStripMenuItem quitterToolStripMenuItem;
        private ToolStripMenuItem editerToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem copierToolStripMenuItem;
        private ToolStripMenuItem couperToolStripMenuItem;
        private ToolStripMenuItem collerToolStripMenuItem1;
        private ToolStripMenuItem justifierToolStripMenuItem;
        private ToolStripMenuItem gaucheToolStripMenuItem;
        private ToolStripMenuItem centreToolStripMenuItem;
        private ToolStripMenuItem droiteToolStripMenuItem;
        private ToolStripMenuItem policeToolStripMenuItem;
        private ToolStripMenuItem caractèreToolStripMenuItem;
        private ToolStripMenuItem grasToolStripMenuItem;
        private ToolStripMenuItem italiqueToolStripMenuItem;
        private ToolStripMenuItem soulignéToolStripMenuItem;
        private ToolStripMenuItem barrerToolStripMenuItem;
        private Panel pMenu;
        private PictureBox Ouvrir;
        private PictureBox Nouveau;
        private PictureBox Quitter;
        private PictureBox Enregistrer;
        private RichTextBox rtbTexte;
        private OpenFileDialog ofdOuvrir;
        private SaveFileDialog sfdenregistrer;
        private FontDialog fdPolice;
    }
}