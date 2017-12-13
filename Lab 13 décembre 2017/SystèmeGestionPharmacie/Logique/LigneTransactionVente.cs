
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace Syst�meGestionPharmacie.Logique
{
public class LigneTransactionVente : DomainObject
 {
		private int mNum�ro;
		public int Num�ro {
    			get {
      				return  mNum�ro;
    			}
    			set {
      				mNum�ro=value;
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
		private byte[] mCopie�tiquette;
		public byte[] Copie�tiquette {
    			get {
      				return  mCopie�tiquette;
    			}
    			set {
      				mCopie�tiquette=value;
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
       