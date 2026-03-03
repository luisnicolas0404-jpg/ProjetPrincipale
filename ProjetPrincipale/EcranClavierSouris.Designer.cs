namespace ProjetPrincipale
{
    partial class EcranClavierSouris
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
            pnlSouris = new Panel();
            listBox1 = new ListBox();
            lblClavier = new Label();
            lblPositionY = new Label();
            lblPositionX = new Label();
            lblClicDroit = new Label();
            lblClicGauche = new Label();
            tbxClicGauche = new TextBox();
            tbxClicDroit = new TextBox();
            tbxPositionX = new TextBox();
            tbxPositionY = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // pnlSouris
            // 
            pnlSouris.Location = new Point(313, 98);
            pnlSouris.Name = "pnlSouris";
            pnlSouris.Size = new Size(446, 331);
            pnlSouris.TabIndex = 0;
            pnlSouris.MouseDown += pnlSouris_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 25;
            listBox1.Location = new Point(22, 48);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(232, 329);
            listBox1.TabIndex = 6;
            // 
            // lblClavier
            // 
            lblClavier.AutoSize = true;
            lblClavier.Location = new Point(22, 9);
            lblClavier.Name = "lblClavier";
            lblClavier.Size = new Size(164, 25);
            lblClavier.TabIndex = 1;
            lblClavier.Text = "Interception Clavier";
            // 
            // lblPositionY
            // 
            lblPositionY.AutoSize = true;
            lblPositionY.Location = new Point(659, 9);
            lblPositionY.Name = "lblPositionY";
            lblPositionY.Size = new Size(90, 25);
            lblPositionY.TabIndex = 5;
            lblPositionY.Text = "Position Y";
            // 
            // lblPositionX
            // 
            lblPositionX.AutoSize = true;
            lblPositionX.Location = new Point(547, 9);
            lblPositionX.Name = "lblPositionX";
            lblPositionX.Size = new Size(91, 25);
            lblPositionX.TabIndex = 4;
            lblPositionX.Text = "Position X";
            // 
            // lblClicDroit
            // 
            lblClicDroit.AutoSize = true;
            lblClicDroit.Location = new Point(437, 9);
            lblClicDroit.Name = "lblClicDroit";
            lblClicDroit.Size = new Size(82, 25);
            lblClicDroit.TabIndex = 3;
            lblClicDroit.Text = "Clic droit";
            // 
            // lblClicGauche
            // 
            lblClicGauche.AutoSize = true;
            lblClicGauche.Location = new Point(313, 9);
            lblClicGauche.Name = "lblClicGauche";
            lblClicGauche.Size = new Size(101, 25);
            lblClicGauche.TabIndex = 2;
            lblClicGauche.Text = "Clic gauche";
            // 
            // tbxClicGauche
            // 
            tbxClicGauche.Location = new Point(313, 48);
            tbxClicGauche.Name = "tbxClicGauche";
            tbxClicGauche.Size = new Size(92, 31);
            tbxClicGauche.TabIndex = 7;
            tbxClicGauche.TextChanged += textBox1_TextChanged;
            // 
            // tbxClicDroit
            // 
            tbxClicDroit.Location = new Point(428, 48);
            tbxClicDroit.Name = "tbxClicDroit";
            tbxClicDroit.Size = new Size(91, 31);
            tbxClicDroit.TabIndex = 8;
            // 
            // tbxPositionX
            // 
            tbxPositionX.Location = new Point(547, 48);
            tbxPositionX.Name = "tbxPositionX";
            tbxPositionX.Size = new Size(91, 31);
            tbxPositionX.TabIndex = 9;
            // 
            // tbxPositionY
            // 
            tbxPositionY.Location = new Point(659, 48);
            tbxPositionY.Name = "tbxPositionY";
            tbxPositionY.Size = new Size(100, 31);
            tbxPositionY.TabIndex = 10;
            // 
            // button1
            // 
            button1.Location = new Point(22, 395);
            button1.Name = "button1";
            button1.Size = new Size(232, 34);
            button1.TabIndex = 0;
            button1.Text = "Remise a zéro";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // EcranClavierSouris
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(tbxPositionY);
            Controls.Add(tbxPositionX);
            Controls.Add(tbxClicDroit);
            Controls.Add(tbxClicGauche);
            Controls.Add(listBox1);
            Controls.Add(lblPositionY);
            Controls.Add(lblPositionX);
            Controls.Add(lblClicDroit);
            Controls.Add(lblClicGauche);
            Controls.Add(lblClavier);
            Controls.Add(pnlSouris);
            Name = "EcranClavierSouris";
            Text = "EcranClavierSouris";
            KeyDown += Fenetre_ToucheEnfoncee;
            KeyPress += Fenetre_ToucheTapee;
            KeyUp += Fenetre_ToucheRelachee;
            MouseDown += pnlSouris_Paint;
            MouseMove += pnlSouris_Deplacement;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlSouris;
        private ListBox listBox1;
        private Label lblClavier;
        private Label lblPositionY;
        private Label lblPositionX;
        private Label lblClicDroit;
        private Label lblClicGauche;
        private TextBox tbxClicGauche;
        private TextBox tbxClicDroit;
        private TextBox tbxPositionX;
        private TextBox tbxPositionY;
        private Button button1;
    }
}