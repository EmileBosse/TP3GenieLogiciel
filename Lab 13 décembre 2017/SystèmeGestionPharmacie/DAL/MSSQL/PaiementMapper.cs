

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Data;
using SystèmeGestionPharmacie.Logique;

namespace SystèmeGestionPharmacie.DAL.MSSQL
{
    public class PaiementMapper : AbstractMapper, IPaiementMapper
    {

        public PaiementMapper()
        {
        }

        //--------------------------------------------------------------------
        public Paiement Find(Guid ID)
        {
            Paiement lPaiement = (Paiement)AbstractFind(ID);

            if (Util.isNULL(lPaiement))
            {
                DataRow row = DataBase.SelectID(ID, "[tblPaiement]");
                if (Util.isNULL(row))
                    return null;
                lPaiement = this.FillFields(row);
                LoadedMap.Add(lPaiement.ID, lPaiement); 
            }
            return lPaiement;
        }


        //--------------------------------------------------------------------
        private Paiement FillFields(DataRow pDataRow)
        {
            Paiement lPaiement = new Paiement();
	    
                 lPaiement.Numéro = (string)pDataRow["Numéro"];
		
                 lPaiement.DatePaiement = (DateTime)pDataRow["DatePaiement"];
		
                 lPaiement.Montant = (decimal)pDataRow["Montant"];
		
                 lPaiement.TypePaiement = (string)pDataRow["TypePaiement"];
		
            lPaiement.ID = new Guid(pDataRow["ID"].ToString());

	    
            return lPaiement;
        }

        //--------------------------------------------------------------------
        public DataTable FindAll()
        {
            return DataBase.SelectTable("[tblPaiement]", "");
        }


	

        //---------------------------------------------------------------------
        private void FillArray(ref string[] pCols, ref string[] pValues, Paiement pPaiement, bool pIsInsertID)
        {
            int liCpt = 0;
            int liNombre = 4 + 0;
            if (pIsInsertID)
            {
                pCols = new string[liNombre + 1];
                pValues = new string[liNombre + 1];
                pCols[liCpt] = "ID";
                pValues[liCpt++] = "'" + pPaiement.ID.ToString() + "'";
            }
            else
            {
                pCols = new string[liNombre];
                pValues = new string[liNombre];
            }

	    
		pCols[liCpt] = "Numéro";
		
				pValues[liCpt++] = "'" + Util.DoubleQuote(pPaiement.Numéro) + "'";
  			
		pCols[liCpt] = "DatePaiement";
		
      		      		pValues[liCpt++] = "'" + pPaiement.DatePaiement.ToString() + "'"; 
			
		pCols[liCpt] = "Montant";
		
      		      		pValues[liCpt++] = "'" + pPaiement.Montant.ToString() + "'"; 
			
		pCols[liCpt] = "TypePaiement";
		
				pValues[liCpt++] = "'" + Util.DoubleQuote(pPaiement.TypePaiement) + "'";
  			
        }

        //----------------------------------------------------------------------------------------
        public int Delete(Paiement pPaiement)
        {
            int liErreur = int.MinValue;
            int liTemp;
            int liI = 0;

            liTemp = DataBase.DeleteID(pPaiement.ID, "[tblPaiement]");
            if (liTemp == liErreur)
                liI = liErreur;
            if (liI != liErreur)
                liI += liTemp;
	    
	    
            return liI;
        }

        //--------------------------------------------------------------------

        public int Insert(Paiement pPaiement)
        {
            string[] lsCols = null;
            string[] lsValues = null;
            this.FillArray(ref lsCols, ref lsValues, pPaiement, true);
            return DataBase.Insert("[tblPaiement]", lsCols, lsValues);
        }

        
        //---------------------------------------------------------------------
        public int Update(Paiement pPaiement)
        {
            string[] lsCols = null;
            string[] lsValues = null;

            this.FillArray(ref lsCols, ref lsValues, pPaiement, false);
            return DataBase.UpdateID("tblPaiement", lsCols, lsValues, pPaiement.ID);
        }

    }
}

