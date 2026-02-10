namespace ProjetPrincipale
{
    partial class EcranListe
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
            lFichier = new Label();
            lNom = new Label();
            lQualité = new Label();
            bAnnulé = new Button();
            bConfirmer = new Button();
            bOuvrir = new Button();
            bEnregistrer = new Button();
            bSupprimer = new Button();
            bAjouter = new Button();
            lbPersonne = new ListBox();
            cbQualiter = new ComboBox();
            gbDetail = new GroupBox();
            bmodifier = new Button();
            groupBox1 = new GroupBox();
            tbNom = new TextBox();
            ofdOuvrir = new OpenFileDialog();
            sfdEnregistrer = new SaveFileDialog();
            gbDetail.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // lFichier
            // 
            lFichier.AutoSize = true;
            lFichier.Location = new Point(23, 14);
            lFichier.Name = "lFichier";
            lFichier.Size = new Size(132, 25);
            lFichier.TabIndex = 0;
            lFichier.Text = "Nom de Fichier";
            // 
            // lNom
            // 
            lNom.AutoSize = true;
            lNom.Location = new Point(33, 90);
            lNom.Name = "lNom";
            lNom.Size = new Size(52, 25);
            lNom.TabIndex = 1;
            lNom.Text = "Nom";
            // 
            // lQualité
            // 
            lQualité.AutoSize = true;
            lQualité.Location = new Point(33, 27);
            lQualité.Name = "lQualité";
            lQualité.Size = new Size(68, 25);
            lQualité.TabIndex = 2;
            lQualité.Text = "Qualité";
            // 
            // bAnnulé
            // 
            bAnnulé.Location = new Point(167, 155);
            bAnnulé.Name = "bAnnulé";
            bAnnulé.Size = new Size(113, 34);
            bAnnulé.TabIndex = 3;
            bAnnulé.Text = "Annulé";
            bAnnulé.UseVisualStyleBackColor = true;
            bAnnulé.Click += bAnnulé_Click;
            // 
            // bConfirmer
            // 
            bConfirmer.Location = new Point(33, 155);
            bConfirmer.Name = "bConfirmer";
            bConfirmer.Size = new Size(114, 34);
            bConfirmer.TabIndex = 4;
            bConfirmer.Text = "Confirmer";
            bConfirmer.UseVisualStyleBackColor = true;
            bConfirmer.Click += bConfirmer_Click;
            // 
            // bOuvrir
            // 
            bOuvrir.Location = new Point(16, 224);
            bOuvrir.Name = "bOuvrir";
            bOuvrir.Size = new Size(112, 34);
            bOuvrir.TabIndex = 5;
            bOuvrir.Text = "Ouvrir";
            bOuvrir.UseVisualStyleBackColor = true;
            bOuvrir.Click += bOuvrir_Click;
            // 
            // bEnregistrer
            // 
            bEnregistrer.Location = new Point(16, 264);
            bEnregistrer.Name = "bEnregistrer";
            bEnregistrer.Size = new Size(112, 34);
            bEnregistrer.TabIndex = 6;
            bEnregistrer.Text = "Enregistrer";
            bEnregistrer.UseVisualStyleBackColor = true;
            bEnregistrer.Click += bEnregistrer_Click;
            // 
            // bSupprimer
            // 
            bSupprimer.Location = new Point(16, 370);
            bSupprimer.Name = "bSupprimer";
            bSupprimer.Size = new Size(112, 34);
            bSupprimer.TabIndex = 7;
            bSupprimer.Text = "Supprimer";
            bSupprimer.UseVisualStyleBackColor = true;
            bSupprimer.Click += bSupprimer_Click;
            // 
            // bAjouter
            // 
            bAjouter.Location = new Point(16, 330);
            bAjouter.Name = "bAjouter";
            bAjouter.Size = new Size(112, 34);
            bAjouter.TabIndex = 8;
            bAjouter.Text = "Ajouter";
            bAjouter.UseVisualStyleBackColor = true;
            bAjouter.Click += bAjouter_Click;
            // 
            // lbPersonne
            // 
            lbPersonne.FormattingEnabled = true;
            lbPersonne.ItemHeight = 25;
            lbPersonne.Location = new Point(16, 30);
            lbPersonne.Name = "lbPersonne";
            lbPersonne.Size = new Size(513, 179);
            lbPersonne.TabIndex = 9;
            lbPersonne.SelectedIndexChanged += lbPersonne_SelectedIndexChanged;
            // 
            // cbQualiter
            // 
            cbQualiter.FormattingEnabled = true;
            cbQualiter.Items.AddRange(new object[] { "Monsieur", "Madame", "Mademoiselle" });
            cbQualiter.Location = new Point(33, 54);
            cbQualiter.Name = "cbQualiter";
            cbQualiter.Size = new Size(247, 33);
            cbQualiter.TabIndex = 10;
            // 
            // gbDetail
            // 
            gbDetail.Controls.Add(groupBox1);
            gbDetail.Controls.Add(bOuvrir);
            gbDetail.Controls.Add(lbPersonne);
            gbDetail.Controls.Add(bEnregistrer);
            gbDetail.Controls.Add(bAjouter);
            gbDetail.Controls.Add(bSupprimer);
            gbDetail.Location = new Point(23, 37);
            gbDetail.Name = "gbDetail";
            gbDetail.Size = new Size(551, 480);
            gbDetail.TabIndex = 11;
            gbDetail.TabStop = false;
            gbDetail.Enter += gbDetail_Enter;
            // 
            // bmodifier
            // 
            bmodifier.Location = new Point(580, 418);
            bmodifier.Name = "bmodifier";
            bmodifier.Size = new Size(247, 38);
            bmodifier.TabIndex = 12;
            bmodifier.Text = "Modifié";
            bmodifier.UseVisualStyleBackColor = true;
            bmodifier.Click += bmodifier_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(bConfirmer);
            groupBox1.Controls.Add(tbNom);
            groupBox1.Controls.Add(cbQualiter);
            groupBox1.Controls.Add(lQualité);
            groupBox1.Controls.Add(bAnnulé);
            groupBox1.Controls.Add(lNom);
            groupBox1.Location = new Point(193, 215);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(336, 204);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            groupBox1.Text = "Détail personne";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // tbNom
            // 
            tbNom.Location = new Point(33, 118);
            tbNom.Name = "tbNom";
            tbNom.Size = new Size(247, 31);
            tbNom.TabIndex = 0;
            // 
            // ofdOuvrir
            // 
            ofdOuvrir.FileName = "openFileDialog1";
            // 
            // EcranListe
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(927, 558);
            Controls.Add(bmodifier);
            Controls.Add(gbDetail);
            Controls.Add(lFichier);
            Name = "EcranListe";
            Text = "EcranListe";
            gbDetail.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lFichier;
        private Label lNom;
        private Label lQualité;
        private Button bAnnulé;
        private Button bConfirmer;
        private Button bOuvrir;
        private Button bEnregistrer;
        private Button bSupprimer;
        private Button bAjouter;
        private ListBox lbPersonne;
        private ComboBox cbQualiter;
        private GroupBox gbDetail;
        private TextBox tbNom;
        private Button bmodifier;
        private OpenFileDialog ofdOuvrir;
        private SaveFileDialog sfdEnregistrer;
        private GroupBox groupBox1;
    }
}