

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Data;
using Syst�meGestionPharmacie.Logique;

namespace Syst�meGestionPharmacie.DAL.MSSQL
{
    public class PharmacieMapper : AbstractMapper, IPharmacieMapper
    {

        public PharmacieMapper()
        {
        }

        //--------------------------------------------------------------------
        public Pharmacie Find(Guid ID)
        {
            Pharmacie lPharmacie = (Pharmacie)AbstractFind(ID);

            if (Util.isNULL(lPharmacie))
            {
                DataRow row = DataBase.SelectID(ID, "[tblPharmacie]");
                if (Util.isNULL(row))
                    return null;
                lPharmacie = this.FillFields(row);
                LoadedMap.Add(lPharmacie.ID, lPharmacie); 
            }
            return lPharmacie;
        }

        public List<Pharmacie> Find(string numero, string nom)
        {
            List<Pharmacie> lPharmacie = new List<Pharmacie>();
            Pharmacie p;

            String query = "WHERE";
            if (nom.Trim() != "")
            {
                query += " nom ='" + nom + "'";
                if (numero.Trim() != "")
                    query += " and num�ro='" + numero + "'";
            }
            else
            {
                if (numero.Trim() != "")
                    query += " num�ro='" + numero + "'";
            }

            if (query.Equals("WHERE"))
                query = "";

            DataTable table = DataBase.Select("SELECT * FROM [tblPharmacie] " + query + " ORDER BY nom");
            if (Util.isNULL(table))
                return null;

            DataRow[] dr = table.Select();
            for (int i = 0; i < dr.Length; i++)
            {
                p = this.FillFields(dr.ElementAt(i));
                lPharmacie.Add(p);
                LoadedMap.Add(p.ID, p);
            }
            if (lPharmacie.Count() > 0)
                return lPharmacie;

            return null;
        }

        //--------------------------------------------------------------------
        private Pharmacie FillFields(DataRow pDataRow)
        {
            Pharmacie lPharmacie = new Pharmacie();
	    
                 lPharmacie.Num�ro = (string)pDataRow["Num�ro"];
		
                 lPharmacie.Nom = (string)pDataRow["Nom"];
		
                 lPharmacie.NomR�sponsable = (string)pDataRow["NomR�sponsable"];
		
                 lPharmacie.Adresse = (string)pDataRow["Adresse"];
		
                 lPharmacie.Num�roT�l�phone = (string)pDataRow["Num�roT�l�phone"];
		
            lPharmacie.ID = new Guid(pDataRow["ID"].ToString());

	    
            return lPharmacie;
        }

        //--------------------------------------------------------------------
        public DataTable FindAll()
        {
            return DataBase.SelectTable("[tblPharmacie]", "");
        }


	

        //---------------------------------------------------------------------
        private void FillArray(ref string[] pCols, ref string[] pValues, Pharmacie pPharmacie, bool pIsInsertID)
        {
            int liCpt = 0;
            int liNombre = 5 + 0;
            if (pIsInsertID)
            {
                pCols = new string[liNombre + 1];
                pValues = new string[liNombre + 1];
                pCols[liCpt] = "ID";
                pValues[liCpt++] = "'" + pPharmacie.ID.ToString() + "'";
            }
            else
            {
                pCols = new string[liNombre];
                pValues = new string[liNombre];
            }

	    
		pCols[liCpt] = "Num�ro";
		
				pValues[liCpt++] = "'" + Util.DoubleQuote(pPharmacie.Num�ro) + "'";
  			
		pCols[liCpt] = "Nom";
		
				pValues[liCpt++] = "'" + Util.DoubleQuote(pPharmacie.Nom) + "'";
  			
		pCols[liCpt] = "NomR�sponsable";
		
				pValues[liCpt++] = "'" + Util.DoubleQuote(pPharmacie.NomR�sponsable) + "'";
  			
		pCols[liCpt] = "Adresse";
		
				pValues[liCpt++] = "'" + Util.DoubleQuote(pPharmacie.Adresse) + "'";
  			
		pCols[liCpt] = "Num�roT�l�phone";
		
				pValues[liCpt++] = "'" + Util.DoubleQuote(pPharmacie.Num�roT�l�phone) + "'";
  			
        }

        //----------------------------------------------------------------------------------------
        public int Delete(Pharmacie pPharmacie)
        {
            int liErreur = int.MinValue;
            int liTemp;
            int liI = 0;

            liTemp = DataBase.DeleteID(pPharmacie.ID, "[tblPharmacie]");
            if (liTemp == liErreur)
                liI = liErreur;
            if (liI != liErreur)
                liI += liTemp;
	    
	    
            return liI;
        }

        //--------------------------------------------------------------------

        public int Insert(Pharmacie pPharmacie)
        {
            string[] lsCols = null;
            string[] lsValues = null;
            this.FillArray(ref lsCols, ref lsValues, pPharmacie, true);
            return DataBase.Insert("[tblPharmacie]", lsCols, lsValues);
        }

        
        //---------------------------------------------------------------------
        public int Update(Pharmacie pPharmacie)
        {
            string[] lsCols = null;
            string[] lsValues = null;

            this.FillArray(ref lsCols, ref lsValues, pPharmacie, false);
            return DataBase.UpdateID("tblPharmacie", lsCols, lsValues, pPharmacie.ID);
        }

    }
}

