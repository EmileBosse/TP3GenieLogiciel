
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Syst�meGestionPharmacie.Logique;
namespace Syst�meGestionPharmacie.DAL
{
public interface IPrescriptionMapper
 {
	Prescription Find(Guid ID);
        DataTable FindAll();
	
	int Insert(Prescription pPrescription);
        int Update(Prescription pPrescription);
        int Delete(Prescription pPrescription);

	
		DataTable FindAllM�dicamentTable(Prescription pPrescription);
        	void FindAllM�dicament(ref Prescription pPrescription);
		int InsertAllM�dicament(Prescription pPrescription);
	
 }
}	
       