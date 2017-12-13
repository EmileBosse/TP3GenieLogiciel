
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Syst�meGestionPharmacie.Logique;
namespace Syst�meGestionPharmacie.DAL
{
public interface IRuptureDeStockMapper
 {
	RuptureDeStock Find(Guid ID);
        DataTable FindAll();
	
	int Insert(RuptureDeStock pRuptureDeStock);
        int Update(RuptureDeStock pRuptureDeStock);
        int Delete(RuptureDeStock pRuptureDeStock);

	
 }
}	
       