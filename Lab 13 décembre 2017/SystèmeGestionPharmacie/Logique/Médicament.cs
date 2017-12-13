
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace SystèmeGestionPharmacie.Logique
{
public class Médicament : DomainObject
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
		private string mManièreLivraison;
		public string ManièreLivraison {
    			get {
      				return  mManièreLivraison;
    			}
    			set {
      				mManièreLivraison=value;
    			}
		    }
		private string mEndroit;
		public string Endroit {
    			get {
      				return  mEndroit;
    			}
    			set {
      				mEndroit=value;
    			}
		    }
		private Posologie mPosologieMédicament;
		public Posologie PosologieMédicament {
    			get {
      				return  mPosologieMédicament;
    			}
    			set {
      				mPosologieMédicament=value;
    			}
		    }
		private decimal mQuantitéStock;
		public decimal QuantitéStock {
    			get {
      				return  mQuantitéStock;
    			}
    			set {
      				mQuantitéStock=value;
    			}
		    }
		private decimal mPrixVente;
		public decimal PrixVente {
    			get {
      				return  mPrixVente;
    			}
    			set {
      				mPrixVente=value;
    			}
		    }
	
 
 }
}	
       