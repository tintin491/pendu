using PremierProgramme.Modele;
using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace PremierProgramme.Controllers
{
    class AjoutBddModif
    {
        private int cpt = 0;
        public int Cpt
        {
            get { return cpt; }
            set { cpt = value; }
        }
        public DataGridView RechargerDvg(DataGridView dgv, TextBox mot, ComboBox diff)
        {
            try
            {
                Mots dt_mot = new Mots();
                DataView dv = new DataView(dt_mot.GetListeMots());
                dgv.DataSource = dv;
                //cacher les champs à cacher et remettre la taille des colonnes
                dgv.Columns["IDMOTS"].Visible = false;

                //Gérer la largeur des colonnes
                dgv.Columns["mot"].Width = 190;
                dgv.Columns["difficulte"].Width = 83;
                //remettre à 0 les champs de recherche
                mot.Text = "";
                diff.SelectedIndex = -1;
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
            return dgv;
        }

        public void AjouterModif(string id, string mot, string diff)
        {
            if (cpt == 0)
            {
                if (mot == "" & diff == "-1" & diff == "")
                {
                    MessageBox.Show("Le mot de passe ou le nom de l'utilisateur ne doivent pas être bon", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    try
                    {
                        Connection conn = new Connection();
                        string motAjouter = mot.ToUpper();
                        using (MySqlCommand cmd = new MySqlCommand("INSERT INTO `mots` (`IDMOTS`, `LABELMOTS`, `IDDIFFICULTE`) VALUES('', '" + mot + "','" + diff + "' );", conn.Laconnection))
                        {
                            conn.Laconnection.Open();
                            MySqlDataReader reader = cmd.ExecuteReader();
                            cpt = 0;
                        }
                    }
                    catch (Exception e)
                    {
                        MessageBox.Show(e.ToString(), "Erreur 3", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                    }
                }
            }
            else if (cpt == 1)
            {
                try
                {
                    Connection conn = new Connection();
                    using (MySqlCommand cmd = new MySqlCommand("UPDATE mots SET LABELMOTS = '" + mot + "', IDDIFFICULTE = '" + diff + "' WHERE IDMOTS = '" + id + "';", conn.Laconnection))
                    {
                        conn.Laconnection.Open();
                        MySqlDataReader reader = cmd.ExecuteReader();
                        cpt = 0;
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString(), "Erreur 3", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                }
            }
            else
            {
                try
                {
                    Connection conn = new Connection();
                    string motAjouter = mot.ToUpper();
                    using (MySqlCommand cmd = new MySqlCommand("Delete from mots where LABELMOTS = '" + mot + "' and IDDIFFICULTE = '" + diff + "' and IDMOTS = '" + id + "'", conn.Laconnection))
                    {
                        conn.Laconnection.Open();
                        MySqlDataReader reader = cmd.ExecuteReader();
                        cpt = 0;
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString(), "Erreur 3", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                }
            }
        }

        public Boolean GetIfMotInBdd(string mot, string diff)
        {
            Boolean result = false;
            try
            {
                Connection conn = new Connection();
                DataTable dtListeMots = new DataTable();

                string motAjouter = mot.ToUpper();
                using (MySqlCommand cmd = new MySqlCommand("Select IDMOTS from mots where LABELMOTS = '"+mot+"' and IDDIFFICULTE = '"+diff+"'" , conn.Laconnection))
                {
                    conn.Laconnection.Open();
                    MySqlDataReader reader = cmd.ExecuteReader();
                    dtListeMots.Load(reader);

                    if (dtListeMots.Rows.Count == 0)
                        result = true;
                    else
                        result = false;
                    return result;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "Erreur 3", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
            }
            return result;
        }
    }
}
