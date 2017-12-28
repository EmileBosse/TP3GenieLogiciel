using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SystèmeGestionPharmacie.Logique;
using SystèmeGestionPharmacie.DAL.MSSQL;

namespace SystèmeGestionPharmacie
{
    public partial class WIZZ02 : Form
    {
        WIZZ01 creator;
        DateTime datePrescription;
        Médecin medecinPrescription;

        public WIZZ02(WIZZ01 last)
        {
            creator = last;
            InitializeComponent();
            enabled(false);
            btnAjoutNvMedecin.Enabled = false;
            btnSuivantMed.Enabled = false;
        }

        public void CloseCreator()
        {
            creator.CloseCreator();
            creator.Close();
        }

        private void btnPrecedentMed_Click(object sender, EventArgs e)
        {
            // PRECEDENT = WIZZ01
            creator.Show();
            Hide();
        }

        private void btnSuivantMed_Click(object sender, EventArgs e)
        {
            // SUIVANT = WIZZ03
            datePrescription = txtDate.Value;
            WIZZ03 c = new WIZZ03(this) { Tag = this };
            c.Show(this);
            Hide();
        }

        private void btnCancelMed_Click(object sender, EventArgs e)
        {
            CloseCreator();
            Close();
        }

        private void btnAjoutNvMedecin_Click(object sender, EventArgs e)
        {
            if (btnAjoutNvMedecin.Text == "Ajouter Nouveau Médecin")
            {
                btnAjoutNvMedecin.Text = "Confirmer Nouveau Médecin";
                enabled(true);
            }
            else if (btnAjoutNvMedecin.Text == "Confirmer Nouveau Médecin")
            {
                btnAjoutNvMedecin.Text = "Ajouter Nouveau Médecin";
                enabled(false);
                btnAjoutNvMedecin.Enabled = false;
                MédecinMapper mM = new MédecinMapper();
                Médecin m = new Médecin
                {
                    NuméroLicense = txtNumLicenceMed.Text,
                    Nom = txtNomMed.Text,
                    Prénom = txtPrenomMed.Text,
                    Adresse = txtAdresseMed.Text,
                    NuméroTéléphone = txtNoTelMed.Text
                };
                if(mM.Insert(m) > 0)
                {
                    btnSuivantMed.Enabled = true;
                    medecinPrescription = m;
                }
            }
        }

        // utils fonction info

        private void search(String numeroLicense)
        {
            MédecinMapper mM = new MédecinMapper();
            Médecin m = mM.Find(numeroLicense);
            if(m == null)
            {
                viderChampInfo();
                lblNbResultat.Text = "Aucun médecin trouvé";
                btnAjoutNvMedecin.Enabled = true;
            }
            else
            {
                lblNbResultat.Text = "";
                remplirChampInfo(m);
                medecinPrescription = m;
            }
        }
        
        private void enabled(bool b)
        {
            txtNumLicenceMed.Enabled = b;
            txtNomMed.Enabled = b;
            txtPrenomMed.Enabled = b;
            txtAdresseMed.Enabled = b;
            txtNoTelMed.Enabled = b;
        }

        private void viderChampInfo()
        {
            txtNumLicenceMed.Text = "";
            txtNomMed.Text = "";
            txtPrenomMed.Text = "";
            txtAdresseMed.Text = "";
            txtNoTelMed.Text = "";
        }

        private void remplirChampInfo(Médecin m)
        {
            txtNumLicenceMed.Text = m.NuméroLicense;
            txtNomMed.Text = m.Nom;
            txtPrenomMed.Text = m.Prénom;
            txtAdresseMed.Text = m.Adresse;
            txtNoTelMed.Text = m.NuméroTéléphone;
        }
    }
}
