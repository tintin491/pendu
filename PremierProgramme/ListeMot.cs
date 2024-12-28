using PremierProgramme.Modele;
using PremierProgramme.Controllers;
using System;
using System.Data;
using System.Windows.Forms;

namespace PremierProgramme
{
    public partial class ListeMot : Form
    {
        DataView dv_mot;
        Mots dt_mot;
        AjoutBddModif ajoutModiff = new AjoutBddModif();
        public ListeMot()
        {
            InitializeComponent();

        }

        private void Form2_Load(object sender, EventArgs e)

        {            
            dt_mot = new Mots();
            dv_mot = new DataView(dt_mot.GetListeMots());
            dgv_Mots.DataSource = dv_mot;
            //Cacher les colonnes qui ne servent à rien pour l’utilisateur
            dgv_Mots.Columns["IDMOTS"].Visible = false;

            //Gérer la largeur des colonnes
            dgv_Mots.Columns["mot"].Width = 190;
            dgv_Mots.Columns["difficulte"].Width = 83;

            Difficulte dt_difficulte = new Difficulte();
            cbb_diffMotmodif.DataSource = dt_difficulte.GetListeDifficulte();
            cbb_diffMotmodif.DisplayMember = "difficulte";
            cbb_diffMotmodif.ValueMember = "IDDIFFICULTE";
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            dv_mot = new DataView(dt_mot.GetListeMotsdifficult(txtBox_chercheMot.Text, comboBox_diff.SelectedIndex.ToString()));
            dgv_Mots.DataSource = dv_mot;
        }

        private void TxtBox_chercheMot_TextChanged(object sender, EventArgs e)
        {

            dv_mot = new DataView(dt_mot.GetListeMotsdifficult(txtBox_chercheMot.Text, comboBox_diff.SelectedIndex.ToString()));
            dgv_Mots.DataSource = dv_mot;

        }

        private void Btn_AjouterMots_Click(object sender, EventArgs e)
        {
            dgv_Mots.Enabled = false;
            SousFormulaire modifierBdd = new SousFormulaire(pan_modiffMot);
            modifierBdd.MontrerMots(pan_modiffMot);
            ajoutModiff.Cpt = 0;
        }

        private void Btn_ModifMots_Click(object sender, EventArgs e)
        {
            dgv_Mots.Enabled = false;
            SousFormulaire modifierBdd = new SousFormulaire(pan_modiffMot);
            modifierBdd.MontrerMots(pan_modiffMot);
            ajoutModiff.Cpt = 1;
            txt_modifMot.Text =  dgv_Mots.CurrentRow.Cells["IDMOTS"].Value.ToString();
            txt_nonmotModif.Text = dgv_Mots.CurrentRow.Cells["mot"].Value.ToString();
            cbb_diffMotmodif.Text = dgv_Mots.CurrentRow.Cells["difficulte"].Value.ToString();
        }

        private void Btn_annulerModifMot_Click(object sender, EventArgs e)
        {
            dgv_Mots.Enabled = true;
            SousFormulaire modifierBdd = new SousFormulaire(pan_modiffMot);
            txt_nonmotModif.Text = "";
            txt_modifMot.Text = "";
            cbb_diffMotmodif.SelectedIndex = -1;
            modifierBdd.cacherMots(pan_modiffMot);
    
        }

        private void Dgv_Mots_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_modifMot.Text = dgv_Mots.Rows[e.RowIndex].Cells["IDMOTS"].Value.ToString(); // pas convaincu 
        }

        private void Btn_ValiderModifmot_Click(object sender, EventArgs e)
        {
            if (ajoutModiff.get_ifMotinBdd(txt_nonmotModif.Text, cbb_diffMotmodif.SelectedIndex.ToString()))
            {
                ajoutModiff.AjouterModif(txt_modifMot.Text, txt_nonmotModif.Text, cbb_diffMotmodif.SelectedIndex.ToString());
                dgv_Mots = ajoutModiff.rechargerDvg(dgv_Mots, txt_nonmotModif, cbb_diffMotmodif);
                dgv_Mots.Enabled = true;
                SousFormulaire modifierBdd = new SousFormulaire(pan_modiffMot);
                modifierBdd.cacherMots(pan_modiffMot);
            }
            else
            {
                MessageBox.Show("Ce mot ce trouvent déja dans la liste", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_SupprMots_Click(object sender, EventArgs e)
        {
            dgv_Mots.Enabled = false;
            SousFormulaire modifierBdd = new SousFormulaire(pan_modiffMot);
            modifierBdd.MontrerMots(pan_modiffMot);
            ajoutModiff.Cpt = 2;
            txt_modifMot.Text = dgv_Mots.CurrentRow.Cells["IDMOTS"].Value.ToString();
            txt_nonmotModif.Text = dgv_Mots.CurrentRow.Cells["mot"].Value.ToString();
            cbb_diffMotmodif.Text = dgv_Mots.CurrentRow.Cells["difficulte"].Value.ToString();
        }
    }
}
