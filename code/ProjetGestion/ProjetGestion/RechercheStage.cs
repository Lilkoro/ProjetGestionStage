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
    public partial class RechercheStage : Form
    {
        private void ChargerStages()
        {
            API api = new API();
            List<StageAPourvoir> stages = api.GetStagesPourvoir();

            dataGridViewStages.DataSource = null;
            dataGridViewStages.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewStages.Columns.Clear();
            dataGridViewStages.DataSource = stages;

            dataGridViewStages.Columns["IdStage"].HeaderText = "ID";
            dataGridViewStages.Columns["Titre"].HeaderText = "Nom du poste";
            dataGridViewStages.Columns["Description"].HeaderText = "Description";
            dataGridViewStages.Columns["Lieu"].HeaderText = "Lieu";
            dataGridViewStages.Columns["DateDebut"].HeaderText = "Date de debut";
            dataGridViewStages.Columns["DureeSemaines"].HeaderText = "Durée du stage (semaines)";
            dataGridViewStages.Columns["nomEtp"].HeaderText = "Nom de l'entreprise";

            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            btn.HeaderText = "Action";
            btn.Text = "Postuler";
            btn.UseColumnTextForButtonValue = true;
            btn.Name = "btnPostuler";
            dataGridViewStages.Columns.Add(btn);
        }

        public RechercheStage()
        {
            InitializeComponent();
            dataGridViewStages.CellContentClick += dataGridViewStages_CellContentClick; // pour gérer le clic sur le bouton
        }
        private void RechercheStage_Load(object sender, EventArgs e)
        {
            ChargerStages(); // tu crées cette méthode
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            AccueilElv accueilElv = new AccueilElv();
            this.Hide();
            accueilElv.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ChargerStages(); // recharge les stages
        }

        private void dataGridViewStages_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Vérifie si c'est la colonne du bouton
            if (dataGridViewStages.Columns[e.ColumnIndex].Name == "btnPostuler" && e.RowIndex >= 0)
            {
                API api = new API();
                bool isPostulated = api.UserApply(Convert.ToInt32(dataGridViewStages.Rows[e.RowIndex].Cells["IdStage"].Value));
                if (isPostulated)
                {

                    var row = dataGridViewStages.Rows[e.RowIndex];
                    string id = row.Cells["IdStage"].Value?.ToString();
                    string titre = row.Cells["Titre"].Value?.ToString();
                    string description = row.Cells["Description"].Value?.ToString();
                    string lieu = row.Cells["Lieu"].Value?.ToString();
                    string dateDebut = row.Cells["DateDebut"].Value?.ToString();
                    string duree = row.Cells["DureeSemaines"].Value?.ToString();
                    string entreprise = row.Cells["nomEtp"].Value?.ToString();

                    string message = $"ID: {id}\nPoste: {titre}\nDescription: {description}\nLieu: {lieu}\nDate début: {dateDebut}\nDurée: {duree} semaines\nEntreprise: {entreprise}";
                    MessageBox.Show(message, "Détail de l'offre");
                }
                else
                {
                    MessageBox.Show("Vous avez déjà postulé à cette offre.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
