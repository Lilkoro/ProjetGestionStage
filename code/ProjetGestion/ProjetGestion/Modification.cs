using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetGestion
{
    public partial class Modification : Form
    {
        public Modification()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Sélectionnez un fichier";
            openFileDialog.Filter = "Fichiers PDF (*.pdf)|*.pdf|Tous les fichiers (*.*)|*.*";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string cheminFichier = openFileDialog.FileName;
                MessageBox.Show("Fichier sélectionné : " + cheminFichier);
            }

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            AccueilElv accueil = new AccueilElv();
            accueil.ShowDialog();
        }
    }
}
