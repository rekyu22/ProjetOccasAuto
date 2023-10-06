using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ClassOccasAuto
{
    public class Concessionaire
    {
        private int idConces;
        private string nom;
        private string prenom;
        private string adresse;
        private string codePostal;
        private string ville;

        public static List<Concessionaire> Rechercher(string selection, string condition)
        {
            MySqlConnection cnx = new MySqlConnection();
            cnx.ConnectionString = "SERVER=localhost;DATABASE=bdoccasauto;UID=root;";
            cnx.Open();
            string request = $"SELECT idConces, nom, prenom, adresse, codePostal, ville FROM concessionaire ";

            if (condition != null || condition == "") {
                if (selection == "Ville")request += $"WHERE ville LIKE '%{condition}%'";
                else if(selection == "Nom")request += $"WHERE nom LIKE '%{condition}%'";
                else if (selection == "Code postal")request += $"WHERE codePostal LIKE '%{condition}%'";
            }       

            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = cnx;
            cmd.CommandText = request;
            //cmd.Parameters.Add("@condition", MySqlDbType.String);
            //cmd.Parameters["@condition"].Value = selection;
            //cmd.Parameters.Add("@content", MySqlDbType.String);
            //cmd.Parameters["@content"].Value = condition;
            MySqlDataReader reader = cmd.ExecuteReader();
            List<Concessionaire> lesConcess = new List<Concessionaire>();
            while (reader.Read())
            {
            
                lesConcess.Add(new Concessionaire((int)reader["idConces"], reader["nom"].ToString(), reader["prenom"].ToString(), reader["adresse"].ToString(), reader["codePostal"].ToString(), reader["ville"].ToString()));
                
                

            }
            cnx.Close();
            reader.Close();
            return lesConcess;

        }



        public Concessionaire(int idConces, string nom, string prenom, string adresse, string codePostal, string ville)
        {
            IdConces = idConces;
            Nom = nom;
            Prenom = prenom;
            Adresse = adresse;
            CodePostal = codePostal;
            Ville = ville;
        }

       

        public int IdConces { get => idConces; set => idConces = value; }
        public string Nom { get => nom; set => nom = value; }
        public string Prenom { get => prenom; set => prenom = value; }
        public string Adresse { get => adresse; set => adresse = value; }
        public string CodePostal { get => codePostal; set => codePostal = value; }
        public string Ville { get => ville; set => ville = value; }
    }
}
