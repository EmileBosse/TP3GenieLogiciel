using System;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace SystèmeGestionPharmacie.InterfaceUtilisateur
{
    public partial class ACCE02 : Form
    {
        public ACCE02()
        {
            InitializeComponent();
        }

        private void btnMedicaments_Click(object sender, EventArgs e)
        {
            MEDI01 dlgMedicaments = new MEDI01 {Tag = this};
            dlgMedicaments.Show(this);
            Hide();

        }

        private void btnMedecins_Click(object sender, EventArgs e)
        {
            MEDE01 dlgMedecins = new MEDE01 { Tag = this };
            dlgMedecins.Show();
            Hide();
        }

        private void btnPatients_Click(object sender, EventArgs e)
        {
            PATI01 dlgPatients = new PATI01 { Tag = this };
            dlgPatients.Show();
            Hide();
        }

        private void btnPharmacies_Click(object sender, EventArgs e)
        {
            PHAR01 dlgPharmacies = new PHAR01 { Tag = this };
            dlgPharmacies.Show();
            Hide();
        }

        private void btnPrescriptions_Click(object sender, EventArgs e)
        {
            PRES01 dlgPrescriptions = new PRES01 { Tag = this};
            dlgPrescriptions.Show();
            Hide();
        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
