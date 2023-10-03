using ClassOccasAuto;
using InscriptionForm;
using OccasAuto;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Co_n
{
    public partial class FormConnexion : Form
    {

        public FormConnexion()
        {
            InitializeComponent();
        }

        private void Connect()
        {
            List<Connexion> LesConnexions = Connexion.Load();
            foreach (Connexion uneConnexion in LesConnexions)
            {
                
                if (uneConnexion.Identifiant == idTextBox.Text && uneConnexion.Password == passwordTextBox.Text)
                {
                    Submit formSubmit = new Submit();
                    formSubmit.ShowDialog();                   
                }

            }

        }

        private void Inscript()
        {
            FormInscription formInscript = new FormInscription();
            formInscript.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }



        private void subscriptionSubmit_Click(object sender, EventArgs e)
        {
            Connect();
        }

        private void hideLabel_Click(object sender, EventArgs e)
        {
            if (passwordTextBox.UseSystemPasswordChar)
            {
                passwordTextBox.UseSystemPasswordChar = false;
            }
            else
            {
                passwordTextBox.UseSystemPasswordChar = true;
            }


        }

        private void subscription_Click(object sender, EventArgs e)
        {
            Inscript();
        }

        private void closeBox_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void minimBox_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
