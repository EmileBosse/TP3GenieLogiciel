
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace SystèmeGestionPharmacie.Logique
{
public class Session : DomainObject
 {
		private DateTime mDateConnexion;
		public DateTime DateConnexion {
    			get {
      				return  mDateConnexion;
    			}
    			set {
      				mDateConnexion=value;
    			}
		    }
		private DateTime mDateDeconnexion;
		public DateTime DateDeconnexion {
    			get {
      				return  mDateDeconnexion;
    			}
    			set {
      				mDateDeconnexion=value;
    			}
		    }
	
		private Dictionary<Guid, Prescription> lsPrescription = new Dictionary<Guid, Prescription>();
		public Dictionary<Guid, Prescription> ListPrescription
        	{
            		get { return lsPrescription; }
            		set { lsPrescription = value; }
        	}
	
		private Dictionary<Guid, TransactionVente> lsTransactionVente = new Dictionary<Guid, TransactionVente>();
		public Dictionary<Guid, TransactionVente> ListTransactionVente
        	{
            		get { return lsTransactionVente; }
            		set { lsTransactionVente = value; }
        	}
	
 
 }
}	
       