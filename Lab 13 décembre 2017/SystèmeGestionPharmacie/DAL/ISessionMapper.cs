
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using SystèmeGestionPharmacie.Logique;
namespace SystèmeGestionPharmacie.DAL
{
public interface ISessionMapper
 {
	Session Find(Guid ID);
        DataTable FindAll();
	
	int Insert(Session pSession);
        int Update(Session pSession);
        int Delete(Session pSession);

	
		DataTable FindAllPrescriptionTable(Session pSession);
        	void FindAllPrescription(ref Session pSession);
		int InsertAllPrescription(Session pSession);
	
		DataTable FindAllTransactionVenteTable(Session pSession);
        	void FindAllTransactionVente(ref Session pSession);
		int InsertAllTransactionVente(Session pSession);
	
 }
}	
       