
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Syst�meGestionPharmacie.DAL.MSSQL
{
    public class MSSQLDataMapperFactory : DataMapperFactory
    {
        public MSSQLDataMapperFactory()
        {
        }

        
		public override IPrescriptionMapper GetPrescriptionMapper()
        	{
            		return new PrescriptionMapper();
        	}
	    
		public override IPatientMapper GetPatientMapper()
        	{
            		return new PatientMapper();
        	}
	    
		public override IM�dicamentMapper GetM�dicamentMapper()
        	{
            		return new M�dicamentMapper();
        	}
	    
		public override ITransactionVenteMapper GetTransactionVenteMapper()
        	{
            		return new TransactionVenteMapper();
        	}
	    
		public override IRuptureDeStockMapper GetRuptureDeStockMapper()
        	{
            		return new RuptureDeStockMapper();
        	}
	    
		public override IM�decinMapper GetM�decinMapper()
        	{
            		return new M�decinMapper();
        	}
	    
		public override IPharmacieMapper GetPharmacieMapper()
        	{
            		return new PharmacieMapper();
        	}
	    
		public override ILigneTransactionVenteMapper GetLigneTransactionVenteMapper()
        	{
            		return new LigneTransactionVenteMapper();
        	}
	    
		public override IUtilisateurMapper GetUtilisateurMapper()
        	{
            		return new UtilisateurMapper();
        	}
	    
		public override ISessionMapper GetSessionMapper()
        	{
            		return new SessionMapper();
        	}
	    
		public override IPharmacienMapper GetPharmacienMapper()
        	{
            		return new PharmacienMapper();
        	}
	    
		public override IPaiementMapper GetPaiementMapper()
        	{
            		return new PaiementMapper();
        	}
	    
		public override IPrescriptionLignePrescriptionM�dicamentMapper GetPrescriptionLignePrescriptionM�dicamentMapper()
        	{
            		return new PrescriptionLignePrescriptionM�dicamentMapper();
        	}
	   

    }
}
       