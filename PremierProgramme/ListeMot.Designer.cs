namespace PremierProgramme
{
    partial class ListeMot
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
            this.dgv_Mots = new System.Windows.Forms.DataGridView();
            this.btn_fermer = new System.Windows.Forms.Button();
            this.label_chercheDiff = new System.Windows.Forms.Label();
            this.label_cherchMot = new System.Windows.Forms.Label();
            this.comboBox_diff = new System.Windows.Forms.ComboBox();
            this.txtBox_chercheMot = new System.Windows.Forms.TextBox();
            this.mySqlCommand1 = new MySql.Data.MySqlClient.MySqlCommand();
            this.btn_AjouterMots = new System.Windows.Forms.Button();
            this.btn_ModifMots = new System.Windows.Forms.Button();
            this.btn_SupprMots = new System.Windows.Forms.Button();
            this.pan_listemot = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_annulerModifMot = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_modifMot = new System.Windows.Forms.TextBox();
            this.txt_nonmotModif = new System.Windows.Forms.TextBox();
            this.cbb_diffMotmodif = new System.Windows.Forms.ComboBox();
            this.btn_ValiderModifmot = new System.Windows.Forms.Button();
            this.pan_modiffMot = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Mots)).BeginInit();
            this.pan_listemot.SuspendLayout();
            this.pan_modiffMot.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_Mots
            // 
            this.dgv_Mots.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Mots.Location = new System.Drawing.Point(264, 238);
            this.dgv_Mots.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.dgv_Mots.Name = "dgv_Mots";
            this.dgv_Mots.RowHeadersWidth = 82;
            this.dgv_Mots.Size = new System.Drawing.Size(668, 481);
            this.dgv_Mots.TabIndex = 0;
            this.dgv_Mots.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_Mots_CellContentClick);
            // 
            // btn_fermer
            // 
            this.btn_fermer.BackColor = System.Drawing.Color.LightCoral;
            this.btn_fermer.Location = new System.Drawing.Point(22, 315);
            this.btn_fermer.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btn_fermer.Name = "btn_fermer";
            this.btn_fermer.Size = new System.Drawing.Size(150, 44);
            this.btn_fermer.TabIndex = 1;
            this.btn_fermer.Text = "Fermer";
            this.btn_fermer.UseVisualStyleBackColor = false;
            this.btn_fermer.Click += new System.EventHandler(this.Button1_Click);
            // 
            // label_chercheDiff
            // 
            this.label_chercheDiff.AutoSize = true;
            this.label_chercheDiff.Location = new System.Drawing.Point(6, 169);
            this.label_chercheDiff.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label_chercheDiff.Name = "label_chercheDiff";
            this.label_chercheDiff.Size = new System.Drawing.Size(251, 25);
            this.label_chercheDiff.TabIndex = 2;
            this.label_chercheDiff.Text = "Rechercher une difficulté";
            // 
            // label_cherchMot
            // 
            this.label_cherchMot.AutoSize = true;
            this.label_cherchMot.Location = new System.Drawing.Point(6, 88);
            this.label_cherchMot.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label_cherchMot.Name = "label_cherchMot";
            this.label_cherchMot.Size = new System.Drawing.Size(194, 25);
            this.label_cherchMot.TabIndex = 3;
            this.label_cherchMot.Text = "Rechercher un mot";
            // 
            // comboBox_diff
            // 
            this.comboBox_diff.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_diff.FormattingEnabled = true;
            this.comboBox_diff.Location = new System.Drawing.Point(264, 163);
            this.comboBox_diff.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.comboBox_diff.Name = "comboBox_diff";
            this.comboBox_diff.Size = new System.Drawing.Size(498, 33);
            this.comboBox_diff.TabIndex = 4;
            this.comboBox_diff.SelectedIndexChanged += new System.EventHandler(this.ComboBox1_SelectedIndexChanged);
            // 
            // txtBox_chercheMot
            // 
            this.txtBox_chercheMot.Location = new System.Drawing.Point(264, 88);
            this.txtBox_chercheMot.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtBox_chercheMot.Name = "txtBox_chercheMot";
            this.txtBox_chercheMot.Size = new System.Drawing.Size(498, 31);
            this.txtBox_chercheMot.TabIndex = 5;
            this.txtBox_chercheMot.TextChanged += new System.EventHandler(this.TxtBox_chercheMot_TextChanged);
            // 
            // mySqlCommand1
            // 
            this.mySqlCommand1.CacheAge = 0;
            this.mySqlCommand1.Connection = null;
            this.mySqlCommand1.EnableCaching = false;
            this.mySqlCommand1.Transaction = null;
            // 
            // btn_AjouterMots
            // 
            this.btn_AjouterMots.Location = new System.Drawing.Point(968, 238);
            this.btn_AjouterMots.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btn_AjouterMots.Name = "btn_AjouterMots";
            this.btn_AjouterMots.Size = new System.Drawing.Size(150, 44);
            this.btn_AjouterMots.TabIndex = 6;
            this.btn_AjouterMots.Text = "Ajouter";
            this.btn_AjouterMots.UseVisualStyleBackColor = true;
            this.btn_AjouterMots.Click += new System.EventHandler(this.Btn_AjouterMots_Click);
            // 
            // btn_ModifMots
            // 
            this.btn_ModifMots.Location = new System.Drawing.Point(968, 315);
            this.btn_ModifMots.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btn_ModifMots.Name = "btn_ModifMots";
            this.btn_ModifMots.Size = new System.Drawing.Size(150, 44);
            this.btn_ModifMots.TabIndex = 7;
            this.btn_ModifMots.Text = "Modifier";
            this.btn_ModifMots.UseVisualStyleBackColor = true;
            this.btn_ModifMots.Click += new System.EventHandler(this.Btn_ModifMots_Click);
            // 
            // btn_SupprMots
            // 
            this.btn_SupprMots.Location = new System.Drawing.Point(968, 381);
            this.btn_SupprMots.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btn_SupprMots.Name = "btn_SupprMots";
            this.btn_SupprMots.Size = new System.Drawing.Size(150, 44);
            this.btn_SupprMots.TabIndex = 8;
            this.btn_SupprMots.Text = "Supprimer";
            this.btn_SupprMots.UseVisualStyleBackColor = true;
            this.btn_SupprMots.Click += new System.EventHandler(this.Btn_SupprMots_Click);
            // 
            // pan_listemot
            // 
            this.pan_listemot.Controls.Add(this.btn_SupprMots);
            this.pan_listemot.Controls.Add(this.btn_ModifMots);
            this.pan_listemot.Controls.Add(this.btn_AjouterMots);
            this.pan_listemot.Controls.Add(this.txtBox_chercheMot);
            this.pan_listemot.Controls.Add(this.comboBox_diff);
            this.pan_listemot.Controls.Add(this.label_cherchMot);
            this.pan_listemot.Controls.Add(this.label_chercheDiff);
            this.pan_listemot.Controls.Add(this.btn_fermer);
            this.pan_listemot.Controls.Add(this.dgv_Mots);
            this.pan_listemot.Location = new System.Drawing.Point(2, 4);
            this.pan_listemot.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.pan_listemot.Name = "pan_listemot";
            this.pan_listemot.Size = new System.Drawing.Size(1138, 827);
            this.pan_listemot.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 400);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 25);
            this.label2.TabIndex = 16;
            this.label2.Text = "Difficulte : ";
            // 
            // btn_annulerModifMot
            // 
            this.btn_annulerModifMot.Location = new System.Drawing.Point(314, 604);
            this.btn_annulerModifMot.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btn_annulerModifMot.Name = "btn_annulerModifMot";
            this.btn_annulerModifMot.Size = new System.Drawing.Size(150, 44);
            this.btn_annulerModifMot.TabIndex = 20;
            this.btn_annulerModifMot.Text = "Annuler";
            this.btn_annulerModifMot.UseVisualStyleBackColor = true;
            this.btn_annulerModifMot.Click += new System.EventHandler(this.Btn_annulerModifMot_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 298);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 25);
            this.label1.TabIndex = 15;
            this.label1.Text = "Mot : ";
            // 
            // txt_modifMot
            // 
            this.txt_modifMot.Location = new System.Drawing.Point(152, 163);
            this.txt_modifMot.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txt_modifMot.Name = "txt_modifMot";
            this.txt_modifMot.Size = new System.Drawing.Size(308, 31);
            this.txt_modifMot.TabIndex = 14;
            this.txt_modifMot.Visible = false;
            // 
            // txt_nonmotModif
            // 
            this.txt_nonmotModif.Location = new System.Drawing.Point(152, 292);
            this.txt_nonmotModif.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txt_nonmotModif.Name = "txt_nonmotModif";
            this.txt_nonmotModif.Size = new System.Drawing.Size(308, 31);
            this.txt_nonmotModif.TabIndex = 17;
            // 
            // cbb_diffMotmodif
            // 
            this.cbb_diffMotmodif.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_diffMotmodif.FormattingEnabled = true;
            this.cbb_diffMotmodif.Location = new System.Drawing.Point(152, 400);
            this.cbb_diffMotmodif.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.cbb_diffMotmodif.Name = "cbb_diffMotmodif";
            this.cbb_diffMotmodif.Size = new System.Drawing.Size(308, 33);
            this.cbb_diffMotmodif.TabIndex = 18;
            // 
            // btn_ValiderModifmot
            // 
            this.btn_ValiderModifmot.Location = new System.Drawing.Point(152, 604);
            this.btn_ValiderModifmot.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btn_ValiderModifmot.Name = "btn_ValiderModifmot";
            this.btn_ValiderModifmot.Size = new System.Drawing.Size(150, 44);
            this.btn_ValiderModifmot.TabIndex = 19;
            this.btn_ValiderModifmot.Text = "Valider";
            this.btn_ValiderModifmot.UseVisualStyleBackColor = true;
            this.btn_ValiderModifmot.Click += new System.EventHandler(this.Btn_ValiderModifmot_Click);
            // 
            // pan_modiffMot
            // 
            this.pan_modiffMot.Controls.Add(this.txt_nonmotModif);
            this.pan_modiffMot.Controls.Add(this.btn_annulerModifMot);
            this.pan_modiffMot.Controls.Add(this.label2);
            this.pan_modiffMot.Controls.Add(this.btn_ValiderModifmot);
            this.pan_modiffMot.Controls.Add(this.txt_modifMot);
            this.pan_modiffMot.Controls.Add(this.cbb_diffMotmodif);
            this.pan_modiffMot.Controls.Add(this.label1);
            this.pan_modiffMot.Location = new System.Drawing.Point(1152, 4);
            this.pan_modiffMot.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.pan_modiffMot.Name = "pan_modiffMot";
            this.pan_modiffMot.Size = new System.Drawing.Size(660, 827);
            this.pan_modiffMot.TabIndex = 21;
            this.pan_modiffMot.Visible = false;
            // 
            // ListeMot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1814, 827);
            this.Controls.Add(this.pan_modiffMot);
            this.Controls.Add(this.pan_listemot);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "ListeMot";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Mots)).EndInit();
            this.pan_listemot.ResumeLayout(false);
            this.pan_listemot.PerformLayout();
            this.pan_modiffMot.ResumeLayout(false);
            this.pan_modiffMot.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_Mots;
        private System.Windows.Forms.Button btn_fermer;
        private System.Windows.Forms.Label label_chercheDiff;
        private System.Windows.Forms.Label label_cherchMot;
        private System.Windows.Forms.ComboBox comboBox_diff;
        private System.Windows.Forms.TextBox txtBox_chercheMot;
        private MySql.Data.MySqlClient.MySqlCommand mySqlCommand1;
        private System.Windows.Forms.Button btn_AjouterMots;
        private System.Windows.Forms.Button btn_ModifMots;
        private System.Windows.Forms.Button btn_SupprMots;
        private System.Windows.Forms.Panel pan_listemot;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_annulerModifMot;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_modifMot;
        private System.Windows.Forms.TextBox txt_nonmotModif;
        private System.Windows.Forms.ComboBox cbb_diffMotmodif;
        private System.Windows.Forms.Button btn_ValiderModifmot;
        public System.Windows.Forms.Panel pan_modiffMot;
    }
}