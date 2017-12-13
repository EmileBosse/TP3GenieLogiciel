using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SysPharmacie
{
    public partial class WIZZ03 : Form
    {
        public WIZZ03()
        {
            InitializeComponent();
        }

        private void btnSuivantPatient_Click(object sender, EventArgs e)
        {
            WIZZ04 c = new WIZZ04();
            c.Show();
            this.Close();
        }

        private void btnPrecedentPatient_Click(object sender, EventArgs e)
        {
            //Parent.Show();
            this.Close();
        }

        private void btnCancelPatient_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
