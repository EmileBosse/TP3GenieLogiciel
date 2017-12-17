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
using SystèmeGestionPharmacie.InterfaceUtilisateur;

namespace SystèmeGestionPharmacie
{
    public partial class MEDE01 : Form
    {
        public MEDE01()
        {
            InitializeComponent();
        }

        private void btnRetour_Click(object sender, EventArgs e)
        {
            var dlgAccueil = (ACCE02)Tag;
            dlgAccueil.Show();
            Close();
        }

        private void btnAjouterMedecin_Click(object sender, EventArgs e)
        {

        }

        private void btnRechercher_Click(object sender, EventArgs e)
        {
            lbMedecins.Items.Clear();
            MédecinMapper mM = new MédecinMapper();
            List<Médecin> ms = mM.Find(txtRechercheNumero.Text, txtRechercheNom.Text, txtRecherchePrenom.Text);

            if (ms != null)
            {
                for (int i = 0; i < ms.Count; i++)
                {
                    lbMedecins.Items.Add(ms[i].Nom+" "+ms[i].Prénom);
                }
            }
            else
            {
                MessageBox.Show("Aucun résultat.");
            }
        }
    }
}
