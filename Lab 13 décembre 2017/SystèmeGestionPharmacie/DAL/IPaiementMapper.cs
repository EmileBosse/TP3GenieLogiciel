
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using SystèmeGestionPharmacie.Logique;
namespace SystèmeGestionPharmacie.DAL
{
public interface IPaiementMapper
 {
	Paiement Find(Guid ID);
        DataTable FindAll();
	
	int Insert(Paiement pPaiement);
        int Update(Paiement pPaiement);
        int Delete(Paiement pPaiement);

	
 }
}	
       