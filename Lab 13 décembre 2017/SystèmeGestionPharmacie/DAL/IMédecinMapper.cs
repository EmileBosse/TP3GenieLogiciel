
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Syst�meGestionPharmacie.Logique;
namespace Syst�meGestionPharmacie.DAL
{
public interface IM�decinMapper
 {
	M�decin Find(Guid ID);
        DataTable FindAll();
	
	int Insert(M�decin pM�decin);
        int Update(M�decin pM�decin);
        int Delete(M�decin pM�decin);

	
 }
}	
       