
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace SystèmeGestionPharmacie.Logique
{
public class PrescriptionLignePrescriptionMédicament : DomainObject
 {		private Guid mIDPrescription;
		public Guid   IDPrescription {
    			get {
      				return mIDPrescription;
    			}
    			set {
      				mIDPrescription=value;
    			}
		}
        	private Guid mIDMédicament;
		public Guid   IDMédicament {
    			get {
      				return mIDMédicament;
    			}
    			set {
      				mIDMédicament=value;
    			}
		}
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
		private Posologie mPosologieLignePrescription;
		public Posologie PosologieLignePrescription {
    			get {
      				return  mPosologieLignePrescription;
    			}
    			set {
      				mPosologieLignePrescription=value;
    			}
		    }
		private decimal mQuantité;
		public decimal Quantité {
    			get {
      				return  mQuantité;
    			}
    			set {
      				mQuantité=value;
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
       