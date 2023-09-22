using System;
using System.Collections.Generic;
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
