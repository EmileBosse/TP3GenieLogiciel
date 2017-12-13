

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Data;
using Syst�meGestionPharmacie.Logique;

namespace Syst�meGestionPharmacie.DAL.MSSQL
{
    public class M�dicamentMapper : AbstractMapper, IM�dicamentMapper
    {

        public M�dicamentMapper()
        {
        }

        //--------------------------------------------------------------------
        public M�dicament Find(Guid ID)
        {
            M�dicament lM�dicament = (M�dicament)AbstractFind(ID);

            if (Util.isNULL(lM�dicament))
            {
                DataRow row = DataBase.SelectID(ID, "[tblM�dicament]");
                if (Util.isNULL(row))
                    return null;
                lM�dicament = this.FillFields(row);
                LoadedMap.Add(lM�dicament.ID, lM�dicament); 
            }
            return lM�dicament;
        }


        //--------------------------------------------------------------------
        private M�dicament FillFields(DataRow pDataRow)
        {
            M�dicament lM�dicament = new M�dicament();
	    
                 lM�dicament.Num�ro = (string)pDataRow["Num�ro"];
		
                 lM�dicament.Nom = (string)pDataRow["Nom"];
		
                 lM�dicament.Mani�reLivraison = (string)pDataRow["Mani�reLivraison"];
		
                 lM�dicament.Endroit = (string)pDataRow["Endroit"];
		
                  lM�dicament.PosologieM�dicament.NombreUnit�sParJour = (decimal)pDataRow["NombreUnit�sParJour"];
	         
                  lM�dicament.PosologieM�dicament.NombreJours = (int)pDataRow["NombreJours"];
	         
                 lM�dicament.Quantit�Stock = (decimal)pDataRow["Quantit�Stock"];
		
                 lM�dicament.PrixVente = (decimal)pDataRow["PrixVente"];
		
            lM�dicament.ID = new Guid(pDataRow["ID"].ToString());

	    
            return lM�dicament;
        }

        //--------------------------------------------------------------------
        public DataTable FindAll()
        {
            return DataBase.SelectTable("[tblM�dicament]", "");
        }


	

        //---------------------------------------------------------------------
        private void FillArray(ref string[] pCols, ref string[] pValues, M�dicament pM�dicament, bool pIsInsertID)
        {
            int liCpt = 0;
            int liNombre = 6 + 0;
            if (pIsInsertID)
            {
                pCols = new string[liNombre + 1];
                pValues = new string[liNombre + 1];
                pCols[liCpt] = "ID";
                pValues[liCpt++] = "'" + pM�dicament.ID.ToString() + "'";
            }
            else
            {
                pCols = new string[liNombre];
                pValues = new string[liNombre];
            }

	    
		pCols[liCpt] = "Num�ro";
		
				pValues[liCpt++] = "'" + Util.DoubleQuote(pM�dicament.Num�ro) + "'";
  			
		pCols[liCpt] = "Nom";
		
				pValues[liCpt++] = "'" + Util.DoubleQuote(pM�dicament.Nom) + "'";
  			
		pCols[liCpt] = "Mani�reLivraison";
		
				pValues[liCpt++] = "'" + Util.DoubleQuote(pM�dicament.Mani�reLivraison) + "'";
  			
		pCols[liCpt] = "Endroit";
		
				pValues[liCpt++] = "'" + Util.DoubleQuote(pM�dicament.Endroit) + "'";
  			
		  liNombre++;
	          
		pCols[liCpt] = "NombreUnit�sParJour";
		
      		      		pValues[liCpt++] = "'" + pM�dicament.PosologieM�dicament.NombreUnit�sParJour.ToString() + "'"; 
			
		  liNombre++;
	          
		pCols[liCpt] = "NombreJours";
		
      		      		pValues[liCpt++] = "'" + pM�dicament.PosologieM�dicament.NombreJours.ToString() + "'"; 
			
		pCols[liCpt] = "Quantit�Stock";
		
      		      		pValues[liCpt++] = "'" + pM�dicament.Quantit�Stock.ToString() + "'"; 
			
		pCols[liCpt] = "PrixVente";
		
      		      		pValues[liCpt++] = "'" + pM�dicament.PrixVente.ToString() + "'"; 
			
        }

        //----------------------------------------------------------------------------------------
        public int Delete(M�dicament pM�dicament)
        {
            int liErreur = int.MinValue;
            int liTemp;
            int liI = 0;

            liTemp = DataBase.DeleteID(pM�dicament.ID, "[tblM�dicament]");
            if (liTemp == liErreur)
                liI = liErreur;
            if (liI != liErreur)
                liI += liTemp;
	    
	    
            return liI;
        }

        //--------------------------------------------------------------------

        public int Insert(M�dicament pM�dicament)
        {
            string[] lsCols = null;
            string[] lsValues = null;
            this.FillArray(ref lsCols, ref lsValues, pM�dicament, true);
            return DataBase.Insert("[tblM�dicament]", lsCols, lsValues);
        }

        
        //---------------------------------------------------------------------
        public int Update(M�dicament pM�dicament)
        {
            string[] lsCols = null;
            string[] lsValues = null;

            this.FillArray(ref lsCols, ref lsValues, pM�dicament, false);
            return DataBase.UpdateID("tblM�dicament", lsCols, lsValues, pM�dicament.ID);
        }

    }
}

