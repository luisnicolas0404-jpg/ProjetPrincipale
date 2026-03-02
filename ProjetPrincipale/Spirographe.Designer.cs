namespace ProjetPrincipale
{
    partial class Spirographe
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
            groupBox1 = new GroupBox();
            bGo = new Button();
            tbProfondeur = new TrackBar();
            tbSommets = new TrackBar();
            tbDensite = new TrackBar();
            lSommets = new Label();
            lProfondeur = new Label();
            lDensiter = new Label();
            bTrait = new Button();
            bFond = new Button();
            cdCouleur = new ColorDialog();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tbProfondeur).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tbSommets).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tbDensite).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(bGo);
            groupBox1.Controls.Add(tbProfondeur);
            groupBox1.Controls.Add(tbSommets);
            groupBox1.Controls.Add(tbDensite);
            groupBox1.Controls.Add(lSommets);
            groupBox1.Controls.Add(lProfondeur);
            groupBox1.Controls.Add(lDensiter);
            groupBox1.Location = new Point(25, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(262, 373);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Paramétrage";
            // 
            // bGo
            // 
            bGo.Location = new Point(12, 330);
            bGo.Name = "bGo";
            bGo.Size = new Size(230, 34);
            bGo.TabIndex = 1;
            bGo.Text = "GO";
            bGo.UseVisualStyleBackColor = true;
            bGo.Click += bGo_Click;
            // 
            // tbProfondeur
            // 
            tbProfondeur.Location = new Point(12, 261);
            tbProfondeur.Name = "tbProfondeur";
            tbProfondeur.Size = new Size(230, 72);
            tbProfondeur.TabIndex = 1;
            // 
            // tbSommets
            // 
            tbSommets.Location = new Point(12, 55);
            tbSommets.Name = "tbSommets";
            tbSommets.Size = new Size(230, 72);
            tbSommets.TabIndex = 2;
            // 
            // tbDensite
            // 
            tbDensite.Location = new Point(12, 158);
            tbDensite.Name = "tbDensite";
            tbDensite.Size = new Size(230, 72);
            tbDensite.TabIndex = 3;
            // 
            // lSommets
            // 
            lSommets.AutoSize = true;
            lSommets.Location = new Point(6, 27);
            lSommets.Name = "lSommets";
            lSommets.Size = new Size(182, 25);
            lSommets.TabIndex = 0;
            lSommets.Text = "Nombre de sommets";
            // 
            // lProfondeur
            // 
            lProfondeur.AutoSize = true;
            lProfondeur.Location = new Point(12, 130);
            lProfondeur.Name = "lProfondeur";
            lProfondeur.Size = new Size(190, 25);
            lProfondeur.TabIndex = 2;
            lProfondeur.Text = "Profondeur de dessins";
            lProfondeur.Click += lProfondeur_Click;
            // 
            // lDensiter
            // 
            lDensiter.AutoSize = true;
            lDensiter.Location = new Point(6, 233);
            lDensiter.Name = "lDensiter";
            lDensiter.Size = new Size(159, 25);
            lDensiter.TabIndex = 1;
            lDensiter.Text = "Densité de dessins";
            // 
            // bTrait
            // 
            bTrait.Location = new Point(25, 404);
            bTrait.Name = "bTrait";
            bTrait.Size = new Size(112, 34);
            bTrait.TabIndex = 1;
            bTrait.Text = "Trait";
            bTrait.UseVisualStyleBackColor = true;
            bTrait.Click += bTrait_Click;
            // 
            // bFond
            // 
            bFond.Location = new Point(175, 404);
            bFond.Name = "bFond";
            bFond.Size = new Size(112, 34);
            bFond.TabIndex = 2;
            bFond.Text = "Fond";
            bFond.UseVisualStyleBackColor = true;
            bFond.Click += bFond_Click;
            // 
            // Spirographe
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(bFond);
            Controls.Add(bTrait);
            Controls.Add(groupBox1);
            Name = "Spirographe";
            Text = "Spirographe";
            Load += Spirographe_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)tbProfondeur).EndInit();
            ((System.ComponentModel.ISupportInitialize)tbSommets).EndInit();
            ((System.ComponentModel.ISupportInitialize)tbDensite).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label lSommets;
        private Label lDensiter;
        private Label lProfondeur;
        private Button bGo;
        private TrackBar tbProfondeur;
        private TrackBar tbSommets;
        private TrackBar tbDensite;
        private Button bTrait;
        private Button bFond;
        private ColorDialog cdCouleur;
    }
}