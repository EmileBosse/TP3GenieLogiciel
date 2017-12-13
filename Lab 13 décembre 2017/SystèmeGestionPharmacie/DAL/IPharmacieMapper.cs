
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Syst�meGestionPharmacie.Logique;
namespace Syst�meGestionPharmacie.DAL
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
       