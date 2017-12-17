namespace SystèmeGestionPharmacie
{
    partial class WIZZ05
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
            this.btnTerminerPrescription = new System.Windows.Forms.Button();
            this.btnPrecedentPrescription = new System.Windows.Forms.Button();
            this.gbPharmacien = new System.Windows.Forms.GroupBox();
            this.lblNumLicencePharmacien = new System.Windows.Forms.Label();
            this.lblPrenomPharamcien = new System.Windows.Forms.Label();
            this.lblNomPharmacien = new System.Windows.Forms.Label();
            this.txtNumLicencePharmacien = new System.Windows.Forms.TextBox();
            this.txtPrenomPharmacien = new System.Windows.Forms.TextBox();
            this.txtNomPharmacien = new System.Windows.Forms.TextBox();
            this.lblPrixPrescription = new System.Windows.Forms.Label();
            this.lblNbRenouvellementPrescription = new System.Windows.Forms.Label();
            this.txtNbRenouvellementPrescription = new System.Windows.Forms.TextBox();
            this.txtPrixPrescription = new System.Windows.Forms.TextBox();
            this.gbPharmacien.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancelPrescription
            // 
            this.btnCancelPrescription.Location = new System.Drawing.Point(16, 122);
            this.btnCancelPrescription.Name = "btnCancelPrescription";
            this.btnCancelPrescription.Size = new System.Drawing.Size(75, 23);
            this.btnCancelPrescription.TabIndex = 24;
            this.btnCancelPrescription.Text = "Annuler";
            this.btnCancelPrescription.UseVisualStyleBackColor = true;
            this.btnCancelPrescription.Click += new System.EventHandler(this.btnCancelPrescription_Click);
            // 
            // btnTerminerPrescription
            // 
            this.btnTerminerPrescription.Location = new System.Drawing.Point(340, 122);
            this.btnTerminerPrescription.Name = "btnTerminerPrescription";
            this.btnTerminerPrescription.Size = new System.Drawing.Size(100, 23);
            this.btnTerminerPrescription.TabIndex = 23;
            this.btnTerminerPrescription.Text = "Terminer";
            this.btnTerminerPrescription.UseVisualStyleBackColor = true;
            this.btnTerminerPrescription.Click += new System.EventHandler(this.btnTerminerPrescription_Click);
            // 
            // btnPrecedentPrescription
            // 
            this.btnPrecedentPrescription.Location = new System.Drawing.Point(240, 122);
            this.btnPrecedentPrescription.Name = "btnPrecedentPrescription";
            this.btnPrecedentPrescription.Size = new System.Drawing.Size(94, 23);
            this.btnPrecedentPrescription.TabIndex = 22;
            this.btnPrecedentPrescription.Text = "Précédent";
            this.btnPrecedentPrescription.UseVisualStyleBackColor = true;
            this.btnPrecedentPrescription.Click += new System.EventHandler(this.btnPrecedentPrescription_Click);
            // 
            // gbPharmacien
            // 
            this.gbPharmacien.Controls.Add(this.lblNumLicencePharmacien);
            this.gbPharmacien.Controls.Add(this.lblPrenomPharamcien);
            this.gbPharmacien.Controls.Add(this.lblNomPharmacien);
            this.gbPharmacien.Controls.Add(this.txtNumLicencePharmacien);
            this.gbPharmacien.Controls.Add(this.txtPrenomPharmacien);
            this.gbPharmacien.Controls.Add(this.txtNomPharmacien);
            this.gbPharmacien.Location = new System.Drawing.Point(240, 12);
            this.gbPharmacien.Name = "gbPharmacien";
            this.gbPharmacien.Size = new System.Drawing.Size(200, 104);
            this.gbPharmacien.TabIndex = 25;
            this.gbPharmacien.TabStop = false;
            this.gbPharmacien.Text = "Pharmacien :";
            // 
            // lblNumLicencePharmacien
            // 
            this.lblNumLicencePharmacien.AutoSize = true;
            this.lblNumLicencePharmacien.Location = new System.Drawing.Point(6, 74);
            this.lblNumLicencePharmacien.Name = "lblNumLicencePharmacien";
            this.lblNumLicencePharmacien.Size = new System.Drawing.Size(72, 13);
            this.lblNumLicencePharmacien.TabIndex = 5;
            this.lblNumLicencePharmacien.Text = "Num. licence:";
            // 
            // lblPrenomPharamcien
            // 
            this.lblPrenomPharamcien.AutoSize = true;
            this.lblPrenomPharamcien.Location = new System.Drawing.Point(6, 48);
            this.lblPrenomPharamcien.Name = "lblPrenomPharamcien";
            this.lblPrenomPharamcien.Size = new System.Drawing.Size(46, 13);
            this.lblPrenomPharamcien.TabIndex = 4;
            this.lblPrenomPharamcien.Text = "Prénom:";
            // 
            // lblNomPharmacien
            // 
            this.lblNomPharmacien.AutoSize = true;
            this.lblNomPharmacien.Location = new System.Drawing.Point(6, 22);
            this.lblNomPharmacien.Name = "lblNomPharmacien";
            this.lblNomPharmacien.Size = new System.Drawing.Size(32, 13);
            this.lblNomPharmacien.TabIndex = 3;
            this.lblNomPharmacien.Text = "Nom:";
            // 
            // txtNumLicencePharmacien
            // 
            this.txtNumLicencePharmacien.Location = new System.Drawing.Point(94, 71);
            this.txtNumLicencePharmacien.Name = "txtNumLicencePharmacien";
            this.txtNumLicencePharmacien.Size = new System.Drawing.Size(100, 20);
            this.txtNumLicencePharmacien.TabIndex = 2;
            // 
            // txtPrenomPharmacien
            // 
            this.txtPrenomPharmacien.Location = new System.Drawing.Point(94, 45);
            this.txtPrenomPharmacien.Name = "txtPrenomPharmacien";
            this.txtPrenomPharmacien.Size = new System.Drawing.Size(100, 20);
            this.txtPrenomPharmacien.TabIndex = 1;
            // 
            // txtNomPharmacien
            // 
            this.txtNomPharmacien.Location = new System.Drawing.Point(94, 19);
            this.txtNomPharmacien.Name = "txtNomPharmacien";
            this.txtNomPharmacien.Size = new System.Drawing.Size(100, 20);
            this.txtNomPharmacien.TabIndex = 0;
            // 
            // lblPrixPrescription
            // 
            this.lblPrixPrescription.AutoSize = true;
            this.lblPrixPrescription.Location = new System.Drawing.Point(13, 15);
            this.lblPrixPrescription.Name = "lblPrixPrescription";
            this.lblPrixPrescription.Size = new System.Drawing.Size(50, 13);
            this.lblPrixPrescription.TabIndex = 26;
            this.lblPrixPrescription.Text = "Prix total:";
            // 
            // lblNbRenouvellementPrescription
            // 
            this.lblNbRenouvellementPrescription.AutoSize = true;
            this.lblNbRenouvellementPrescription.Location = new System.Drawing.Point(13, 51);
            this.lblNbRenouvellementPrescription.Name = "lblNbRenouvellementPrescription";
            this.lblNbRenouvellementPrescription.Size = new System.Drawing.Size(107, 13);
            this.lblNbRenouvellementPrescription.TabIndex = 27;
            this.lblNbRenouvellementPrescription.Text = "Nb. Renouvellement:";
            // 
            // txtNbRenouvellementPrescription
            // 
            this.txtNbRenouvellementPrescription.Location = new System.Drawing.Point(126, 48);
            this.txtNbRenouvellementPrescription.Name = "txtNbRenouvellementPrescription";
            this.txtNbRenouvellementPrescription.Size = new System.Drawing.Size(100, 20);
            this.txtNbRenouvellementPrescription.TabIndex = 28;
            // 
            // txtPrixPrescription
            // 
            this.txtPrixPrescription.Location = new System.Drawing.Point(126, 12);
            this.txtPrixPrescription.Name = "txtPrixPrescription";
            this.txtPrixPrescription.Size = new System.Drawing.Size(100, 20);
            this.txtPrixPrescription.TabIndex = 29;
            // 
            // WIZZ05
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 152);
            this.Controls.Add(this.txtPrixPrescription);
            this.Controls.Add(this.txtNbRenouvellementPrescription);
            this.Controls.Add(this.lblNbRenouvellementPrescription);
            this.Controls.Add(this.lblPrixPrescription);
            this.Controls.Add(this.gbPharmacien);
            this.Controls.Add(this.btnCancelPrescription);
            this.Controls.Add(this.btnTerminerPrescription);
            this.Controls.Add(this.btnPrecedentPrescription);
            this.Name = "WIZZ05";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Assitant Prescription (Étape fin)";
            this.gbPharmacien.ResumeLayout(false);
            this.gbPharmacien.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancelPrescription;
        private System.Windows.Forms.Button btnTerminerPrescription;
        private System.Windows.Forms.Button btnPrecedentPrescription;
        private System.Windows.Forms.GroupBox gbPharmacien;
        private System.Windows.Forms.Label lblNumLicencePharmacien;
        private System.Windows.Forms.Label lblPrenomPharamcien;
        private System.Windows.Forms.Label lblNomPharmacien;
        private System.Windows.Forms.TextBox txtNumLicencePharmacien;
        private System.Windows.Forms.TextBox txtPrenomPharmacien;
        private System.Windows.Forms.TextBox txtNomPharmacien;
        private System.Windows.Forms.Label lblPrixPrescription;
        private System.Windows.Forms.Label lblNbRenouvellementPrescription;
        private System.Windows.Forms.TextBox txtNbRenouvellementPrescription;
        private System.Windows.Forms.TextBox txtPrixPrescription;
    }
}