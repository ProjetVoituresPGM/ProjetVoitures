using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Metier;

namespace Metier
{
    //agence cool caro
    public class Agence
    {
        /// <summary>
        /// Propriétés
        /// </summary>
        private string nom;
        private string ParcVoitures;
        private List<Personne> lesPersonnes;


        /// <summary>
        /// Getters & Setters
        /// </summary>
        public string Nom
        {
            get { return nom; }
            set { nom = value; }
        }

        public string ParcVoitures1
        {
            get { return ParcVoitures; }
            set { ParcVoitures = value; }
        }

        internal List<Personne> LesPersonnes
        {
            get { return lesPersonnes; }
            set { lesPersonnes = value; }
        }

        public Agence()
        {

        }


    }
}
