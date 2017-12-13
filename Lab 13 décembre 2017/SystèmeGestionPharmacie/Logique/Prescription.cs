
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace SystèmeGestionPharmacie.Logique
{
public class Prescription : DomainObject
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
		private DateTime mDatePresciption;
		public DateTime DatePresciption {
    			get {
      				return  mDatePresciption;
    			}
    			set {
      				mDatePresciption=value;
    			}
		    }
		private byte[] mCopiePrescription;
		public byte[] CopiePrescription {
    			get {
      				return  mCopiePrescription;
    			}
    			set {
      				mCopiePrescription=value;
    			}
		    }
	
		private Dictionary<Guid, Médicament> lsMédicament = new Dictionary<Guid, Médicament>();
		public Dictionary<Guid, Médicament> ListMédicament
        	{
            		get { return lsMédicament; }
            		set { lsMédicament = value; }
        	}
	
 
 }
}	
       