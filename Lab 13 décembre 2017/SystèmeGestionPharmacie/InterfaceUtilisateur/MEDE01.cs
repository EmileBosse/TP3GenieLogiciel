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
        private List<Médecin> ms;

        public MEDE01()
        {
            InitializeComponent();
            enabled(false);
        }

        private void btnRetour_Click(object sender, EventArgs e)
        {
            var dlgAccueil = (ACCE02)Tag;
            dlgAccueil.Show();
            Close();
        }

        private void btnAjouterMedecin_Click(object sender, EventArgs e)
        {
            if (btnAjouterMedecin.Text == "Ajouter")
            {
                //on change le visuel
                btnAjouterMedecin.Text = "Confirmer";
                btnModifierMedecin.Text = "Annuler";
                viderChampInfo();
                enabled(true);
                lbMedecins.Enabled = false;
            }
            else if (btnAjouterMedecin.Text == "Confirmer")
            {
                //on change le visuel
                btnAjouterMedecin.Text = "Ajouter";
                btnModifierMedecin.Text = "Modifier";
                enabled(false);
                lbMedecins.Enabled = true;
                //on crée le médecin et on l'ajoute a la bd
                MédecinMapper mM = new MédecinMapper();
                Médecin m = new Médecin {
                    NuméroLicense = txtNumeroMedecin.Text,
                    Nom = txtNomMedecin.Text,
                    Prénom = txtPrenomMedecin.Text,
                    Adresse = txtAdresse.Text,
                    NuméroTéléphone = txtTelephone.Text
                };
                if (mM.Insert(m) > 0)
                {
                    System.Windows.Forms.MessageBox.Show("Succès ! Médecin ajouté !");
                    viderChampInfo();
                }
                else
                {
                    System.Windows.Forms.MessageBox.Show("Erreur ! Médecin non ajouté !");
                }
            }
        }

        private void btnModifierMedecin_Click(object sender, EventArgs e)
        {
            if (btnModifierMedecin.Text == "Annuler")
            {
                //annule l'ajout
                btnAjouterMedecin.Text = "Ajouter";
                btnModifierMedecin.Text = "Modifier";
                enabled(false);
                lbMedecins.Enabled = true;
                //On reselectionne
                remplirChampInfo(ms[lbMedecins.SelectedIndex]);
            }
            else if (btnModifierMedecin.Text == "Modifier")
            {
                //on change le visuel
                btnModifierMedecin.Text = "Confirmer";
                enabled(true);
                lbMedecins.Enabled = false;
                btnAjouterMedecin.Enabled = false;
            }
            else if (btnModifierMedecin.Text == "Confirmer")
            {
                //on change le visuel
                btnModifierMedecin.Text = "Modifier";
                enabled(false);
                lbMedecins.Enabled = true;
                btnAjouterMedecin.Enabled = true;
                //on modifie le médecin
                MédecinMapper mM = new MédecinMapper();
                mM.Delete(ms[lbMedecins.SelectedIndex]);
                Médecin m = new Médecin {
                    NuméroLicense = txtNumeroMedecin.Text,
                    Nom = txtNomMedecin.Text,
                    Prénom = txtPrenomMedecin.Text,
                    Adresse = txtAdresse.Text,
                    NuméroTéléphone = txtTelephone.Text
                };
                mM.Insert(m);
            }
        }

        private void btnRechercher_Click(object sender, EventArgs e)
        {
            lbMedecins.Items.Clear();
            MédecinMapper mM = new MédecinMapper();
            ms = mM.Find(txtRechercheNumero.Text, txtRechercheNom.Text, txtRecherchePrenom.Text);

            if (ms != null)
            {
                for (int i = 0; i < ms.Count; i++)
                {
                    lbMedecins.Items.Add(i+"   "+ms[i].Nom+" "+ms[i].Prénom);
                }
            }
            else
            {
                MessageBox.Show("Aucun résultat.");
            }
        }

        private void lbMedecins_SelectedIndexChanged(object sender, EventArgs e)
        {
            remplirChampInfo(ms[lbMedecins.SelectedIndex]);
        }

        //utils fonction info

        private void enabled(bool b)
        {
            txtNumeroMedecin.Enabled = b;
            txtNomMedecin.Enabled = b;
            txtPrenomMedecin.Enabled = b;
            txtAdresse.Enabled = b;
            txtTelephone.Enabled = b;
            chbMedecinActif.Enabled = b;
        }

        private void viderChampInfo()
        {
            txtNumeroMedecin.Text = "";
            txtNomMedecin.Text = "";
            txtPrenomMedecin.Text = "";
            txtAdresse.Text = "";
            txtTelephone.Text = "";
            chbMedecinActif.Checked = false;
        }

        private void remplirChampInfo(Médecin m)
        {
            txtNumeroMedecin.Text = m.NuméroLicense;
            txtNomMedecin.Text = m.Nom;
            txtPrenomMedecin.Text = m.Prénom;
            txtAdresse.Text = m.Adresse;
            txtTelephone.Text = m.NuméroTéléphone;
            chbMedecinActif.Checked = false;
        }
    }
}
