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
    public partial class FrmAjoutPersonne : Form
    {
        private Personne personne;
        private Agence agence;

        public FrmAjoutPersonne(Agence agence)
        {
            InitializeComponent();
            this.agence = agence;
            personne = new Personne(); 
        }

        public void LoadPersonne()
        {
            try
            {
                if (txt_nom.Text == "" || txt_prenom.Text == "" || txt_ville.Text == "")
                {
                    MessageBox.Show("Veuillez remplir tous les champs.");
                }
                else
                {
                    personne.Nom = txt_nom.Text;
                    personne.Prenom = txt_prenom.Text;
                    personne.Ville = txt_ville.Text;

                    agence.AjouterPersonne(personne);
                    Close();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

        }



        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmAjoutPersonne_Load(object sender, EventArgs e)
        {

        }

        private void btn_ajouter_Click(object sender, EventArgs e)
        {
            LoadPersonne();
        }




    }
}
