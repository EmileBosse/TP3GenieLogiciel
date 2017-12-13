
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using SystèmeGestionPharmacie.Logique;
namespace SystèmeGestionPharmacie.DAL
{
public interface IMédecinMapper
 {
	Médecin Find(Guid ID);
        DataTable FindAll();
	
	int Insert(Médecin pMédecin);
        int Update(Médecin pMédecin);
        int Delete(Médecin pMédecin);

	
 }
}	
       