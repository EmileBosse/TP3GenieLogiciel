
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Syst�meGestionPharmacie.Logique;
namespace Syst�meGestionPharmacie.DAL
{
public interface IM�dicamentMapper
 {
	M�dicament Find(Guid ID);
        DataTable FindAll();
	
	int Insert(M�dicament pM�dicament);
        int Update(M�dicament pM�dicament);
        int Delete(M�dicament pM�dicament);

	
 }
}	
       