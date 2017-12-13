
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Syst�meGestionPharmacie.Logique;
namespace Syst�meGestionPharmacie.DAL
{
public interface ILigneTransactionVenteMapper
 {
	LigneTransactionVente Find(Guid ID);
        DataTable FindAll();
	DataTable FindAllPourUnTransactionVente(Guid pTransactionVenteId);
	int Insert(LigneTransactionVente pLigneTransactionVente);
        int Update(LigneTransactionVente pLigneTransactionVente);
        int Delete(LigneTransactionVente pLigneTransactionVente);

	
 }
}	
       