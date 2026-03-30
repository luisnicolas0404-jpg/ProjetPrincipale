namespace principale_seance11
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.bcreer = new System.Windows.Forms.Button();
            this.bDessiner = new System.Windows.Forms.Button();
            this.pDessin = new System.Windows.Forms.Panel();
            this.lbMonpoint = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // bcreer
            // 
            this.bcreer.Location = new System.Drawing.Point(68, 61);
            this.bcreer.Name = "bcreer";
            this.bcreer.Size = new System.Drawing.Size(142, 45);
            this.bcreer.TabIndex = 0;
            this.bcreer.Text = "Créer";
            this.bcreer.UseVisualStyleBackColor = true;
            this.bcreer.Click += new System.EventHandler(this.button1_Click);
            // 
            // bDessiner
            // 
            this.bDessiner.Location = new System.Drawing.Point(554, 61);
            this.bDessiner.Name = "bDessiner";
            this.bDessiner.Size = new System.Drawing.Size(115, 45);
            this.bDessiner.TabIndex = 1;
            this.bDessiner.Text = "Dessiner";
            this.bDessiner.UseVisualStyleBackColor = true;
            this.bDessiner.Click += new System.EventHandler(this.bDessiner_Click);
            // 
            // pDessin
            // 
            this.pDessin.Location = new System.Drawing.Point(68, 151);
            this.pDessin.Name = "pDessin";
            this.pDessin.Size = new System.Drawing.Size(426, 309);
            this.pDessin.TabIndex = 2;
            this.pDessin.Paint += new System.Windows.Forms.PaintEventHandler(this.pDessin_Paint);
            // 
            // lbMonpoint
            // 
            this.lbMonpoint.FormattingEnabled = true;
            this.lbMonpoint.ItemHeight = 20;
            this.lbMonpoint.Location = new System.Drawing.Point(554, 156);
            this.lbMonpoint.Name = "lbMonpoint";
            this.lbMonpoint.Size = new System.Drawing.Size(209, 304);
            this.lbMonpoint.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1467, 752);
            this.Controls.Add(this.lbMonpoint);
            this.Controls.Add(this.pDessin);
            this.Controls.Add(this.bDessiner);
            this.Controls.Add(this.bcreer);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bcreer;
        private System.Windows.Forms.Button bDessiner;
        private System.Windows.Forms.Panel pDessin;
        private System.Windows.Forms.ListBox lbMonpoint;
        
    }
}

