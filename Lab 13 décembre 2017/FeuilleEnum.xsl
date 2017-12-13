<xsl:stylesheet xmlns:xsl="http://www.w3.org/1999/XSL/Transform"  xmlns:uFN="uFN" version="2.0">
  <xsl:import href="utilFunctions.xsl"/>
	<xsl:output method="text" encoding="iso-8859-1" indent="yes"/>

  <xsl:template match="Project/Models">
           <xsl:variable name="projectName" select="/Project/@Name"/>
	   <xsl:result-document href="{$projectName}/DAL/Enum.cs">
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace <xsl:value-of select="$projectName"/>.DAL
{
    public enum MapperType
    {
        MEMORY,
        MYSQL,
        MSSQL,
        ORACLE,
        FLAT_FILE,
        NONE
    }
}


       </xsl:result-document>
</xsl:template>
</xsl:stylesheet>

