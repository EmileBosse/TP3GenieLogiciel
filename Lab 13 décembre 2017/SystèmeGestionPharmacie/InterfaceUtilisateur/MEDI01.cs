﻿using System;
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
    public partial class MEDI01 : Form
    {
        public MEDI01()
        {
            InitializeComponent();
        }

        private void btnRetour_Click(object sender, EventArgs e)
        {
            var dlgAccueil = (ACCE02)Tag;
            dlgAccueil.Show();
            Close();
        }

        private void btnAjouterMedicament_Click(object sender, EventArgs e)
        {
            MEDI02 dlgAjoutMedicament = new MEDI02 { Tag = this };
            dlgAjoutMedicament.Show(this);
            Hide();
        }
    }
}
