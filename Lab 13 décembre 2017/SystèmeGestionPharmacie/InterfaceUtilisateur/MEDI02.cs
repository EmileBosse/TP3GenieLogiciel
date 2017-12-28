using System;
using System.Windows.Forms;
using SystèmeGestionPharmacie.DAL;
using SystèmeGestionPharmacie.DAL.MSSQL;
using SystèmeGestionPharmacie.Logique;

namespace SystèmeGestionPharmacie.InterfaceUtilisateur
{
    public partial class MEDI02 : Form
    {
        public MEDI02()
        {
            InitializeComponent();
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            var dlgMedi = (MEDI01)Tag;
            dlgMedi.Show();
            Close();
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            // Initialisation
            Médicament med = new Médicament();
            Posologie pos = new Posologie();

            // Assignation
            med.Nom = txtNomMedicament.Text;
            med.Endroit = txtEndroit.Text;
            med.ManièreLivraison = txtManiereLivraison.Text;
            med.Numéro = txtNumeroMedicament.Text;
            med.QuantitéStock = Convert.ToDecimal(txtQuantiteStock.Text);
            med.PrixVente = Convert.ToDecimal(txtPrixVente.Text);
            pos.NombreJours = (int)udnJoursPosologie.Value;
            pos.NombreUnitésParJour = (int)udnUnitePosologie.Value;
            med.PosologieMédicament = pos;

            // Insertin dans la base de données
            MédicamentMapper medMap = new MédicamentMapper();
            medMap.Insert(med);

            // Fermeture de la fenêtre
            var dlgMedi = (MEDI01)Tag;
            dlgMedi.Show();
            Close();
        }
    }
}
