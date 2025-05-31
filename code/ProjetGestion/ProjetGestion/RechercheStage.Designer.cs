namespace ProjetGestion
{
    partial class RechercheStage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labTitre = new System.Windows.Forms.Label();
            this.dataGridViewStages = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.btnLogOut = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStages)).BeginInit();
            this.SuspendLayout();
            // 
            // labTitre
            // 
            this.labTitre.AutoSize = true;
            this.labTitre.Font = new System.Drawing.Font("Arial", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labTitre.Location = new System.Drawing.Point(387, 9);
            this.labTitre.Name = "labTitre";
            this.labTitre.Size = new System.Drawing.Size(654, 75);
            this.labTitre.TabIndex = 0;
            this.labTitre.Text = "Recherche De Stage";
            // 
            // dataGridViewStages
            // 
            this.dataGridViewStages.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridViewStages.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStages.Location = new System.Drawing.Point(12, 144);
            this.dataGridViewStages.Name = "dataGridViewStages";
            this.dataGridViewStages.Size = new System.Drawing.Size(1417, 412);
            this.dataGridViewStages.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(645, 104);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(159, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "🔄 Rechercher / Actualiser";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnLogOut
            // 
            this.btnLogOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnLogOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOut.ForeColor = System.Drawing.Color.White;
            this.btnLogOut.Location = new System.Drawing.Point(35, 578);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(123, 29);
            this.btnLogOut.TabIndex = 24;
            this.btnLogOut.Text = "Retour";
            this.btnLogOut.UseVisualStyleBackColor = false;
            // 
            // RechercheStage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1457, 629);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridViewStages);
            this.Controls.Add(this.labTitre);
            this.Name = "RechercheStage";
            this.Text = "RechercheStage";
            this.Load += new System.EventHandler(this.RechercheStage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStages)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labTitre;
        private System.Windows.Forms.DataGridView dataGridViewStages;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnLogOut;
    }
}