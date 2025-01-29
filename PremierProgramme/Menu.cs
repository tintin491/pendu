using PremierProgramme.Modele;
using System;
using System.Windows.Forms;

namespace PremierProgramme
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();

        }


        private void MotsBDDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SousFormulaire SF2 = new SousFormulaire(Pan_SubForm);
            SF2.OpenChildForm(new ListeMot());
        }
        private void DémarrerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SousFormulaire SF1 = new SousFormulaire(Pan_SubForm);
            SF1.OpenChildForm(new Form1());
        }

        private void InscriptionUtilisateurToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SousFormulaire SF1 = new SousFormulaire(Pan_SubForm);
            SF1.OpenChildForm(new NewUtilisateur());
        }
    }
}
