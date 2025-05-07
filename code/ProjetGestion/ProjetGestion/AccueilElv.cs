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
    public partial class AccueilElv : Form
    {
        public AccueilElv()
        {
            InitializeComponent();
        }

        private void AccueilElv_Load(object sender, EventArgs e)
        {
            API sqlconf = new API();
            List<User> user = sqlconf.GetSessionUserFromDatabase(Session.IdUtilisateur);
            string path = System.IO.Path.GetFullPath(user[0].profilPic);
            Bitmap image = new Bitmap(path);
            pictureBox1.Image = image;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Modification modif_form = new Modification();
            this.Close();
            modif_form.ShowDialog();
        }
    }
}
