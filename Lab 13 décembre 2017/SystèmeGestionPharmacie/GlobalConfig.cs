
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SystèmeGestionPharmacie.DAL;
namespace SystèmeGestionPharmacie
{
    public static class GlobalConfig
    {

        public static string getConnectionString()
        {
            return "Data Source=.;Initial Catalog=SystèmeGestionPharmacieDB;Trusted_Connection=Yes";
        }

        public static MapperType getMapperType()
        {
            return MapperType.MSSQL;
        }
    }
}

       