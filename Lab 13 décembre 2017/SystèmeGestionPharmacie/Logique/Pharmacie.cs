
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace SystèmeGestionPharmacie.Logique
{
public class Pharmacie : DomainObject
 {
		private string mNuméro;
		public string Numéro {
    			get {
      				return  mNuméro;
    			}
    			set {
      				mNuméro=value;
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
		private string mNomRésponsable;
		public string NomRésponsable {
    			get {
      				return  mNomRésponsable;
    			}
    			set {
      				mNomRésponsable=value;
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
       