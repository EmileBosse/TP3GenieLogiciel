
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using SystèmeGestionPharmacie.Logique;
namespace SystèmeGestionPharmacie.DAL
{
public interface IPrescriptionLignePrescriptionMédicamentMapper
 {
	PrescriptionLignePrescriptionMédicament Find(Guid ID);
        DataTable FindAll();
	int Insert(PrescriptionLignePrescriptionMédicament pPrescriptionLignePrescriptionMédicament);
        int Update(PrescriptionLignePrescriptionMédicament pPrescriptionLignePrescriptionMédicament);
        int Delete(PrescriptionLignePrescriptionMédicament pPrescriptionLignePrescriptionMédicament);
 }
}	
       