﻿using System;
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
        public PATI01()
        {
            InitializeComponent();
        }

        private void btbRetour_Click(object sender, EventArgs e)
        {
            var dlgAccueil = (ACCE02)Tag;
            dlgAccueil.Show();
            Close();
        }

        private void btnAjouterPatient_Click(object sender, EventArgs e)
        {
            PATI02 dlgAjoutPatient = new PATI02 {Tag = this};
            dlgAjoutPatient.Show(this);
            Hide();
        }

        private void btnRechercher_Click(object sender, EventArgs e)
        {
            PatientMapper pM = new PatientMapper();
            Patient p = pM.Find(txtRechercheNom.Text, txtRecherchePrenom.Text);
            if(Util.isNULL(p))
            {
                labelRecherche.Text = "Aucun patient trouvé";
            }
            else
            {
                txtNAS.Text = p.NuméroAssuranceMaladie;
                txtNomPatients.Text = p.Nom;
                txtPrenomPatient.Text = p.Prénom;
                txtAdressePatient.Text = p.Adresse;
                txtTelephonePatient.Text = p.NuméroTéléphone;
                dateNaissance.Value = p.DateNaissance;
            }

        }
    }
}
