using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Mysqlx.Crud;

namespace ProjetGestion
{
    public partial class Modification : Form
    {
        API api = new API();
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
                try
                {
                    File.Copy(cheminFichier, "../../assets/CV.pdf", true);
                    string updateQuery = "UPDATE eleve SET pathCV = '../../assets/CV.pdf' WHERE idElv = " + Session.IdUtilisateur;
                    MySqlConnection conn = api.getConnection();
                    using (conn)
                    {
                        conn.Open();
                        using (MySqlCommand cmd = new MySqlCommand(updateQuery, conn))
                        {
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("CV mis à jour avec succès !");
                        }
                        conn.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur " + ex);
                    throw;
                }
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
            MySqlConnection conn = api.getConnection();
            List<Specialite> specialites = api.GetSpecialites();
            List<infoElv> eleve = api.GetCurrentStudentInfo(Session.IdUtilisateur);
            List<lieuTravail> lieux = api.GetTravails();
            comboBoxSecOpt.DisplayMember = "Nom";
            comboBoxSecOpt.ValueMember = "Id";
            foreach (Specialite spe in specialites)
            {
                comboBoxSecOpt.Items.Add(spe);
            }
            txtPoste.Text = eleve[0].NomPoste;
        }

        private void btnValider_Click(object sender, EventArgs e)
        {

            // Récupération des valeurs saisies
            string nom = txtNom.Text.Trim();
            string prenom = txtPrenom.Text.Trim();
            string mail = txtMail.Text.Trim();
            string tel = txtTel.Text.Trim();
            string adr = txtAdr.Text.Trim();
            Specialite selectedSpe = comboBoxSecOpt.SelectedItem as Specialite;
            string idSpecialite = selectedSpe != null && !string.IsNullOrEmpty(selectedSpe.Id) ? selectedSpe.Id : null;
            string portfolio = txtPortfolio.Text.Trim();
            string poste = txtPoste.Text.Trim();

            // Vérification du format du numéro de téléphone
            if (!string.IsNullOrEmpty(tel))
            {
                Regex regexTel = new Regex(@"^0[1-9]\d{8}$");
                if (!regexTel.IsMatch(tel))
                {
                    MessageBox.Show("Le numéro de téléphone doit être composé de 10 chiffres et commencer par 0 (ex : 0612345678).");
                    return;
                }
            }

            string modeTravail = "";
            if (radioSite.Checked) modeTravail = "Sur Site";
            else if (radioDist.Checked) modeTravail = "Distanciel";
            else if (radioPartiel.Checked) modeTravail = "Partiel";
            // Construction dynamique de la requête UPDATE
            List<string> updates = new List<string>();
            if (!string.IsNullOrEmpty(nom)) updates.Add("nomElv = @nom");
            if (!string.IsNullOrEmpty(prenom)) updates.Add("prenomElv = @prenom");
            if (!string.IsNullOrEmpty(mail)) updates.Add("email = @mail");
            if (!string.IsNullOrEmpty(tel)) updates.Add("tel = @tel");
            if (!string.IsNullOrEmpty(adr)) updates.Add("rueElv = @adr");
            if (!string.IsNullOrEmpty(idSpecialite)) updates.Add("sectionOption = @sectionOption");
            if (!string.IsNullOrEmpty(portfolio)) updates.Add("urlPortfolio = @portfolio");
            if (!string.IsNullOrEmpty(poste)) updates.Add("nomPoste = @poste");
            if (!string.IsNullOrEmpty(modeTravail)) updates.Add("lieuTravail = @modeTravail");

            if (updates.Count == 0)
            {
                MessageBox.Show("Aucune information à mettre à jour.");
                return;
            }

            string updateQuery = "UPDATE eleve SET " + string.Join(", ", updates) + " WHERE idElv = @idElv";
            MySqlConnection conn = api.getConnection();
            using (conn)
            {
                try
                {
                    conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand(updateQuery, conn))
                    {
                        if (!string.IsNullOrEmpty(nom)) cmd.Parameters.AddWithValue("@nom", nom);
                        if (!string.IsNullOrEmpty(prenom)) cmd.Parameters.AddWithValue("@prenom", prenom);
                        if (!string.IsNullOrEmpty(mail)) cmd.Parameters.AddWithValue("@mail", mail);
                        if (!string.IsNullOrEmpty(tel)) cmd.Parameters.AddWithValue("@tel", tel);
                        if (!string.IsNullOrEmpty(adr)) cmd.Parameters.AddWithValue("@adr", adr);
                        if (!string.IsNullOrEmpty(idSpecialite)) cmd.Parameters.AddWithValue("@sectionOption", idSpecialite);
                        if (!string.IsNullOrEmpty(portfolio)) cmd.Parameters.AddWithValue("@portfolio", portfolio);
                        if (!string.IsNullOrEmpty(poste)) cmd.Parameters.AddWithValue("@poste", poste);
                        if (!string.IsNullOrEmpty(modeTravail)) cmd.Parameters.AddWithValue("@modeTravail", modeTravail);
                        cmd.Parameters.AddWithValue("@idElv", Session.IdUtilisateur);

                        int rows = cmd.ExecuteNonQuery();
                        if (rows > 0)
                            MessageBox.Show("Mise à jour réussie !");
                        else
                            MessageBox.Show("Aucune modification effectuée.");
                        conn.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur lors de la mise à jour : " + ex.Message);
                    conn.Close();
                }
            }
        }
    }
}
