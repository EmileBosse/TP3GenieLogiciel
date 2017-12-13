
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using SystèmeGestionPharmacie.Logique;
namespace SystèmeGestionPharmacie.DAL
{
public interface IPrescriptionMapper
 {
	Prescription Find(Guid ID);
        DataTable FindAll();
	
	int Insert(Prescription pPrescription);
        int Update(Prescription pPrescription);
        int Delete(Prescription pPrescription);

	
		DataTable FindAllMédicamentTable(Prescription pPrescription);
        	void FindAllMédicament(ref Prescription pPrescription);
		int InsertAllMédicament(Prescription pPrescription);
	
 }
}	
       