using PremierProgramme.Modele;
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
    public partial class jeu : Form
    {

        public static string motAtrouver = "";
        public static string motAfficher = "";
        public static int temps = 0;
        public static int compteur = 0;
        public static Timer timer;
        public static int dureecout = 0;
        Partie NewPartie;

        private void Init()
        {
            InitializeComponent();
            // Ajouter le code permettant l’initialisation du jeu 
            //timer
            timer = new Timer(); //Instancie un objet timer de la classe 
            timer.Interval = 1000;
            timer.Tick += Timer_Tick;
            timer.Start();
            txt_timer.Text = Convert.ToString(timer.Interval);
            NewPartie = new Partie(txt_motPendue, progress_barPendue, imagePendue, compteur);
        }


        public jeu(string nomPrenomJoueur, string difficultePartie)
        {
            Init();
            txt_nom.Text = nomPrenomJoueur;
            txt_difficulte.Text = difficultePartie;
            NewPartie.difficulte = difficultePartie;
            NewPartie.GenererMotAtrouver();
            NewPartie.GenererMotAfficher(NewPartie.motAtrouver);
            NewPartie.zoneTxt.Text = NewPartie.motAfficher;
            
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
 
            timer.Interval -= 1;
            temps += 1;
            txt_timer.Text = Convert.ToString(timer.Interval);
            progress_barPendue.Increment(1);
            if (progress_barPendue.Value == 10)
            {
                NewPartie.compteur += 1;
                NewPartie.ChangerIMG();
                progress_barPendue.Value = 0;
                if (NewPartie.compteur == 8)
                {
                    timer.Stop();
                    DialogResult message;
                    message = MessageBox.Show("Bravo, vous avez perdu !! \r\nVous n'avez trouver le mot: " + NewPartie.motAtrouver + " En " + temps + " seconde \r\nVoulez vous faire une autre partie ??",
                              "You loose",
                               MessageBoxButtons.YesNo,
                               MessageBoxIcon.None,
                             MessageBoxDefaultButton.Button1);
                    if (message == DialogResult.Yes)
                    {
                        redemarrerPartie();
                    }
                    else
                    {
                        Application.Exit();
                    }
                }
            }
        }

        private void btn_A_click(object sender, EventArgs e)
        {

            NewPartie.Verifier((sender as Button).Text.ToString());
            NewPartie.ChangerIMG();
            (sender as Button).Enabled = false;

            if (NewPartie.zoneTxt.Text == NewPartie.motAtrouver)
            {
                timer.Stop();
                DialogResult msg;
                msg = MessageBox.Show("Bravo, vous avez gagné !! \r\nVous avez trouver le mot: " + NewPartie.motAtrouver + " En " + temps + " seconde \r\nVoulez vous faire une autre partie ??",
                           "You win",
                           MessageBoxButtons.YesNo,
                           MessageBoxIcon.None,
                           MessageBoxDefaultButton.Button1);

                if (msg == DialogResult.Yes)
                {
                    redemarrerPartie();
                }
                else
                {
                    Application.Exit();
                }
            }

            if (NewPartie.compteur == 8)
            {
                timer.Stop();
                DialogResult message;
                message = MessageBox.Show("Bravo, vous avez perdu !! \r\nVous n'avez trouver le mot: " + NewPartie.motAtrouver + " En " + temps + " seconde \r\nVoulez vous faire une autre partie ??",
                           "You loose",
                           MessageBoxButtons.YesNo,
                           MessageBoxIcon.None,
                           MessageBoxDefaultButton.Button1);
                if (message == DialogResult.Yes)
                {
                    redemarrerPartie();
                }
                else
                {
                    Application.Exit();
  
                }
            }
        }

        public void redemarrerPartie()
        {
            progress_barPendue.Value = 0;
            timer.Interval = 1000;
            temps = 0;
            NewPartie.compteur = 0;
            NewPartie.imagePendue.Image = Properties.Resources.C1;
            NewPartie.motAtrouver = "";
            NewPartie.motAfficher = "";
            NewPartie.GenererMotAtrouver();
            NewPartie.GenererMotAfficher(NewPartie.motAtrouver);
            NewPartie.zoneTxt.Text = NewPartie.motAfficher;
            timer.Start();
            buttonA.Enabled = true;
            buttonB.Enabled = true;
            buttonC.Enabled = true;
            buttonD.Enabled = true;
            buttonE.Enabled = true;
            buttonF.Enabled = true;
            buttonG.Enabled = true;
            buttonH.Enabled = true;
            buttonI.Enabled = true;
            buttonJ.Enabled = true;
            buttonK.Enabled = true;
            buttonL.Enabled = true;
            buttonM.Enabled = true;
            buttonN.Enabled = true;
            buttonO.Enabled = true;
            buttonP.Enabled = true;
            buttonQ.Enabled = true;
            buttonR.Enabled = true;
            buttonS.Enabled = true;
            buttonT.Enabled = true;
            buttonU.Enabled = true;
            buttonV.Enabled = true;
            buttonW.Enabled = true;
            buttonX.Enabled = true;
            buttonY.Enabled = true;
            buttonZ.Enabled = true;
        }

        private void ButtonFermer_Click(object sender, EventArgs e)
        {
            SousFormulaire SF = new SousFormulaire((System.Windows.Forms.Application.OpenForms["Menu"] as Menu).Pan_SubForm);
            SF.OpenChildForm(new Form1());
            timer.Stop();
            this.Close();
        }

        private void Txt_motPendue_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void Txt_difficulte_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
