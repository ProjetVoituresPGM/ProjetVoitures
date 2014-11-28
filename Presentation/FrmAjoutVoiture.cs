using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Metier;

namespace Presentation
{
    public partial class FrmAjoutVoiture : Form
    {

        private Voiture uneVoiture;
        private Agence uneAgence;

        public Voiture UneVoiture
        {
            get { return uneVoiture; }
            set { uneVoiture = value; }
        }

        public Agence UneAgence
        {
            get { return uneAgence; }
            set { uneAgence = value; }
        }


        public FrmAjoutVoiture(Agence uneAgence)
        {
            InitializeComponent();
            this.uneAgence = uneAgence;
            Voiture uneVoiture = new Voiture();
        }

       

        private void btn_fermer_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_ajouter_Click(object sender, EventArgs e)
        {
            AjouterUneVoiture();
        }

        public void AjouterUneVoiture()
        {


            if (tbx_nomVoiture.Text == "" || tbx_categorieVoiture.Text == ""
                || tbx_dateMiseServiceVoiture.Text == ""
                || tbx_ImmatriculationVoiture.Text == "" || tbx_puissanceVoiture.Text == "")
            {
                MessageBox.Show("Vous avez commis une erreur !! ");
            }
            else
            {
                uneVoiture.Categorie = tbx_categorieVoiture.Text;
                uneVoiture.DateMiseEnService = Convert.ToDateTime(tbx_dateMiseServiceVoiture.Text);
                uneVoiture.Immatriculation = tbx_ImmatriculationVoiture.Text;
                uneVoiture.Nom = tbx_nomVoiture.Text;
                uneVoiture.Puissance = Convert.ToInt32(tbx_puissanceVoiture.Text);

                this.uneAgence.AjouterVoiture(uneVoiture);
                this.Close();
            }

        }
    }
}

