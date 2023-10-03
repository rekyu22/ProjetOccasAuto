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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void listViewAuto_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Submit_Load(object sender, EventArgs e)
        {

        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

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
    }
}
