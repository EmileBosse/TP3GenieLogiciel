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
        WIZZ01 creator;

        public WIZZ06(WIZZ01 last)
        {
            creator = last;
            InitializeComponent();
        }

        public void CloseCreator()
        {
            creator.CloseCreator();
            creator.Close();
        }

        private void btnSuivantPrescription_Click(object sender, EventArgs e)
        {
            // SUIVANT = WIZZ07
            WIZZ07 c = new WIZZ07(this) { Tag = this};
            c.Show();
            Hide();
        }

        private void btnPrecedentPrescription_Click(object sender, EventArgs e)
        {
            // PRECEDENT = WIZZ01
            creator.Show();
            Hide();
        }

        private void btnCancelPrescription_Click(object sender, EventArgs e)
        {
            CloseCreator();
            Close();
        }
    }
}
