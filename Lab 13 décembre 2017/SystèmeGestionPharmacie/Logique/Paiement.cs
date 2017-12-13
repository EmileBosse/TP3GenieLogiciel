
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace SystèmeGestionPharmacie.Logique
{
public class Paiement : DomainObject
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
		private DateTime mDatePaiement;
		public DateTime DatePaiement {
    			get {
      				return  mDatePaiement;
    			}
    			set {
      				mDatePaiement=value;
    			}
		    }
		private decimal mMontant;
		public decimal Montant {
    			get {
      				return  mMontant;
    			}
    			set {
      				mMontant=value;
    			}
		    }
		private string mTypePaiement;
		public string TypePaiement {
    			get {
      				return  mTypePaiement;
    			}
    			set {
      				mTypePaiement=value;
    			}
		    }
	
 
 }
}	
       