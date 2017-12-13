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
	<xsl:result-document href="{$projectName}/Logique//{$contextName}.cs">
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace <xsl:value-of select="$projectName"/>.Logique
{
public class <xsl:value-of select="$contextName"/> : DomainObject
 {		private Guid mID<xsl:value-of select="$fromEndAssociationClassName"/>;
		public Guid <xsl:text>&#x20;</xsl:text> ID<xsl:value-of select="$fromEndAssociationClassName"/> {
    			get {
      				return mID<xsl:value-of select="$fromEndAssociationClassName"/>;
    			}
    			set {
      				mID<xsl:value-of select="$fromEndAssociationClassName"/>=value;
    			}
		}
        	private Guid mID<xsl:value-of select="$toEndAssociationClassName"/>;
		public Guid <xsl:text>&#x20;</xsl:text> ID<xsl:value-of select="$toEndAssociationClassName"/> {
    			get {
      				return mID<xsl:value-of select="$toEndAssociationClassName"/>;
    			}
    			set {
      				mID<xsl:value-of select="$toEndAssociationClassName"/>=value;
    			}
		}
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
      				m<xsl:value-of select="uFN:first-upper(@Name)"/>=value;
    			}
		    }
	</xsl:for-each>

 }
}	
       </xsl:result-document>
</xsl:template>
</xsl:stylesheet>

