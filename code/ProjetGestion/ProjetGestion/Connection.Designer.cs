﻿namespace ProjetGestion
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
            this.txtLog = new System.Windows.Forms.TextBox();
            this.txtMdp = new System.Windows.Forms.TextBox();
            this.btnConn = new System.Windows.Forms.Button();
            this.erreurs = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labLogin
            // 
            this.labLogin.AutoSize = true;
            this.labLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labLogin.Location = new System.Drawing.Point(168, 147);
            this.labLogin.Name = "labLogin";
            this.labLogin.Size = new System.Drawing.Size(123, 25);
            this.labLogin.TabIndex = 0;
            this.labLogin.Text = "Identifiant : ";
            // 
            // labPass
            // 
            this.labPass.AutoSize = true;
            this.labPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labPass.Location = new System.Drawing.Point(140, 229);
            this.labPass.Name = "labPass";
            this.labPass.Size = new System.Drawing.Size(160, 25);
            this.labPass.TabIndex = 1;
            this.labPass.Text = "Mot de passe : ";
            // 
            // txtLog
            // 
            this.txtLog.Location = new System.Drawing.Point(332, 153);
            this.txtLog.Name = "txtLog";
            this.txtLog.Size = new System.Drawing.Size(100, 20);
            this.txtLog.TabIndex = 2;
            // 
            // txtMdp
            // 
            this.txtMdp.Location = new System.Drawing.Point(332, 235);
            this.txtMdp.Name = "txtMdp";
            this.txtMdp.PasswordChar = '*';
            this.txtMdp.Size = new System.Drawing.Size(100, 20);
            this.txtMdp.TabIndex = 3;
            this.txtMdp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMdp_KeyPress);
            // 
            // btnConn
            // 
            this.btnConn.Location = new System.Drawing.Point(344, 288);
            this.btnConn.Name = "btnConn";
            this.btnConn.Size = new System.Drawing.Size(75, 23);
            this.btnConn.TabIndex = 4;
            this.btnConn.Text = "Connexion";
            this.btnConn.UseVisualStyleBackColor = true;
            this.btnConn.Click += new System.EventHandler(this.btnConn_Click);
            // 
            // erreurs
            // 
            this.erreurs.AutoSize = true;
            this.erreurs.Location = new System.Drawing.Point(254, 338);
            this.erreurs.Name = "erreurs";
            this.erreurs.Size = new System.Drawing.Size(270, 13);
            this.erreurs.TabIndex = 5;
            this.erreurs.Text = "Vous avez entré un mauvais identifiant ou mot de passe";
            this.erreurs.Visible = false;
            // 
            // Connection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.erreurs);
            this.Controls.Add(this.btnConn);
            this.Controls.Add(this.txtMdp);
            this.Controls.Add(this.txtLog);
            this.Controls.Add(this.labPass);
            this.Controls.Add(this.labLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Connection";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labLogin;
        private System.Windows.Forms.Label labPass;
        private System.Windows.Forms.TextBox txtLog;
        private System.Windows.Forms.TextBox txtMdp;
        private System.Windows.Forms.Button btnConn;
        private System.Windows.Forms.Label erreurs;
    }
}

