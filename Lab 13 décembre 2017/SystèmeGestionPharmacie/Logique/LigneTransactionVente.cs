
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace SystèmeGestionPharmacie.Logique
{
public class LigneTransactionVente : DomainObject
 {
		private int mNuméro;
		public int Numéro {
    			get {
      				return  mNuméro;
    			}
    			set {
      				mNuméro=value;
    			}
		    }
		private decimal mMontantLigne;
		public decimal MontantLigne {
    			get {
      				return  mMontantLigne;
    			}
    			set {
      				mMontantLigne=value;
    			}
		    }
		private byte[] mCopieÉtiquette;
		public byte[] CopieÉtiquette {
    			get {
      				return  mCopieÉtiquette;
    			}
    			set {
      				mCopieÉtiquette=value;
    			}
		    }
	
		private Guid mIDTransactionVente;
		public Guid IDTransactionVente
        	{
            		get { return mIDTransactionVente; }
            		set { mIDTransactionVente = value; }
        	}
	
 
 }
}	
       