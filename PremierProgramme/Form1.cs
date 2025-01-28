using PremierProgramme.Modele;
using PremierProgramme.Controllers;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace PremierProgramme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            {
                Difficulte dt_difficulte = new Difficulte();
                ChoixDiff.DataSource = dt_difficulte.GetListeDifficulte();
                ChoixDiff.DisplayMember = "difficulte";
                ChoixDiff.ValueMember = "IDDIFFICULTE";

            }
        }

        private void SelectIndexChanged(object sender, EventArgs e)
        {
            if (Convert.ToString(ChoixDiff.SelectedItem) == "Enfer")
            {
                this.BackColor = Color.Red;
                ChoixDiff.Font = new Font(ChoixDiff.Font, FontStyle.Bold);
                difficulte.Font = new Font(ChoixDiff.Font, FontStyle.Bold);
                textBoxPrenom.Font = new Font(ChoixDiff.Font, FontStyle.Bold);
                textBoxNom.Font = new Font(ChoixDiff.Font, FontStyle.Bold);
            }
            else
            {
                this.BackColor = Color.FromArgb(153, 180, 209);
                ChoixDiff.Font = new Font(ChoixDiff.Font, FontStyle.Regular);
                difficulte.Font = new Font(ChoixDiff.Font, FontStyle.Regular);
                textBoxPrenom.Font = new Font(ChoixDiff.Font, FontStyle.Regular);
                textBoxNom.Font = new Font(ChoixDiff.Font, FontStyle.Regular);

            }
        }
        private void btn_valider_Click(object sender, EventArgs e)
        {
            if (ChoixDiff.SelectedIndex == 0)
            {
                MessageBox.Show("Aucune difficulté n'est rentré n'est rentré", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (textBoxNom.Text == "")
            {
                MessageBox.Show("Aucun Nom n'est rentré n'est rentré", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (textBoxNom.Text == "")
            {
                MessageBox.Show("Aucun Prénom n'est rentré n'est rentré", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (textBoxNom.Text != "" && textBoxPrenom.Text != "" && ChoixDiff.SelectedIndex != 0)
            {
                string joueur = textBoxNom.Text;
                joueur += " " + textBoxPrenom.Text;

                SousFormulaire SF = new SousFormulaire((System.Windows.Forms.Application.OpenForms["Menu"] as Menu).Pan_SubForm);
                SF.OpenChildForm(new jeu(joueur, Convert.ToString(ChoixDiff.Text)));
                this.Close();
            }

        }

        private void ButtonFermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
