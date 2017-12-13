<xsl:stylesheet xmlns:xsl="http://www.w3.org/1999/XSL/Transform"  xmlns:uFN="uFN" version="2.0">
  <xsl:import href="utilFunctions.xsl"/>
	<xsl:output method="text" encoding="iso-8859-1" indent="yes"/>

  <xsl:template match="Project/Models">
           <xsl:variable name="projectName" select="/Project/@Name"/>
	   <xsl:result-document href="{$projectName}/Logique/DomainObject.cs">
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace <xsl:value-of select="$projectName"/>.Logique
{
    public class DomainObject
    {
        private Guid lID;

        public DomainObject()
        {
            lID = Guid.NewGuid();
        }

        public Guid ID
        {
            get { return lID; }
            set { lID = value; }
        }
    }
}


       </xsl:result-document>
</xsl:template>
</xsl:stylesheet>

