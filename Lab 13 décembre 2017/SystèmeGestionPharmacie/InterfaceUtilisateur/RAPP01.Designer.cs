namespace SystèmeGestionPharmacie
{
    partial class RAPP01
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
            this.cmbRapport = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpDateDebut = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpDateFin = new System.Windows.Forms.DateTimePicker();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.btnGenerer = new System.Windows.Forms.Button();
            this.lbRapport = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // cmbRapport
            // 
            this.cmbRapport.FormattingEnabled = true;
            this.cmbRapport.Items.AddRange(new object[] {
            "Rupture de stocks"});
            this.cmbRapport.Location = new System.Drawing.Point(387, 29);
            this.cmbRapport.Name = "cmbRapport";
            this.cmbRapport.Size = new System.Drawing.Size(232, 21);
            this.cmbRapport.TabIndex = 0;
            this.cmbRapport.Text = "Rupture de stocks";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(337, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Rapport";
            // 
            // dtpDateDebut
            // 
            this.dtpDateDebut.Location = new System.Drawing.Point(387, 56);
            this.dtpDateDebut.Name = "dtpDateDebut";
            this.dtpDateDebut.Size = new System.Drawing.Size(232, 20);
            this.dtpDateDebut.TabIndex = 2;
            this.dtpDateDebut.Value = new System.DateTime(2017, 11, 7, 0, 0, 0, 0);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(321, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Date début";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(337, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Date fin";
            // 
            // dtpDateFin
            // 
            this.dtpDateFin.Location = new System.Drawing.Point(387, 82);
            this.dtpDateFin.Name = "dtpDateFin";
            this.dtpDateFin.Size = new System.Drawing.Size(232, 20);
            this.dtpDateFin.TabIndex = 4;
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Location = new System.Drawing.Point(544, 108);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(75, 23);
            this.btnAnnuler.TabIndex = 6;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            // 
            // btnGenerer
            // 
            this.btnGenerer.Location = new System.Drawing.Point(463, 108);
            this.btnGenerer.Name = "btnGenerer";
            this.btnGenerer.Size = new System.Drawing.Size(75, 23);
            this.btnGenerer.TabIndex = 7;
            this.btnGenerer.Text = "Générer";
            this.btnGenerer.UseVisualStyleBackColor = true;
            // 
            // lbRapport
            // 
            this.lbRapport.FormattingEnabled = true;
            this.lbRapport.Items.AddRange(new object[] {
            "Antidépresseur 500mg,",
            "Ibuprophène"});
            this.lbRapport.Location = new System.Drawing.Point(12, 29);
            this.lbRapport.Name = "lbRapport";
            this.lbRapport.Size = new System.Drawing.Size(303, 316);
            this.lbRapport.TabIndex = 8;
            // 
            // RAPP01
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 359);
            this.Controls.Add(this.lbRapport);
            this.Controls.Add(this.btnGenerer);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtpDateFin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtpDateDebut);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbRapport);
            this.Name = "RAPP01";
            this.Text = "Génération de rapports";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbRapport;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpDateDebut;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpDateFin;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.Button btnGenerer;
        private System.Windows.Forms.ListBox lbRapport;
    }
}