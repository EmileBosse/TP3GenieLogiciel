
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace Syst�meGestionPharmacie.Logique
{
public class RuptureDeStock : DomainObject
 {
		private DateTime mDateRuptureDeStock;
		public DateTime DateRuptureDeStock {
    			get {
      				return  mDateRuptureDeStock;
    			}
    			set {
      				mDateRuptureDeStock=value;
    			}
		    }
		private decimal mQuantit�Demand�e;
		public decimal Quantit�Demand�e {
    			get {
      				return  mQuantit�Demand�e;
    			}
    			set {
      				mQuantit�Demand�e=value;
    			}
		    }
	
 
 }
}	
       