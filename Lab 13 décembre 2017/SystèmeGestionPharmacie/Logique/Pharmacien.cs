
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace Syst�meGestionPharmacie.Logique
{
public class Pharmacien : Utilisateur
 {
		private string mNum�roLicense;
		public string Num�roLicense {
    			get {
      				return  mNum�roLicense;
    			}
    			set {
      				mNum�roLicense=value;
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
		private string mPr�nom;
		public string Pr�nom {
    			get {
      				return  mPr�nom;
    			}
    			set {
      				mPr�nom=value;
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
       