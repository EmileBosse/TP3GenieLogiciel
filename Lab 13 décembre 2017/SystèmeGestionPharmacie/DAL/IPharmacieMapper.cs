
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using SystèmeGestionPharmacie.Logique;
namespace SystèmeGestionPharmacie.DAL
{
public interface IPharmacieMapper
 {
	Pharmacie Find(Guid ID);
        DataTable FindAll();
	
	int Insert(Pharmacie pPharmacie);
        int Update(Pharmacie pPharmacie);
        int Delete(Pharmacie pPharmacie);

	
 }
}	
       