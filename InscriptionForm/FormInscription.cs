
using ClassOccasAuto;
using MySql.Data.MySqlClient;
using OccasAuto;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace InscriptionForm
{
    public partial class FormInscription : Form
    {
        public FormInscription()
        {
            InitializeComponent();

        }


        public void Writing(string identifiant, string password)
        {
            MySqlConnection cnx = new MySqlConnection();
            cnx.ConnectionString = "SERVER=localhost;DATABASE=bdoccasauto;UID=root;";
            cnx.Open();
            string request = $"INSERT INTO utilisateur VALUES (@id, @identifiant, @password)";
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = cnx;
            cmd.CommandText = request;
            cmd.Parameters.Add("@identifiant", MySqlDbType.String);
            cmd.Parameters.Add("@password", MySqlDbType.String);
            cmd.Parameters.Add("@id", MySqlDbType.Int32);
            cmd.Parameters["@identifiant"].Value = identifiant;
            cmd.Parameters["@password"].Value = password;
            cmd.Parameters["@id"].Value = null;
            MySqlDataReader reader = cmd.ExecuteReader();
            cnx.Close();
        }

        private void InscriptionSubmit_Click(object sender, EventArgs e)
        {
            if(idTextBoxInscr.Text != "" && passwordTextBoxInscr.Text != "" && idTextBoxInscr.Text != null  && passwordTextBoxInscr.Text != null && !string.IsNullOrWhiteSpace(idTextBoxInscr.Text) && !string.IsNullOrWhiteSpace(passwordTextBoxInscr.Text))
            {
                Writing(idTextBoxInscr.Text, passwordTextBoxInscr.Text);
                acceptLabel.Visible = true;
                refuseLabel.Visible = false;
            }
            else
            {
                acceptLabel.Visible = false;
                refuseLabel.Visible = true;
            }
        }

        private void idTextBoxInscr_TextChanged(object sender, EventArgs e)
        {

        }

        private void passwordTextBoxInscr_TextChanged(object sender, EventArgs e)
        {

        }

        

        private void minBox_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void clsBox_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void hideLab_Click(object sender, EventArgs e)
        {
            
                if (passwordTextBoxInscr.UseSystemPasswordChar)
                {
                    passwordTextBoxInscr.UseSystemPasswordChar = false;
                }
                else
                {
                    passwordTextBoxInscr.UseSystemPasswordChar = true;
                }


            
        }
    }
}

