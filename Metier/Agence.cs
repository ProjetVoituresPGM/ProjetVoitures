using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using System.Runtime.Serialization;
using System.Threading.Tasks;
using Metier;

namespace Metier
{
    /// <summary>
    /// Classe Agence
    /// </summary>
    [DataContract]
    [Serializable]
    [XmlRoot("Agence", Namespace = "", IsNullable = false)]
    public class Agence
    {
        #region Attributs
        private string nom;
        private List<Voiture> lesVoitures;
        private List<Personne> lesPersonnes;
        #endregion

        #region Getters And Setters
        [DataMember]
        [XmlElement("Nom")]
        public string Nom
        {
            get { return nom; }
            set { nom = value; }
        }
        [DataMember]
        [XmlArray("ParcVoiture")]
        [XmlArrayItem("Voiture", typeof(Voiture))]
        public List<Voiture> LesVoitures
        {
            get { return lesVoitures; }
            set { lesVoitures = value; }
        }
        [DataMember]
        [XmlArray("LesPersonnes")]
        [XmlArrayItem("Personne", typeof(Personne))]
        public List<Personne> LesPersonnes
        {
            get { return lesPersonnes; }
            set { lesPersonnes = value; }
        }
        #endregion

        #region Constructeurs
        /// <summary>
        /// Constructeur Agence
        /// </summary>
        /// <param name="nom">Le nom de l'agence</param>
        public Agence(string nom)
        {
            this.nom = nom;
            lesVoitures = new List<Voiture>();
            lesPersonnes = new List<Personne>();
        }
        /// <summary>
        /// Constructeur par défaut
        /// </summary>
        public Agence()
        //     : this("Nom par default")
        {
        }
        #endregion

        #region Méthodes


        /// Ajoute une voiture à l'agence
        /// <param name="voiture">La voiture</param>
        public void AjouterVoiture(Voiture voiture)
        {
            lesVoitures.Add(voiture);
        }



        /// Supprime une voiture à l'agence
        /// <param name="voiture">La voiture</param>
        public void SupprimerVoiture(Voiture voiture)
        {
            lesVoitures.Remove(voiture);
        }



        /// Ajoute une personne à l'agence
        /// <param name="personne">La personne</param>
        public void AjouterPersonne(Personne personne)
        {
            lesPersonnes.Add(personne);
        }



        /// Supprime une personne à l'agence
        /// <param name="personne">La personne</param>
        public void SupprimerPersonne(Personne personne)
        {
            lesPersonnes.Remove(personne);
        }



        /// Loue une voiture
        /// <param name="voiture">La voiture à louée</param>
        /// <param name="personne">La personne qui loue la voiture</param>    
        public void LouerVoiture(Voiture voiture, Personne personne)
        {
            voiture.Loueur = personne;
            voiture.EstLouee = true;
        }



        /// Rend une voiture
        /// <param name="voiture">La voiture rendue</param>
        public void RendreVoiture(Voiture voiture)
        {
            voiture.Loueur = null;
            voiture.EstLouee = false;
        }
        #endregion

    }
}
