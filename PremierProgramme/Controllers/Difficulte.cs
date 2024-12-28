using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using PremierProgramme.Modele;

namespace PremierProgramme.Controllers
{
    class Difficulte
    {
        # region Récupération des difficultés
        public DataTable GetListeDifficulte()
        {
            //Instencier l’objet dtListeMots de type DataTable
            DataTable dtListeDiff = new DataTable();

            //Instencier l’objet conn de type Connection
            Connection conn = new Connection();

            try
            {
                using (MySqlCommand cmd = new MySqlCommand("Select IDDIFFICULTE, LABELDIFFICULTE as difficulte FROM difficulte", conn.Laconnection))
                {
                    conn.Laconnection.Open();
                    MySqlDataReader reader = cmd.ExecuteReader();
                    dtListeDiff.Load(reader);

                    DataRow workRow = dtListeDiff.NewRow();
                    workRow[0] = -1;
                    workRow[1] = "";
                    dtListeDiff.Rows.InsertAt(workRow, 0);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "Erreur 3", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
            }
            return dtListeDiff;
        }
        #endregion
    }
}
