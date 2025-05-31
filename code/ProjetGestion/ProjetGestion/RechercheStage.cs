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
            var stages = api.GetStagesPourvoir();

            dataGridViewStages.DataSource = null;
            dataGridViewStages.Columns.Clear(); // éviter les doublons si tu recharges

            dataGridViewStages.DataSource = stages;

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
        }
        private void RechercheStageForm_Load(object sender, EventArgs e)
        {
            ChargerStages(); // tu crées cette méthode
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
