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
            WIZZ04 c = new WIZZ04(this);
            c.Show();
            this.Hide();
        }

        private void btnPrecedentPatient_Click(object sender, EventArgs e)
        {
            creator.Show();
            this.Hide();
        }

        private void btnCancelPatient_Click(object sender, EventArgs e)
        {
            CloseCreator();
            this.Close();
        }
    }
}
