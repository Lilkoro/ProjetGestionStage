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
    public partial class StageEffectue : Form
    {
        public StageEffectue()
        {
            InitializeComponent();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            AccueilElv accueilElv = new AccueilElv();
            this.Close();
            accueilElv.ShowDialog();
        }

        private void StageEffectue_Load(object sender, EventArgs e)
        {
            API API = new API();
            List<Stages> stages = API.GetStagesByUser(Session.IdUtilisateur);
            dataGridViewStages.DataSource = stages;
            dataGridViewStages.Columns["IdStage"].HeaderText = "ID";
            dataGridViewStages.Columns["nomTuteur"].HeaderText = "Tuteur";
            dataGridViewStages.Columns["nomEntreprise"].HeaderText = "Entreprise";
            dataGridViewStages.Columns["nomProf"].HeaderText = "Professeur";
            dataGridViewStages.Columns["dateDebut"].HeaderText = "Début";
            dataGridViewStages.Columns["dateFin"].HeaderText = "Fin";
            dataGridViewStages.Columns["NomPoste"].HeaderText = "Poste"; 
            dataGridViewStages.Columns["EtatString"].HeaderText = "État";
        }
    }
}
