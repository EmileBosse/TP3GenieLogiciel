
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace Syst�meGestionPharmacie.Logique
{
public class Posologie : DomainObject
 {
		private decimal mNombreUnit�sParJour;
		public decimal NombreUnit�sParJour {
    			get {
      				return  mNombreUnit�sParJour;
    			}
    			set {
      				mNombreUnit�sParJour=value;
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
       