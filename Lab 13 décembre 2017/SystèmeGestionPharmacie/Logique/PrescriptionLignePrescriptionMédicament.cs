
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace Syst�meGestionPharmacie.Logique
{
public class PrescriptionLignePrescriptionM�dicament : DomainObject
 {		private Guid mIDPrescription;
		public Guid   IDPrescription {
    			get {
      				return mIDPrescription;
    			}
    			set {
      				mIDPrescription=value;
    			}
		}
        	private Guid mIDM�dicament;
		public Guid   IDM�dicament {
    			get {
      				return mIDM�dicament;
    			}
    			set {
      				mIDM�dicament=value;
    			}
		}
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
		private Posologie mPosologieLignePrescription;
		public Posologie PosologieLignePrescription {
    			get {
      				return  mPosologieLignePrescription;
    			}
    			set {
      				mPosologieLignePrescription=value;
    			}
		    }
		private decimal mQuantit�;
		public decimal Quantit� {
    			get {
      				return  mQuantit�;
    			}
    			set {
      				mQuantit�=value;
    			}
		    }
		private int mNombreRenouvellements;
		public int NombreRenouvellements {
    			get {
      				return  mNombreRenouvellements;
    			}
    			set {
      				mNombreRenouvellements=value;
    			}
		    }
		private int mNombreRenouvellementsRestants;
		public int NombreRenouvellementsRestants {
    			get {
      				return  mNombreRenouvellementsRestants;
    			}
    			set {
      				mNombreRenouvellementsRestants=value;
    			}
		    }
	

 }
}	
       