
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace SystèmeGestionPharmacie.Logique
{
public class Utilisateur : DomainObject
 {
		private string mNomConnexion;
		public string NomConnexion {
    			get {
      				return  mNomConnexion;
    			}
    			set {
      				mNomConnexion=value;
    			}
		    }
		private string mMotDePasse;
		public string MotDePasse {
    			get {
      				return  mMotDePasse;
    			}
    			set {
      				mMotDePasse=value;
    			}
		    }
	
 
 }
}	
       