using System;
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
    public partial class WIZZ05 : Form
    {
        WIZZ04 creatorP = null;
        WIZZ07 creatorR = null;

        public WIZZ05(WIZZ04 last)
        {
            creatorP = last;
            InitializeComponent();
        }

        public WIZZ05(WIZZ07 last)
        {
            creatorR = last;
            InitializeComponent();
        }

        public void CloseCreator()
        {
            if (creatorP != null)
            {
                creatorP.CloseCreator();
                creatorP.Close();
            }
            if (creatorR != null)
            {
                creatorR.CloseCreator();
                creatorR.Close();
            }
        }

        private void btnCancelPrescription_Click(object sender, EventArgs e)
        {
            CloseCreator();
            this.Close();
        }

        private void btnPrecedentPrescription_Click(object sender, EventArgs e)
        {
            if (creatorP != null)
            {
                creatorP.Show();
            }
            else if (creatorR != null)
            {
                creatorR.Show();
            }
            this.Hide();
        }

        private void btnTerminerPrescription_Click(object sender, EventArgs e)
        {
            enregistrerPrescription();
            this.Close();
        }

        private void enregistrerPrescription()
        {

        }
    }
}
