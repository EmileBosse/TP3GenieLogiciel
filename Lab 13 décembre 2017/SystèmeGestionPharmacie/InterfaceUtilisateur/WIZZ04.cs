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
    public partial class WIZZ04 : Form
    {
        WIZZ03 creator;

        public WIZZ04(WIZZ03 last)
        {
            creator = last;
            InitializeComponent();
        }

        public void CloseCreator()
        {
            creator.CloseCreator();
            creator.Close();
        }

        private void btnSuivantMedicament_Click(object sender, EventArgs e)
        {
            // SUIVANT = WIZZ05
            WIZZ05 c = new WIZZ05(this) { Tag = this };
            c.Show();
            Hide();
        }

        private void btnPrecedentMedicament_Click(object sender, EventArgs e)
        {
            //PRECEDENT = WIZZ03
            creator.Show();
            Hide();
        }

        private void btnCancelMedicament_Click(object sender, EventArgs e)
        {
            CloseCreator();
            Close();
        }
    }
}
