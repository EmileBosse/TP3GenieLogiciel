

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Data;
using SystèmeGestionPharmacie.Logique;

namespace SystèmeGestionPharmacie.DAL.MSSQL
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
                    query += " and numéro='" + numero + "'";
            }
            else
            {
                if (numero.Trim() != "")
                    query += " numéro='" + numero + "'";
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
	    
                 lPharmacie.Numéro = (string)pDataRow["Numéro"];
		
                 lPharmacie.Nom = (string)pDataRow["Nom"];
		
                 lPharmacie.NomRésponsable = (string)pDataRow["NomRésponsable"];
		
                 lPharmacie.Adresse = (string)pDataRow["Adresse"];
		
                 lPharmacie.NuméroTéléphone = (string)pDataRow["NuméroTéléphone"];
		
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

	    
		pCols[liCpt] = "Numéro";
		
				pValues[liCpt++] = "'" + Util.DoubleQuote(pPharmacie.Numéro) + "'";
  			
		pCols[liCpt] = "Nom";
		
				pValues[liCpt++] = "'" + Util.DoubleQuote(pPharmacie.Nom) + "'";
  			
		pCols[liCpt] = "NomRésponsable";
		
				pValues[liCpt++] = "'" + Util.DoubleQuote(pPharmacie.NomRésponsable) + "'";
  			
		pCols[liCpt] = "Adresse";
		
				pValues[liCpt++] = "'" + Util.DoubleQuote(pPharmacie.Adresse) + "'";
  			
		pCols[liCpt] = "NuméroTéléphone";
		
				pValues[liCpt++] = "'" + Util.DoubleQuote(pPharmacie.NuméroTéléphone) + "'";
  			
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

