using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace x_prj_biblio
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void nouveauBibliothécaireToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ajouter_Bibliothecaire ajouter_bibliothecaire = new Ajouter_Bibliothecaire();
            ajouter_bibliothecaire.Show();
        }

        private void gererBibliothécairesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Gerer_Bibliothecaire gerer_bibliothecaire = new Gerer_Bibliothecaire();
            gerer_bibliothecaire.Show();
        }

        private void bibliothécairesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void nouveauEmpruntToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ajouter_Autor gerer_bibliothecaire = new Ajouter_Autor();
            gerer_bibliothecaire.Show();
        }

        private void gererAutorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Gerer_Autor Gerer_Autor = new Gerer_Autor();
            Gerer_Autor.Show();
        }

        private void nouveauBorrowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Add_Borrowing add_Borrowing = new Add_Borrowing();
            add_Borrowing.Show();
        }

        private void gererBorrowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Gerer_Borrowing gerer_Borrowing = new Gerer_Borrowing();
            gerer_Borrowing.Show();
        }

        private void gererLivresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Manage_Books manage_Books = new Manage_Books();
            manage_Books.Show();
        }
    }
}
