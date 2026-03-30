namespace Mes_Controles
{
    partial class UserControl1
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

        #region Code généré par le Concepteur de composants

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.boutonColore1 = new Mes_Controles.BoutonColore();
            this.SuspendLayout();
            // 
            // boutonColore1
            // 
            this.boutonColore1.CouleurDroite = System.Drawing.Color.Red;
            this.boutonColore1.CouleurGauche = System.Drawing.Color.Blue;
            this.boutonColore1.Location = new System.Drawing.Point(416, 129);
            this.boutonColore1.Name = "boutonColore1";
            this.boutonColore1.Size = new System.Drawing.Size(198, 102);
            this.boutonColore1.TabIndex = 0;
            this.boutonColore1.Text = "boutonColore1";
            this.boutonColore1.TransparenceDroite = 255;
            this.boutonColore1.TransparenceGauche = 255;
            this.boutonColore1.UseVisualStyleBackColor = true;
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.boutonColore1);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(800, 450);
            this.ResumeLayout(false);

        }

        #endregion

        private BoutonColore boutonColore1;
    }
}
