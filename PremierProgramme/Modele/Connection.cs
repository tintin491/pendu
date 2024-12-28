using MySql.Data.MySqlClient;

namespace PremierProgramme.Modele
{

    class Connection
    {
        private MySqlConnection connection;
        public MySqlConnection Laconnection
        {
            get { return connection; }
            set { connection = value; }
        }
        private string server;
        private string uid;
        private string database;
        private string password;

        public Connection()
        {
            server = "";
            uid = "";
            database = "";
            password = "";
            Initialise();
        }

        #region Initialisation de la connection
        private void Initialise()
        {
            server = "localhost";
            database = "bdd_pendue_qk";
            uid = "root";
            password = "";
            string connectionString;
            connectionString = "SERVER=" + server + ";" + "DATABASE=" +
            database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";

            connection = new MySqlConnection(connectionString);
        }
        #endregion
    }
}
