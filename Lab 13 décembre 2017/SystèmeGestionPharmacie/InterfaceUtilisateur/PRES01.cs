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
    public partial class PRES01 : Form
    {
        public PRES01()
        {
            InitializeComponent();
        }

        private void btnRetour_Click(object sender, EventArgs e)
        {
            var dlgAccueil = (ACCE02)Tag;
            dlgAccueil.Show();
            Close();
        }

        private void btnNouvellePrescription_Click(object sender, EventArgs e)
        {
            var dlgWizard = new WIZZ01() { Tag = this } ;
            dlgWizard.Show();
            Hide();
        }

        private void btnRecherche_Click(object sender, EventArgs e)
        {

        }

        // utils fonction info

        private void remplirChampInfo(Prescription p)
        {
            txtDatePrescription.Value = p.DatePresciption;
            txtNumeroPrescription.Text = p.Numéro;
            //txtPatientPrescription.Text = 
            //txtMedecinPrescription.Text = 
            for(int i = 0; i < p.ListMédicament.Count; i++)
            {
                //lbMedicamentsPrescription.Items.Add(p.ListMédicament[i].Nom + "  " + p.ListMédicament[i].PosologieMédicament.NombreUnitésParJour + "  " + p.ListMédicament[i].PosologieMédicament.NombreJours + "  " + p.RenouvellementTotal + "(" + (p.RenouvellementTotal-p.Renouvellement) + ")");
            }
        }
    }
}
