using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetGestion
{
    public partial class Connection : Form
    {
        API sqlConf = new API();
        AccueilElv accueil = new AccueilElv();
        public Connection()
        {
            InitializeComponent();
        }

        private void btnConn_Click(object sender, EventArgs e)
        {
            // Récupérer les utilisateurs à partir de sqlConf
            List<User> users = sqlConf.GetUsersFromDatabase();
            string log = txtLog.Text;
            string pass = txtMdp.Text;
            int id = 0;
            bool isValid = false;

            foreach (var user in users)
            {
                if (user.Login == log && user.Password == pass)
                { 
                    id = user.Id;
                    isValid = true;
                    break;  // On peut arrêter la boucle si on a trouvé une correspondance
                }
            }

            if (isValid)
            {
                Session.IdUtilisateur = id;
                erreurs.Hide();
                accueil.Show();
                this.Hide();
            }
            else
            {
                erreurs.Show();
            }
        }

        private void txtMdp_KeyPress(object sender, KeyPressEventArgs e)
        {
            if( e.KeyChar == (char)Keys.Enter)
            {
                btnConn_Click(sender, e);
            }
        }
    }
    public static class Session
    {
        public static int IdUtilisateur { get; set; }
        // Tu peux ajouter d’autres propriétés utiles : rôle, nom complet, etc.
    }
}
