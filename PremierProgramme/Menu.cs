using PremierProgramme.Modele;
using PremierProgramme.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PremierProgramme
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();

        }


        private void motsBDDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SousFormulaire SF2 = new SousFormulaire(Pan_SubForm);
            SF2.openChildForm(new ListeMot());
        }
        private void DémarrerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SousFormulaire SF1 = new SousFormulaire(Pan_SubForm);
            SF1.openChildForm(new Form1());
        }

        private void Cbb_diffMotmodif_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void MenuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void inscriptionUtilisateurToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SousFormulaire SF1 = new SousFormulaire(Pan_SubForm);
            SF1.openChildForm(new NewUtilisateur());
        }
    }
}
