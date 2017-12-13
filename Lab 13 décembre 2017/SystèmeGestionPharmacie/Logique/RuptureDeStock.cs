
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace SystèmeGestionPharmacie.Logique
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
		private decimal mQuantitéDemandée;
		public decimal QuantitéDemandée {
    			get {
      				return  mQuantitéDemandée;
    			}
    			set {
      				mQuantitéDemandée=value;
    			}
		    }
	
 
 }
}	
       