
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace Syst�meGestionPharmacie.Logique
{
public class M�dicament : DomainObject
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
		private string mMani�reLivraison;
		public string Mani�reLivraison {
    			get {
      				return  mMani�reLivraison;
    			}
    			set {
      				mMani�reLivraison=value;
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
		private Posologie mPosologieM�dicament;
		public Posologie PosologieM�dicament {
    			get {
      				return  mPosologieM�dicament;
    			}
    			set {
      				mPosologieM�dicament=value;
    			}
		    }
		private decimal mQuantit�Stock;
		public decimal Quantit�Stock {
    			get {
      				return  mQuantit�Stock;
    			}
    			set {
      				mQuantit�Stock=value;
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
       