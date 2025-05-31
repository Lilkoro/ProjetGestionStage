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
            API api = new API();
            string path = Session.pathUtilisateur;
            Bitmap image = new Bitmap(path);
            pictureBox1.Image = image;
            List<infoElv> studentInfo = api.GetCurrentStudentInfo(Session.IdUtilisateur);
            if (studentInfo != null && studentInfo.Count > 0)
            {
                foreach (infoElv student in studentInfo)
                {
                    labInfo.Text = student.Nom + " " + student.Prenom;
                }
            }
            else
            {
                labInfo.Text = "Aucune information trouvée.";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Modification modif_form = new Modification();
            this.Close();
            modif_form.ShowDialog();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            Connection conForm = new Connection();
            Session.resetUser();
            this.Hide();
            conForm.ShowDialog();

        }

        private void btnStaEff_Click(object sender, EventArgs e)
        {
            StageEffectue stageEffectue = new StageEffectue();
            this.Hide();
            stageEffectue.ShowDialog();
        }
    }
}
