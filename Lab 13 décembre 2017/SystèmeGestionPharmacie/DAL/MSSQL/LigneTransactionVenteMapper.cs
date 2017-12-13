

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Data;
using SystèmeGestionPharmacie.Logique;

namespace SystèmeGestionPharmacie.DAL.MSSQL
{
    public class LigneTransactionVenteMapper : AbstractMapper, ILigneTransactionVenteMapper
    {

        public LigneTransactionVenteMapper()
        {
        }

        //--------------------------------------------------------------------
        public LigneTransactionVente Find(Guid ID)
        {
            LigneTransactionVente lLigneTransactionVente = (LigneTransactionVente)AbstractFind(ID);

            if (Util.isNULL(lLigneTransactionVente))
            {
                DataRow row = DataBase.SelectID(ID, "[tblLigneTransactionVente]");
                if (Util.isNULL(row))
                    return null;
                lLigneTransactionVente = this.FillFields(row);
                LoadedMap.Add(lLigneTransactionVente.ID, lLigneTransactionVente); 
            }
            return lLigneTransactionVente;
        }


        //--------------------------------------------------------------------
        private LigneTransactionVente FillFields(DataRow pDataRow)
        {
            LigneTransactionVente lLigneTransactionVente = new LigneTransactionVente();
	    
                 lLigneTransactionVente.Numéro = (int)pDataRow["Numéro"];
		
                 lLigneTransactionVente.MontantLigne = (decimal)pDataRow["MontantLigne"];
		
                 lLigneTransactionVente.CopieÉtiquette = (byte[])pDataRow["CopieÉtiquette"];
		
            lLigneTransactionVente.ID = new Guid(pDataRow["ID"].ToString());

	    
		if (pDataRow["IDTransactionVente"].GetType() != typeof(System.DBNull))
			lLigneTransactionVente.IDTransactionVente = new Guid(pDataRow["IDTransactionVente"].ToString());
	    
            return lLigneTransactionVente;
        }

        //--------------------------------------------------------------------
        public DataTable FindAll()
        {
            return DataBase.SelectTable("[tblLigneTransactionVente]", "");
        }


	
		//--------------------------------------------------------------------
		public DataTable FindAllPourUnTransactionVente(Guid pTransactionVenteId)
		{
            		return DataBase.Select("SELECT * FROM tblLigneTransactionVente WHERE IDTransactionVente='" + pTransactionVenteId.ToString() + "'");
        	}
		

        //---------------------------------------------------------------------
        private void FillArray(ref string[] pCols, ref string[] pValues, LigneTransactionVente pLigneTransactionVente, bool pIsInsertID)
        {
            int liCpt = 0;
            int liNombre = 3 + 1;
            if (pIsInsertID)
            {
                pCols = new string[liNombre + 1];
                pValues = new string[liNombre + 1];
                pCols[liCpt] = "ID";
                pValues[liCpt++] = "'" + pLigneTransactionVente.ID.ToString() + "'";
            }
            else
            {
                pCols = new string[liNombre];
                pValues = new string[liNombre];
            }

	    
		pCols[liCpt] = "Numéro";
		
      		      		pValues[liCpt++] = "'" + pLigneTransactionVente.Numéro.ToString() + "'"; 
			
		pCols[liCpt] = "MontantLigne";
		
      		      		pValues[liCpt++] = "'" + pLigneTransactionVente.MontantLigne.ToString() + "'"; 
			
		pCols[liCpt] = "CopieÉtiquette";
		
      		      		pValues[liCpt++] = "0x" + BitConverter.ToString(pLigneTransactionVente.CopieÉtiquette).Replace("-", "");
			
		if (!Util.isNULL(pLigneTransactionVente.IDTransactionVente))
            	{
			pCols[liCpt] = "IDTransactionVente";
            		pValues[liCpt++] = "'" + pLigneTransactionVente.IDTransactionVente.ToString() + "'";
		}
	    
        }

        //----------------------------------------------------------------------------------------
        public int Delete(LigneTransactionVente pLigneTransactionVente)
        {
            int liErreur = int.MinValue;
            int liTemp;
            int liI = 0;

            liTemp = DataBase.DeleteID(pLigneTransactionVente.ID, "[tblLigneTransactionVente]");
            if (liTemp == liErreur)
                liI = liErreur;
            if (liI != liErreur)
                liI += liTemp;
	    
	    
            return liI;
        }

        //--------------------------------------------------------------------

        public int Insert(LigneTransactionVente pLigneTransactionVente)
        {
            string[] lsCols = null;
            string[] lsValues = null;
            this.FillArray(ref lsCols, ref lsValues, pLigneTransactionVente, true);
            return DataBase.Insert("[tblLigneTransactionVente]", lsCols, lsValues);
        }

        
        //---------------------------------------------------------------------
        public int Update(LigneTransactionVente pLigneTransactionVente)
        {
            string[] lsCols = null;
            string[] lsValues = null;

            this.FillArray(ref lsCols, ref lsValues, pLigneTransactionVente, false);
            return DataBase.UpdateID("tblLigneTransactionVente", lsCols, lsValues, pLigneTransactionVente.ID);
        }

    }
}

