using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using PremierProgramme.Modele;

namespace PremierProgramme.Controllers
{
    class Mots
    {
        DataTable dtListeMots;

        #region Recuperation liste de mots
        public DataTable GetListeMots()
        {
            //Instencier l’objet dtListeMots de type DataTable
            dtListeMots = new DataTable();

            //Instencier l’objet conn de type Connection
            Connection conn = new Connection();

            try
            {
                using (MySqlCommand cmd = new MySqlCommand("Select IDMOTS, LABELMOTS as mot, LABELDIFFICULTE as difficulte FROM mots INNER JOIN difficulte ON mots.IDDIFFICULTE = difficulte.IDDIFFICULTE;", conn.Laconnection))
                {
                    conn.Laconnection.Open();
                    MySqlDataReader reader = cmd.ExecuteReader();
                    dtListeMots.Load(reader);

                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "Erreur 3", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
            }
            return dtListeMots;
        }
        #endregion

        #region Tri de l'affichage
        public DataTable GetListeMotsdifficult(string mot, string diff)
        {

            if (mot != "" | diff != "0")
            {
                if ((diff == "0") | (diff =="-1"))
                {
                    string rqtSql = "";
                    rqtSql += "Select LABELMOTS as mot, LABELDIFFICULTE as difficulte FROM mots INNER JOIN difficulte ON mots.IDDIFFICULTE = difficulte.IDDIFFICULTE  where LABELMOTS Like'%" + mot + "%'";
                    dtListeMots = new DataTable();

                    try
                    {
                        Connection conn = new Connection();
                        using (MySqlCommand cmd = new MySqlCommand(rqtSql, conn.Laconnection))
                        {
                            conn.Laconnection.Open();
                            MySqlDataReader reader = cmd.ExecuteReader();
                            dtListeMots.Load(reader);
                        }
                    }
                    catch (Exception e)
                    {
                        MessageBox.Show(e.ToString(), "Erreur 3", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                    }
                    return dtListeMots;
                }
                else
                {
                    string rqtSql = "";
                    rqtSql += "Select LABELMOTS as mot, LABELDIFFICULTE as difficulte FROM mots INNER JOIN difficulte ON mots.IDDIFFICULTE = difficulte.IDDIFFICULTE  where LABELMOTS Like'%" + mot + "%' AND difficulte.IDDIFFICULTE Like'%" + diff + "%';";
                    DataTable dtListeMots = new DataTable();

                    try
                    {
                        Connection conn = new Connection();
                        using (MySqlCommand cmd = new MySqlCommand(rqtSql, conn.Laconnection))
                        {
                            conn.Laconnection.Open();
                            MySqlDataReader reader = cmd.ExecuteReader();
                            dtListeMots.Load(reader);
                        }
                    }
                    catch (Exception e)
                    {
                        MessageBox.Show(e.ToString(), "Erreur 3", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                    }
                    return dtListeMots;
                }
            }
            return GetListeMots();
        }
        #endregion

        #region Recuperation liste most en fonction d'une difficulte
        public List<string> MotAtrouver( string diff)
        { 
            List<String> ListeDeMotatrouver = new List<string>();
            string rqtSql = "";
            rqtSql += "Select LABELMOTS as mot, LABELDIFFICULTE as difficulte FROM mots INNER JOIN difficulte ON mots.IDDIFFICULTE = difficulte.IDDIFFICULTE  where labeldifficulte = '"+ diff + "';";
            DataTable dtListeMots = new DataTable();

            try
            {
                Connection conn = new Connection();
                using (MySqlCommand cmd = new MySqlCommand(rqtSql, conn.Laconnection))
                {
                    conn.Laconnection.Open();
                    MySqlDataReader reader = cmd.ExecuteReader();
                    dtListeMots.Load(reader);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "Erreur 3", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
            }

            foreach (DataRow row in dtListeMots.Rows)
            {
                ListeDeMotatrouver.Add(row["mot"].ToString());
            }

            return ListeDeMotatrouver;
        }
        #endregion
    }
}
