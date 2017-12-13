
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Syst�meGestionPharmacie.Logique;
namespace Syst�meGestionPharmacie.DAL
{
public interface ITransactionVenteMapper
 {
	TransactionVente Find(Guid ID);
        DataTable FindAll();
	
	int Insert(TransactionVente pTransactionVente);
        int Update(TransactionVente pTransactionVente);
        int Delete(TransactionVente pTransactionVente);

	
 }
}	
       