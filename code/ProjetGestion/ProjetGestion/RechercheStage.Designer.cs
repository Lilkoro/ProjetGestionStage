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
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewStages = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnPostuler = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStages)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(243, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(654, 75);
            this.label1.TabIndex = 0;
            this.label1.Text = "Recherche De Stage";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dataGridViewStages
            // 
            this.dataGridViewStages.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridViewStages.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStages.Location = new System.Drawing.Point(12, 144);
            this.dataGridViewStages.Name = "dataGridViewStages";
            this.dataGridViewStages.Size = new System.Drawing.Size(1152, 412);
            this.dataGridViewStages.TabIndex = 9;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 107);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(332, 20);
            this.textBox1.TabIndex = 10;
            this.textBox1.Text = "Recherche...";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1005, 107);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(159, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "🔄 Rechercher / Actualiser";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnPostuler
            // 
            this.btnPostuler.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(58)))), ((int)(((byte)(183)))));
            this.btnPostuler.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPostuler.ForeColor = System.Drawing.Color.White;
            this.btnPostuler.Location = new System.Drawing.Point(12, 576);
            this.btnPostuler.Name = "btnPostuler";
            this.btnPostuler.Size = new System.Drawing.Size(107, 41);
            this.btnPostuler.TabIndex = 23;
            this.btnPostuler.Text = "Postuler !";
            this.btnPostuler.UseVisualStyleBackColor = false;
            // 
            // RechercheStage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1176, 629);
            this.Controls.Add(this.btnPostuler);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridViewStages);
            this.Controls.Add(this.label1);
            this.Name = "RechercheStage";
            this.Text = "RechercheStage";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStages)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewStages;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnPostuler;
    }
}