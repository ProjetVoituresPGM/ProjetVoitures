using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metier
{
    class Voiture
    {

        // blabla

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
        /// <summary>
        /// Constructeur de Voiture
        /// </summary>
        /// <param name="categorie"></param>
        /// <param name="estLouee"></param>
        /// <param name="imma"></param>
        /// <param name="loueur"></param>
        /// <param name="nom"></param>
        /// <param name="puissance"></param>
        public Voiture(string categorie, bool estLouee, string imma, string loueur, string nom, double puissance)
        {
            this.categorie = categorie;
            this.estLouee = estLouee;
            this.immatriculation = imma;
            this.loueur = loueur;
            this.nom = nom;
            this.puissance = puissance;
        }

        /// <summary>
        /// surchage du constructeur
        /// </summary>
        public Voiture()
        { }



        // Méthode 



    }
}
