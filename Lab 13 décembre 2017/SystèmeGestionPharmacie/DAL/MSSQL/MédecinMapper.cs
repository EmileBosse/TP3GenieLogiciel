using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Data;
using Syst�meGestionPharmacie.Logique;

namespace Syst�meGestionPharmacie.DAL.MSSQL
{
    public class M�decinMapper : AbstractMapper, IM�decinMapper
    {

        public M�decinMapper()
        {
        }

        //--------------------------------------------------------------------
        public M�decin Find(Guid ID)
        {
            M�decin lM�decin = (M�decin)AbstractFind(ID);

            if (Util.isNULL(lM�decin))
            {
                DataRow row = DataBase.SelectID(ID, "[tblM�decin]");
                if (Util.isNULL(row))
                    return null;
                lM�decin = this.FillFields(row);
                LoadedMap.Add(lM�decin.ID, lM�decin); 
            }
            return lM�decin;
        }

        public List<M�decin> Find(String numero, String nom, String prenom)
        {
            String where = "";
            bool ajouterAnd = false;
            if (numero != "" || nom != "" || prenom != "")
            {
                where = "WHERE ";
                if (numero != "") { where += ("num�roLicense='"+numero+"'"); ajouterAnd = true; }
                if (nom != "") { if (ajouterAnd) { where += ("and nom='"+nom+"'"); } else { where += ("nom='"+nom+"'"); } ajouterAnd = true; }
                if (prenom != "") { if (ajouterAnd) { where += ("and pr�nom='"+prenom+"'"); } else { where += ("pr�nom='"+prenom+"'"); } }
            }
            
            DataTable table = DataBase.Select("SELECT * FROM dbo.tblM�decin "+where+"ORDER BY nom");
            if (Util.isNULL(table))
                return null;

            DataRow[] t = table.Select();
            List<M�decin> ms = new List<M�decin>();
            for (int i = 0; i < t.Length; i++)
            {
                ms.Add(this.FillFields(t[i]));
            }

            return ms;
        }


        //--------------------------------------------------------------------
        private M�decin FillFields(DataRow pDataRow)
        {
            M�decin lM�decin = new M�decin();
	    
                 lM�decin.Num�roLicense = (string)pDataRow["Num�roLicense"];
		
                 lM�decin.Nom = (string)pDataRow["Nom"];
		
                 lM�decin.Pr�nom = (string)pDataRow["Pr�nom"];
		
                 lM�decin.Adresse = (string)pDataRow["Adresse"];
		
                 lM�decin.Num�roT�l�phone = (string)pDataRow["Num�roT�l�phone"];
		
            lM�decin.ID = new Guid(pDataRow["ID"].ToString());

	    
            return lM�decin;
        }

        //--------------------------------------------------------------------
        public DataTable FindAll()
        {
            return DataBase.SelectTable("[tblM�decin]", "");
        }


	

        //---------------------------------------------------------------------
        private void FillArray(ref string[] pCols, ref string[] pValues, M�decin pM�decin, bool pIsInsertID)
        {
            int liCpt = 0;
            int liNombre = 5 + 0;
            if (pIsInsertID)
            {
                pCols = new string[liNombre + 1];
                pValues = new string[liNombre + 1];
                pCols[liCpt] = "ID";
                pValues[liCpt++] = "'" + pM�decin.ID.ToString() + "'";
            }
            else
            {
                pCols = new string[liNombre];
                pValues = new string[liNombre];
            }

	    
		pCols[liCpt] = "Num�roLicense";
		
				pValues[liCpt++] = "'" + Util.DoubleQuote(pM�decin.Num�roLicense) + "'";
  			
		pCols[liCpt] = "Nom";
		
				pValues[liCpt++] = "'" + Util.DoubleQuote(pM�decin.Nom) + "'";
  			
		pCols[liCpt] = "Pr�nom";
		
				pValues[liCpt++] = "'" + Util.DoubleQuote(pM�decin.Pr�nom) + "'";
  			
		pCols[liCpt] = "Adresse";
		
				pValues[liCpt++] = "'" + Util.DoubleQuote(pM�decin.Adresse) + "'";
  			
		pCols[liCpt] = "Num�roT�l�phone";
		
				pValues[liCpt++] = "'" + Util.DoubleQuote(pM�decin.Num�roT�l�phone) + "'";
  			
        }

        //----------------------------------------------------------------------------------------
        public int Delete(M�decin pM�decin)
        {
            int liErreur = int.MinValue;
            int liTemp;
            int liI = 0;

            liTemp = DataBase.DeleteID(pM�decin.ID, "[tblM�decin]");
            if (liTemp == liErreur)
                liI = liErreur;
            if (liI != liErreur)
                liI += liTemp;
	    
	    
            return liI;
        }

        //--------------------------------------------------------------------

        public int Insert(M�decin pM�decin)
        {
            string[] lsCols = null;
            string[] lsValues = null;
            this.FillArray(ref lsCols, ref lsValues, pM�decin, true);
            return DataBase.Insert("[tblM�decin]", lsCols, lsValues);
        }

        
        //---------------------------------------------------------------------
        public int Update(M�decin pM�decin)
        {
            string[] lsCols = null;
            string[] lsValues = null;

            this.FillArray(ref lsCols, ref lsValues, pM�decin, false);
            return DataBase.UpdateID("tblM�decin", lsCols, lsValues, pM�decin.ID);
        }

    }
}

