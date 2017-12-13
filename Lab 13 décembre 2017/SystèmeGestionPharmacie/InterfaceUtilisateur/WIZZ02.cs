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
    public partial class WIZZ02 : Form
    {
        public WIZZ02()
        {
            InitializeComponent();
        }

        private void btnPrecedentMed_Click(object sender, EventArgs e)
        {
            Parent.Show();
            this.Close();
        }

        private void btnSuivantMed_Click(object sender, EventArgs e)
        {
            WIZZ03 c = new WIZZ03();
            c.Show();
            this.Close();
        }

        private void btnCancelMed_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
