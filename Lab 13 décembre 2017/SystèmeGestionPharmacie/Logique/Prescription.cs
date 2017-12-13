
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace Syst�meGestionPharmacie.Logique
{
public class Prescription : DomainObject
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
	
		private Dictionary<Guid, M�dicament> lsM�dicament = new Dictionary<Guid, M�dicament>();
		public Dictionary<Guid, M�dicament> ListM�dicament
        	{
            		get { return lsM�dicament; }
            		set { lsM�dicament = value; }
        	}
	
 
 }
}	
       