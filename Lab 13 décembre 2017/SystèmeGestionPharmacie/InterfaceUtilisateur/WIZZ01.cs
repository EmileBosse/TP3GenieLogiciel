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

        private void WIZZ01_Load(object sender, EventArgs e)
        {
            
        }

        private void btnNvlPrescription_Click(object sender, EventArgs e)
        {
            WIZZ02 c = new WIZZ02();
            c.Show();
            this.Close();
        }

        private void btnRenouveler_Click(object sender, EventArgs e)
        {
            WIZZ06 c = new WIZZ06();
            c.Show();
            this.Close();
        }
    }
}
