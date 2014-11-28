using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metier
{

    [Serializable]
    public class Personne
    {

        /// Propriétés
        private string nom;
        private string prenom;
        private string ville;



        /// Getters & Setters
        public string Nom
        {
            get { return nom; }
            set { nom = value; }
        }
        public string Prenom
        {
            get { return prenom; }
            set { prenom = value; }
        }
        public string Ville
        {
            get { return ville; }
            set { ville = value; }
        }

        /// <summary>
        /// constructeur de personne
        /// </summary>
        /// <param name="nom"></param>
        /// <param name="prenom"></param>
        /// <param name="ville"></param>
        public Personne(string nom, string prenom, string ville)
        {
            this.nom = nom;
            this.prenom = prenom;
            this.ville = ville;
        }


        /// <summary>
        /// surcharge du constructeur
        /// </summary>
        public Personne()
        { }

       
    }
}
