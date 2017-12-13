namespace SysPharmacie
{
    partial class WIZZ06
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
            this.btnCancelPrescription = new System.Windows.Forms.Button();
            this.btnSuivantPrescription = new System.Windows.Forms.Button();
            this.btnPrecedentPrescription = new System.Windows.Forms.Button();
            this.btnRecherchePrescription = new System.Windows.Forms.Button();
            this.txtRecherchePrescription = new System.Windows.Forms.TextBox();
            this.radBtnMemePharamacie = new System.Windows.Forms.RadioButton();
            this.radBtnDiffPharmacie = new System.Windows.Forms.RadioButton();
            this.gbPrescriptionInfo = new System.Windows.Forms.GroupBox();
            this.lblNomPharmacie = new System.Windows.Forms.Label();
            this.txtNomPharmacie = new System.Windows.Forms.TextBox();
            this.txtNumPharmacie = new System.Windows.Forms.TextBox();
            this.txtNbRenouvellement = new System.Windows.Forms.TextBox();
            this.txtNumeroPharmacie = new System.Windows.Forms.TextBox();
            this.lblNumPharamacie = new System.Windows.Forms.Label();
            this.lblNbRenouvellementPrescription = new System.Windows.Forms.Label();
            this.lblNumeroPrescription = new System.Windows.Forms.Label();
            this.gbPrescriptionInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancelPrescription
            // 
            this.btnCancelPrescription.Location = new System.Drawing.Point(11, 148);
            this.btnCancelPrescription.Name = "btnCancelPrescription";
            this.btnCancelPrescription.Size = new System.Drawing.Size(75, 23);
            this.btnCancelPrescription.TabIndex = 24;
            this.btnCancelPrescription.Text = "Cancel";
            this.btnCancelPrescription.UseVisualStyleBackColor = true;
            this.btnCancelPrescription.Click += new System.EventHandler(this.btnCancelPrescription_Click);
            // 
            // btnSuivantPrescription
            // 
            this.btnSuivantPrescription.Location = new System.Drawing.Point(339, 148);
            this.btnSuivantPrescription.Name = "btnSuivantPrescription";
            this.btnSuivantPrescription.Size = new System.Drawing.Size(100, 23);
            this.btnSuivantPrescription.TabIndex = 23;
            this.btnSuivantPrescription.Text = "Suivant";
            this.btnSuivantPrescription.UseVisualStyleBackColor = true;
            this.btnSuivantPrescription.Click += new System.EventHandler(this.btnSuivantPrescription_Click);
            // 
            // btnPrecedentPrescription
            // 
            this.btnPrecedentPrescription.Location = new System.Drawing.Point(239, 148);
            this.btnPrecedentPrescription.Name = "btnPrecedentPrescription";
            this.btnPrecedentPrescription.Size = new System.Drawing.Size(94, 23);
            this.btnPrecedentPrescription.TabIndex = 22;
            this.btnPrecedentPrescription.Text = "Précédent";
            this.btnPrecedentPrescription.UseVisualStyleBackColor = true;
            this.btnPrecedentPrescription.Click += new System.EventHandler(this.btnPrecedentPrescription_Click);
            // 
            // btnRecherchePrescription
            // 
            this.btnRecherchePrescription.Location = new System.Drawing.Point(117, 11);
            this.btnRecherchePrescription.Name = "btnRecherchePrescription";
            this.btnRecherchePrescription.Size = new System.Drawing.Size(75, 23);
            this.btnRecherchePrescription.TabIndex = 26;
            this.btnRecherchePrescription.Text = "Rechercher";
            this.btnRecherchePrescription.UseVisualStyleBackColor = true;
            // 
            // txtRecherchePrescription
            // 
            this.txtRecherchePrescription.Location = new System.Drawing.Point(11, 12);
            this.txtRecherchePrescription.Name = "txtRecherchePrescription";
            this.txtRecherchePrescription.Size = new System.Drawing.Size(100, 20);
            this.txtRecherchePrescription.TabIndex = 25;
            this.txtRecherchePrescription.Text = "numéro prescription";
            // 
            // radBtnMemePharamacie
            // 
            this.radBtnMemePharamacie.AutoSize = true;
            this.radBtnMemePharamacie.Checked = true;
            this.radBtnMemePharamacie.Location = new System.Drawing.Point(13, 64);
            this.radBtnMemePharamacie.Name = "radBtnMemePharamacie";
            this.radBtnMemePharamacie.Size = new System.Drawing.Size(112, 17);
            this.radBtnMemePharamacie.TabIndex = 27;
            this.radBtnMemePharamacie.TabStop = true;
            this.radBtnMemePharamacie.Text = "Même pharamacie";
            this.radBtnMemePharamacie.UseVisualStyleBackColor = true;
            // 
            // radBtnDiffPharmacie
            // 
            this.radBtnDiffPharmacie.AutoSize = true;
            this.radBtnDiffPharmacie.Location = new System.Drawing.Point(13, 88);
            this.radBtnDiffPharmacie.Name = "radBtnDiffPharmacie";
            this.radBtnDiffPharmacie.Size = new System.Drawing.Size(123, 17);
            this.radBtnDiffPharmacie.TabIndex = 28;
            this.radBtnDiffPharmacie.Text = "Différente pharmacie";
            this.radBtnDiffPharmacie.UseVisualStyleBackColor = true;
            // 
            // gbPrescriptionInfo
            // 
            this.gbPrescriptionInfo.Controls.Add(this.lblNomPharmacie);
            this.gbPrescriptionInfo.Controls.Add(this.txtNomPharmacie);
            this.gbPrescriptionInfo.Controls.Add(this.txtNumPharmacie);
            this.gbPrescriptionInfo.Controls.Add(this.txtNbRenouvellement);
            this.gbPrescriptionInfo.Controls.Add(this.txtNumeroPharmacie);
            this.gbPrescriptionInfo.Controls.Add(this.lblNumPharamacie);
            this.gbPrescriptionInfo.Controls.Add(this.lblNbRenouvellementPrescription);
            this.gbPrescriptionInfo.Controls.Add(this.lblNumeroPrescription);
            this.gbPrescriptionInfo.Location = new System.Drawing.Point(239, 12);
            this.gbPrescriptionInfo.Name = "gbPrescriptionInfo";
            this.gbPrescriptionInfo.Size = new System.Drawing.Size(200, 130);
            this.gbPrescriptionInfo.TabIndex = 29;
            this.gbPrescriptionInfo.TabStop = false;
            this.gbPrescriptionInfo.Text = "Prescription trouvé:";
            // 
            // lblNomPharmacie
            // 
            this.lblNomPharmacie.AutoSize = true;
            this.lblNomPharmacie.Location = new System.Drawing.Point(6, 98);
            this.lblNomPharmacie.Name = "lblNomPharmacie";
            this.lblNomPharmacie.Size = new System.Drawing.Size(84, 13);
            this.lblNomPharmacie.TabIndex = 7;
            this.lblNomPharmacie.Text = "Nom pharmacie:";
            // 
            // txtNomPharmacie
            // 
            this.txtNomPharmacie.Location = new System.Drawing.Point(94, 95);
            this.txtNomPharmacie.Name = "txtNomPharmacie";
            this.txtNomPharmacie.Size = new System.Drawing.Size(100, 20);
            this.txtNomPharmacie.TabIndex = 6;
            // 
            // txtNumPharmacie
            // 
            this.txtNumPharmacie.Location = new System.Drawing.Point(94, 69);
            this.txtNumPharmacie.Name = "txtNumPharmacie";
            this.txtNumPharmacie.Size = new System.Drawing.Size(100, 20);
            this.txtNumPharmacie.TabIndex = 5;
            // 
            // txtNbRenouvellement
            // 
            this.txtNbRenouvellement.Location = new System.Drawing.Point(94, 43);
            this.txtNbRenouvellement.Name = "txtNbRenouvellement";
            this.txtNbRenouvellement.Size = new System.Drawing.Size(100, 20);
            this.txtNbRenouvellement.TabIndex = 4;
            // 
            // txtNumeroPharmacie
            // 
            this.txtNumeroPharmacie.Location = new System.Drawing.Point(94, 17);
            this.txtNumeroPharmacie.Name = "txtNumeroPharmacie";
            this.txtNumeroPharmacie.Size = new System.Drawing.Size(100, 20);
            this.txtNumeroPharmacie.TabIndex = 3;
            // 
            // lblNumPharamacie
            // 
            this.lblNumPharamacie.AutoSize = true;
            this.lblNumPharamacie.Location = new System.Drawing.Point(6, 72);
            this.lblNumPharamacie.Name = "lblNumPharamacie";
            this.lblNumPharamacie.Size = new System.Drawing.Size(87, 13);
            this.lblNumPharamacie.TabIndex = 2;
            this.lblNumPharamacie.Text = "Num. pharmacie:";
            // 
            // lblNbRenouvellementPrescription
            // 
            this.lblNbRenouvellementPrescription.AutoSize = true;
            this.lblNbRenouvellementPrescription.Location = new System.Drawing.Point(6, 46);
            this.lblNbRenouvellementPrescription.Name = "lblNbRenouvellementPrescription";
            this.lblNbRenouvellementPrescription.Size = new System.Drawing.Size(69, 13);
            this.lblNbRenouvellementPrescription.TabIndex = 1;
            this.lblNbRenouvellementPrescription.Text = "Nb. renouv. :";
            // 
            // lblNumeroPrescription
            // 
            this.lblNumeroPrescription.AutoSize = true;
            this.lblNumeroPrescription.Location = new System.Drawing.Point(6, 20);
            this.lblNumeroPrescription.Name = "lblNumeroPrescription";
            this.lblNumeroPrescription.Size = new System.Drawing.Size(47, 13);
            this.lblNumeroPrescription.TabIndex = 0;
            this.lblNumeroPrescription.Text = "Numéro:";
            // 
            // WIZZ06
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 183);
            this.Controls.Add(this.gbPrescriptionInfo);
            this.Controls.Add(this.radBtnDiffPharmacie);
            this.Controls.Add(this.radBtnMemePharamacie);
            this.Controls.Add(this.btnRecherchePrescription);
            this.Controls.Add(this.txtRecherchePrescription);
            this.Controls.Add(this.btnCancelPrescription);
            this.Controls.Add(this.btnSuivantPrescription);
            this.Controls.Add(this.btnPrecedentPrescription);
            this.Name = "WIZZ06";
            this.Text = "Assistant Renouvellement (Étape 1)";
            this.gbPrescriptionInfo.ResumeLayout(false);
            this.gbPrescriptionInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancelPrescription;
        private System.Windows.Forms.Button btnSuivantPrescription;
        private System.Windows.Forms.Button btnPrecedentPrescription;
        private System.Windows.Forms.Button btnRecherchePrescription;
        private System.Windows.Forms.TextBox txtRecherchePrescription;
        private System.Windows.Forms.RadioButton radBtnMemePharamacie;
        private System.Windows.Forms.RadioButton radBtnDiffPharmacie;
        private System.Windows.Forms.GroupBox gbPrescriptionInfo;
        private System.Windows.Forms.Label lblNomPharmacie;
        private System.Windows.Forms.TextBox txtNomPharmacie;
        private System.Windows.Forms.TextBox txtNumPharmacie;
        private System.Windows.Forms.TextBox txtNbRenouvellement;
        private System.Windows.Forms.TextBox txtNumeroPharmacie;
        private System.Windows.Forms.Label lblNumPharamacie;
        private System.Windows.Forms.Label lblNbRenouvellementPrescription;
        private System.Windows.Forms.Label lblNumeroPrescription;
    }
}