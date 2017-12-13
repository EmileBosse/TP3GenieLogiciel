
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SystèmeGestionPharmacie.DAL.MSSQL
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
	    
		public override IMédicamentMapper GetMédicamentMapper()
        	{
            		return new MédicamentMapper();
        	}
	    
		public override ITransactionVenteMapper GetTransactionVenteMapper()
        	{
            		return new TransactionVenteMapper();
        	}
	    
		public override IRuptureDeStockMapper GetRuptureDeStockMapper()
        	{
            		return new RuptureDeStockMapper();
        	}
	    
		public override IMédecinMapper GetMédecinMapper()
        	{
            		return new MédecinMapper();
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
	    
		public override IPrescriptionLignePrescriptionMédicamentMapper GetPrescriptionLignePrescriptionMédicamentMapper()
        	{
            		return new PrescriptionLignePrescriptionMédicamentMapper();
        	}
	   

    }
}
       