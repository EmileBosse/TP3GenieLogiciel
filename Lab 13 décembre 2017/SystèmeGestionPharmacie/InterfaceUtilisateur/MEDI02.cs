﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SystèmeGestionPharmacie
{
    public partial class MEDI02 : Form
    {
        public MEDI02()
        {
            InitializeComponent();
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            var dlgMedi = (MEDI01)Tag;
            dlgMedi.Show();
            Close();
        }
    }
}
