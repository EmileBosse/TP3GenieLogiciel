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
    public partial class WIZZ02 : Form
    {
        WIZZ01 creator;

        public WIZZ02(WIZZ01 last)
        {
            creator = last;
            InitializeComponent();
        }

        public void CloseCreator()
        {
            creator.CloseCreator();
            creator.Close();
        }

        private void btnPrecedentMed_Click(object sender, EventArgs e)
        {
            // PRECEDENT = WIZZ01
            creator.Show();
            Hide();
        }

        private void btnSuivantMed_Click(object sender, EventArgs e)
        {
            // SUIVANT = WIZZ03
            WIZZ03 c = new WIZZ03(this) { Tag = this };
            c.Show(this);
            Hide();
        }

        private void btnCancelMed_Click(object sender, EventArgs e)
        {
            CloseCreator();
            Close();
        }
    }
}
