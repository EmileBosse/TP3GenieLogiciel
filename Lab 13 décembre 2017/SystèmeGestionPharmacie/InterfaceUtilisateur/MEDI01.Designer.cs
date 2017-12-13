namespace SystèmeGestionPharmacie
{
    partial class MEDI01
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.chbMedicamentActif = new System.Windows.Forms.CheckBox();
            this.udnUnitePosologie = new System.Windows.Forms.NumericUpDown();
            this.udnJoursPosologie = new System.Windows.Forms.NumericUpDown();
            this.lblPendantPosologie = new System.Windows.Forms.Label();
            this.txtPrixVente = new System.Windows.Forms.TextBox();
            this.txtEndroit = new System.Windows.Forms.TextBox();
            this.txtManiereLivraison = new System.Windows.Forms.TextBox();
            this.txtNomMedicament = new System.Windows.Forms.TextBox();
            this.txtNumeroMedicament = new System.Windows.Forms.TextBox();
            this.lblPrixVente = new System.Windows.Forms.Label();
            this.lblPosologie = new System.Windows.Forms.Label();
            this.lblEndroit = new System.Windows.Forms.Label();
            this.lblManiereLivraison = new System.Windows.Forms.Label();
            this.lblNom = new System.Windows.Forms.Label();
            this.lblNumero = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btnRuptureStock = new System.Windows.Forms.Button();
            this.btnModifierMedicament = new System.Windows.Forms.Button();
            this.btnAjouterMedicament = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.udnUnitePosologie)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udnJoursPosologie)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Items.AddRange(new object[] {
            "1\tAcétaminophène,",
            "2 \tIbuprophène"});
            this.listBox1.Location = new System.Drawing.Point(12, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(308, 355);
            this.listBox1.TabIndex = 34;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Location = new System.Drawing.Point(345, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(381, 107);
            this.panel1.TabIndex = 40;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(98, 73);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 44;
            this.button1.Text = "Rechercher";
            this.button1.UseVisualStyleBackColor = true;
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
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(98, 47);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(208, 20);
            this.textBox2.TabIndex = 41;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(98, 21);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(70, 20);
            this.textBox1.TabIndex = 40;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.chbMedicamentActif);
            this.panel2.Controls.Add(this.udnUnitePosologie);
            this.panel2.Controls.Add(this.udnJoursPosologie);
            this.panel2.Controls.Add(this.lblPendantPosologie);
            this.panel2.Controls.Add(this.txtPrixVente);
            this.panel2.Controls.Add(this.txtEndroit);
            this.panel2.Controls.Add(this.txtManiereLivraison);
            this.panel2.Controls.Add(this.txtNomMedicament);
            this.panel2.Controls.Add(this.txtNumeroMedicament);
            this.panel2.Controls.Add(this.lblPrixVente);
            this.panel2.Controls.Add(this.lblPosologie);
            this.panel2.Controls.Add(this.lblEndroit);
            this.panel2.Controls.Add(this.lblManiereLivraison);
            this.panel2.Controls.Add(this.lblNom);
            this.panel2.Controls.Add(this.lblNumero);
            this.panel2.Location = new System.Drawing.Point(345, 125);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(381, 210);
            this.panel2.TabIndex = 41;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(334, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 49;
            this.label3.Text = "jour(s)";
            // 
            // chbMedicamentActif
            // 
            this.chbMedicamentActif.AutoSize = true;
            this.chbMedicamentActif.Location = new System.Drawing.Point(98, 175);
            this.chbMedicamentActif.Name = "chbMedicamentActif";
            this.chbMedicamentActif.Size = new System.Drawing.Size(47, 17);
            this.chbMedicamentActif.TabIndex = 48;
            this.chbMedicamentActif.Text = "Actif";
            this.chbMedicamentActif.UseVisualStyleBackColor = true;
            // 
            // udnUnitePosologie
            // 
            this.udnUnitePosologie.Location = new System.Drawing.Point(98, 149);
            this.udnUnitePosologie.Name = "udnUnitePosologie";
            this.udnUnitePosologie.Size = new System.Drawing.Size(70, 20);
            this.udnUnitePosologie.TabIndex = 47;
            // 
            // udnJoursPosologie
            // 
            this.udnJoursPosologie.Location = new System.Drawing.Point(266, 149);
            this.udnJoursPosologie.Name = "udnJoursPosologie";
            this.udnJoursPosologie.Size = new System.Drawing.Size(62, 20);
            this.udnJoursPosologie.TabIndex = 46;
            // 
            // lblPendantPosologie
            // 
            this.lblPendantPosologie.AutoSize = true;
            this.lblPendantPosologie.Location = new System.Drawing.Point(174, 151);
            this.lblPendantPosologie.Name = "lblPendantPosologie";
            this.lblPendantPosologie.Size = new System.Drawing.Size(86, 13);
            this.lblPendantPosologie.TabIndex = 45;
            this.lblPendantPosologie.Text = "unité(s), pendant";
            // 
            // txtPrixVente
            // 
            this.txtPrixVente.Location = new System.Drawing.Point(98, 123);
            this.txtPrixVente.Name = "txtPrixVente";
            this.txtPrixVente.Size = new System.Drawing.Size(100, 20);
            this.txtPrixVente.TabIndex = 44;
            // 
            // txtEndroit
            // 
            this.txtEndroit.Location = new System.Drawing.Point(98, 97);
            this.txtEndroit.Name = "txtEndroit";
            this.txtEndroit.Size = new System.Drawing.Size(100, 20);
            this.txtEndroit.TabIndex = 43;
            // 
            // txtManiereLivraison
            // 
            this.txtManiereLivraison.Location = new System.Drawing.Point(98, 71);
            this.txtManiereLivraison.Name = "txtManiereLivraison";
            this.txtManiereLivraison.Size = new System.Drawing.Size(208, 20);
            this.txtManiereLivraison.TabIndex = 42;
            // 
            // txtNomMedicament
            // 
            this.txtNomMedicament.Location = new System.Drawing.Point(98, 45);
            this.txtNomMedicament.Name = "txtNomMedicament";
            this.txtNomMedicament.Size = new System.Drawing.Size(208, 20);
            this.txtNomMedicament.TabIndex = 41;
            // 
            // txtNumeroMedicament
            // 
            this.txtNumeroMedicament.Location = new System.Drawing.Point(98, 19);
            this.txtNumeroMedicament.Name = "txtNumeroMedicament";
            this.txtNumeroMedicament.Size = new System.Drawing.Size(70, 20);
            this.txtNumeroMedicament.TabIndex = 40;
            // 
            // lblPrixVente
            // 
            this.lblPrixVente.AutoSize = true;
            this.lblPrixVente.Location = new System.Drawing.Point(37, 126);
            this.lblPrixVente.Name = "lblPrixVente";
            this.lblPrixVente.Size = new System.Drawing.Size(54, 13);
            this.lblPrixVente.TabIndex = 39;
            this.lblPrixVente.Text = "Prix vente";
            // 
            // lblPosologie
            // 
            this.lblPosologie.AutoSize = true;
            this.lblPosologie.Location = new System.Drawing.Point(38, 151);
            this.lblPosologie.Name = "lblPosologie";
            this.lblPosologie.Size = new System.Drawing.Size(53, 13);
            this.lblPosologie.TabIndex = 38;
            this.lblPosologie.Text = "Posologie";
            // 
            // lblEndroit
            // 
            this.lblEndroit.AutoSize = true;
            this.lblEndroit.Location = new System.Drawing.Point(51, 100);
            this.lblEndroit.Name = "lblEndroit";
            this.lblEndroit.Size = new System.Drawing.Size(40, 13);
            this.lblEndroit.TabIndex = 37;
            this.lblEndroit.Text = "Endroit";
            // 
            // lblManiereLivraison
            // 
            this.lblManiereLivraison.AutoSize = true;
            this.lblManiereLivraison.Location = new System.Drawing.Point(5, 74);
            this.lblManiereLivraison.Name = "lblManiereLivraison";
            this.lblManiereLivraison.Size = new System.Drawing.Size(86, 13);
            this.lblManiereLivraison.TabIndex = 36;
            this.lblManiereLivraison.Text = "Manière livraison";
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
            // btnRuptureStock
            // 
            this.btnRuptureStock.Location = new System.Drawing.Point(513, 341);
            this.btnRuptureStock.Name = "btnRuptureStock";
            this.btnRuptureStock.Size = new System.Drawing.Size(102, 23);
            this.btnRuptureStock.TabIndex = 44;
            this.btnRuptureStock.Text = "Rapports";
            this.btnRuptureStock.UseVisualStyleBackColor = true;
            // 
            // btnModifierMedicament
            // 
            this.btnModifierMedicament.Location = new System.Drawing.Point(429, 341);
            this.btnModifierMedicament.Name = "btnModifierMedicament";
            this.btnModifierMedicament.Size = new System.Drawing.Size(75, 23);
            this.btnModifierMedicament.TabIndex = 43;
            this.btnModifierMedicament.Text = "Modifier";
            this.btnModifierMedicament.UseVisualStyleBackColor = true;
            // 
            // btnAjouterMedicament
            // 
            this.btnAjouterMedicament.Location = new System.Drawing.Point(344, 341);
            this.btnAjouterMedicament.Name = "btnAjouterMedicament";
            this.btnAjouterMedicament.Size = new System.Drawing.Size(75, 23);
            this.btnAjouterMedicament.TabIndex = 42;
            this.btnAjouterMedicament.Text = "Ajouter";
            this.btnAjouterMedicament.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(651, 341);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 61;
            this.button2.Text = "Retour";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // MEDI01
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 376);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnRuptureStock);
            this.Controls.Add(this.btnModifierMedicament);
            this.Controls.Add(this.btnAjouterMedicament);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.listBox1);
            this.Name = "MEDI01";
            this.Text = "Gestion des médicaments";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.udnUnitePosologie)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udnJoursPosologie)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.CheckBox chbMedicamentActif;
        private System.Windows.Forms.NumericUpDown udnUnitePosologie;
        private System.Windows.Forms.NumericUpDown udnJoursPosologie;
        private System.Windows.Forms.Label lblPendantPosologie;
        private System.Windows.Forms.TextBox txtPrixVente;
        private System.Windows.Forms.TextBox txtEndroit;
        private System.Windows.Forms.TextBox txtManiereLivraison;
        private System.Windows.Forms.TextBox txtNomMedicament;
        private System.Windows.Forms.TextBox txtNumeroMedicament;
        private System.Windows.Forms.Label lblPrixVente;
        private System.Windows.Forms.Label lblPosologie;
        private System.Windows.Forms.Label lblEndroit;
        private System.Windows.Forms.Label lblManiereLivraison;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.Label lblNumero;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btnRuptureStock;
        private System.Windows.Forms.Button btnModifierMedicament;
        private System.Windows.Forms.Button btnAjouterMedicament;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
    }
}