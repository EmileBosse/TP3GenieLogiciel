
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace Syst�meGestionPharmacie.Logique
{
public class Pharmacie : DomainObject
 {
		private string mNum�ro;
		public string Num�ro {
    			get {
      				return  mNum�ro;
    			}
    			set {
      				mNum�ro=value;
    			}
		    }
		private string mNom;
		public string Nom {
    			get {
      				return  mNom;
    			}
    			set {
      				mNom=value;
    			}
		    }
		private string mNomR�sponsable;
		public string NomR�sponsable {
    			get {
      				return  mNomR�sponsable;
    			}
    			set {
      				mNomR�sponsable=value;
    			}
		    }
		private string mAdresse;
		public string Adresse {
    			get {
      				return  mAdresse;
    			}
    			set {
      				mAdresse=value;
    			}
		    }
		private string mNum�roT�l�phone;
		public string Num�roT�l�phone {
    			get {
      				return  mNum�roT�l�phone;
    			}
    			set {
      				mNum�roT�l�phone=value;
    			}
		    }
	
 
 }
}	
       