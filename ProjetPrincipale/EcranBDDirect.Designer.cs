namespace ProjetPrincipale
{
    partial class EcranBDDirect
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
            lbconsole = new ListBox();
            bConsulter = new Button();
            bDenombrer = new Button();
            bAjouter = new Button();
            lNom = new Label();
            lPrenom = new Label();
            tbPrenom = new TextBox();
            tbNom = new TextBox();
            SuspendLayout();
            // 
            // lbconsole
            // 
            lbconsole.FormattingEnabled = true;
            lbconsole.ItemHeight = 25;
            lbconsole.Location = new Point(35, 22);
            lbconsole.Name = "lbconsole";
            lbconsole.Size = new Size(383, 404);
            lbconsole.TabIndex = 0;
            // 
            // bConsulter
            // 
            bConsulter.Location = new Point(479, 22);
            bConsulter.Name = "bConsulter";
            bConsulter.Size = new Size(183, 34);
            bConsulter.TabIndex = 1;
            bConsulter.Text = "Consulter";
            bConsulter.UseVisualStyleBackColor = true;
            bConsulter.Click += bConsulter_Click;
            // 
            // bDenombrer
            // 
            bDenombrer.Location = new Point(479, 132);
            bDenombrer.Name = "bDenombrer";
            bDenombrer.Size = new Size(183, 34);
            bDenombrer.TabIndex = 2;
            bDenombrer.Text = "Dénombrer";
            bDenombrer.UseVisualStyleBackColor = true;
            bDenombrer.Click += bDenombrer_Click;
            // 
            // bAjouter
            // 
            bAjouter.Location = new Point(479, 382);
            bAjouter.Name = "bAjouter";
            bAjouter.Size = new Size(183, 34);
            bAjouter.TabIndex = 3;
            bAjouter.Text = "Ajouter";
            bAjouter.UseVisualStyleBackColor = true;
            bAjouter.Click += bAjouter_Click;
            // 
            // lNom
            // 
            lNom.AutoSize = true;
            lNom.Location = new Point(479, 267);
            lNom.Name = "lNom";
            lNom.Size = new Size(52, 25);
            lNom.TabIndex = 4;
            lNom.Text = "Nom";
            // 
            // lPrenom
            // 
            lPrenom.AutoSize = true;
            lPrenom.Location = new Point(479, 194);
            lPrenom.Name = "lPrenom";
            lPrenom.Size = new Size(74, 25);
            lPrenom.TabIndex = 5;
            lPrenom.Text = "Prénom";
            // 
            // tbPrenom
            // 
            tbPrenom.Location = new Point(479, 222);
            tbPrenom.Name = "tbPrenom";
            tbPrenom.Size = new Size(183, 31);
            tbPrenom.TabIndex = 6;
            // 
            // tbNom
            // 
            tbNom.Location = new Point(479, 295);
            tbNom.Name = "tbNom";
            tbNom.Size = new Size(183, 31);
            tbNom.TabIndex = 7;
            // 
            // EcranBDDirect
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tbNom);
            Controls.Add(tbPrenom);
            Controls.Add(lPrenom);
            Controls.Add(lNom);
            Controls.Add(bAjouter);
            Controls.Add(bDenombrer);
            Controls.Add(bConsulter);
            Controls.Add(lbconsole);
            Name = "EcranBDDirect";
            Text = "EcranBDDirect";
            Load += EcranBDDirect_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lbconsole;
        private Button bConsulter;
        private Button bDenombrer;
        private Button bAjouter;
        private Label lNom;
        private Label lPrenom;
        private TextBox tbPrenom;
        private TextBox tbNom;
    }
}