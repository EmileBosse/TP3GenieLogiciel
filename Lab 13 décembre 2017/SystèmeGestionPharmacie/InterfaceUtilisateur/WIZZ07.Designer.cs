namespace SystèmeGestionPharmacie
{
    partial class WIZZ07
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
            this.listMedicament = new System.Windows.Forms.ListBox();
            this.btnCancelMedicament = new System.Windows.Forms.Button();
            this.btnSuivantMedicament = new System.Windows.Forms.Button();
            this.btnPrecedentMedicament = new System.Windows.Forms.Button();
            this.txtNumMedicament = new System.Windows.Forms.TextBox();
            this.btnRechercherMedicament = new System.Windows.Forms.Button();
            this.lblNumMedicament = new System.Windows.Forms.Label();
            this.btnAjouterMedicament = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listMedicament
            // 
            this.listMedicament.FormattingEnabled = true;
            this.listMedicament.Location = new System.Drawing.Point(13, 13);
            this.listMedicament.Name = "listMedicament";
            this.listMedicament.Size = new System.Drawing.Size(171, 95);
            this.listMedicament.TabIndex = 0;
            // 
            // btnCancelMedicament
            // 
            this.btnCancelMedicament.Location = new System.Drawing.Point(13, 117);
            this.btnCancelMedicament.Name = "btnCancelMedicament";
            this.btnCancelMedicament.Size = new System.Drawing.Size(75, 23);
            this.btnCancelMedicament.TabIndex = 27;
            this.btnCancelMedicament.Text = "Cancel";
            this.btnCancelMedicament.UseVisualStyleBackColor = true;
            this.btnCancelMedicament.Click += new System.EventHandler(this.btnCancelMedicament_Click);
            // 
            // btnSuivantMedicament
            // 
            this.btnSuivantMedicament.Location = new System.Drawing.Point(341, 117);
            this.btnSuivantMedicament.Name = "btnSuivantMedicament";
            this.btnSuivantMedicament.Size = new System.Drawing.Size(100, 23);
            this.btnSuivantMedicament.TabIndex = 26;
            this.btnSuivantMedicament.Text = "Suivant";
            this.btnSuivantMedicament.UseVisualStyleBackColor = true;
            this.btnSuivantMedicament.Click += new System.EventHandler(this.btnSuivantMedicament_Click);
            // 
            // btnPrecedentMedicament
            // 
            this.btnPrecedentMedicament.Location = new System.Drawing.Point(241, 117);
            this.btnPrecedentMedicament.Name = "btnPrecedentMedicament";
            this.btnPrecedentMedicament.Size = new System.Drawing.Size(94, 23);
            this.btnPrecedentMedicament.TabIndex = 25;
            this.btnPrecedentMedicament.Text = "Précédent";
            this.btnPrecedentMedicament.UseVisualStyleBackColor = true;
            this.btnPrecedentMedicament.Click += new System.EventHandler(this.btnPrecedentMedicament_Click);
            // 
            // txtNumMedicament
            // 
            this.txtNumMedicament.Location = new System.Drawing.Point(328, 13);
            this.txtNumMedicament.Name = "txtNumMedicament";
            this.txtNumMedicament.Size = new System.Drawing.Size(112, 20);
            this.txtNumMedicament.TabIndex = 28;
            // 
            // btnRechercherMedicament
            // 
            this.btnRechercherMedicament.Location = new System.Drawing.Point(241, 41);
            this.btnRechercherMedicament.Name = "btnRechercherMedicament";
            this.btnRechercherMedicament.Size = new System.Drawing.Size(94, 23);
            this.btnRechercherMedicament.TabIndex = 29;
            this.btnRechercherMedicament.Text = "Rechercher";
            this.btnRechercherMedicament.UseVisualStyleBackColor = true;
            // 
            // lblNumMedicament
            // 
            this.lblNumMedicament.AutoSize = true;
            this.lblNumMedicament.Location = new System.Drawing.Point(226, 16);
            this.lblNumMedicament.Name = "lblNumMedicament";
            this.lblNumMedicament.Size = new System.Drawing.Size(96, 13);
            this.lblNumMedicament.TabIndex = 30;
            this.lblNumMedicament.Text = "Num. Médicament:";
            // 
            // btnAjouterMedicament
            // 
            this.btnAjouterMedicament.Enabled = false;
            this.btnAjouterMedicament.Location = new System.Drawing.Point(341, 41);
            this.btnAjouterMedicament.Name = "btnAjouterMedicament";
            this.btnAjouterMedicament.Size = new System.Drawing.Size(99, 23);
            this.btnAjouterMedicament.TabIndex = 31;
            this.btnAjouterMedicament.Text = "Ajouter";
            this.btnAjouterMedicament.UseVisualStyleBackColor = true;
            // 
            // WIZZ07
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 152);
            this.Controls.Add(this.btnAjouterMedicament);
            this.Controls.Add(this.lblNumMedicament);
            this.Controls.Add(this.btnRechercherMedicament);
            this.Controls.Add(this.txtNumMedicament);
            this.Controls.Add(this.btnCancelMedicament);
            this.Controls.Add(this.btnSuivantMedicament);
            this.Controls.Add(this.btnPrecedentMedicament);
            this.Controls.Add(this.listMedicament);
            this.Name = "WIZZ07";
            this.Text = "Assistant Renouvellement (Étape 2)";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listMedicament;
        private System.Windows.Forms.Button btnCancelMedicament;
        private System.Windows.Forms.Button btnSuivantMedicament;
        private System.Windows.Forms.Button btnPrecedentMedicament;
        private System.Windows.Forms.TextBox txtNumMedicament;
        private System.Windows.Forms.Button btnRechercherMedicament;
        private System.Windows.Forms.Label lblNumMedicament;
        private System.Windows.Forms.Button btnAjouterMedicament;
    }
}