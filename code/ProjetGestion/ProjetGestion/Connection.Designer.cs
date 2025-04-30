namespace ProjetGestion
{
    partial class Connection
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.labLogin = new System.Windows.Forms.Label();
            this.labPass = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labLogin
            // 
            this.labLogin.AutoSize = true;
            this.labLogin.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labLogin.Location = new System.Drawing.Point(168, 147);
            this.labLogin.Name = "labLogin";
            this.labLogin.Size = new System.Drawing.Size(130, 24);
            this.labLogin.TabIndex = 0;
            this.labLogin.Text = "Identifiant : ";
            this.labLogin.Click += new System.EventHandler(this.labLogin_Click);
            // 
            // labPass
            // 
            this.labPass.AutoSize = true;
            this.labPass.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labPass.Location = new System.Drawing.Point(140, 229);
            this.labPass.Name = "labPass";
            this.labPass.Size = new System.Drawing.Size(158, 24);
            this.labPass.TabIndex = 1;
            this.labPass.Text = "Mot de passe : ";
            // 
            // Connection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labPass);
            this.Controls.Add(this.labLogin);
            this.Name = "Connection";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labLogin;
        private System.Windows.Forms.Label labPass;
    }
}

