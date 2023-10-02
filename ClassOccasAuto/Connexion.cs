using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using MySql.Data.MySqlClient;

namespace ClassOccasAuto
{
    public class Connexion
    {
        private string identifiant;
        private string password;

        public Connexion(string identifiant, string password)
        {
            this.Identifiant = identifiant;
            this.Password = password;
        }

        public string Identifiant { get => identifiant; set => identifiant = value; }
        public string Password { get => password; set => password = value; }

        public static List<Connexion> Load()
        {

            MySqlConnection cnx = new MySqlConnection();
            cnx.ConnectionString = "SERVER=localhost;DATABASE=bdoccasauto;UID=root;";
            cnx.Open();
            string request = $"SELECT identifiant, password FROM utilisateur ";
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = cnx;
            cmd.CommandText = request;
            MySqlDataReader reader = cmd.ExecuteReader();
            List<Connexion> lesConnections = new List<Connexion>();
            while (reader.Read())
            {
                lesConnections.Add(new Connexion(reader["identifiant"].ToString(), reader["password"].ToString()));
            }

            cnx.Close();
            reader.Close();
            return lesConnections;
        }
    }
}
