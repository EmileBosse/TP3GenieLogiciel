namespace SystèmeGestionPharmacie
{
    partial class WIZZ03
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
            this.btnAjoutNvPatient = new System.Windows.Forms.Button();
            this.btnCancelPatient = new System.Windows.Forms.Button();
            this.btnSuivantPatient = new System.Windows.Forms.Button();
            this.btnPrecedentPatient = new System.Windows.Forms.Button();
            this.cbxPatient = new System.Windows.Forms.ComboBox();
            this.lblNbResultatPatient = new System.Windows.Forms.Label();
            this.gbPatientInfo = new System.Windows.Forms.GroupBox();
            this.txtDateNaissancePatient = new System.Windows.Forms.TextBox();
            this.txtNoTelPatient = new System.Windows.Forms.TextBox();
            this.txtAdressePatient = new System.Windows.Forms.TextBox();
            this.txtPrenomPatient = new System.Windows.Forms.TextBox();
            this.txtNomPatient = new System.Windows.Forms.TextBox();
            this.txtNoAssurancePatient = new System.Windows.Forms.TextBox();
            this.lblDateNaissancePatient = new System.Windows.Forms.Label();
            this.lblNoTelPatient = new System.Windows.Forms.Label();
            this.lblAdressePatient = new System.Windows.Forms.Label();
            this.lblPrenomPatient = new System.Windows.Forms.Label();
            this.lblNomPatient = new System.Windows.Forms.Label();
            this.lblNoAssurancePatient = new System.Windows.Forms.Label();
            this.btnRecherchePatient = new System.Windows.Forms.Button();
            this.txtRecherchePatient = new System.Windows.Forms.TextBox();
            this.gbPatientInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAjoutNvPatient
            // 
            this.btnAjoutNvPatient.Location = new System.Drawing.Point(12, 101);
            this.btnAjoutNvPatient.Name = "btnAjoutNvPatient";
            this.btnAjoutNvPatient.Size = new System.Drawing.Size(105, 49);
            this.btnAjoutNvPatient.TabIndex = 19;
            this.btnAjoutNvPatient.Text = "Ajouter Nouveau Patient";
            this.btnAjoutNvPatient.UseVisualStyleBackColor = true;
            // 
            // btnCancelPatient
            // 
            this.btnCancelPatient.Location = new System.Drawing.Point(12, 194);
            this.btnCancelPatient.Name = "btnCancelPatient";
            this.btnCancelPatient.Size = new System.Drawing.Size(75, 23);
            this.btnCancelPatient.TabIndex = 18;
            this.btnCancelPatient.Text = "Annuler";
            this.btnCancelPatient.UseVisualStyleBackColor = true;
            this.btnCancelPatient.Click += new System.EventHandler(this.btnCancelPatient_Click);
            // 
            // btnSuivantPatient
            // 
            this.btnSuivantPatient.Location = new System.Drawing.Point(340, 194);
            this.btnSuivantPatient.Name = "btnSuivantPatient";
            this.btnSuivantPatient.Size = new System.Drawing.Size(100, 23);
            this.btnSuivantPatient.TabIndex = 17;
            this.btnSuivantPatient.Text = "Suivant";
            this.btnSuivantPatient.UseVisualStyleBackColor = true;
            this.btnSuivantPatient.Click += new System.EventHandler(this.btnSuivantPatient_Click);
            // 
            // btnPrecedentPatient
            // 
            this.btnPrecedentPatient.Location = new System.Drawing.Point(240, 194);
            this.btnPrecedentPatient.Name = "btnPrecedentPatient";
            this.btnPrecedentPatient.Size = new System.Drawing.Size(94, 23);
            this.btnPrecedentPatient.TabIndex = 16;
            this.btnPrecedentPatient.Text = "Précédent";
            this.btnPrecedentPatient.UseVisualStyleBackColor = true;
            this.btnPrecedentPatient.Click += new System.EventHandler(this.btnPrecedentPatient_Click);
            // 
            // cbxPatient
            // 
            this.cbxPatient.FormattingEnabled = true;
            this.cbxPatient.Location = new System.Drawing.Point(12, 50);
            this.cbxPatient.Name = "cbxPatient";
            this.cbxPatient.Size = new System.Drawing.Size(121, 21);
            this.cbxPatient.TabIndex = 14;
            this.cbxPatient.Text = "\"choisir parmi les résultats\"";
            // 
            // lblNbResultatPatient
            // 
            this.lblNbResultatPatient.AutoSize = true;
            this.lblNbResultatPatient.Location = new System.Drawing.Point(13, 34);
            this.lblNbResultatPatient.Name = "lblNbResultatPatient";
            this.lblNbResultatPatient.Size = new System.Drawing.Size(104, 13);
            this.lblNbResultatPatient.TabIndex = 13;
            this.lblNbResultatPatient.Text = "\"nombre de résultat\"";
            // 
            // gbPatientInfo
            // 
            this.gbPatientInfo.Controls.Add(this.txtDateNaissancePatient);
            this.gbPatientInfo.Controls.Add(this.txtNoTelPatient);
            this.gbPatientInfo.Controls.Add(this.txtAdressePatient);
            this.gbPatientInfo.Controls.Add(this.txtPrenomPatient);
            this.gbPatientInfo.Controls.Add(this.txtNomPatient);
            this.gbPatientInfo.Controls.Add(this.txtNoAssurancePatient);
            this.gbPatientInfo.Controls.Add(this.lblDateNaissancePatient);
            this.gbPatientInfo.Controls.Add(this.lblNoTelPatient);
            this.gbPatientInfo.Controls.Add(this.lblAdressePatient);
            this.gbPatientInfo.Controls.Add(this.lblPrenomPatient);
            this.gbPatientInfo.Controls.Add(this.lblNomPatient);
            this.gbPatientInfo.Controls.Add(this.lblNoAssurancePatient);
            this.gbPatientInfo.Location = new System.Drawing.Point(240, 6);
            this.gbPatientInfo.Name = "gbPatientInfo";
            this.gbPatientInfo.Size = new System.Drawing.Size(200, 182);
            this.gbPatientInfo.TabIndex = 12;
            this.gbPatientInfo.TabStop = false;
            this.gbPatientInfo.Text = "Patient trouvé:";
            // 
            // txtDateNaissancePatient
            // 
            this.txtDateNaissancePatient.Location = new System.Drawing.Point(94, 147);
            this.txtDateNaissancePatient.Name = "txtDateNaissancePatient";
            this.txtDateNaissancePatient.Size = new System.Drawing.Size(100, 20);
            this.txtDateNaissancePatient.TabIndex = 11;
            // 
            // txtNoTelPatient
            // 
            this.txtNoTelPatient.Location = new System.Drawing.Point(94, 121);
            this.txtNoTelPatient.Name = "txtNoTelPatient";
            this.txtNoTelPatient.Size = new System.Drawing.Size(100, 20);
            this.txtNoTelPatient.TabIndex = 10;
            // 
            // txtAdressePatient
            // 
            this.txtAdressePatient.Location = new System.Drawing.Point(94, 95);
            this.txtAdressePatient.Name = "txtAdressePatient";
            this.txtAdressePatient.Size = new System.Drawing.Size(100, 20);
            this.txtAdressePatient.TabIndex = 9;
            // 
            // txtPrenomPatient
            // 
            this.txtPrenomPatient.Location = new System.Drawing.Point(94, 69);
            this.txtPrenomPatient.Name = "txtPrenomPatient";
            this.txtPrenomPatient.Size = new System.Drawing.Size(100, 20);
            this.txtPrenomPatient.TabIndex = 8;
            // 
            // txtNomPatient
            // 
            this.txtNomPatient.Location = new System.Drawing.Point(94, 43);
            this.txtNomPatient.Name = "txtNomPatient";
            this.txtNomPatient.Size = new System.Drawing.Size(100, 20);
            this.txtNomPatient.TabIndex = 7;
            // 
            // txtNoAssurancePatient
            // 
            this.txtNoAssurancePatient.Location = new System.Drawing.Point(94, 17);
            this.txtNoAssurancePatient.Name = "txtNoAssurancePatient";
            this.txtNoAssurancePatient.Size = new System.Drawing.Size(100, 20);
            this.txtNoAssurancePatient.TabIndex = 6;
            // 
            // lblDateNaissancePatient
            // 
            this.lblDateNaissancePatient.AutoSize = true;
            this.lblDateNaissancePatient.Location = new System.Drawing.Point(7, 150);
            this.lblDateNaissancePatient.Name = "lblDateNaissancePatient";
            this.lblDateNaissancePatient.Size = new System.Drawing.Size(86, 13);
            this.lblDateNaissancePatient.TabIndex = 5;
            this.lblDateNaissancePatient.Text = "Date Naissance:";
            // 
            // lblNoTelPatient
            // 
            this.lblNoTelPatient.AutoSize = true;
            this.lblNoTelPatient.Location = new System.Drawing.Point(7, 124);
            this.lblNoTelPatient.Name = "lblNoTelPatient";
            this.lblNoTelPatient.Size = new System.Drawing.Size(81, 13);
            this.lblNoTelPatient.TabIndex = 4;
            this.lblNoTelPatient.Text = "No. Téléphone:";
            // 
            // lblAdressePatient
            // 
            this.lblAdressePatient.AutoSize = true;
            this.lblAdressePatient.Location = new System.Drawing.Point(7, 98);
            this.lblAdressePatient.Name = "lblAdressePatient";
            this.lblAdressePatient.Size = new System.Drawing.Size(48, 13);
            this.lblAdressePatient.TabIndex = 3;
            this.lblAdressePatient.Text = "Adresse:";
            // 
            // lblPrenomPatient
            // 
            this.lblPrenomPatient.AutoSize = true;
            this.lblPrenomPatient.Location = new System.Drawing.Point(6, 72);
            this.lblPrenomPatient.Name = "lblPrenomPatient";
            this.lblPrenomPatient.Size = new System.Drawing.Size(46, 13);
            this.lblPrenomPatient.TabIndex = 2;
            this.lblPrenomPatient.Text = "Prénom:";
            // 
            // lblNomPatient
            // 
            this.lblNomPatient.AutoSize = true;
            this.lblNomPatient.Location = new System.Drawing.Point(7, 46);
            this.lblNomPatient.Name = "lblNomPatient";
            this.lblNomPatient.Size = new System.Drawing.Size(32, 13);
            this.lblNomPatient.TabIndex = 1;
            this.lblNomPatient.Text = "Nom:";
            // 
            // lblNoAssurancePatient
            // 
            this.lblNoAssurancePatient.AutoSize = true;
            this.lblNoAssurancePatient.Location = new System.Drawing.Point(7, 20);
            this.lblNoAssurancePatient.Name = "lblNoAssurancePatient";
            this.lblNoAssurancePatient.Size = new System.Drawing.Size(80, 13);
            this.lblNoAssurancePatient.TabIndex = 0;
            this.lblNoAssurancePatient.Text = "No. Assurance:";
            // 
            // btnRecherchePatient
            // 
            this.btnRecherchePatient.Location = new System.Drawing.Point(119, 6);
            this.btnRecherchePatient.Name = "btnRecherchePatient";
            this.btnRecherchePatient.Size = new System.Drawing.Size(75, 23);
            this.btnRecherchePatient.TabIndex = 11;
            this.btnRecherchePatient.Text = "Rechercher";
            this.btnRecherchePatient.UseVisualStyleBackColor = true;
            // 
            // txtRecherchePatient
            // 
            this.txtRecherchePatient.Location = new System.Drawing.Point(13, 7);
            this.txtRecherchePatient.Name = "txtRecherchePatient";
            this.txtRecherchePatient.Size = new System.Drawing.Size(100, 20);
            this.txtRecherchePatient.TabIndex = 10;
            this.txtRecherchePatient.Text = "nom Patient";
            // 
            // WIZZ03
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 226);
            this.Controls.Add(this.btnAjoutNvPatient);
            this.Controls.Add(this.btnCancelPatient);
            this.Controls.Add(this.btnSuivantPatient);
            this.Controls.Add(this.btnPrecedentPatient);
            this.Controls.Add(this.cbxPatient);
            this.Controls.Add(this.lblNbResultatPatient);
            this.Controls.Add(this.gbPatientInfo);
            this.Controls.Add(this.btnRecherchePatient);
            this.Controls.Add(this.txtRecherchePatient);
            this.Name = "WIZZ03";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Assistant Prescription (Étape 2)";
            this.gbPatientInfo.ResumeLayout(false);
            this.gbPatientInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAjoutNvPatient;
        private System.Windows.Forms.Button btnCancelPatient;
        private System.Windows.Forms.Button btnSuivantPatient;
        private System.Windows.Forms.Button btnPrecedentPatient;
        private System.Windows.Forms.ComboBox cbxPatient;
        private System.Windows.Forms.Label lblNbResultatPatient;
        private System.Windows.Forms.GroupBox gbPatientInfo;
        private System.Windows.Forms.Button btnRecherchePatient;
        private System.Windows.Forms.TextBox txtRecherchePatient;
        private System.Windows.Forms.TextBox txtDateNaissancePatient;
        private System.Windows.Forms.TextBox txtNoTelPatient;
        private System.Windows.Forms.TextBox txtAdressePatient;
        private System.Windows.Forms.TextBox txtPrenomPatient;
        private System.Windows.Forms.TextBox txtNomPatient;
        private System.Windows.Forms.TextBox txtNoAssurancePatient;
        private System.Windows.Forms.Label lblDateNaissancePatient;
        private System.Windows.Forms.Label lblNoTelPatient;
        private System.Windows.Forms.Label lblAdressePatient;
        private System.Windows.Forms.Label lblPrenomPatient;
        private System.Windows.Forms.Label lblNomPatient;
        private System.Windows.Forms.Label lblNoAssurancePatient;
    }
}