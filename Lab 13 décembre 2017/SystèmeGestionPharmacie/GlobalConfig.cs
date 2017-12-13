
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Syst�meGestionPharmacie.DAL;
namespace Syst�meGestionPharmacie
{
    public static class GlobalConfig
    {

        public static string getConnectionString()
        {
            return "Data Source=.;Initial Catalog=Syst�meGestionPharmacieDB;Trusted_Connection=Yes";
        }

        public static MapperType getMapperType()
        {
            return MapperType.MSSQL;
        }
    }
}

       