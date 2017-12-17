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
    public partial class WIZZ01 : Form
    {
        public WIZZ01()
        {
            InitializeComponent();
        }

        public void CloseCreator()
        {
            var dlgPrescriptions = (PRES01)Tag;
            dlgPrescriptions.Show();
            Close();
        }

        private void btnNvlPrescription_Click(object sender, EventArgs e)
        {
            // SUIVANT = WIZZ02
            WIZZ02 c = new WIZZ02(this) { Tag = this };
            c.Show();
            Hide();
        }

        private void btnRenouveler_Click(object sender, EventArgs e)
        {
            // SUIVANT = WIZZ 06
            WIZZ06 c = new WIZZ06(this);
            c.ShowDialog();
            Hide();
        }
    }
}
