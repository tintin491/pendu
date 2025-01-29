namespace PremierProgramme
{
    partial class Menu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.jeuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.démarrerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scoreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.paramétreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.motsPrésentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.Pan_SubForm = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.inscriptionUtilisateurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.Pan_SubForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.jeuToolStripMenuItem,
            this.scoreToolStripMenuItem,
            this.paramétreToolStripMenuItem,
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(855, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // jeuToolStripMenuItem
            // 
            this.jeuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.démarrerToolStripMenuItem});
            this.jeuToolStripMenuItem.Name = "jeuToolStripMenuItem";
            this.jeuToolStripMenuItem.Size = new System.Drawing.Size(36, 20);
            this.jeuToolStripMenuItem.Text = "Jeu";
            // 
            // démarrerToolStripMenuItem
            // 
            this.démarrerToolStripMenuItem.Name = "démarrerToolStripMenuItem";
            this.démarrerToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.démarrerToolStripMenuItem.Text = "Démarrer";
            this.démarrerToolStripMenuItem.Click += new System.EventHandler(this.DémarrerToolStripMenuItem_Click);
            // 
            // scoreToolStripMenuItem
            // 
            this.scoreToolStripMenuItem.Name = "scoreToolStripMenuItem";
            this.scoreToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.scoreToolStripMenuItem.Text = "Score ";
            // 
            // paramétreToolStripMenuItem
            // 
            this.paramétreToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.motsPrésentToolStripMenuItem,
            this.inscriptionUtilisateurToolStripMenuItem});
            this.paramétreToolStripMenuItem.Name = "paramétreToolStripMenuItem";
            this.paramétreToolStripMenuItem.Size = new System.Drawing.Size(78, 20);
            this.paramétreToolStripMenuItem.Text = "Paramètres";
            // 
            // motsPrésentToolStripMenuItem
            // 
            this.motsPrésentToolStripMenuItem.Name = "motsPrésentToolStripMenuItem";
            this.motsPrésentToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.motsPrésentToolStripMenuItem.Text = "Mots présent";
            this.motsPrésentToolStripMenuItem.Click += new System.EventHandler(this.MotsBDDToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(24, 20);
            this.toolStripMenuItem1.Text = "?";
            // 
            // Pan_SubForm
            // 
            this.Pan_SubForm.Controls.Add(this.pictureBox1);
            this.Pan_SubForm.Location = new System.Drawing.Point(0, 27);
            this.Pan_SubForm.Name = "Pan_SubForm";
            this.Pan_SubForm.Size = new System.Drawing.Size(855, 508);
            this.Pan_SubForm.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PremierProgramme.Properties.Resources.Moeraki_Boulders_New_Zealand;
            this.pictureBox1.Location = new System.Drawing.Point(77, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(694, 460);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // inscriptionUtilisateurToolStripMenuItem
            // 
            this.inscriptionUtilisateurToolStripMenuItem.Name = "inscriptionUtilisateurToolStripMenuItem";
            this.inscriptionUtilisateurToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.inscriptionUtilisateurToolStripMenuItem.Text = "Inscription utilisateur ";
            this.inscriptionUtilisateurToolStripMenuItem.Click += new System.EventHandler(this.InscriptionUtilisateurToolStripMenuItem_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(855, 535);
            this.Controls.Add(this.Pan_SubForm);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Menu";
            this.Text = "Menu";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.Pan_SubForm.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem jeuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem scoreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem paramétreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem démarrerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        public System.Windows.Forms.Panel Pan_SubForm;
        private System.Windows.Forms.ToolStripMenuItem motsPrésentToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem inscriptionUtilisateurToolStripMenuItem;
    }
}