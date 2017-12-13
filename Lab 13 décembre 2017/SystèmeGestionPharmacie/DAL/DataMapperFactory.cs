
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace SystèmeGestionPharmacie.DAL
{
    public abstract class DataMapperFactory
    {
        	
		public abstract IPrescriptionMapper GetPrescriptionMapper();
	    	
		public abstract IPatientMapper GetPatientMapper();
	    	
		public abstract IMédicamentMapper GetMédicamentMapper();
	    	
		public abstract ITransactionVenteMapper GetTransactionVenteMapper();
	    	
		public abstract IRuptureDeStockMapper GetRuptureDeStockMapper();
	    	
		public abstract IMédecinMapper GetMédecinMapper();
	    	
		public abstract IPharmacieMapper GetPharmacieMapper();
	    	
		public abstract ILigneTransactionVenteMapper GetLigneTransactionVenteMapper();
	    	
		public abstract IUtilisateurMapper GetUtilisateurMapper();
	    	
		public abstract ISessionMapper GetSessionMapper();
	    	
		public abstract IPharmacienMapper GetPharmacienMapper();
	    	
		public abstract IPaiementMapper GetPaiementMapper();
	    	
		public abstract IPrescriptionLignePrescriptionMédicamentMapper GetPrescriptionLignePrescriptionMédicamentMapper();
	      
        
        public static DataMapperFactory GetDataMapperFactory()
        {
            switch (GlobalConfig.getMapperType())
            {
                case MapperType.MEMORY:
                    return null;
                case MapperType.MSSQL:
                    return new MSSQL.MSSQLDataMapperFactory();
                case MapperType.MYSQL:
                    return null;
                case MapperType.ORACLE:
                    return null;
                case MapperType.FLAT_FILE:
                    return null;
                case MapperType.NONE:
                    return null;
                default:
                    return null;
            }

        }
    }
}

       