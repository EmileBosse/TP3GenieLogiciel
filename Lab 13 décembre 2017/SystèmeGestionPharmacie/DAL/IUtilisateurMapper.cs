
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Syst�meGestionPharmacie.Logique;
namespace Syst�meGestionPharmacie.DAL
{
public interface IUtilisateurMapper
 {
	Utilisateur Find(Guid ID);
        DataTable FindAll();
	
	int Insert(Utilisateur pUtilisateur);
        int Update(Utilisateur pUtilisateur);
        int Delete(Utilisateur pUtilisateur);

	
 }
}	
       