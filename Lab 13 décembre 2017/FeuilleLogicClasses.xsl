<xsl:stylesheet xmlns:xsl="http://www.w3.org/1999/XSL/Transform"  xmlns:uFN="uFN" version="2.0">
  <xsl:import href="utilFunctions.xsl"/>
	<xsl:output method="text" encoding="iso-8859-1" indent="yes"/>

  <xsl:template match="Project/Models/Package/ModelChildren/Class[not (.//AssociationClass)]">
	   <xsl:variable name="projectName" select="/Project/@Name"/>
           <xsl:variable name="contextName" select="@Name"/>
	   <xsl:variable name="iDClass" select="@Id"/>
	   <xsl:result-document href="{$projectName}/Logique//{$contextName}.cs">
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace <xsl:value-of select="$projectName"/>.Logique
{
public class <xsl:value-of select="$contextName"/> : <xsl:if test="/.//Generalization[@To=$iDClass]"><xsl:value-of select="/.//Class[@Id=/.//Generalization[@To=$iDClass]/@From]/@Name"/></xsl:if><xsl:if test="not(/.//Generalization[@To=$iDClass])">DomainObject</xsl:if>
 {
	<xsl:for-each select=".//Attribute">
	    <xsl:variable name="attributeType">
	   	<xsl:if test="not(./Stereotypes/Stereotype[@Name='Embedded'])">
		   <xsl:value-of select="concat(concat(.//DataType/@Name, ./@Type), ./@TypeModifier)"/>
		</xsl:if>
	        <xsl:if test="./Stereotypes/Stereotype[@Name='Embedded']">
		   <xsl:variable name="attributeTypeClassRef" select="./Type/Class/@Idref"/>
	           <xsl:variable name="attributeTypeClass" select="/Project/Models/Package/ModelChildren/Class[@Id=$attributeTypeClassRef]"/>
	           <xsl:value-of select="$attributeTypeClass/@Name"/>
                </xsl:if>
	   </xsl:variable>
		<xsl:text>&#x9;</xsl:text>
		<xsl:value-of select="@Visibility"/>
		<xsl:text>&#x20;</xsl:text>
		<xsl:value-of select="$attributeType"/>
		<xsl:text> m</xsl:text>
		<xsl:value-of select="uFN:first-upper(@Name)"/>;
		public <xsl:value-of select="$attributeType"/> <xsl:text>&#x20;</xsl:text> <xsl:value-of select="uFN:first-upper(./@Name)"/> {
    			get {
      				return <xsl:text> m</xsl:text><xsl:value-of select="uFN:first-upper(@Name)"/>;
    			}
    			set {
      				<xsl:text>m</xsl:text><xsl:value-of select="uFN:first-upper(@Name)"/>=value;
    			}
		    }
	</xsl:for-each>

	<xsl:for-each select="/.//Association/ToEnd/AssociationEnd[@EndModelElement=$iDClass and (../../FromEnd/AssociationEnd/@Multiplicity='1' or ../../FromEnd/AssociationEnd/@Multiplicity='Unspecified' or../../FromEnd/AssociationEnd/@Multiplicity='0..1')]">
		<xsl:variable name="fromEndId" select="../../FromEnd/AssociationEnd/@EndModelElement"/>
		<xsl:variable name="fromEndClassName" select="/.//Class[@Id=$fromEndId]/@Name"/>
		private Guid<xsl:if test= "../../FromEnd/AssociationEnd/@Multiplicity='0..1'">?</xsl:if> mID<xsl:value-of select="$fromEndClassName"/>;
		public Guid<xsl:if test= "../../FromEnd/AssociationEnd/@Multiplicity='0..1'">?</xsl:if> ID<xsl:value-of select="$fromEndClassName"/>
        	{
            		get { return mID<xsl:value-of select="$fromEndClassName"/>; }
            		set { mID<xsl:value-of select="$fromEndClassName"/> = value; }
        	}
	</xsl:for-each>

	<xsl:for-each select="/.//Association/FromEnd/AssociationEnd[@EndModelElement=$iDClass and (@Multiplicity='*' or @Multiplicity='0..*' or @Multiplicity='1..*') and (../../ToEnd/AssociationEnd/@Multiplicity='*' or ../../ToEnd/AssociationEnd/@Multiplicity='0..*' or ../../ToEnd/AssociationEnd/@Multiplicity='1..*')]">
		<xsl:variable name="toEndId" select="../../ToEnd/AssociationEnd/@EndModelElement"/>
		<xsl:variable name="toEndClassName" select="/.//Class[@Id=$toEndId]/@Name"/>
		private Dictionary&#60;Guid, <xsl:value-of select="$toEndClassName"/>&#62; ls<xsl:value-of select="$toEndClassName"/> = new Dictionary&#60;Guid, <xsl:value-of select="$toEndClassName"/>&#62;();
		public Dictionary&#60;Guid, <xsl:value-of select="$toEndClassName"/>&#62; List<xsl:value-of select="$toEndClassName"/>
        	{
            		get { return ls<xsl:value-of select="$toEndClassName"/>; }
            		set { ls<xsl:value-of select="$toEndClassName"/> = value; }
        	}
	</xsl:for-each>
 
 }
}	
       </xsl:result-document>
</xsl:template>
</xsl:stylesheet>

