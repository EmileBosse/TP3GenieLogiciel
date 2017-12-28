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
    public partial class PHAR01 : Form
    {
        private List<Pharmacie> lp;

        public PHAR01()
        {
            InitializeComponent();
            enabled(false);
            Search("", "");
        }

        private void btnRetour_Click(object sender, EventArgs e)
        {
            var dlgAccueil = (ACCE02)Tag;
            dlgAccueil.Show();
            Close();
        }

        private void btnRecherche_Click(object sender, EventArgs e)
        {
            Search(txtRechercheNumero.Text, txtRechercheNom.Text);
        }

        private void btnAjouterPharmacie_Click(object sender, EventArgs e)
        {
            PHAR02 dlgAjoutPharmacie = new PHAR02 { Tag = this };
            dlgAjoutPharmacie.Show(this);
            Hide();
        }

        private void btnModifierPharmacie_Click(object sender, EventArgs e)
        {
            if (btnModifierPharmacie.Text == "Modifier")
            {
                btnModifierPharmacie.Text = "Confirmer";
                enabled(true);
                lbPharmacies.Enabled = false;
                btnAjouterPharmacie.Enabled = false;
            }
            else if (btnModifierPharmacie.Text == "Confirmer")
            {
                btnModifierPharmacie.Text = "Modifier";
                enabled(false);
                lbPharmacies.Enabled = true;
                btnAjouterPharmacie.Enabled = true;

                PharmacieMapper pM = new PharmacieMapper();
                Pharmacie p = new Pharmacie
                {
                    Numéro = txtNumeroPharmacie.Text,
                    Nom = txtNomPharmacie.Text,
                    NomRésponsable = txtResponsablePharmacie.Text,
                    Adresse = txtAdressePharmacie.Text,
                    NuméroTéléphone = txtTelephonePharmacie.Text,
                };
                pM.Delete(lp[lbPharmacies.SelectedIndex]);
                pM.Insert(p);
                Search(txtRechercheNumero.Text, txtRechercheNom.Text);
            }
        }

        private void lbPharmacies_SelectedIndexChanged(object sender, EventArgs e)
        {
            remplirChampInfo(lp[lbPharmacies.SelectedIndex]);
            btnModifierPharmacie.Enabled = true;
        }

        // utils fonction

        public void Search(String numero, String nom)
        {
            PharmacieMapper pM = new PharmacieMapper();
            lp = pM.Find(numero, nom);
            if (Util.isNULL(lp))
            {
                labelRecherche.Text = "Aucune pharmacie trouvée";
            }
            else
            {
                labelRecherche.Text = "";
                lbPharmacies.Items.Clear();
                for (int i = 0; i < lp.Count(); i++)
                {
                    lbPharmacies.Items.Add((i + 1).ToString() + "    " + (lp.ElementAt(i)).Nom + " " + (lp.ElementAt(i)).Numéro);
                }
                if (lbPharmacies.Items.Count > 0)
                    lbPharmacies.SetSelected(0, true);
            }
        }

        private void enabled(bool b)
        {
            txtNumeroPharmacie.Enabled = b;
            txtNomPharmacie.Enabled = b;
            txtResponsablePharmacie.Enabled = b;
            txtAdressePharmacie.Enabled = b;
            txtTelephonePharmacie.Enabled = b;
            chbPharmacieActif.Enabled = b;
        }

        private void viderChampInfo()
        {
            txtNumeroPharmacie.Text = "";
            txtNomPharmacie.Text = "";
            txtResponsablePharmacie.Text = "";
            txtAdressePharmacie.Text = "";
            txtTelephonePharmacie.Text = "";
            chbPharmacieActif.Checked = false;
        }

        private void remplirChampInfo(Pharmacie p)
        {
            txtNumeroPharmacie.Text = p.Numéro;
            txtNomPharmacie.Text = p.Nom;
            txtResponsablePharmacie.Text = p.NomRésponsable;
            txtAdressePharmacie.Text = p.Adresse;
            txtTelephonePharmacie.Text = p.NuméroTéléphone;
            chbPharmacieActif.Checked = false;
        }
    }
}
