<xsl:stylesheet xmlns:xsl="http://www.w3.org/1999/XSL/Transform"  xmlns:uFN="uFN" version="2.0">
  <xsl:import href="utilFunctions.xsl"/>
	<xsl:output method="text" encoding="iso-8859-1" indent="yes"/>

  <xsl:template match="Project/Models/Package/ModelChildren/Class[.//AssociationClass]">
	<xsl:variable name="projectName" select="/Project/@Name"/>
        <xsl:variable name="associationClassIdref" select=".//AssociationClass/@Idref"/>
	<xsl:variable name="associationClass" select="/.//Association[.//AssociationClass/@Idref=$associationClassIdref]"/>
	<xsl:variable name="fromEndAssociationClassId" select="$associationClass/FromEnd/AssociationEnd/@EndModelElement"/>
	<xsl:variable name="fromEndAssociationClassName" select="/.//Class[@Id=$fromEndAssociationClassId]/@Name"/>
	<xsl:variable name="toEndAssociationClassId" select="$associationClass/ToEnd/AssociationEnd/@EndModelElement"/>
	<xsl:variable name="toEndAssociationClassName" select="/.//Class[@Id=$toEndAssociationClassId]/@Name"/>
	<xsl:variable name="contextName" select="concat($fromEndAssociationClassName, concat(uFN:first-upper(@Name), $toEndAssociationClassName))"/>
	<xsl:variable name="iDClass" select="@Id"/>
	   <xsl:result-document href="{$projectName}/DAL//I{$contextName}Mapper.cs">
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using <xsl:value-of select="$projectName"/>.Logique;
namespace <xsl:value-of select="$projectName"/>.DAL
{
public interface I<xsl:value-of select="$contextName"/>Mapper
 {
	<xsl:value-of select="$contextName"/> Find(Guid ID);
        DataTable FindAll();
	int Insert(<xsl:value-of select="$contextName"/> p<xsl:value-of select="$contextName"/>);
        int Update(<xsl:value-of select="$contextName"/> p<xsl:value-of select="$contextName"/>);
        int Delete(<xsl:value-of select="$contextName"/> p<xsl:value-of select="$contextName"/>);
 }
}	
       </xsl:result-document>
</xsl:template>
</xsl:stylesheet>

