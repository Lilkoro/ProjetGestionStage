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
        API api = new API();
        AccueilElv accueil = new AccueilElv();
        public Connection()
        {
            InitializeComponent();
        }

        private void btnConn_Click(object sender, EventArgs e)
        {
            // Récupérer les utilisateurs à partir de sqlConf
            List<User> users = api.GetUsersFromDatabase();
            string log = txtLog.Text;
            string pass = txtMdp.Text;

            foreach (var user in users)
            {
                if (user.Login == log && user.Password == pass)
                { 
                    Session.IdUtilisateur = user.Id;
                    Session.pathUtilisateur = user.profilPic;
                    accueil.Show();
                    erreurs.Hide();
                    this.Hide();
                    break;  // On peut arrêter la boucle si on a trouvé une correspondance
                } else
                {
                    erreurs.Show();
                }
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

}
