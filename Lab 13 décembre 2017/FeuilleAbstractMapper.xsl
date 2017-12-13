<xsl:stylesheet xmlns:xsl="http://www.w3.org/1999/XSL/Transform"  xmlns:uFN="uFN" version="2.0">
  <xsl:import href="utilFunctions.xsl"/>
	<xsl:output method="text" encoding="iso-8859-1" indent="yes"/>

  <xsl:template match="Project/Models">
           <xsl:variable name="projectName" select="/Project/@Name"/>
	   <xsl:result-document href="{$projectName}/DAL/MSSQL//AbstractMapper.cs">
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using <xsl:value-of select="$projectName"/>.Logique;

namespace <xsl:value-of select="$projectName"/>.DAL.MSSQL
{
    public abstract class AbstractMapper
    {
        private Dictionary<xsl:text>&lt;</xsl:text>Guid, DomainObject<xsl:text>&gt;</xsl:text> lLoadedMap = new Dictionary<xsl:text>&lt;</xsl:text>Guid, DomainObject<xsl:text>&gt;</xsl:text>();

        public AbstractMapper() { }

        protected DomainObject AbstractFind(Guid pID)
        {
            if (lLoadedMap.ContainsKey(pID))
            {
                return lLoadedMap[pID];
            }
            return null;
        }

        protected Dictionary<xsl:text>&lt;</xsl:text>Guid, DomainObject<xsl:text>&gt;</xsl:text> LoadedMap
        {
            get { return lLoadedMap; }
            set { lLoadedMap = value; }
        }

    }
}

       </xsl:result-document>
</xsl:template>
</xsl:stylesheet>

