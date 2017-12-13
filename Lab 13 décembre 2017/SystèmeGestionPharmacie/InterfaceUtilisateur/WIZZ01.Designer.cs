namespace SystèmeGestionPharmacie
{
    partial class WIZZ01
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
            this.btnNvlPrescription = new System.Windows.Forms.Button();
            this.btnRenouveler = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnNvlPrescription
            // 
            this.btnNvlPrescription.Location = new System.Drawing.Point(13, 58);
            this.btnNvlPrescription.Name = "btnNvlPrescription";
            this.btnNvlPrescription.Size = new System.Drawing.Size(150, 50);
            this.btnNvlPrescription.TabIndex = 0;
            this.btnNvlPrescription.Text = "Nouvelle Prescription";
            this.btnNvlPrescription.UseVisualStyleBackColor = true;
            this.btnNvlPrescription.Click += new System.EventHandler(this.btnNvlPrescription_Click);
            // 
            // btnRenouveler
            // 
            this.btnRenouveler.Location = new System.Drawing.Point(169, 58);
            this.btnRenouveler.Name = "btnRenouveler";
            this.btnRenouveler.Size = new System.Drawing.Size(150, 50);
            this.btnRenouveler.TabIndex = 1;
            this.btnRenouveler.Text = "Renouvellement";
            this.btnRenouveler.UseVisualStyleBackColor = true;
            this.btnRenouveler.Click += new System.EventHandler(this.btnRenouveler_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(80, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Voulez-vous faire un renouvellement";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(92, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "ou une nouvelle prescription?";
            // 
            // WIZZ01
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 120);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRenouveler);
            this.Controls.Add(this.btnNvlPrescription);
            this.Name = "WIZZ01";
            this.Text = "Assistant Prescription";
            this.Load += new System.EventHandler(this.WIZZ01_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNvlPrescription;
        private System.Windows.Forms.Button btnRenouveler;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}