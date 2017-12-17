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
            PATI02 dlgAjoutPatient = new PATI02 { Tag = this };
            dlgAjoutPatient.Show(this);
            Hide();
        }
    }
}
