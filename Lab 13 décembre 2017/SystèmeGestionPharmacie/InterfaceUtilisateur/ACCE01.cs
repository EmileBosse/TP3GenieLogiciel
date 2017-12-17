using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SystèmeGestionPharmacie.Logique;
using SystèmeGestionPharmacie.DAL.MSSQL;

namespace SystèmeGestionPharmacie
{
    public partial class ACCE01 : Form
    {
        public ACCE01()
        {
            InitializeComponent();
        }

        private void btnConnexion_Click(object sender, EventArgs e)
        {
            UtilisateurMapper uM = new UtilisateurMapper();
            Utilisateur u = uM.Find(txtLogin.Text, txtLogin.Text);

            if(Util.isNULL(u))
            {
                labelMsg.Text = "Erreur : les identifiants sont incorrects";
            }
            else
            {
                ACCE02 aCCE02 = new ACCE02();
                aCCE02.Show();
                this.Close();
            }

        }
    }
}
