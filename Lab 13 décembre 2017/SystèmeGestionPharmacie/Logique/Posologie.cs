
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace SystèmeGestionPharmacie.Logique
{
public class Posologie : DomainObject
 {
		private decimal mNombreUnitésParJour;
		public decimal NombreUnitésParJour {
    			get {
      				return  mNombreUnitésParJour;
    			}
    			set {
      				mNombreUnitésParJour=value;
    			}
		    }
		private int mNombreJours;
		public int NombreJours {
    			get {
      				return  mNombreJours;
    			}
    			set {
      				mNombreJours=value;
    			}
		    }
	
 
 }
}	
       