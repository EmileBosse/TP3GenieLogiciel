namespace SystèmeGestionPharmacie
{
    partial class PHAR01
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
            this.btnModifierPharmacie = new System.Windows.Forms.Button();
            this.btnAjouterPharmacie = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.chbPharmacieActif = new System.Windows.Forms.CheckBox();
            this.txtTelephonePharmacie = new System.Windows.Forms.TextBox();
            this.txtAdressePharmacie = new System.Windows.Forms.TextBox();
            this.txtResponsablePharmacie = new System.Windows.Forms.TextBox();
            this.txtNomPharmacie = new System.Windows.Forms.TextBox();
            this.txtNumeroPharmacie = new System.Windows.Forms.TextBox();
            this.lblPrixVente = new System.Windows.Forms.Label();
            this.lblEndroit = new System.Windows.Forms.Label();
            this.lblManiereLivraison = new System.Windows.Forms.Label();
            this.lblNom = new System.Windows.Forms.Label();
            this.lblNumero = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelRecherche = new System.Windows.Forms.Label();
            this.btnRecherche = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtRechercheNom = new System.Windows.Forms.TextBox();
            this.txtRechercheNumero = new System.Windows.Forms.TextBox();
            this.lbPharmacies = new System.Windows.Forms.ListBox();
            this.btnRetour = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnModifierPharmacie
            // 
            this.btnModifierPharmacie.Location = new System.Drawing.Point(430, 310);
            this.btnModifierPharmacie.Name = "btnModifierPharmacie";
            this.btnModifierPharmacie.Size = new System.Drawing.Size(75, 23);
            this.btnModifierPharmacie.TabIndex = 59;
            this.btnModifierPharmacie.Text = "Modifier";
            this.btnModifierPharmacie.UseVisualStyleBackColor = true;
            this.btnModifierPharmacie.Click += new System.EventHandler(this.btnModifierPharmacie_Click);
            // 
            // btnAjouterPharmacie
            // 
            this.btnAjouterPharmacie.Location = new System.Drawing.Point(345, 310);
            this.btnAjouterPharmacie.Name = "btnAjouterPharmacie";
            this.btnAjouterPharmacie.Size = new System.Drawing.Size(75, 23);
            this.btnAjouterPharmacie.TabIndex = 58;
            this.btnAjouterPharmacie.Text = "Ajouter";
            this.btnAjouterPharmacie.UseVisualStyleBackColor = true;
            this.btnAjouterPharmacie.Click += new System.EventHandler(this.btnAjouterPharmacie_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.chbPharmacieActif);
            this.panel2.Controls.Add(this.txtTelephonePharmacie);
            this.panel2.Controls.Add(this.txtAdressePharmacie);
            this.panel2.Controls.Add(this.txtResponsablePharmacie);
            this.panel2.Controls.Add(this.txtNomPharmacie);
            this.panel2.Controls.Add(this.txtNumeroPharmacie);
            this.panel2.Controls.Add(this.lblPrixVente);
            this.panel2.Controls.Add(this.lblEndroit);
            this.panel2.Controls.Add(this.lblManiereLivraison);
            this.panel2.Controls.Add(this.lblNom);
            this.panel2.Controls.Add(this.lblNumero);
            this.panel2.Location = new System.Drawing.Point(345, 125);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(381, 179);
            this.panel2.TabIndex = 57;
            // 
            // chbPharmacieActif
            // 
            this.chbPharmacieActif.AutoSize = true;
            this.chbPharmacieActif.Location = new System.Drawing.Point(98, 149);
            this.chbPharmacieActif.Name = "chbPharmacieActif";
            this.chbPharmacieActif.Size = new System.Drawing.Size(47, 17);
            this.chbPharmacieActif.TabIndex = 48;
            this.chbPharmacieActif.Text = "Actif";
            this.chbPharmacieActif.UseVisualStyleBackColor = true;
            // 
            // txtTelephonePharmacie
            // 
            this.txtTelephonePharmacie.Location = new System.Drawing.Point(98, 123);
            this.txtTelephonePharmacie.Name = "txtTelephonePharmacie";
            this.txtTelephonePharmacie.Size = new System.Drawing.Size(100, 20);
            this.txtTelephonePharmacie.TabIndex = 44;
            // 
            // txtAdressePharmacie
            // 
            this.txtAdressePharmacie.Location = new System.Drawing.Point(98, 97);
            this.txtAdressePharmacie.Name = "txtAdressePharmacie";
            this.txtAdressePharmacie.Size = new System.Drawing.Size(208, 20);
            this.txtAdressePharmacie.TabIndex = 43;
            // 
            // txtResponsablePharmacie
            // 
            this.txtResponsablePharmacie.Location = new System.Drawing.Point(98, 71);
            this.txtResponsablePharmacie.Name = "txtResponsablePharmacie";
            this.txtResponsablePharmacie.Size = new System.Drawing.Size(208, 20);
            this.txtResponsablePharmacie.TabIndex = 42;
            // 
            // txtNomPharmacie
            // 
            this.txtNomPharmacie.Location = new System.Drawing.Point(98, 45);
            this.txtNomPharmacie.Name = "txtNomPharmacie";
            this.txtNomPharmacie.Size = new System.Drawing.Size(208, 20);
            this.txtNomPharmacie.TabIndex = 41;
            // 
            // txtNumeroPharmacie
            // 
            this.txtNumeroPharmacie.Location = new System.Drawing.Point(98, 19);
            this.txtNumeroPharmacie.Name = "txtNumeroPharmacie";
            this.txtNumeroPharmacie.Size = new System.Drawing.Size(70, 20);
            this.txtNumeroPharmacie.TabIndex = 40;
            // 
            // lblPrixVente
            // 
            this.lblPrixVente.AutoSize = true;
            this.lblPrixVente.Location = new System.Drawing.Point(33, 126);
            this.lblPrixVente.Name = "lblPrixVente";
            this.lblPrixVente.Size = new System.Drawing.Size(58, 13);
            this.lblPrixVente.TabIndex = 39;
            this.lblPrixVente.Text = "Téléphone";
            // 
            // lblEndroit
            // 
            this.lblEndroit.AutoSize = true;
            this.lblEndroit.Location = new System.Drawing.Point(46, 100);
            this.lblEndroit.Name = "lblEndroit";
            this.lblEndroit.Size = new System.Drawing.Size(45, 13);
            this.lblEndroit.TabIndex = 37;
            this.lblEndroit.Text = "Adresse";
            // 
            // lblManiereLivraison
            // 
            this.lblManiereLivraison.AutoSize = true;
            this.lblManiereLivraison.Location = new System.Drawing.Point(22, 74);
            this.lblManiereLivraison.Name = "lblManiereLivraison";
            this.lblManiereLivraison.Size = new System.Drawing.Size(69, 13);
            this.lblManiereLivraison.TabIndex = 36;
            this.lblManiereLivraison.Text = "Responsable";
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Location = new System.Drawing.Point(62, 48);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(29, 13);
            this.lblNom.TabIndex = 35;
            this.lblNom.Text = "Nom";
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(47, 22);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(44, 13);
            this.lblNumero.TabIndex = 34;
            this.lblNumero.Text = "Numéro";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.labelRecherche);
            this.panel1.Controls.Add(this.btnRecherche);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtRechercheNom);
            this.panel1.Controls.Add(this.txtRechercheNumero);
            this.panel1.Location = new System.Drawing.Point(345, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(381, 107);
            this.panel1.TabIndex = 56;
            // 
            // labelRecherche
            // 
            this.labelRecherche.AutoSize = true;
            this.labelRecherche.Location = new System.Drawing.Point(179, 78);
            this.labelRecherche.Name = "labelRecherche";
            this.labelRecherche.Size = new System.Drawing.Size(0, 13);
            this.labelRecherche.TabIndex = 45;
            // 
            // btnRecherche
            // 
            this.btnRecherche.Location = new System.Drawing.Point(98, 73);
            this.btnRecherche.Name = "btnRecherche";
            this.btnRecherche.Size = new System.Drawing.Size(75, 23);
            this.btnRecherche.TabIndex = 44;
            this.btnRecherche.Text = "Rechercher";
            this.btnRecherche.UseVisualStyleBackColor = true;
            this.btnRecherche.Click += new System.EventHandler(this.btnRecherche_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(62, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 43;
            this.label2.Text = "Nom";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 42;
            this.label1.Text = "Numéro";
            // 
            // txtRechercheNom
            // 
            this.txtRechercheNom.Location = new System.Drawing.Point(98, 47);
            this.txtRechercheNom.Name = "txtRechercheNom";
            this.txtRechercheNom.Size = new System.Drawing.Size(208, 20);
            this.txtRechercheNom.TabIndex = 41;
            // 
            // txtRechercheNumero
            // 
            this.txtRechercheNumero.Location = new System.Drawing.Point(98, 21);
            this.txtRechercheNumero.Name = "txtRechercheNumero";
            this.txtRechercheNumero.Size = new System.Drawing.Size(70, 20);
            this.txtRechercheNumero.TabIndex = 40;
            // 
            // lbPharmacies
            // 
            this.lbPharmacies.FormattingEnabled = true;
            this.lbPharmacies.Location = new System.Drawing.Point(12, 12);
            this.lbPharmacies.Name = "lbPharmacies";
            this.lbPharmacies.Size = new System.Drawing.Size(308, 329);
            this.lbPharmacies.TabIndex = 55;
            this.lbPharmacies.SelectedIndexChanged += new System.EventHandler(this.lbPharmacies_SelectedIndexChanged);
            // 
            // btnRetour
            // 
            this.btnRetour.Location = new System.Drawing.Point(651, 310);
            this.btnRetour.Name = "btnRetour";
            this.btnRetour.Size = new System.Drawing.Size(75, 23);
            this.btnRetour.TabIndex = 60;
            this.btnRetour.Text = "Retour";
            this.btnRetour.UseVisualStyleBackColor = true;
            this.btnRetour.Click += new System.EventHandler(this.btnRetour_Click);
            // 
            // PHAR01
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 351);
            this.Controls.Add(this.btnRetour);
            this.Controls.Add(this.btnModifierPharmacie);
            this.Controls.Add(this.btnAjouterPharmacie);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbPharmacies);
            this.Name = "PHAR01";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestion de pharmacies";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnModifierPharmacie;
        private System.Windows.Forms.Button btnAjouterPharmacie;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.CheckBox chbPharmacieActif;
        private System.Windows.Forms.TextBox txtTelephonePharmacie;
        private System.Windows.Forms.TextBox txtAdressePharmacie;
        private System.Windows.Forms.TextBox txtResponsablePharmacie;
        private System.Windows.Forms.TextBox txtNomPharmacie;
        private System.Windows.Forms.TextBox txtNumeroPharmacie;
        private System.Windows.Forms.Label lblPrixVente;
        private System.Windows.Forms.Label lblEndroit;
        private System.Windows.Forms.Label lblManiereLivraison;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnRecherche;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRechercheNom;
        private System.Windows.Forms.TextBox txtRechercheNumero;
        private System.Windows.Forms.ListBox lbPharmacies;
        private System.Windows.Forms.Button btnRetour;
        private System.Windows.Forms.Label labelRecherche;
    }
}