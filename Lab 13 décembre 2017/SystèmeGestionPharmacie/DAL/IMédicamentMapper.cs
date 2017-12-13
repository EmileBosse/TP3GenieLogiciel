
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using SystèmeGestionPharmacie.Logique;
namespace SystèmeGestionPharmacie.DAL
{
public interface IMédicamentMapper
 {
	Médicament Find(Guid ID);
        DataTable FindAll();
	
	int Insert(Médicament pMédicament);
        int Update(Médicament pMédicament);
        int Delete(Médicament pMédicament);

	
 }
}	
       