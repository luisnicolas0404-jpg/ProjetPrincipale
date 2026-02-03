namespace ProjetPrincipale
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            button1 = new Button();
            button2 = new Button();
            menuStrip1 = new MenuStrip();
            controleToolStripMenuItem = new ToolStripMenuItem();
            listeToolStripMenuItem = new ToolStripMenuItem();
            barreDeProgressionToolStripMenuItem = new ToolStripMenuItem();
            quitterToolStripMenuItem = new ToolStripMenuItem();
            applicationToolStripMenuItem = new ToolStripMenuItem();
            editeurToolStripMenuItem = new ToolStripMenuItem();
            aideToolStripMenuItem = new ToolStripMenuItem();
            aProposToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.InitialImage = null;
            pictureBox1.Location = new Point(150, 165);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(179, 84);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.InitialImage = null;
            pictureBox2.Location = new Point(458, 165);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(172, 84);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // button1
            // 
            button1.Location = new Point(323, 80);
            button1.Name = "button1";
            button1.Size = new Size(137, 55);
            button1.TabIndex = 2;
            button1.Text = "Inversion";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(323, 272);
            button2.Name = "button2";
            button2.Size = new Size(137, 56);
            button2.TabIndex = 3;
            button2.Text = "Nouvelle Page";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { controleToolStripMenuItem, applicationToolStripMenuItem, aideToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 33);
            menuStrip1.TabIndex = 4;
            menuStrip1.Text = "menuStrip1";
            // 
            // controleToolStripMenuItem
            // 
            controleToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { listeToolStripMenuItem, barreDeProgressionToolStripMenuItem, quitterToolStripMenuItem });
            controleToolStripMenuItem.Name = "controleToolStripMenuItem";
            controleToolStripMenuItem.Size = new Size(93, 29);
            controleToolStripMenuItem.Text = "controle";
            // 
            // listeToolStripMenuItem
            // 
            listeToolStripMenuItem.Name = "listeToolStripMenuItem";
            listeToolStripMenuItem.Size = new Size(279, 34);
            listeToolStripMenuItem.Text = "Liste";
            listeToolStripMenuItem.Click += listeToolStripMenuItem_Click;
            // 
            // barreDeProgressionToolStripMenuItem
            // 
            barreDeProgressionToolStripMenuItem.Name = "barreDeProgressionToolStripMenuItem";
            barreDeProgressionToolStripMenuItem.Size = new Size(279, 34);
            barreDeProgressionToolStripMenuItem.Text = "Barre de progression";
            barreDeProgressionToolStripMenuItem.Click += barreDeProgressionToolStripMenuItem_Click;
            // 
            // quitterToolStripMenuItem
            // 
            quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            quitterToolStripMenuItem.Size = new Size(279, 34);
            quitterToolStripMenuItem.Text = "Quitter";
            quitterToolStripMenuItem.Click += quitterToolStripMenuItem_Click;
            // 
            // applicationToolStripMenuItem
            // 
            applicationToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { editeurToolStripMenuItem });
            applicationToolStripMenuItem.Name = "applicationToolStripMenuItem";
            applicationToolStripMenuItem.Size = new Size(115, 29);
            applicationToolStripMenuItem.Text = "application";
            // 
            // editeurToolStripMenuItem
            // 
            editeurToolStripMenuItem.Name = "editeurToolStripMenuItem";
            editeurToolStripMenuItem.Size = new Size(169, 34);
            editeurToolStripMenuItem.Text = "Editeur";
            editeurToolStripMenuItem.Click += editeurToolStripMenuItem_Click;
            // 
            // aideToolStripMenuItem
            // 
            aideToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { aProposToolStripMenuItem });
            aideToolStripMenuItem.Name = "aideToolStripMenuItem";
            aideToolStripMenuItem.Size = new Size(66, 29);
            aideToolStripMenuItem.Text = "aide ";
            // 
            // aProposToolStripMenuItem
            // 
            aProposToolStripMenuItem.Name = "aProposToolStripMenuItem";
            aProposToolStripMenuItem.Size = new Size(270, 34);
            aProposToolStripMenuItem.Text = "A propos";
            aProposToolStripMenuItem.Click += aProposToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Button button1;
        private Button button2;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem controleToolStripMenuItem;
        private ToolStripMenuItem listeToolStripMenuItem;
        private ToolStripMenuItem barreDeProgressionToolStripMenuItem;
        private ToolStripMenuItem quitterToolStripMenuItem;
        private ToolStripMenuItem applicationToolStripMenuItem;
        private ToolStripMenuItem aideToolStripMenuItem;
        private ToolStripMenuItem editeurToolStripMenuItem;
        private ToolStripMenuItem aProposToolStripMenuItem;
    }
}
