<xsl:stylesheet xmlns:xsl="http://www.w3.org/1999/XSL/Transform"  xmlns:uFN="uFN" version="2.0">
  <xsl:import href="utilFunctions.xsl"/>
	<xsl:output method="text" encoding="iso-8859-1" indent="yes"/>

  <xsl:template match="Project/Models">
           <xsl:variable name="projectName" select="/Project/@Name"/>
	   <xsl:result-document href="{$projectName}/GlobalConfig.cs">
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using <xsl:value-of select="$projectName"/>.DAL;
namespace <xsl:value-of select="$projectName"/>
{
    public static class GlobalConfig
    {

        public static string getConnectionString()
        {
            return "Data Source=.;Initial Catalog=<xsl:value-of select="$projectName"/>DB;Trusted_Connection=Yes";
        }

        public static MapperType getMapperType()
        {
            return MapperType.MSSQL;
        }
    }
}

       </xsl:result-document>
</xsl:template>
</xsl:stylesheet>

