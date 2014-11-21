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
using Utilitaire;

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
            uneVoiture = new Voiture();
            FrmLouerVoiture uneLocationVoiture = new FrmLouerVoiture();
            uneLocationVoiture.Show();
        }

        private void rendreUneVoitureToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void toutesLesVoituresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            uneVoiture = new Voiture();
            FrmConsulterVoitures unAffichDesVoitures = new FrmConsulterVoitures();
            unAffichDesVoitures.Show();
        }
    }
}
