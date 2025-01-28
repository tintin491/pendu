using System;
using System.Windows.Forms;
using PremierProgramme.Controllers;

namespace PremierProgramme.Modele
{
    class SousFormulaire
    {
        public Panel PanelSousFormlaire;
        public Form activeForm = null;
        public SousFormulaire(Panel panelenvoit)
        {
            PanelSousFormlaire = panelenvoit;
        }

        #region Creation formulaire pour le menu 
        public void OpenChildForm(Form formEnfant)
        {
            activeForm?.Close();

            activeForm = formEnfant;
            formEnfant.TopLevel = false;
            formEnfant.FormBorderStyle = FormBorderStyle.None;
            formEnfant.Dock = DockStyle.Fill;
            PanelSousFormlaire.Controls.Add(formEnfant);
            PanelSousFormlaire.Tag = formEnfant;
            formEnfant.BringToFront();
            formEnfant.Show();

        }
        #endregion

        public void CacherMots(Panel PanelSousFormlaire)
        {
            PanelSousFormlaire.Visible = false; 
        }

        public void MontrerMots(Panel PanelSousFormlaire)
        {
            PanelSousFormlaire.Visible = true;
        }

    }

    class Partie
    {
        public string motAtrouver;
        public TextBox zoneTxt;
        public int compteur;
        public ProgressBar progressbar;
        public PictureBox imagePendue;
        public string motAfficher;
        public string difficulte;

        public Partie( TextBox laZoneTxt, ProgressBar laProgressbar, PictureBox image, int cpt)
        {
            motAtrouver = "";
            motAfficher = "";
            zoneTxt = laZoneTxt;
            progressbar = laProgressbar;
            imagePendue = image;
            compteur = cpt;
        }

        #region Fonction de verification de la présence de la lettre tape dans le mot
        public void Verifier(string lettretape)
        {
            progressbar.Value = 0;
            int cpt = 0;
            string mot = "";
            for (int i = 0; i <= motAtrouver.Length - 1; i++)
            {
                if (lettretape == Convert.ToString(motAtrouver[i]))
                {
                    mot += lettretape;
                    cpt++;
                }
                else
                {
                    mot += zoneTxt.Text[i];
                }
            }
            if (cpt == 0)
            {
                compteur++;
            }
            zoneTxt.Text = mot;
           
        }
        #endregion

        #region Fonction pour changer d'image
        public void ChangerIMG()
        {
            switch (compteur)
            {
                case (0):
                    imagePendue.Image = Properties.Resources.C1;
                    imagePendue.Refresh();
                    break;

                case (1):
                    imagePendue.Image = Properties.Resources.C2;
                    imagePendue.Refresh();
                    break;

                case (2):
                    imagePendue.Image = Properties.Resources.C3;
                    imagePendue.Refresh();
                    break;

                case (3):
                    imagePendue.Image = Properties.Resources.C4;
                    imagePendue.Refresh();
                    break;

                case (4):
                    imagePendue.Image = Properties.Resources.C5;
                    imagePendue.Refresh();
                    break;

                case (5):
                    imagePendue.Image = Properties.Resources.C6;
                    imagePendue.Refresh();
                    break;

                case (6):
                    imagePendue.Image = Properties.Resources.C7;
                    imagePendue.Refresh();
                    break;

                case (7):
                    imagePendue.Image = Properties.Resources.C8;
                    imagePendue.Refresh();
                    break;

                case (8):
                    imagePendue.Image = Properties.Resources.C9;
                    imagePendue.Refresh();
                    break;
            }
        }
        #endregion

        #region Fonction pour generer le mot a trouver
        public void GenererMotAtrouver()
        {
            Mots liste  = new Mots();
            var listeMotaTrouver = liste.MotAtrouver(difficulte); 
            Random aleatoire = new Random();
            motAtrouver  = listeMotaTrouver[aleatoire.Next(listeMotaTrouver.Count)].ToUpper();
        }
        #endregion

        #region Fonction por generer le mot a afficher
        public void GenererMotAfficher(string motAtrouver)
        {
            for (int i = 0; i <= motAtrouver.Length - 1; i++)
            {
               motAfficher += "_";
            }
        }
        #endregion
    }
}
