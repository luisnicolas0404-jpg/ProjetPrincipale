namespace ProjetPrincipale
{
    partial class EcranExploreure
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EcranExploreure));
            tsCommandes = new ToolStrip();
            tsbQuitter = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            tsApparence = new ToolStripDropDownButton();
            petitIconsToolStripMenuItem = new ToolStripMenuItem();
            grandIconesToolStripMenuItem = new ToolStripMenuItem();
            listeToolStripMenuItem = new ToolStripMenuItem();
            detailToolStripMenuItem = new ToolStripMenuItem();
            ssMessage = new StatusStrip();
            slMessage = new ToolStripStatusLabel();
            splitContainer1 = new SplitContainer();
            tvRepertoire = new TreeView();
            ilTreeView = new ImageList(components);
            lvFichier = new ListView();
            Nom = new ColumnHeader();
            Taille = new ColumnHeader();
            creation = new ColumnHeader();
            Modifications = new ColumnHeader();
            ilGrand = new ImageList(components);
            ilPetit = new ImageList(components);
            tsCommandes.SuspendLayout();
            ssMessage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            SuspendLayout();
            // 
            // tsCommandes
            // 
            tsCommandes.ImageScalingSize = new Size(24, 24);
            tsCommandes.Items.AddRange(new ToolStripItem[] { tsbQuitter, toolStripSeparator1, tsApparence });
            tsCommandes.Location = new Point(0, 0);
            tsCommandes.Name = "tsCommandes";
            tsCommandes.Size = new Size(800, 33);
            tsCommandes.TabIndex = 0;
            tsCommandes.Text = "toolStrip1";
            // 
            // tsbQuitter
            // 
            tsbQuitter.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tsbQuitter.Image = (Image)resources.GetObject("tsbQuitter.Image");
            tsbQuitter.ImageTransparentColor = Color.Magenta;
            tsbQuitter.Name = "tsbQuitter";
            tsbQuitter.Size = new Size(34, 28);
            tsbQuitter.Text = "Quitter";
            tsbQuitter.Click += tsbQuitter_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 33);
            // 
            // tsApparence
            // 
            tsApparence.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tsApparence.DropDownItems.AddRange(new ToolStripItem[] { petitIconsToolStripMenuItem, grandIconesToolStripMenuItem, listeToolStripMenuItem, detailToolStripMenuItem });
            tsApparence.Image = (Image)resources.GetObject("tsApparence.Image");
            tsApparence.ImageTransparentColor = Color.Magenta;
            tsApparence.Name = "tsApparence";
            tsApparence.Size = new Size(42, 28);
            tsApparence.Text = "Apparence";
            // 
            // petitIconsToolStripMenuItem
            // 
            petitIconsToolStripMenuItem.Name = "petitIconsToolStripMenuItem";
            petitIconsToolStripMenuItem.Size = new Size(217, 34);
            petitIconsToolStripMenuItem.Text = "Petit icons";
            petitIconsToolStripMenuItem.Click += petitIconsToolStripMenuItem_Click;
            // 
            // grandIconesToolStripMenuItem
            // 
            grandIconesToolStripMenuItem.Name = "grandIconesToolStripMenuItem";
            grandIconesToolStripMenuItem.Size = new Size(217, 34);
            grandIconesToolStripMenuItem.Text = "Grand icones";
            grandIconesToolStripMenuItem.Click += grandIconesToolStripMenuItem_Click;
            // 
            // listeToolStripMenuItem
            // 
            listeToolStripMenuItem.Name = "listeToolStripMenuItem";
            listeToolStripMenuItem.Size = new Size(217, 34);
            listeToolStripMenuItem.Text = "liste";
            listeToolStripMenuItem.Click += listeToolStripMenuItem_Click;
            // 
            // detailToolStripMenuItem
            // 
            detailToolStripMenuItem.Name = "detailToolStripMenuItem";
            detailToolStripMenuItem.Size = new Size(217, 34);
            detailToolStripMenuItem.Text = "detail";
            detailToolStripMenuItem.Click += detailToolStripMenuItem_Click;
            // 
            // ssMessage
            // 
            ssMessage.ImageScalingSize = new Size(24, 24);
            ssMessage.Items.AddRange(new ToolStripItem[] { slMessage });
            ssMessage.Location = new Point(0, 418);
            ssMessage.Name = "ssMessage";
            ssMessage.Size = new Size(800, 32);
            ssMessage.TabIndex = 1;
            ssMessage.Text = "statusStrip1";
            // 
            // slMessage
            // 
            slMessage.Name = "slMessage";
            slMessage.Size = new Size(92, 25);
            slMessage.Text = "Bienvenue";
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 33);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(tvRepertoire);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(lvFichier);
            splitContainer1.Size = new Size(800, 385);
            splitContainer1.SplitterDistance = 266;
            splitContainer1.TabIndex = 2;
            // 
            // tvRepertoire
            // 
            tvRepertoire.Dock = DockStyle.Fill;
            tvRepertoire.ImageIndex = 0;
            tvRepertoire.ImageList = ilTreeView;
            tvRepertoire.Location = new Point(0, 0);
            tvRepertoire.Name = "tvRepertoire";
            tvRepertoire.SelectedImageIndex = 0;
            tvRepertoire.Size = new Size(266, 385);
            tvRepertoire.TabIndex = 0;
            tvRepertoire.AfterSelect += tvRepertoire_AfterSelect;
            // 
            // ilTreeView
            // 
            ilTreeView.ColorDepth = ColorDepth.Depth32Bit;
            ilTreeView.ImageSize = new Size(16, 16);
            ilTreeView.TransparentColor = Color.Transparent;
            // 
            // lvFichier
            // 
            lvFichier.Columns.AddRange(new ColumnHeader[] { Nom, Taille, creation, Modifications });
            lvFichier.Dock = DockStyle.Fill;
            lvFichier.FullRowSelect = true;
            lvFichier.GridLines = true;
            lvFichier.LargeImageList = ilGrand;
            lvFichier.Location = new Point(0, 0);
            lvFichier.Name = "lvFichier";
            lvFichier.Size = new Size(530, 385);
            lvFichier.SmallImageList = ilPetit;
            lvFichier.TabIndex = 0;
            lvFichier.UseCompatibleStateImageBehavior = false;
            lvFichier.View = View.Details;
            // 
            // Nom
            // 
            Nom.Text = "Nom";
            Nom.Width = 200;
            // 
            // Taille
            // 
            Taille.Text = "taille";
            Taille.Width = 80;
            // 
            // creation
            // 
            creation.Text = "creation";
            creation.Width = 150;
            // 
            // Modifications
            // 
            Modifications.Text = "Modifications";
            Modifications.Width = 150;
            // 
            // ilGrand
            // 
            ilGrand.ColorDepth = ColorDepth.Depth32Bit;
            ilGrand.ImageSize = new Size(32, 32);
            ilGrand.TransparentColor = Color.Transparent;
            // 
            // ilPetit
            // 
            ilPetit.ColorDepth = ColorDepth.Depth32Bit;
            ilPetit.ImageSize = new Size(16, 16);
            ilPetit.TransparentColor = Color.Transparent;
            // 
            // EcranExploreure
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(splitContainer1);
            Controls.Add(ssMessage);
            Controls.Add(tsCommandes);
            Name = "EcranExploreure";
            Text = "EcranExploreure";
            tsCommandes.ResumeLayout(false);
            tsCommandes.PerformLayout();
            ssMessage.ResumeLayout(false);
            ssMessage.PerformLayout();
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip tsCommandes;
        private ToolStripButton tsbQuitter;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripDropDownButton tsApparence;
        private ToolStripMenuItem petitIconsToolStripMenuItem;
        private ToolStripMenuItem grandIconesToolStripMenuItem;
        private ToolStripMenuItem listeToolStripMenuItem;
        private ToolStripMenuItem detailToolStripMenuItem;
        private StatusStrip ssMessage;
        private ToolStripStatusLabel slMessage;
        private SplitContainer splitContainer1;
        private TreeView tvRepertoire;
        private ListView lvFichier;
        private ColumnHeader Nom;
        private ColumnHeader Taille;
        private ColumnHeader creation;
        private ColumnHeader Modifications;
        private ImageList ilTreeView;
        private ImageList ilGrand;
        private ImageList ilPetit;
    }
}