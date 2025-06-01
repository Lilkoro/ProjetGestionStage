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
    public partial class StagePostule : Form
    {
        public void loadApplyStage()
        {
            API api = new API();
            List<StagesPostule> stages = api.getStagesByStudent();
            dataGridViewStages.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewStages.DataSource = stages;
            dataGridViewStages.Columns["IdStage"].HeaderText = "ID";
            dataGridViewStages.Columns["nomTuteur"].HeaderText = "Tuteur";
            dataGridViewStages.Columns["nomEntreprise"].HeaderText = "Entreprise";
            dataGridViewStages.Columns["dateDebut"].HeaderText = "Début";
            dataGridViewStages.Columns["dureeSemaines"].HeaderText = "Durée en Semaines";
            dataGridViewStages.Columns["NomPoste"].HeaderText = "Poste";
            // Masquer les colonnes vides si au moins une ligne
            if (dataGridViewStages.Rows.Count > 0)
            {
                foreach (DataGridViewColumn col in dataGridViewStages.Columns)
                {
                    bool allEmpty = true;
                    foreach (DataGridViewRow row in dataGridViewStages.Rows)
                    {
                        if (row.IsNewRow) continue; // Ignore la ligne de saisie
                        var value = row.Cells[col.Index].Value;
                        if (value != null && !string.IsNullOrWhiteSpace(value.ToString()))
                        {
                            allEmpty = false;
                            break;
                        }
                    }
                    col.Visible = !allEmpty;
                }
            }
        }

        public StagePostule()
        {
            InitializeComponent();
        }
        private void btnLogOut_Click(object sender, EventArgs e)
        {
            AccueilElv accueilElv = new AccueilElv();
            this.Close();
            accueilElv.ShowDialog();
        }

        private void StagePostule_Load(object sender, EventArgs e)
        {
            loadApplyStage();
        }
    }
}
