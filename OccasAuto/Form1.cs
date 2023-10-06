using ClassOccasAuto;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;

namespace OccasAuto
{
    public partial class Submit : Form
    {

        public Submit()
        {
            InitializeComponent();
            PrintConces("","");
            comboBox1.Text = "Ville";
            updCbBox.Text = "nom";
        }

        private void PrintConces(string select, string cond)
        {
            List<Concessionaire> LesCons = Concessionaire.Rechercher(select, cond);
            listViewAuto.Items.Clear();
            foreach (Concessionaire unConces in LesCons)
            {   
                
                string[] str = { unConces.IdConces.ToString(), unConces.Nom, unConces.Prenom, unConces.Adresse, unConces.CodePostal, unConces.Ville };
                var sd = new ListViewItem(str);
                listViewAuto.Items.Add(sd);
            }
            
        }

        private void DeleteRow(int rowIndex)
        {
            MySqlConnection cnx = new MySqlConnection();
            cnx.ConnectionString = "SERVER=localhost;DATABASE=bdoccasauto;UID=root;";
            cnx.Open();
            string request = $"DELETE FROM concessionaire WHERE idConces = @id";
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = cnx;
            cmd.CommandText = request;
            cmd.Parameters.Add("@id", MySqlDbType.Int32);
            cmd.Parameters["@id"].Value = rowIndex;
            MySqlDataReader reader = cmd.ExecuteReader();
            cnx.Close();
        }

        private void InsertRow(string surname, string name, string adresse, string cp, string city)
        {
            MySqlConnection cnx = new MySqlConnection();
            cnx.ConnectionString = "SERVER=localhost;DATABASE=bdoccasauto;UID=root;";
            cnx.Open();
            string request = $"INSERT INTO concessionaire VALUES (@id, @nom, @prenom, @adresse, @codePostal, @ville)";
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = cnx;
            cmd.CommandText = request;
            cmd.Parameters.Add("@id", MySqlDbType.Int32);
            cmd.Parameters["@id"].Value = null;
            cmd.Parameters.Add("@nom", MySqlDbType.String);
            cmd.Parameters["@nom"].Value = surname;
            cmd.Parameters.Add("@prenom", MySqlDbType.String);
            cmd.Parameters["@prenom"].Value = name;
            cmd.Parameters.Add("@adresse", MySqlDbType.String);
            cmd.Parameters["@adresse"].Value = adresse;
            cmd.Parameters.Add("@codePostal", MySqlDbType.String);
            cmd.Parameters["@codePostal"].Value = cp;
            cmd.Parameters.Add("@ville", MySqlDbType.String);
            cmd.Parameters["@ville"].Value = city;
            MySqlDataReader reader = cmd.ExecuteReader();
            cnx.Close();
        }

        private void UpdtRow(string id, string selection, string parameter)
        {
            MySqlConnection cnx = new MySqlConnection();
            cnx.ConnectionString = "SERVER=localhost;DATABASE=bdoccasauto;UID=root;";
            cnx.Open();
            string request = $"UPDATE concessionaire ";
            if (parameter != null || parameter == "")
            {
                if (selection == "Ville") request += $"SET ville = '{parameter}' WHERE idConces = {id}";
                else if (selection == "Nom") request += $"SET nom = '{parameter}' WHERE idConces = {id}";
                else if (selection == "Prenom") request += $"SET prenom = '{parameter}' WHERE idConces =  {id}";
                else if (selection == "Adresse") request += $"SET adresse = '{parameter}' WHERE idConces = {id}";
                else if (selection == "Code postal") request += $"SET codePostal = '{parameter}' WHERE idConces =  {id}";
            }
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = cnx;
            cmd.CommandText = request;
            MySqlDataReader reader = cmd.ExecuteReader();
            cnx.Close();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            PrintConces(comboBox1.Text, textBox1.Text);
        }

        private void closBox_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void minimizeBox_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void listViewAuto_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            // Vérifiez si un élément est sélectionné
            
                // Obtenez l'index de l'élément sélectionné
                int index = e.ItemIndex + 1;

            // Utilisez l'index comme vous le souhaitez
                
            DialogResult result = MessageBox.Show($"Voulez vous vraiment supprimer ce concessionnaire ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            
            if (result == DialogResult.Yes)
            {
                DeleteRow(index);
            }
            else
            {
                this.Close();
            }

        }

        private void dltBtn_Click(object sender, EventArgs e)
        {
            string str = idTB.Text;
            int result = Convert.ToInt32(str);
            DeleteRow(result);
            listViewAuto.Items.Clear();
            PrintConces("", "");
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            InsertRow(surnameTB.Text, nameTB.Text, adrTB.Text, cpTB.Text, cityTB.Text);
            listViewAuto.Items.Clear();
            PrintConces("", "");
        }

        private void updtBtn_Click(object sender, EventArgs e)
        {
            UpdtRow(updtIdTb.Text, updCbBox.Text, updtTB.Text);
            listViewAuto.Items.Clear();
            PrintConces("", "");
        }
    }
}
