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
    public partial class WIZZ03 : Form
    {
        WIZZ02 creator;

        public WIZZ03(WIZZ02 last)
        {
            creator = last;
            InitializeComponent();
        }

        public void CloseCreator()
        {
            creator.CloseCreator();
            creator.Close();
        }

        private void btnSuivantPatient_Click(object sender, EventArgs e)
        {
            // SUIVANT = WIZZ04
            WIZZ04 c = new WIZZ04(this) { Tag = this };
            c.Show();
            Hide();
        }

        private void btnPrecedentPatient_Click(object sender, EventArgs e)
        {
            // PRECEDENT = WIZZ02
            creator.Show();
            Hide();
        }

        private void btnCancelPatient_Click(object sender, EventArgs e)
        {
            CloseCreator();
            Close();
        }
    }
}
