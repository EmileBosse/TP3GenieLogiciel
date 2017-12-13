<xsl:stylesheet xmlns:xsl="http://www.w3.org/1999/XSL/Transform"  xmlns:uFN="uFN" version="2.0">
  <xsl:import href="utilFunctions.xsl"/>
	<xsl:output method="text" encoding="iso-8859-1" indent="yes"/>

  <xsl:template match="Project/Models/Package/ModelChildren/Class[not (.//AssociationClass)]">
	<xsl:if test="not(./Stereotypes/Stereotype[@Name='Embedded'])">
	   <xsl:variable name="projectName" select="/Project/@Name"/>
           <xsl:variable name="contextName" select="@Name"/>
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
	<xsl:for-each select="/.//Association/ToEnd/AssociationEnd[@EndModelElement=$iDClass and (../../FromEnd/AssociationEnd/@Multiplicity='1' or ../../FromEnd/AssociationEnd/@Multiplicity='Unspecified' or../../FromEnd/AssociationEnd/@Multiplicity='0..1') ]">
		<xsl:variable name="fromEndId" select="../../FromEnd/AssociationEnd/@EndModelElement"/>
		<xsl:variable name="fromEndClassName" select="/.//Class[@Id=$fromEndId]/@Name"/>
		<xsl:if test="@Multiplicity='*' or @Multiplicity='0..*' or @Multiplicity='1..*'">DataTable FindAllPourUn<xsl:value-of select="$fromEndClassName"/>(Guid p<xsl:value-of select="$fromEndClassName"/>Id);</xsl:if>
	</xsl:for-each>
	int Insert(<xsl:value-of select="$contextName"/> p<xsl:value-of select="$contextName"/>);
        int Update(<xsl:value-of select="$contextName"/> p<xsl:value-of select="$contextName"/>);
        int Delete(<xsl:value-of select="$contextName"/> p<xsl:value-of select="$contextName"/>);

	<xsl:for-each select="/.//Association/FromEnd/AssociationEnd[@EndModelElement=$iDClass and (@Multiplicity='*' or @Multiplicity='0..*' or @Multiplicity='1..*') and (../../ToEnd/AssociationEnd/@Multiplicity='*' or ../../ToEnd/AssociationEnd/@Multiplicity='0..*' or ../../ToEnd/AssociationEnd/@Multiplicity='1..*')]">
		<xsl:variable name="toEndId" select="../../ToEnd/AssociationEnd/@EndModelElement"/>
		<xsl:variable name="toEndClassName" select="/.//Class[@Id=$toEndId]/@Name"/>
		DataTable FindAll<xsl:value-of select="$toEndClassName"/>Table(<xsl:value-of select="$contextName"/> p<xsl:value-of select="$contextName"/>);
        	void FindAll<xsl:value-of select="$toEndClassName"/>(ref <xsl:value-of select="$contextName"/> p<xsl:value-of select="$contextName"/>);
		int InsertAll<xsl:value-of select="$toEndClassName"/>(<xsl:value-of select="$contextName"/> p<xsl:value-of select="$contextName"/>);
	</xsl:for-each>
 }
}	
       </xsl:result-document>
</xsl:if>
</xsl:template>
</xsl:stylesheet>

