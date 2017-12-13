<xsl:stylesheet xmlns:xsl="http://www.w3.org/1999/XSL/Transform" xmlns:UML="//org.omg/UML/1.3" xmlns:uUML="uUML" xmlns:uFN="uFN" xmlns:iUML="iUML" version="2.0">
<xsl:import href="utilFunctions.xsl"/>
<xsl:output method="text"/>

<xsl:template match="Project/Models/Package/ModelChildren">
	<xsl:variable name="projectName" select="/Project/@Name"/>
	<xsl:result-document href="{$projectName}/ScriptSQL.sql">
CREATE DATABASE <xsl:value-of select="$projectName"/>DB
GO
Use <xsl:value-of select="$projectName"/>DB
Go
<xsl:for-each select="./Class[not (.//AssociationClass)]">
<xsl:if test="not(./Stereotypes/Stereotype[@Name='Embedded'])">
<xsl:variable name="contextName" select="@Name"/>
<xsl:variable name="iDClass" select="@Id"/>

<xsl:text>CREATE TABLE [dbo].[</xsl:text>
<xsl:value-of select="concat('tbl', $contextName)"/>
<xsl:text>] (&#xD;</xsl:text>
	<xsl:text>[ID] [uniqueidentifier] NOT NULL,&#xD;</xsl:text>
<xsl:for-each select=".//Attribute">
   <xsl:if test="not(./Stereotypes/Stereotype[@Name='Embedded'])">
	<xsl:variable name="attributeType" select="concat(concat(.//DataType/@Name, ./@Type), ./@TypeModifier)"/>
	<xsl:value-of select="uFN:first-lower(@Name)"/>
	<xsl:text>&#032;</xsl:text>
	<xsl:value-of select="uFN:database-type($attributeType)"/>
	<xsl:text>, </xsl:text>
	<xsl:text>&#xD;</xsl:text>
  </xsl:if>
  <xsl:if test="./Stereotypes/Stereotype[@Name='Embedded']">
	<xsl:variable name="attributeTypeClassRef" select="./Type/Class/@Idref"/>
	<xsl:variable name="attributeTypeClass" select="/Project/Models/Package/ModelChildren/Class[@Id=$attributeTypeClassRef]"/>
	<xsl:for-each select="$attributeTypeClass//Attribute">
	 <xsl:variable name="attributeType" select="concat(concat(.//DataType/@Name, ./@Type), ./@TypeModifier)"/>
	 <xsl:value-of select="uFN:first-lower(@Name)"/>
	 <xsl:text>&#032;</xsl:text>
	 <xsl:value-of select="uFN:database-type($attributeType)"/>
	 <xsl:text>, </xsl:text>
	 <xsl:text>&#xD;</xsl:text>
	</xsl:for-each>
  </xsl:if>
</xsl:for-each>
<xsl:for-each select="/.//Association/ToEnd/AssociationEnd[@EndModelElement=$iDClass and (../../FromEnd/AssociationEnd/@Multiplicity='1' or ../../FromEnd/AssociationEnd/@Multiplicity='Unspecified' or../../FromEnd/AssociationEnd/@Multiplicity='0..1')]">
	<xsl:variable name="fromEndId" select="../../FromEnd/AssociationEnd/@EndModelElement"/>
	<xsl:variable name="fromEndClassName" select="/.//Class[@Id=$fromEndId]/@Name"/>
	<xsl:value-of select="concat('ID', $fromEndClassName)"/>
	<xsl:text>&#032; uniqueidentifier NOT NULL, </xsl:text>
	<xsl:text>&#xD;</xsl:text>
</xsl:for-each>
CONSTRAINT [<xsl:value-of select="concat('PK_tbl', $contextName)"/>] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
) 
) ON [PRIMARY]

GO
</xsl:if>
</xsl:for-each>    

<xsl:for-each select="./Class[.//AssociationClass]">
<xsl:variable name="associationClassIdref" select=".//AssociationClass/@Idref"/>
<xsl:variable name="associationClass" select="/.//Association[.//AssociationClass/@Idref=$associationClassIdref]"/>
<xsl:variable name="fromEndAssociationClassId" select="$associationClass/FromEnd/AssociationEnd/@EndModelElement"/>
<xsl:variable name="fromEndAssociationClassName" select="/.//Class[@Id=$fromEndAssociationClassId]/@Name"/>
<xsl:variable name="toEndAssociationClassId" select="$associationClass/ToEnd/AssociationEnd/@EndModelElement"/>
<xsl:variable name="toEndAssociationClassName" select="/.//Class[@Id=$toEndAssociationClassId]/@Name"/>
<xsl:variable name="contextName" select="concat($fromEndAssociationClassName, concat(uFN:first-upper(@Name), $toEndAssociationClassName))"/>
<xsl:text>CREATE TABLE [dbo].[</xsl:text>
<xsl:value-of select="concat('tbl', $contextName)"/>
<xsl:text>] (&#xD;</xsl:text>
	<xsl:text>ID uniqueidentifier NOT NULL,&#xD;</xsl:text>
	<xsl:value-of select="concat('ID', $fromEndAssociationClassName)"/><xsl:text> [uniqueidentifier] NOT NULL,&#xD;</xsl:text>
	<xsl:value-of select="concat('ID', $toEndAssociationClassName)"/><xsl:text>&#032; uniqueidentifier NOT NULL,&#xD;</xsl:text>
<xsl:for-each select=".//Attribute">
     <xsl:if test="not(./Stereotypes/Stereotype[@Name='Embedded'])">
	<xsl:variable name="attributeType" select="concat(concat(.//DataType/@Name, ./@Type), ./@TypeModifier)"/>
	<xsl:value-of select="uFN:first-lower(@Name)"/>
	<xsl:text>&#032;</xsl:text>
	<xsl:value-of select="uFN:database-type($attributeType)"/>
	<xsl:text>, </xsl:text>
	<xsl:text>&#xD;</xsl:text>
    </xsl:if>
    <xsl:if test="./Stereotypes/Stereotype[@Name='Embedded']">
	<xsl:variable name="attributeTypeClassRef" select="./Type/Class/@Idref"/>
	<xsl:variable name="attributeTypeClass" select="/Project/Models/Package/ModelChildren/Class[@Id=$attributeTypeClassRef]"/>
	<xsl:for-each select="$attributeTypeClass//Attribute">
	 <xsl:variable name="attributeType" select="concat(concat(.//DataType/@Name, ./@Type), ./@TypeModifier)"/>
	 <xsl:value-of select="uFN:first-lower(@Name)"/>
	 <xsl:text>&#032;</xsl:text>
	 <xsl:value-of select="uFN:database-type($attributeType)"/>
	 <xsl:text>, </xsl:text>
	 <xsl:text>&#xD;</xsl:text>
	</xsl:for-each>
   </xsl:if>
</xsl:for-each>
CONSTRAINT [<xsl:value-of select="concat('PK_tbl', $contextName)"/>] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)
) ON [PRIMARY]

GO
</xsl:for-each>    


</xsl:result-document>
</xsl:template>
</xsl:stylesheet>