using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SystèmeGestionPharmacie.InterfaceUtilisateur;
using SystèmeGestionPharmacie.Logique;
using SystèmeGestionPharmacie.DAL.MSSQL;

namespace SystèmeGestionPharmacie
{
    public partial class PATI01 : Form
    {
        private List<Patient> lp;

        public PATI01()
        {
            InitializeComponent();
            enabled(false);
            search("", "");
        }

        private void btbRetour_Click(object sender, EventArgs e)
        {
            var dlgAccueil = (ACCE02)Tag;
            dlgAccueil.Show();
            Close();
        }

        private void btnAjouterPatient_Click(object sender, EventArgs e)
        {
            PATI02 dlgAjoutPatient = new PATI02 { Tag = this };
            dlgAjoutPatient.Show(this);
            Hide();
        }

        private void btnRechercher_Click(object sender, EventArgs e)
        {
            search(txtRechercheNom.Text, txtRecherchePrenom.Text);
        }

        private void btnModifierPatient_Click(object sender, EventArgs e)
        {
            if (btnModifierPatient.Text == "Modifier")
            {
                btnModifierPatient.Text = "Confirmer";
                enabled(true);
                lbPatients.Enabled = false;
                btnAjouterPatient.Enabled = false;
            }
            else if (btnModifierPatient.Text == "Confirmer")
            {
                btnModifierPatient.Text = "Modifier";
                enabled(false);
                lbPatients.Enabled = true;
                btnAjouterPatient.Enabled = true;

                PatientMapper pM = new PatientMapper();
                Patient p = new Patient
                {
                    NuméroAssuranceMaladie = txtNAS.Text,
                    Nom = txtNomPatients.Text,
                    Prénom = txtPrenomPatient.Text,
                    Adresse = txtAdressePatient.Text,
                    NuméroTéléphone = txtTelephonePatient.Text,
                    DateNaissance = dateNaissance.Value
                };
                pM.Delete(lp[lbPatients.SelectedIndex]);
                pM.Insert(p);
                search(txtRechercheNom.Text,txtRecherchePrenom.Text);
            }
            
        }

        private void lbPatients_SelectedIndexChanged(object sender, EventArgs e)
        {
            remplirChampInfo(lp[lbPatients.SelectedIndex]);
            btnModifierPatient.Enabled = true;
        }

        //utils fonction info

        public void search(String nom, String prenom)
        {
            PatientMapper pM = new PatientMapper();
            lp = pM.Find(nom, prenom);
            if (Util.isNULL(lp))
            {
                labelRecherche.Text = "Aucun patient trouvé";
            }
            else
            {
                lbPatients.Items.Clear();
                for (int i = 0; i < lp.Count(); i++)
                {
                    lbPatients.Items.Add((i + 1).ToString() + "    " + (lp.ElementAt(i)).Nom + " " + (lp.ElementAt(i)).Prénom + " " + (lp.ElementAt(i)).NuméroAssuranceMaladie);
                }
                if (lbPatients.Items.Count > 0)
                    lbPatients.SetSelected(0, true);
            }
        }

        private void enabled(bool b)
        {
            txtNAS.Enabled = b;
            txtNomPatients.Enabled = b;
            txtPrenomPatient.Enabled = b;
            txtAdressePatient.Enabled = b;
            txtTelephonePatient.Enabled = b;
            dateNaissance.Enabled = b;
            chbPatientActif.Enabled = b;
        }

        private void viderChampInfo()
        {
            txtNAS.Text = "";
            txtAdressePatient.Text = "";
            txtNomPatients.Text = "";
            txtPrenomPatient.Text = "";
            txtTelephonePatient.Text = "";
            dateNaissance.Text = "";
            chbPatientActif.Checked = false;
        }

        private void remplirChampInfo(Patient p)
        {
            txtNAS.Text = p.NuméroAssuranceMaladie;
            txtAdressePatient.Text = p.Adresse;
            txtNomPatients.Text = p.Nom;
            txtPrenomPatient.Text = p.Prénom;
            txtTelephonePatient.Text = p.NuméroTéléphone;
            dateNaissance.Value = p.DateNaissance;
            chbPatientActif.Checked = false;
        }
    }
}
