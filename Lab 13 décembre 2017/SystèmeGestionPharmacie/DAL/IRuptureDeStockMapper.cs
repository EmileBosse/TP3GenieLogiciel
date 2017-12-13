
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using SystèmeGestionPharmacie.Logique;
namespace SystèmeGestionPharmacie.DAL
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
       