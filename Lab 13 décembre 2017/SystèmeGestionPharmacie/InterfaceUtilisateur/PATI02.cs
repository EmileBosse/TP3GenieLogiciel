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
    public partial class PATI02 : Form
    {
        public PATI02()
        {
            InitializeComponent();
        }


        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            var dlgPati = (PATI01)Tag;
            dlgPati.Show();
            Close();
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            PatientMapper pM = new PatientMapper();
            Patient p = new Patient
            {
                NuméroAssuranceMaladie = txtNAS.Text,
                Nom = txtNomPatient.Text,
                Prénom = txtPrenomPatient.Text,
                Adresse = txtAdressePatient.Text,
                NuméroTéléphone = txtTelephonePatient.Text,
                DateNaissance = dateNaissance.Value
            };
            if (pM.Insert(p) > 0)
            {
                System.Windows.Forms.MessageBox.Show("Succès ! Patient ajouté !");
                var dlgPati = (PATI01)Tag;
                dlgPati.Show();
                Close();
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Erreur ! Patient non ajouté !");
            }
        }
    }
}
