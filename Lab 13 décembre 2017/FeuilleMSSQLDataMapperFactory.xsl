<xsl:stylesheet xmlns:xsl="http://www.w3.org/1999/XSL/Transform"  xmlns:uFN="uFN" version="2.0">
  <xsl:import href="utilFunctions.xsl"/>
	<xsl:output method="text" encoding="iso-8859-1" indent="yes"/>

  <xsl:template match="Project/Models">
           <xsl:variable name="projectName" select="/Project/@Name"/>
	   <xsl:result-document href="{$projectName}/DAL/MSSQL/MSSQLDataMapperFactory.cs">
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace <xsl:value-of select="$projectName"/>.DAL.MSSQL
{
    public class MSSQLDataMapperFactory : DataMapperFactory
    {
        public MSSQLDataMapperFactory()
        {
        }

        <xsl:for-each select="./Package/ModelChildren/Class[not(.//AssociationClass)]">
	    <xsl:if test="not(./Stereotypes/Stereotype[@Name='Embedded'])">
		<xsl:variable name="contextName" select="@Name"/>
		public override I<xsl:value-of select="$contextName"/>Mapper Get<xsl:value-of select="$contextName"/>Mapper()
        	{
            		return new <xsl:value-of select="$contextName"/>Mapper();
        	}
	    </xsl:if>
	</xsl:for-each>   
	<xsl:for-each select="./Package/ModelChildren/Class[.//AssociationClass]">
		<xsl:variable name="associationClassIdref" select=".//AssociationClass/@Idref"/>
		<xsl:variable name="associationClass" select="/.//Association[.//AssociationClass/@Idref=$associationClassIdref]"/>
		<xsl:variable name="fromEndAssociationClassId" select="$associationClass/FromEnd/AssociationEnd/@EndModelElement"/>
		<xsl:variable name="fromEndAssociationClassName" select="/.//Class[@Id=$fromEndAssociationClassId]/@Name"/>
		<xsl:variable name="toEndAssociationClassId" select="$associationClass/ToEnd/AssociationEnd/@EndModelElement"/>
		<xsl:variable name="toEndAssociationClassName" select="/.//Class[@Id=$toEndAssociationClassId]/@Name"/>
		<xsl:variable name="contextName" select="concat($fromEndAssociationClassName, concat(uFN:first-upper(@Name), $toEndAssociationClassName))"/>
		public override I<xsl:value-of select="$contextName"/>Mapper Get<xsl:value-of select="$contextName"/>Mapper()
        	{
            		return new <xsl:value-of select="$contextName"/>Mapper();
        	}
	</xsl:for-each>   

    }
}
       </xsl:result-document>
</xsl:template>
</xsl:stylesheet>

