
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Syst�meGestionPharmacie.Logique;
namespace Syst�meGestionPharmacie.DAL
{
public interface IPatientMapper
 {
	Patient Find(Guid ID);
        DataTable FindAll();
	
	int Insert(Patient pPatient);
        int Update(Patient pPatient);
        int Delete(Patient pPatient);

	
 }
}	
       