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
    public partial class PHAR02 : Form
    {
        public PHAR02()
        {
            InitializeComponent();
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            var dlgPhar = (PHAR01)Tag;
            dlgPhar.Show();
            Close();
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            PharmacieMapper pM = new PharmacieMapper();
            Pharmacie p = new Pharmacie
            {
                Numéro = txtNumeroPharmacie.Text,
                Nom = txtNomPharmacie.Text,
                NomRésponsable = txtResponsablePharmacie.Text,
                Adresse = txtAdressePharmacie.Text,
                NuméroTéléphone = txtTelephonePharmacie.Text,
            };
            if (pM.Insert(p) > 0)
            {
                System.Windows.Forms.MessageBox.Show("Succès ! Pharmacie ajouté !");
                var dlgPhar = (PHAR01)Tag;
                dlgPhar.Show();
                Close();
                dlgPhar.Search("", "");
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Erreur ! Pharmacie non ajouté !");
            }
        }
    }
}
