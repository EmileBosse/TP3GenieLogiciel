
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace SystèmeGestionPharmacie.Logique
{
public class TransactionVente : DomainObject
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
		private DateTime mDateTransactionVente;
		public DateTime DateTransactionVente {
    			get {
      				return  mDateTransactionVente;
    			}
    			set {
      				mDateTransactionVente=value;
    			}
		    }
		private decimal mMontantTotal;
		public decimal MontantTotal {
    			get {
      				return  mMontantTotal;
    			}
    			set {
      				mMontantTotal=value;
    			}
		    }
	
		private Guid mIDPaiement;
		public Guid IDPaiement
        	{
            		get { return mIDPaiement; }
            		set { mIDPaiement = value; }
        	}
	
 
 }
}	
       