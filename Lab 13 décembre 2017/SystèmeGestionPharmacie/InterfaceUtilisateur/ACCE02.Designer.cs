namespace SystèmeGestionPharmacie.InterfaceUtilisateur
{
    partial class ACCE02
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ACCE02));
            this.btnQuitter = new System.Windows.Forms.Button();
            this.btnPharmacies = new System.Windows.Forms.Button();
            this.btnPatients = new System.Windows.Forms.Button();
            this.btnMedecins = new System.Windows.Forms.Button();
            this.btnPrescriptions = new System.Windows.Forms.Button();
            this.btnMedicaments = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnQuitter
            // 
            this.btnQuitter.Image = ((System.Drawing.Image)(resources.GetObject("btnQuitter.Image")));
            this.btnQuitter.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnQuitter.Location = new System.Drawing.Point(600, 107);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(193, 73);
            this.btnQuitter.TabIndex = 8;
            this.btnQuitter.Text = "Quitter";
            this.btnQuitter.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQuitter.UseVisualStyleBackColor = true;
            this.btnQuitter.Click += new System.EventHandler(this.btnQuitter_Click);
            // 
            // btnPharmacies
            // 
            this.btnPharmacies.Image = ((System.Drawing.Image)(resources.GetObject("btnPharmacies.Image")));
            this.btnPharmacies.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPharmacies.Location = new System.Drawing.Point(600, 12);
            this.btnPharmacies.Name = "btnPharmacies";
            this.btnPharmacies.Size = new System.Drawing.Size(190, 89);
            this.btnPharmacies.TabIndex = 7;
            this.btnPharmacies.Text = "Pharmacies";
            this.btnPharmacies.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPharmacies.UseVisualStyleBackColor = true;
            this.btnPharmacies.Click += new System.EventHandler(this.btnPharmacies_Click);
            // 
            // btnPatients
            // 
            this.btnPatients.Image = ((System.Drawing.Image)(resources.GetObject("btnPatients.Image")));
            this.btnPatients.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPatients.Location = new System.Drawing.Point(404, 12);
            this.btnPatients.Name = "btnPatients";
            this.btnPatients.Size = new System.Drawing.Size(190, 89);
            this.btnPatients.TabIndex = 6;
            this.btnPatients.Text = "Patients";
            this.btnPatients.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPatients.UseVisualStyleBackColor = true;
            this.btnPatients.Click += new System.EventHandler(this.btnPatients_Click);
            // 
            // btnMedecins
            // 
            this.btnMedecins.Image = ((System.Drawing.Image)(resources.GetObject("btnMedecins.Image")));
            this.btnMedecins.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMedecins.Location = new System.Drawing.Point(208, 12);
            this.btnMedecins.Name = "btnMedecins";
            this.btnMedecins.Size = new System.Drawing.Size(190, 89);
            this.btnMedecins.TabIndex = 5;
            this.btnMedecins.Text = "Médecins";
            this.btnMedecins.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMedecins.UseVisualStyleBackColor = true;
            this.btnMedecins.Click += new System.EventHandler(this.btnMedecins_Click);
            // 
            // btnPrescriptions
            // 
            this.btnPrescriptions.Image = ((System.Drawing.Image)(resources.GetObject("btnPrescriptions.Image")));
            this.btnPrescriptions.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPrescriptions.Location = new System.Drawing.Point(12, 107);
            this.btnPrescriptions.Name = "btnPrescriptions";
            this.btnPrescriptions.Size = new System.Drawing.Size(582, 73);
            this.btnPrescriptions.TabIndex = 4;
            this.btnPrescriptions.Text = "Prescriptions";
            this.btnPrescriptions.UseVisualStyleBackColor = true;
            this.btnPrescriptions.Click += new System.EventHandler(this.btnPrescriptions_Click);
            // 
            // btnMedicaments
            // 
            this.btnMedicaments.Image = ((System.Drawing.Image)(resources.GetObject("btnMedicaments.Image")));
            this.btnMedicaments.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMedicaments.Location = new System.Drawing.Point(12, 12);
            this.btnMedicaments.Name = "btnMedicaments";
            this.btnMedicaments.Size = new System.Drawing.Size(190, 89);
            this.btnMedicaments.TabIndex = 0;
            this.btnMedicaments.Text = "Médicaments";
            this.btnMedicaments.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMedicaments.UseVisualStyleBackColor = true;
            this.btnMedicaments.Click += new System.EventHandler(this.btnMedicaments_Click);
            // 
            // ACCE02
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 192);
            this.Controls.Add(this.btnQuitter);
            this.Controls.Add(this.btnPharmacies);
            this.Controls.Add(this.btnPatients);
            this.Controls.Add(this.btnMedecins);
            this.Controls.Add(this.btnPrescriptions);
            this.Controls.Add(this.btnMedicaments);
            this.Name = "ACCE02";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Accueil";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMedicaments;
        private System.Windows.Forms.Button btnPrescriptions;
        private System.Windows.Forms.Button btnMedecins;
        private System.Windows.Forms.Button btnPatients;
        private System.Windows.Forms.Button btnPharmacies;
        private System.Windows.Forms.Button btnQuitter;
    }
}