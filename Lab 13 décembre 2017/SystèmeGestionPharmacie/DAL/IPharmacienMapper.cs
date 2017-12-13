
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using SystèmeGestionPharmacie.Logique;
namespace SystèmeGestionPharmacie.DAL
{
public interface IPharmacienMapper
 {
	Pharmacien Find(Guid ID);
        DataTable FindAll();
	
	int Insert(Pharmacien pPharmacien);
        int Update(Pharmacien pPharmacien);
        int Delete(Pharmacien pPharmacien);

	
 }
}	
       