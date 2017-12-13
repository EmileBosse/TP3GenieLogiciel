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
    <xsl:result-document href="{$projectName}/DAL/MSSQL//{$contextName}Mapper.cs">

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using <xsl:value-of select="$projectName"/>.Logique;

namespace <xsl:value-of select="$projectName"/>.DAL.MSSQL
{
    public class <xsl:value-of select="$contextName"/>Mapper : AbstractMapper, I<xsl:value-of select="$contextName"/>Mapper
    {

        public <xsl:value-of select="$contextName"/>Mapper()
        {
        }

        //--------------------------------------------------------------------
        public <xsl:value-of select="$contextName"/> Find(Guid ID)
        {
            <xsl:value-of select="$contextName"/> l<xsl:value-of select="$contextName"/> = (<xsl:value-of select="$contextName"/>)AbstractFind(ID);

            if (Util.isNULL(l<xsl:value-of select="$contextName"/>))
            {
                DataRow row = DataBase.SelectID(ID, "[tbl<xsl:value-of select="$contextName"/>]");
                if (Util.isNULL(row))
                    return null;
                l<xsl:value-of select="$contextName"/> = this.FillFields(row);
                LoadedMap.Add(l<xsl:value-of select="$contextName"/>.ID, l<xsl:value-of select="$contextName"/>); 
            }
            return l<xsl:value-of select="$contextName"/>;
        }


        //--------------------------------------------------------------------
        private <xsl:value-of select="$contextName"/> FillFields(DataRow pDataRow)
        {
            <xsl:value-of select="$contextName"/> l<xsl:value-of select="$contextName"/> = new <xsl:value-of select="$contextName"/>();
	    <xsl:for-each select=".//Attribute">
		<xsl:if test="not(./Stereotypes/Stereotype[@Name='Embedded'])">
		 <xsl:variable name="attributeType" select="concat(concat(.//DataType/@Name, ./@Type), ./@TypeModifier)"/>
                 l<xsl:value-of select="$contextName"/>.<xsl:value-of select="uFN:first-upper(@Name)"/> = (<xsl:value-of select="$attributeType"/>)pDataRow["<xsl:value-of select="uFN:first-upper(@Name)"/>"];
		</xsl:if>
		<xsl:if test="./Stereotypes/Stereotype[@Name='Embedded']">
		 <xsl:variable name="embeddedAttributeName" select="./@Name"/>
		 <xsl:variable name="attributeTypeClassRef" select="./Type/Class/@Idref"/>
	         <xsl:variable name="attributeTypeClass" select="/Project/Models/Package/ModelChildren/Class[@Id=$attributeTypeClassRef]"/>
	         <xsl:for-each select="$attributeTypeClass//Attribute">
	          <xsl:variable name="attributeType" select="concat(concat(.//DataType/@Name, ./@Type), ./@TypeModifier)"/>
                  l<xsl:value-of select="$contextName"/>.<xsl:value-of select="uFN:first-upper($embeddedAttributeName)"/>.<xsl:value-of select="uFN:first-upper(@Name)"/> = (<xsl:value-of select="$attributeType"/>)pDataRow["<xsl:value-of select="uFN:first-upper(@Name)"/>"];
	         </xsl:for-each>
                </xsl:if>
	    </xsl:for-each>

            l<xsl:value-of select="$contextName"/>.ID = new Guid(pDataRow["ID"].ToString());
	    l<xsl:value-of select="$contextName"/>.ID<xsl:value-of select="$fromEndAssociationClassName"/> = new Guid(pDataRow["ID<xsl:value-of select="$fromEndAssociationClassName"/>"].ToString());
	    l<xsl:value-of select="$contextName"/>.ID<xsl:value-of select="$toEndAssociationClassName"/> = new Guid(pDataRow["ID<xsl:value-of select="$toEndAssociationClassName"/>"].ToString());
            return l<xsl:value-of select="$contextName"/>;
        }

        //--------------------------------------------------------------------
        public DataTable FindAll()
        {
            return DataBase.SelectTable("[tbl<xsl:value-of select="$contextName"/>]", "");
        }


	

        //---------------------------------------------------------------------
        private void FillArray(ref string[] pCols, ref string[] pValues, <xsl:value-of select="$contextName"/> p<xsl:value-of select="$contextName"/>, bool pIsInsertID)
        {
            int liCpt = 0;
            int liNombre = <xsl:value-of select="count(.//Attribute[not(Stereotypes/Stereotype[@Name='Embedded'])])"/> + 2;
            if (pIsInsertID)
            {
                pCols = new string[liNombre + 1];
                pValues = new string[liNombre + 1];
                pCols[liCpt] = "ID";
                pValues[liCpt++] = "'" + p<xsl:value-of select="$contextName"/>.ID.ToString() + "'";
            }
            else
            {
                pCols = new string[liNombre];
                pValues = new string[liNombre];
            }

	    <xsl:for-each select=".//Attribute">
	      <xsl:if test="not(./Stereotypes/Stereotype[@Name='Embedded'])">
		<xsl:variable name="attributeType" select="concat(concat(.//DataType/@Name, ./@Type), ./@TypeModifier)"/>
		pCols[liCpt] = "<xsl:value-of select="uFN:first-upper(@Name)"/>";
		<xsl:choose>
    			<xsl:when test="$attributeType = 'int' or $attributeType = 'float' or $attributeType = 'double' or $attributeType = 'decimal' or $attributeType = 'DateTime'">
      		      		pValues[liCpt++] = "'" + p<xsl:value-of select="$contextName"/>.<xsl:value-of select="uFN:first-upper(@Name)"/>.ToString() + "'"; 
			</xsl:when>
			<xsl:when test="$attributeType = 'byte[]'">
      		      		pValues[liCpt++] = "0x" + BitConverter.ToString(p<xsl:value-of select="$contextName"/>.<xsl:value-of select="uFN:first-upper(@Name)"/>).Replace("-", "");
			</xsl:when>
    			<xsl:otherwise>
				pValues[liCpt++] = "'" + Util.DoubleQuote(p<xsl:value-of select="$contextName"/>.<xsl:value-of select="uFN:first-upper(@Name)"/>) + "'";
  			</xsl:otherwise>
		</xsl:choose>
	      </xsl:if>
		<xsl:if test="./Stereotypes/Stereotype[@Name='Embedded']">
		 <xsl:variable name="embeddedAttributeName" select="./@Name"/>
		 <xsl:variable name="attributeTypeClassRef" select="./Type/Class/@Idref"/>
	         <xsl:variable name="attributeTypeClass" select="/Project/Models/Package/ModelChildren/Class[@Id=$attributeTypeClassRef]"/>
	         <xsl:for-each select="$attributeTypeClass//Attribute">
		  liNombre++;
	          <xsl:variable name="attributeType" select="concat(concat(.//DataType/@Name, ./@Type), ./@TypeModifier)"/>
		pCols[liCpt] = "<xsl:value-of select="uFN:first-upper(@Name)"/>";
		<xsl:choose>
    			<xsl:when test="$attributeType = 'int' or $attributeType = 'float' or $attributeType = 'double' or $attributeType = 'decimal' or $attributeType = 'DateTime'">
      		      		pValues[liCpt++] = "'" + p<xsl:value-of select="$contextName"/>.<xsl:value-of select="uFN:first-upper($embeddedAttributeName)"/>.<xsl:value-of select="uFN:first-upper(@Name)"/>.ToString() + "'"; 
			</xsl:when>
			<xsl:when test="$attributeType = 'byte[]'">
      		      		pValues[liCpt++] = "0x" + BitConverter.ToString(p<xsl:value-of select="$contextName"/>.<xsl:value-of select="uFN:first-upper($embeddedAttributeName)"/>.<xsl:value-of select="uFN:first-upper(@Name)"/>).Replace("-", "");
			</xsl:when>
    			<xsl:otherwise>
				pValues[liCpt++] = "'" + Util.DoubleQuote(p<xsl:value-of select="$contextName"/>.<xsl:value-of select="uFN:first-upper($embeddedAttributeName)"/>.<xsl:value-of select="uFN:first-upper(@Name)"/>) + "'";
  			</xsl:otherwise>
		</xsl:choose>
	         </xsl:for-each>
                </xsl:if>
	    </xsl:for-each>
	    pCols[liCpt] = "ID<xsl:value-of select="$fromEndAssociationClassName"/>";
            pValues[liCpt++] = "'" + p<xsl:value-of select="$contextName"/>.ID<xsl:value-of select="$fromEndAssociationClassName"/>.ToString() + "'";
	    pCols[liCpt] = "ID<xsl:value-of select="$toEndAssociationClassName"/>";
            pValues[liCpt++] = "'" + p<xsl:value-of select="$contextName"/>.ID<xsl:value-of select="$toEndAssociationClassName"/>.ToString() + "'";
        }

        //----------------------------------------------------------------------------------------
        public int Delete(<xsl:value-of select="$contextName"/> p<xsl:value-of select="$contextName"/>)
        {
            int liErreur = int.MinValue;
            int liTemp;
            int liI = 0;

            liTemp = DataBase.DeleteID(p<xsl:value-of select="$contextName"/>.ID, "[tbl<xsl:value-of select="$contextName"/>]");
            if (liTemp == liErreur)
                liI = liErreur;
            if (liI != liErreur)
                liI += liTemp;
	    
            return liI;
        }

        //--------------------------------------------------------------------

        public int Insert(<xsl:value-of select="$contextName"/> p<xsl:value-of select="$contextName"/>)
        {
            string[] lsCols = null;
            string[] lsValues = null;
            this.FillArray(ref lsCols, ref lsValues, p<xsl:value-of select="$contextName"/>, true);
            return DataBase.Insert("[tbl<xsl:value-of select="$contextName"/>]", lsCols, lsValues);
        }

        
        //---------------------------------------------------------------------
        public int Update(<xsl:value-of select="$contextName"/> p<xsl:value-of select="$contextName"/>)
        {
            string[] lsCols = null;
            string[] lsValues = null;

            this.FillArray(ref lsCols, ref lsValues, p<xsl:value-of select="$contextName"/>, false);
            return DataBase.UpdateID("tbl<xsl:value-of select="$contextName"/>", lsCols, lsValues, p<xsl:value-of select="$contextName"/>.ID);
        }

    }
}

</xsl:result-document>
</xsl:template>



</xsl:stylesheet>

