namespace ProjetPrincipale
{
    partial class BarreDeProgression
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            button1 = new Button();
            button2 = new Button();
            progressBar1 = new ProgressBar();
            progressBar2 = new ProgressBar();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(319, 9);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(228, 33);
            label1.TabIndex = 0;
            label1.Text = "Barre de progression";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Bahnschrift Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(367, 56);
            label2.Name = "label2";
            label2.Size = new Size(134, 29);
            label2.TabIndex = 1;
            label2.Text = "Index principal";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Bahnschrift Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(367, 177);
            label3.Name = "label3";
            label3.Size = new Size(149, 29);
            label3.TabIndex = 2;
            label3.Text = "Index secondaire";
            // 
            // button1
            // 
            button1.Location = new Point(319, 318);
            button1.Name = "button1";
            button1.Size = new Size(125, 41);
            button1.TabIndex = 3;
            button1.Text = "Exécuter";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(467, 318);
            button2.Name = "button2";
            button2.Size = new Size(125, 41);
            button2.TabIndex = 4;
            button2.Text = "Quitter";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(366, 105);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(150, 51);
            progressBar1.TabIndex = 5;
            // 
            // progressBar2
            // 
            progressBar2.Location = new Point(367, 228);
            progressBar2.Name = "progressBar2";
            progressBar2.Size = new Size(150, 51);
            progressBar2.TabIndex = 6;
            // 
            // BarreDeProgression
            // 
            AutoScaleDimensions = new SizeF(13F, 33F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1040, 594);
            Controls.Add(progressBar2);
            Controls.Add(progressBar1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Arial Narrow", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "BarreDeProgression";
            Text = "BarreDeProgression";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Button button1;
        private Button button2;
        private ProgressBar progressBar1;
        private ProgressBar progressBar2;
    }
}