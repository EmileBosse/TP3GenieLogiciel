

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Data;
using SystèmeGestionPharmacie.Logique;

namespace SystèmeGestionPharmacie.DAL.MSSQL
{
    public class TransactionVenteMapper : AbstractMapper, ITransactionVenteMapper
    {

        public TransactionVenteMapper()
        {
        }

        //--------------------------------------------------------------------
        public TransactionVente Find(Guid ID)
        {
            TransactionVente lTransactionVente = (TransactionVente)AbstractFind(ID);

            if (Util.isNULL(lTransactionVente))
            {
                DataRow row = DataBase.SelectID(ID, "[tblTransactionVente]");
                if (Util.isNULL(row))
                    return null;
                lTransactionVente = this.FillFields(row);
                LoadedMap.Add(lTransactionVente.ID, lTransactionVente); 
            }
            return lTransactionVente;
        }


        //--------------------------------------------------------------------
        private TransactionVente FillFields(DataRow pDataRow)
        {
            TransactionVente lTransactionVente = new TransactionVente();
	    
                 lTransactionVente.Numéro = (string)pDataRow["Numéro"];
		
                 lTransactionVente.DateTransactionVente = (DateTime)pDataRow["DateTransactionVente"];
		
                 lTransactionVente.MontantTotal = (decimal)pDataRow["MontantTotal"];
		
            lTransactionVente.ID = new Guid(pDataRow["ID"].ToString());

	    
		if (pDataRow["IDPaiement"].GetType() != typeof(System.DBNull))
			lTransactionVente.IDPaiement = new Guid(pDataRow["IDPaiement"].ToString());
	    
            return lTransactionVente;
        }

        //--------------------------------------------------------------------
        public DataTable FindAll()
        {
            return DataBase.SelectTable("[tblTransactionVente]", "");
        }


	

        //---------------------------------------------------------------------
        private void FillArray(ref string[] pCols, ref string[] pValues, TransactionVente pTransactionVente, bool pIsInsertID)
        {
            int liCpt = 0;
            int liNombre = 3 + 1;
            if (pIsInsertID)
            {
                pCols = new string[liNombre + 1];
                pValues = new string[liNombre + 1];
                pCols[liCpt] = "ID";
                pValues[liCpt++] = "'" + pTransactionVente.ID.ToString() + "'";
            }
            else
            {
                pCols = new string[liNombre];
                pValues = new string[liNombre];
            }

	    
		pCols[liCpt] = "Numéro";
		
				pValues[liCpt++] = "'" + Util.DoubleQuote(pTransactionVente.Numéro) + "'";
  			
		pCols[liCpt] = "DateTransactionVente";
		
      		      		pValues[liCpt++] = "'" + pTransactionVente.DateTransactionVente.ToString() + "'"; 
			
		pCols[liCpt] = "MontantTotal";
		
      		      		pValues[liCpt++] = "'" + pTransactionVente.MontantTotal.ToString() + "'"; 
			
		if (!Util.isNULL(pTransactionVente.IDPaiement))
            	{
			pCols[liCpt] = "IDPaiement";
            		pValues[liCpt++] = "'" + pTransactionVente.IDPaiement.ToString() + "'";
		}
	    
        }

        //----------------------------------------------------------------------------------------
        public int Delete(TransactionVente pTransactionVente)
        {
            int liErreur = int.MinValue;
            int liTemp;
            int liI = 0;

            liTemp = DataBase.DeleteID(pTransactionVente.ID, "[tblTransactionVente]");
            if (liTemp == liErreur)
                liI = liErreur;
            if (liI != liErreur)
                liI += liTemp;
	    
	    
            return liI;
        }

        //--------------------------------------------------------------------

        public int Insert(TransactionVente pTransactionVente)
        {
            string[] lsCols = null;
            string[] lsValues = null;
            this.FillArray(ref lsCols, ref lsValues, pTransactionVente, true);
            return DataBase.Insert("[tblTransactionVente]", lsCols, lsValues);
        }

        
        //---------------------------------------------------------------------
        public int Update(TransactionVente pTransactionVente)
        {
            string[] lsCols = null;
            string[] lsValues = null;

            this.FillArray(ref lsCols, ref lsValues, pTransactionVente, false);
            return DataBase.UpdateID("tblTransactionVente", lsCols, lsValues, pTransactionVente.ID);
        }

    }
}

