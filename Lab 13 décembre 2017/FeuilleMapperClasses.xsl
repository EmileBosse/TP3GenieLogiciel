<xsl:stylesheet xmlns:xsl="http://www.w3.org/1999/XSL/Transform"  xmlns:uFN="uFN" version="2.0">
  <xsl:import href="utilFunctions.xsl"/>
  <xsl:output method="text" encoding="iso-8859-1" indent="yes"/>

  <xsl:template match="Project/Models/Package/ModelChildren/Class[not (.//AssociationClass)]">
<xsl:if test="not(./Stereotypes/Stereotype[@Name='Embedded'])">
    <xsl:variable name="projectName" select="/Project/@Name"/>
    <xsl:variable name="contextName" select="@Name"/>
    <xsl:variable name="iDClass" select="@Id"/>
    <xsl:result-document href="{$projectName}/DAL/MSSQL//{$contextName}Mapper.cs">

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
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

	    <xsl:for-each select="/.//Association/ToEnd/AssociationEnd[@EndModelElement=$iDClass and (../../FromEnd/AssociationEnd/@Multiplicity='1' or ../../FromEnd/AssociationEnd/@Multiplicity='Unspecified' or../../FromEnd/AssociationEnd/@Multiplicity='0..1')]">
		<xsl:variable name="fromEndId" select="../../FromEnd/AssociationEnd/@EndModelElement"/>
		<xsl:variable name="fromEndClassName" select="//.//Class[@Id=$fromEndId]/@Name"/>
		if (pDataRow["ID<xsl:value-of select="$fromEndClassName"/>"].GetType() != typeof(System.DBNull))
			l<xsl:value-of select="$contextName"/>.ID<xsl:value-of select="$fromEndClassName"/> = new Guid(pDataRow["ID<xsl:value-of select="$fromEndClassName"/>"].ToString());
	    </xsl:for-each>
            return l<xsl:value-of select="$contextName"/>;
        }

        //--------------------------------------------------------------------
        public DataTable FindAll()
        {
            return DataBase.SelectTable("[tbl<xsl:value-of select="$contextName"/>]", "");
        }


	<xsl:for-each select="/.//Association/ToEnd/AssociationEnd[@EndModelElement=$iDClass and (../../FromEnd/AssociationEnd/@Multiplicity='1' or ../../FromEnd/AssociationEnd/@Multiplicity='Unspecified' or../../FromEnd/AssociationEnd/@Multiplicity='0..1') ]">
		<xsl:variable name="fromEndId" select="../../FromEnd/AssociationEnd/@EndModelElement"/>
		<xsl:variable name="fromEndClassName" select="/.//Class[@Id=$fromEndId]/@Name"/>
		
		<xsl:if test="@Multiplicity='*' or @Multiplicity='0..*' or @Multiplicity='1..*'">
		//--------------------------------------------------------------------
		public DataTable FindAllPourUn<xsl:value-of select="$fromEndClassName"/>(Guid p<xsl:value-of select="$fromEndClassName"/>Id)
		{
            		return DataBase.Select("SELECT * FROM tbl<xsl:value-of select="$contextName"/> WHERE ID<xsl:value-of select="$fromEndClassName"/>='" + p<xsl:value-of select="$fromEndClassName"/>Id.ToString() + "'");
        	}
		</xsl:if>
	</xsl:for-each>

	<xsl:for-each select="/.//Association/FromEnd/AssociationEnd[@EndModelElement=$iDClass and (@Multiplicity='*' or @Multiplicity='0..*' or @Multiplicity='1..*') and (../../ToEnd/AssociationEnd/@Multiplicity='*' or ../../ToEnd/AssociationEnd/@Multiplicity='0..*' or ../../ToEnd/AssociationEnd/@Multiplicity='1..*')]">
		<xsl:variable name="toEndId" select="../../ToEnd/AssociationEnd/@EndModelElement"/>
		<xsl:variable name="toEndClassName" select="/.//Class[@Id=$toEndId]/@Name"/>
		//--------------------------------------------------------------------
		public DataTable FindAll<xsl:value-of select="$toEndClassName"/>Table(<xsl:value-of select="$contextName"/> p<xsl:value-of select="$contextName"/>)
		{
			return DataBase.Select("SELECT * FROM tbl<xsl:value-of select="$contextName"/><xsl:value-of select="$toEndClassName"/> WHERE ID<xsl:value-of select="$contextName"/> = '" + p<xsl:value-of select="$contextName"/>.ID.ToString() + "'");
		}

		//--------------------------------------------------------------------
        	public void FindAll<xsl:value-of select="$toEndClassName"/>(ref <xsl:value-of select="$contextName"/> p<xsl:value-of select="$contextName"/>)
		{
			DataTable ldt<xsl:value-of select="$toEndClassName"/> = FindAll<xsl:value-of select="$toEndClassName"/>Table(p<xsl:value-of select="$contextName"/>);
			p<xsl:value-of select="$contextName"/>.List<xsl:value-of select="$toEndClassName"/>.Clear();
            		if (Util.isNULL(ldt<xsl:value-of select="$toEndClassName"/>)) return;
            		if (ldt<xsl:value-of select="$toEndClassName"/>.Rows.Count == 0) return;
			DataRow ldr<xsl:value-of select="$toEndClassName"/>;
            		IEnumerator l<xsl:value-of select="$toEndClassName"/>Enumerator = ldt<xsl:value-of select="$toEndClassName"/>.Rows.GetEnumerator();
            		<xsl:value-of select="$toEndClassName"/> l<xsl:value-of select="$toEndClassName"/>;
            		<xsl:value-of select="$toEndClassName"/>Mapper l<xsl:value-of select="$toEndClassName"/>Mapper = new <xsl:value-of select="$toEndClassName"/>Mapper();
            		while (l<xsl:value-of select="$toEndClassName"/>Enumerator.MoveNext())
            		{
                		ldr<xsl:value-of select="$toEndClassName"/> = (DataRow)l<xsl:value-of select="$toEndClassName"/>Enumerator.Current;
                		l<xsl:value-of select="$toEndClassName"/> = l<xsl:value-of select="$toEndClassName"/>Mapper.Find(new Guid(ldr<xsl:value-of select="$toEndClassName"/>["ID<xsl:value-of select="$toEndClassName"/>"].ToString()));
                		p<xsl:value-of select="$contextName"/>.List<xsl:value-of select="$toEndClassName"/>.Add(l<xsl:value-of select="$toEndClassName"/>.ID, l<xsl:value-of select="$toEndClassName"/>);
            		}
			
		}
		
		//--------------------------------------------------------------------
		public int InsertAll<xsl:value-of select="$toEndClassName"/>(<xsl:value-of select="$contextName"/> p<xsl:value-of select="$contextName"/>)
		{
			
			<xsl:variable name="tableName" select="concat(tbl, concat($contextName, $toEndClassName))"/>
            		int liErreur = DataBase.DeleteRecords("<xsl:value-of select="$tableName"/>", "ID<xsl:value-of select="$contextName"/> = '" + p<xsl:value-of select="$contextName"/>.ID.ToString() + "'");

            		if (p<xsl:value-of select="$contextName"/>.List<xsl:value-of select="$toEndClassName"/>.Count == 0) return liErreur;

            		IDictionaryEnumerator lDictionaryEnumerator = p<xsl:value-of select="$contextName"/>.List<xsl:value-of select="$toEndClassName"/>.GetEnumerator();
            		int liI = 0;
            		string[] lsCols = new string[2];
            		string[] lsValues = new string[2];

            		lsCols[0] = "ID<xsl:value-of select="$contextName"/>";
            		lsCols[1] = "ID<xsl:value-of select="$toEndClassName"/>";
            		while (lDictionaryEnumerator.MoveNext())
            		{
                		lsValues[0] = "'" + p<xsl:value-of select="$contextName"/>.ID.ToString() + "'";
                		lsValues[1] = "'" + ((<xsl:value-of select="$toEndClassName"/>)lDictionaryEnumerator.Value).ID.ToString() + "'";
                		if (DataBase.Insert("<xsl:value-of select="$toEndClassName"/>", lsCols, lsValues) == liErreur) liI = liErreur;
                		if (liI != liErreur) liI += 1;
            		}
            		return liI;
        	}
	</xsl:for-each>

        //---------------------------------------------------------------------
        private void FillArray(ref string[] pCols, ref string[] pValues, <xsl:value-of select="$contextName"/> p<xsl:value-of select="$contextName"/>, bool pIsInsertID)
        {
            int liCpt = 0;
            int liNombre = <xsl:value-of select="count(.//Attribute[not(Stereotypes/Stereotype[@Name='Embedded'])])"/> + <xsl:value-of select="count(/.//Association/ToEnd/AssociationEnd[@EndModelElement=$iDClass and (../../FromEnd/AssociationEnd/@Multiplicity='1' or ../../FromEnd/AssociationEnd/@Multiplicity='0..1' or ../../FromEnd/AssociationEnd/@Multiplicity='Unspecified')])"/>;
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
     
	    <xsl:for-each select="/.//Association/ToEnd/AssociationEnd[@EndModelElement=$iDClass and (../../FromEnd/AssociationEnd/@Multiplicity='1' or ../../FromEnd/AssociationEnd/@Multiplicity='Unspecified' or../../FromEnd/AssociationEnd/@Multiplicity='0..1')]">
		<xsl:variable name="fromEndId" select="../../FromEnd/AssociationEnd/@EndModelElement"/>
		<xsl:variable name="fromEndClassName" select="/.//Class[@Id=$fromEndId]/@Name"/>
		if (!Util.isNULL(p<xsl:value-of select="$contextName"/>.ID<xsl:value-of select="$fromEndClassName"/>))
            	{
			pCols[liCpt] = "ID<xsl:value-of select="$fromEndClassName"/>";
            		pValues[liCpt++] = "'" + p<xsl:value-of select="$contextName"/>.ID<xsl:value-of select="$fromEndClassName"/>.ToString() + "'";
		}
	    </xsl:for-each>
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
	    
	    <xsl:for-each select="/.//Association/FromEnd/AssociationEnd[@EndModelElement=$iDClass and (@Multiplicity='*' or @Multiplicity='0..*' or @Multiplicity='1..*') and (../../ToEnd/AssociationEnd/@Multiplicity='*' or ../../ToEnd/AssociationEnd/@Multiplicity='0..*' or ../../ToEnd/AssociationEnd/@Multiplicity='1..*')]">
		<xsl:variable name="toEndId" select="../../ToEnd/AssociationEnd/@EndModelElement"/>
		<xsl:variable name="toEndClassName" select="/.//Class[@Id=$toEndId]/@Name"/>
	    liTemp = DataBase.Delete("DELETE FROM tbl<xsl:value-of select="$contextName"/><xsl:value-of select="$toEndClassName"/> WHERE ID<xsl:value-of select="$contextName"/> ='" + p<xsl:value-of select="$contextName"/>.ID + "'");
            if (liTemp == liErreur)
                liI = liErreur;
            if (liI != liErreur)
                liI += liTemp;
	    </xsl:for-each>
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
</xsl:if>
</xsl:template>



</xsl:stylesheet>

