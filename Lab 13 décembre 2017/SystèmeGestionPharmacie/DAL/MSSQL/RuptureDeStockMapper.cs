

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Data;
using SystèmeGestionPharmacie.Logique;

namespace SystèmeGestionPharmacie.DAL.MSSQL
{
    public class RuptureDeStockMapper : AbstractMapper, IRuptureDeStockMapper
    {

        public RuptureDeStockMapper()
        {
        }

        //--------------------------------------------------------------------
        public RuptureDeStock Find(Guid ID)
        {
            RuptureDeStock lRuptureDeStock = (RuptureDeStock)AbstractFind(ID);

            if (Util.isNULL(lRuptureDeStock))
            {
                DataRow row = DataBase.SelectID(ID, "[tblRuptureDeStock]");
                if (Util.isNULL(row))
                    return null;
                lRuptureDeStock = this.FillFields(row);
                LoadedMap.Add(lRuptureDeStock.ID, lRuptureDeStock); 
            }
            return lRuptureDeStock;
        }


        //--------------------------------------------------------------------
        private RuptureDeStock FillFields(DataRow pDataRow)
        {
            RuptureDeStock lRuptureDeStock = new RuptureDeStock();
	    
                 lRuptureDeStock.DateRuptureDeStock = (DateTime)pDataRow["DateRuptureDeStock"];
		
                 lRuptureDeStock.QuantitéDemandée = (decimal)pDataRow["QuantitéDemandée"];
		
            lRuptureDeStock.ID = new Guid(pDataRow["ID"].ToString());

	    
            return lRuptureDeStock;
        }

        //--------------------------------------------------------------------
        public DataTable FindAll()
        {
            return DataBase.SelectTable("[tblRuptureDeStock]", "");
        }


	

        //---------------------------------------------------------------------
        private void FillArray(ref string[] pCols, ref string[] pValues, RuptureDeStock pRuptureDeStock, bool pIsInsertID)
        {
            int liCpt = 0;
            int liNombre = 2 + 0;
            if (pIsInsertID)
            {
                pCols = new string[liNombre + 1];
                pValues = new string[liNombre + 1];
                pCols[liCpt] = "ID";
                pValues[liCpt++] = "'" + pRuptureDeStock.ID.ToString() + "'";
            }
            else
            {
                pCols = new string[liNombre];
                pValues = new string[liNombre];
            }

	    
		pCols[liCpt] = "DateRuptureDeStock";
		
      		      		pValues[liCpt++] = "'" + pRuptureDeStock.DateRuptureDeStock.ToString() + "'"; 
			
		pCols[liCpt] = "QuantitéDemandée";
		
      		      		pValues[liCpt++] = "'" + pRuptureDeStock.QuantitéDemandée.ToString() + "'"; 
			
        }

        //----------------------------------------------------------------------------------------
        public int Delete(RuptureDeStock pRuptureDeStock)
        {
            int liErreur = int.MinValue;
            int liTemp;
            int liI = 0;

            liTemp = DataBase.DeleteID(pRuptureDeStock.ID, "[tblRuptureDeStock]");
            if (liTemp == liErreur)
                liI = liErreur;
            if (liI != liErreur)
                liI += liTemp;
	    
	    
            return liI;
        }

        //--------------------------------------------------------------------

        public int Insert(RuptureDeStock pRuptureDeStock)
        {
            string[] lsCols = null;
            string[] lsValues = null;
            this.FillArray(ref lsCols, ref lsValues, pRuptureDeStock, true);
            return DataBase.Insert("[tblRuptureDeStock]", lsCols, lsValues);
        }

        
        //---------------------------------------------------------------------
        public int Update(RuptureDeStock pRuptureDeStock)
        {
            string[] lsCols = null;
            string[] lsValues = null;

            this.FillArray(ref lsCols, ref lsValues, pRuptureDeStock, false);
            return DataBase.UpdateID("tblRuptureDeStock", lsCols, lsValues, pRuptureDeStock.ID);
        }

    }
}

