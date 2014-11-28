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
    public partial class FrmSuppVoiture : Form
    {

        private Agence uneAgence;
        private List<Voiture> voitures = new List<Voiture>();
        public FrmSuppVoiture(Agence uneAgence)
        {
            InitializeComponent();
            this.uneAgence = uneAgence;
        }

        private void btnFermer_Click(object sender, EventArgs e)
        {
            Close(); 
        }

        private void btnSupp_Click(object sender, EventArgs e)
        {
            SupprimerUneVoiture();
        }

        public void SupprimerUneVoiture()
        {
            foreach (Voiture voiture in this.voitures)
            {
                //Try permettant de tester si la suppression d'un véhicule de l'agence est possible


                if (cbx_Voiture.SelectedItem.ToString() == voiture.Nom + " - " + voiture.Immatriculation)
                    {
                        uneAgence.SupprimerVoiture(voiture);
                        //MessageBox.Show("La " + voiture.Nom + " ayant l'immatriculation " + voiture.Immatriculation + " a été supprimée de l'agence");
                        AfficherVoiture();
                        break;
                    }
                }
            
            }
        public void AfficherVoiture()
        {
            cbx_Voiture.Items.Clear();
            voitures = uneAgence.LesVoitures();
            foreach (Voiture voiture in voitures)
            {
                cbx_Voiture.Items.Add(voiture.Nom + " - " + voiture.Immatriculation);
            }
            if (voitures.Count == 0)
                Close();
            else
            {
                cbx_Voiture.SelectedIndex = 0;
            }
        }

        }


    }

