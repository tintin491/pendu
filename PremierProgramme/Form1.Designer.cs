namespace PremierProgramme
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
            this.btn_valider = new System.Windows.Forms.Button();
            this.textBoxNom = new System.Windows.Forms.TextBox();
            this.textBoxPrenom = new System.Windows.Forms.TextBox();
            this.nom = new System.Windows.Forms.Label();
            this.prenom = new System.Windows.Forms.Label();
            this.ChoixDiff = new System.Windows.Forms.ComboBox();
            this.difficulte = new System.Windows.Forms.Label();
            this.btn_fermer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_valider
            // 
            this.btn_valider.BackColor = System.Drawing.Color.DarkGray;
            this.btn_valider.Location = new System.Drawing.Point(742, 265);
            this.btn_valider.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btn_valider.Name = "btn_valider";
            this.btn_valider.Size = new System.Drawing.Size(150, 54);
            this.btn_valider.TabIndex = 0;
            this.btn_valider.Text = "Valider";
            this.btn_valider.UseVisualStyleBackColor = false;
            this.btn_valider.Click += new System.EventHandler(this.btn_valider_Click);
            // 
            // textBoxNom
            // 
            this.textBoxNom.Location = new System.Drawing.Point(578, 71);
            this.textBoxNom.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.textBoxNom.Name = "textBoxNom";
            this.textBoxNom.Size = new System.Drawing.Size(530, 31);
            this.textBoxNom.TabIndex = 4;
            // 
            // textBoxPrenom
            // 
            this.textBoxPrenom.Location = new System.Drawing.Point(578, 121);
            this.textBoxPrenom.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.textBoxPrenom.Name = "textBoxPrenom";
            this.textBoxPrenom.Size = new System.Drawing.Size(530, 31);
            this.textBoxPrenom.TabIndex = 5;
            // 
            // nom
            // 
            this.nom.AutoSize = true;
            this.nom.Location = new System.Drawing.Point(264, 85);
            this.nom.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.nom.Name = "nom";
            this.nom.Size = new System.Drawing.Size(74, 25);
            this.nom.TabIndex = 6;
            this.nom.Text = "Nom : ";
            // 
            // prenom
            // 
            this.prenom.AutoSize = true;
            this.prenom.Location = new System.Drawing.Point(264, 135);
            this.prenom.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.prenom.Name = "prenom";
            this.prenom.Size = new System.Drawing.Size(98, 25);
            this.prenom.TabIndex = 7;
            this.prenom.Text = "Prenom :";
            // 
            // ChoixDiff
            // 
            this.ChoixDiff.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ChoixDiff.FormattingEnabled = true;
            this.ChoixDiff.Location = new System.Drawing.Point(578, 171);
            this.ChoixDiff.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.ChoixDiff.Name = "ChoixDiff";
            this.ChoixDiff.Size = new System.Drawing.Size(530, 33);
            this.ChoixDiff.TabIndex = 16;
            this.ChoixDiff.SelectedIndexChanged += new System.EventHandler(this.SelectIndexChanged);
            // 
            // difficulte
            // 
            this.difficulte.AutoSize = true;
            this.difficulte.Location = new System.Drawing.Point(264, 194);
            this.difficulte.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.difficulte.Name = "difficulte";
            this.difficulte.Size = new System.Drawing.Size(103, 25);
            this.difficulte.TabIndex = 17;
            this.difficulte.Text = "difficultés";
            // 
            // btn_fermer
            // 
            this.btn_fermer.BackColor = System.Drawing.Color.LightCoral;
            this.btn_fermer.Location = new System.Drawing.Point(742, 331);
            this.btn_fermer.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btn_fermer.Name = "btn_fermer";
            this.btn_fermer.Size = new System.Drawing.Size(150, 44);
            this.btn_fermer.TabIndex = 18;
            this.btn_fermer.Text = "Fermer";
            this.btn_fermer.UseVisualStyleBackColor = false;
            this.btn_fermer.Click += new System.EventHandler(this.ButtonFermer_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1600, 865);
            this.Controls.Add(this.btn_fermer);
            this.Controls.Add(this.difficulte);
            this.Controls.Add(this.ChoixDiff);
            this.Controls.Add(this.prenom);
            this.Controls.Add(this.nom);
            this.Controls.Add(this.textBoxPrenom);
            this.Controls.Add(this.textBoxNom);
            this.Controls.Add(this.btn_valider);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_valider;
        private System.Windows.Forms.TextBox textBoxNom;
        private System.Windows.Forms.TextBox textBoxPrenom;
        private System.Windows.Forms.Label nom;
        private System.Windows.Forms.Label prenom;
        private System.Windows.Forms.ComboBox ChoixDiff;
        private System.Windows.Forms.Label difficulte;
        private System.Windows.Forms.Button btn_fermer;
    }
}

