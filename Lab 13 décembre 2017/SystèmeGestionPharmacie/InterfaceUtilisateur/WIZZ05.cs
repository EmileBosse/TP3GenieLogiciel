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
        public WIZZ05()
        {
            InitializeComponent();
        }

        private void btnCancelPrescription_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPrecedentPrescription_Click(object sender, EventArgs e)
        {
            Parent.Show();
            this.Close();
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
