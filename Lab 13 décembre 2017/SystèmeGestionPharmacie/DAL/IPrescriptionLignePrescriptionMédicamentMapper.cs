
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Syst�meGestionPharmacie.Logique;
namespace Syst�meGestionPharmacie.DAL
{
public interface IPrescriptionLignePrescriptionM�dicamentMapper
 {
	PrescriptionLignePrescriptionM�dicament Find(Guid ID);
        DataTable FindAll();
	int Insert(PrescriptionLignePrescriptionM�dicament pPrescriptionLignePrescriptionM�dicament);
        int Update(PrescriptionLignePrescriptionM�dicament pPrescriptionLignePrescriptionM�dicament);
        int Delete(PrescriptionLignePrescriptionM�dicament pPrescriptionLignePrescriptionM�dicament);
 }
}	
       