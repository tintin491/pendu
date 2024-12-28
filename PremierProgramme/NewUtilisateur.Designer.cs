namespace PremierProgramme
{
    partial class NewUtilisateur
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
            this.txt_mailNewUti = new System.Windows.Forms.TextBox();
            this.txt_PrenomNexUtil = new System.Windows.Forms.TextBox();
            this.txt_NomNewUtil = new System.Windows.Forms.TextBox();
            this.txt_confirmation = new System.Windows.Forms.TextBox();
            this.txt_mdpNewUtil = new System.Windows.Forms.TextBox();
            this.lbl_mail = new System.Windows.Forms.Label();
            this.lbl_prenom = new System.Windows.Forms.Label();
            this.lbl_nom = new System.Windows.Forms.Label();
            this.lbl_confirmation = new System.Windows.Forms.Label();
            this.lbl_mdp = new System.Windows.Forms.Label();
            this.btn_validerNewUtil = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_mailNewUti
            // 
            this.txt_mailNewUti.Location = new System.Drawing.Point(303, 74);
            this.txt_mailNewUti.Name = "txt_mailNewUti";
            this.txt_mailNewUti.Size = new System.Drawing.Size(241, 20);
            this.txt_mailNewUti.TabIndex = 0;
            // 
            // txt_PrenomNexUtil
            // 
            this.txt_PrenomNexUtil.Location = new System.Drawing.Point(303, 245);
            this.txt_PrenomNexUtil.Name = "txt_PrenomNexUtil";
            this.txt_PrenomNexUtil.Size = new System.Drawing.Size(241, 20);
            this.txt_PrenomNexUtil.TabIndex = 1;
            // 
            // txt_NomNewUtil
            // 
            this.txt_NomNewUtil.Location = new System.Drawing.Point(303, 203);
            this.txt_NomNewUtil.Name = "txt_NomNewUtil";
            this.txt_NomNewUtil.Size = new System.Drawing.Size(241, 20);
            this.txt_NomNewUtil.TabIndex = 2;
            // 
            // txt_confirmation
            // 
            this.txt_confirmation.Location = new System.Drawing.Point(303, 155);
            this.txt_confirmation.Name = "txt_confirmation";
            this.txt_confirmation.Size = new System.Drawing.Size(241, 20);
            this.txt_confirmation.TabIndex = 3;
            // 
            // txt_mdpNewUtil
            // 
            this.txt_mdpNewUtil.Location = new System.Drawing.Point(303, 114);
            this.txt_mdpNewUtil.Name = "txt_mdpNewUtil";
            this.txt_mdpNewUtil.Size = new System.Drawing.Size(241, 20);
            this.txt_mdpNewUtil.TabIndex = 4;
            // 
            // lbl_mail
            // 
            this.lbl_mail.AutoSize = true;
            this.lbl_mail.Location = new System.Drawing.Point(197, 81);
            this.lbl_mail.Name = "lbl_mail";
            this.lbl_mail.Size = new System.Drawing.Size(26, 13);
            this.lbl_mail.TabIndex = 5;
            this.lbl_mail.Text = "Mail";
            // 
            // lbl_prenom
            // 
            this.lbl_prenom.AutoSize = true;
            this.lbl_prenom.Location = new System.Drawing.Point(197, 252);
            this.lbl_prenom.Name = "lbl_prenom";
            this.lbl_prenom.Size = new System.Drawing.Size(43, 13);
            this.lbl_prenom.TabIndex = 6;
            this.lbl_prenom.Text = "Prenom";
            // 
            // lbl_nom
            // 
            this.lbl_nom.AutoSize = true;
            this.lbl_nom.Location = new System.Drawing.Point(197, 206);
            this.lbl_nom.Name = "lbl_nom";
            this.lbl_nom.Size = new System.Drawing.Size(29, 13);
            this.lbl_nom.TabIndex = 7;
            this.lbl_nom.Text = "Nom";
            // 
            // lbl_confirmation
            // 
            this.lbl_confirmation.AutoSize = true;
            this.lbl_confirmation.Location = new System.Drawing.Point(197, 162);
            this.lbl_confirmation.Name = "lbl_confirmation";
            this.lbl_confirmation.Size = new System.Drawing.Size(67, 13);
            this.lbl_confirmation.TabIndex = 8;
            this.lbl_confirmation.Text = "Comfirmation";
            // 
            // lbl_mdp
            // 
            this.lbl_mdp.AutoSize = true;
            this.lbl_mdp.Location = new System.Drawing.Point(197, 121);
            this.lbl_mdp.Name = "lbl_mdp";
            this.lbl_mdp.Size = new System.Drawing.Size(71, 13);
            this.lbl_mdp.TabIndex = 9;
            this.lbl_mdp.Text = "Mot de passe";
            // 
            // btn_validerNewUtil
            // 
            this.btn_validerNewUtil.Location = new System.Drawing.Point(303, 309);
            this.btn_validerNewUtil.Name = "btn_validerNewUtil";
            this.btn_validerNewUtil.Size = new System.Drawing.Size(241, 23);
            this.btn_validerNewUtil.TabIndex = 10;
            this.btn_validerNewUtil.Text = "Valider";
            this.btn_validerNewUtil.UseVisualStyleBackColor = true;
            // 
            // NewUtilisateur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_validerNewUtil);
            this.Controls.Add(this.lbl_mdp);
            this.Controls.Add(this.lbl_confirmation);
            this.Controls.Add(this.lbl_nom);
            this.Controls.Add(this.lbl_prenom);
            this.Controls.Add(this.lbl_mail);
            this.Controls.Add(this.txt_mdpNewUtil);
            this.Controls.Add(this.txt_confirmation);
            this.Controls.Add(this.txt_NomNewUtil);
            this.Controls.Add(this.txt_PrenomNexUtil);
            this.Controls.Add(this.txt_mailNewUti);
            this.Name = "NewUtilisateur";
            this.Text = "NewUtilisateur";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_mailNewUti;
        private System.Windows.Forms.TextBox txt_PrenomNexUtil;
        private System.Windows.Forms.TextBox txt_NomNewUtil;
        private System.Windows.Forms.TextBox txt_confirmation;
        private System.Windows.Forms.TextBox txt_mdpNewUtil;
        private System.Windows.Forms.Label lbl_mail;
        private System.Windows.Forms.Label lbl_prenom;
        private System.Windows.Forms.Label lbl_nom;
        private System.Windows.Forms.Label lbl_confirmation;
        private System.Windows.Forms.Label lbl_mdp;
        private System.Windows.Forms.Button btn_validerNewUtil;
    }
}