
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace SystèmeGestionPharmacie.Logique
{
public class Pharmacien : Utilisateur
 {
		private string mNuméroLicense;
		public string NuméroLicense {
    			get {
      				return  mNuméroLicense;
    			}
    			set {
      				mNuméroLicense=value;
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
		private string mPrénom;
		public string Prénom {
    			get {
      				return  mPrénom;
    			}
    			set {
      				mPrénom=value;
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
		private string mNuméroTéléphone;
		public string NuméroTéléphone {
    			get {
      				return  mNuméroTéléphone;
    			}
    			set {
      				mNuméroTéléphone=value;
    			}
		    }
	
 
 }
}	
       