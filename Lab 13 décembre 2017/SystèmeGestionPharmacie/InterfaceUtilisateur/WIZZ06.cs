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
    public partial class WIZZ06 : Form
    {
        public WIZZ06()
        {
            InitializeComponent();
        }

        private void btnSuivantPrescription_Click(object sender, EventArgs e)
        {
            WIZZ07 c = new WIZZ07();
            c.Show();
            this.Close();
        }

        private void btnPrecedentPrescription_Click(object sender, EventArgs e)
        {
            Parent.Show();
            this.Close();
        }

        private void btnCancelPrescription_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
