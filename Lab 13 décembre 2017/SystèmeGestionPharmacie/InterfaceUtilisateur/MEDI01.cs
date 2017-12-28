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
        private List<Médicament> listeMed { get; set; }

        public MEDI01()
        {
            InitializeComponent();
            enabled(false);
            MédicamentMapper medMap = new MédicamentMapper();

            listeMed = medMap.Find("", "");

            for (int i = 0; i < listeMed.Count; i++)
            {
                lbMedicaments.Items.Add(listeMed[i].toString());
            }
            if (lbMedicaments.Items.Count > 0)
                lbMedicaments.SetSelected(0, true);
        }

        private void btnRetour_Click(object sender, EventArgs e)
        {
            var dlgAccueil = (ACCE02) Tag;
            dlgAccueil.Show();
            Close();
        }

        private void btnAjouterMedicament_Click(object sender, EventArgs e)
        {
            //MEDI02 dlgAjoutMedicament = new MEDI02 {Tag = this};
            //dlgAjoutMedicament.Show(this);
            //Hide();

            if (btnAjouterMedicament.Text == "Ajouter")
            {
                //on change le visuel
                btnAjouterMedicament.Text = "Confirmer";
                btnModifierMedicament.Text = "Annuler";
                viderChampInfo();
                enabled(true);
                lbMedicaments.Enabled = false;
            }
            else if (btnAjouterMedicament.Text == "Confirmer")
            {
                //on change le visuel
                btnAjouterMedicament.Text = "Ajouter";
                btnModifierMedicament.Text = "Modifier";
                enabled(false);
                lbMedicaments.Enabled = true;
                //on crée le médecin et on l'ajoute a la bd
                MédicamentMapper mM = new MédicamentMapper();
                Médicament m = new Médicament
                {
                    Nom = txtNomMedicament.Text,
                    Endroit = txtEndroit.Text,
                    ManièreLivraison = txtManiereLivraison.Text,
                    Numéro = txtNumeroMedicament.Text,
                    QuantitéStock = Convert.ToDecimal(txtQuantiteStock.Text),
                    PrixVente = Convert.ToDecimal(txtPrixVente.Text),
                    PosologieMédicament = new Posologie
                    {
                        NombreUnitésParJour = 0,
                        NombreJours = 0
                    }
                };
                if (mM.Insert(m) > 0)
                {
                    System.Windows.Forms.MessageBox.Show("Succès ! Médicament ajouté !");
                    viderChampInfo();
                }
                else
                {
                    System.Windows.Forms.MessageBox.Show("Erreur ! Médicament non ajouté !");
                }
            }
        }

        private void lbMedicaments_SelectedIndexChanged(object sender, EventArgs e)
        {

            remplirChampInfo(listeMed[lbMedicaments.SelectedIndex]);
            btnModifierMedicament.Enabled = true;
        }

        private void remplirChampInfo(Médicament m)
        {

            txtNumeroMedicament.Text = m.Numéro.ToString();
            txtNomMedicament.Text = m.Nom.ToString();
            txtManiereLivraison.Text = m.ManièreLivraison.ToString();
            txtEndroit.Text = m.Endroit.ToString();
            txtPrixVente.Text = m.PrixVente.ToString();
            txtQuantiteStock.Text = m.QuantitéStock.ToString();
            chbMedicamentActif.Checked = false;
            //udnUnitePosologie.Value = int.Parse(medoc[7].ToString());
            //udnJoursPosologie.Value = int.Parse(medoc[8].ToString());
        }

        private void btnModifierMedicament_Click(object sender, EventArgs e)
        {
            if (btnModifierMedicament.Text == "Annuler")
            {
                //annule l'ajout
                btnAjouterMedicament.Text = "Ajouter";
                btnModifierMedicament.Text = "Modifier";
                enabled(false);
                lbMedicaments.Enabled = true;
                //On reselectionne
                if (lbMedicaments.Items.Count > 0)
                    remplirChampInfo(listeMed[lbMedicaments.SelectedIndex]);
            }
            else if (btnModifierMedicament.Text == "Modifier")
            {
                //on change le visuel
                btnModifierMedicament.Text = "Confirmer";
                enabled(true);
                lbMedicaments.Enabled = false;
                btnAjouterMedicament.Enabled = false;
            }
            else if (btnModifierMedicament.Text == "Confirmer")
            {
                //on change le visuel
                btnModifierMedicament.Text = "Modifier";
                enabled(false);
                lbMedicaments.Enabled = true;
                btnAjouterMedicament.Enabled = true;
                //on modifie le médecin
                MédicamentMapper mM = new MédicamentMapper();
                mM.Delete(listeMed[lbMedicaments.SelectedIndex]);
                Médicament m = new Médicament
                {
                    Nom = txtNomMedicament.Text,
                    Endroit = txtEndroit.Text,
                    ManièreLivraison = txtManiereLivraison.Text,
                    Numéro = txtNumeroMedicament.Text,
                    QuantitéStock = Convert.ToDecimal(txtQuantiteStock.Text),
                    PrixVente = Convert.ToDecimal(txtPrixVente.Text),
                    PosologieMédicament = new Posologie
                    {
                        NombreUnitésParJour = 0,
                        NombreJours = 0
                    }
            };


                mM.Insert(m);
            }
        }

        private void enabled(bool b)
        {
            txtNomMedicament.Enabled = b;
            txtEndroit.Enabled = b;
            txtManiereLivraison.Enabled = b;
            txtNumeroMedicament.Enabled = b;
            txtPrixVente.Enabled = b;
            txtQuantiteStock.Enabled = b;
        }

        private void viderChampInfo()
        {
            txtNomMedicament.Text = "";
            txtEndroit.Text = "";
            txtManiereLivraison.Text = "";
            txtNumeroMedicament.Text = "";
            txtPrixVente.Text = "";
            txtQuantiteStock.Text = "";
            chbMedicamentActif.Checked = false;
        }

        private void btnRechercher_Click(object sender, EventArgs e)
        {
            lbMedicaments.Items.Clear();
            MédicamentMapper mM = new MédicamentMapper();
            listeMed = mM.Find(txtRechercheNom.Text, txtRechercheNumero.Text);

            if (listeMed != null)
            {
                for (int i = 0; i < listeMed.Count; i++)
                {
                    lbMedicaments.Items.Add(listeMed[i].toString());
                }
                if (lbMedicaments.Items.Count > 0)
                    lbMedicaments.SetSelected(0, true);
            }
            else
            {
                MessageBox.Show("Aucun résultat.");
            }
        }

        private void btnRuptureStock_Click(object sender, EventArgs e)
        {
            RAPP01 dlgRapports = new RAPP01 { Tag = this };
            dlgRapports.Show();
            Hide();
        }
    }
}
