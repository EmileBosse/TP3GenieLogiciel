using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SystèmeGestionPharmacie.DAL.MSSQL;
using SystèmeGestionPharmacie.InterfaceUtilisateur;
using SystèmeGestionPharmacie.Logique;

namespace SystèmeGestionPharmacie
{
    public partial class MEDI01 : Form
    {
        private List<DataRow> listeMed { get; set; }

        public MEDI01()
        {
            InitializeComponent();
            MédicamentMapper medMap = new MédicamentMapper();

            listeMed = medMap.FindAll().AsEnumerable().ToList();
            foreach (var med in listeMed)
                lbMedicaments.Items.Add(med[1] + "\t" + med[2]);
        }

        private void btnRetour_Click(object sender, EventArgs e)
        {
            var dlgAccueil = (ACCE02) Tag;
            dlgAccueil.Show();
            Close();
        }

        private void btnAjouterMedicament_Click(object sender, EventArgs e)
        {
            MEDI02 dlgAjoutMedicament = new MEDI02 {Tag = this};
            dlgAjoutMedicament.Show(this);
            Hide();
        }

        private void lbMedicaments_SelectedIndexChanged(object sender, EventArgs e)
        {
            var medoc = listeMed[lbMedicaments.SelectedIndex];

            txtNumeroMedicament.Text = medoc[1].ToString();
            txtNomMedicament.Text = medoc[2].ToString();
            txtManiereLivraison.Text = medoc[3].ToString();
            txtEndroit.Text = medoc[4].ToString();
            txtPrixVente.Text = medoc[5].ToString();
            txtQuantiteStock.Text = medoc[6].ToString();
            udnUnitePosologie.Value = int.Parse(medoc[7].ToString());
            udnJoursPosologie.Value = int.Parse(medoc[8].ToString());
        }
    }
}
