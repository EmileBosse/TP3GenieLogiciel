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
    public partial class WIZZ07 : Form
    {
        WIZZ06 creator;

        public WIZZ07(WIZZ06 last)
        {
            creator = last;
            InitializeComponent();
        }

        public void CloseCreator()
        {
            creator.CloseCreator();
            creator.Close();
        }

        private void btnCancelMedicament_Click(object sender, EventArgs e)
        {
            CloseCreator();
            Close();
        }

        private void btnPrecedentMedicament_Click(object sender, EventArgs e)
        {
            creator.Show();
            Hide();
        }

        private void btnSuivantMedicament_Click(object sender, EventArgs e)
        {
            WIZZ05 c = new WIZZ05(this) { Tag = this };
            c.Show();
            Hide();
        }
    }
}
