using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metier
{
    class Voiture
    {

        private string categorie;
        private bool estLouee;
        private string immatriculation;
        //private date dateMiseEnService;
        private string loueur;
        private int puissance;
        private string nom;


        public string Categorie
        {
            get { return categorie; }
            set { categorie = value; }
        }
        public bool EstLouee
        {
            get { return estLouee; }
            set { estLouee = value; }
        }
        public string Immatriculation
        {
            get { return immatriculation; }
            set { immatriculation = value; }
        }
        public string Loueur
        {
            get { return loueur; }
            set { loueur = value; }
        }
        public string Nom
        {
            get { return nom; }
            set { nom = value; }
        }
        public int Puissance
        {
            get { return puissance; }
            set { puissance = value; }
        }




    }
}
