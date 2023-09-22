using ClassOccasAuto;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace OccasAuto
{
    public partial class Submit : Form
    {

        List<Concessionaire> LesConces = new List<Concessionaire>();


        public Submit()
        {
            InitializeComponent();
            PrintConces();
        }

        public void PrintConces()
        {
            MySqlConnection cnx = new MySqlConnection();
            cnx.ConnectionString = "SERVER=localhost;DATABASE=bdoccasauto;UID=root;";
            cnx.Open();
            string request = "SELECT idConces, nom, prenom, adresse, codePostal, ville FROM concessionaire;";
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = cnx;
            cmd.CommandText = request;
            //cmd.Parameters.Add("@ville", MySqlDbType.String);
            //cmd.Parameters["@ville"].Value = "RIOM";
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {

                Concessionaire unConces = new Concessionaire((int)reader["idConces"], reader["nom"].ToString(), reader["prenom"].ToString(), reader["adresse"].ToString(), reader["codePostal"].ToString(), reader["ville"].ToString());
                LesConces.Add(unConces);

                var list = new ListViewItem();
                list.SubItems.Add(unConces.IdConces.ToString());
                list.SubItems.Add(unConces.Nom);
                list.SubItems.Add(unConces.Prenom);
                list.SubItems.Add(unConces.Adresse);
                list.SubItems.Add(unConces.CodePostal);
                list.SubItems.Add(unConces.Ville);
                listViewAuto.Items.Add(list);
            }


            
            cnx.Close();
            reader.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void listViewAuto_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Submit_Load(object sender, EventArgs e)
        {

        }
    }
}
