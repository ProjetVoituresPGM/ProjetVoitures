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
    public partial class FrmAccueil : Form
    {
        private Personne unePersonne;
        private Voiture uneVoiture;
        

        public FrmAccueil()
        {
            InitializeComponent();
        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ajouterUnePersonneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            unePersonne = new Personne();
            FrmAjoutPersonne unAjoutPersonne = new FrmAjoutPersonne();
            unAjoutPersonne.Show();

        }

        private void louerUneVoitureToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
            FrmLouerVoiture uneLocationVoiture = new FrmLouerVoiture();
            uneLocationVoiture.Show();
        }

        private void rendreUneVoitureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmRendreUneVoiture unRetourVoiture = new FrmRendreUneVoiture();
            unRetourVoiture.Show();
        }

        private void toutesLesVoituresToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            FrmConsulterVoitures unAffichDesVoitures = new FrmConsulterVoitures();
            unAffichDesVoitures.Show();
        }

        private void ajouterUneVoitureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            uneVoiture = new Voiture();
            FrmAjoutVoiture unAjoutVoiture = new FrmAjoutVoiture();
            unAjoutVoiture.Show();
        }

        private void supprimerUneVoitureToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            FrmSuppVoiture SuppVoiture = new FrmSuppVoiture();
            SuppVoiture.Show();

        }

        private void supprimerUnePersonneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmSuppPersonne SupprimerUnePersonne = new FrmSuppPersonne();
            SupprimerUnePersonne.Show();
        }

        private void toutesLesPersonnesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmConsulterPersonnes unAffichageDesPersonnes = new FrmConsulterPersonnes();
            unAffichageDesPersonnes.Show();

        }
    }
}
