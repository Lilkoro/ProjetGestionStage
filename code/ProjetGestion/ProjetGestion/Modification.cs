using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

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

        private void Modification_Load(object sender, EventArgs e)
        {
            API sql = new API();
            int id = Session.IdUtilisateur;
            MySqlConnection conn = sql.getConnection();
            conn.Open();
            MySqlCommand cmd = new MySqlCommand(null, conn);
            cmd.CommandText = "Select * FROM eleve where idCpt = @id";
            MySqlParameter idParam = new MySqlParameter("@id", MySqlDbType.Int32, 0);
            cmd.Parameters.Add(idParam);
            cmd.Prepare();
            cmd.Parameters[0].Value = id; 
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                txtNom.Text = reader["nomElv"].ToString();
            }
            reader.Close();
            conn.Close();
        }
    }
}
