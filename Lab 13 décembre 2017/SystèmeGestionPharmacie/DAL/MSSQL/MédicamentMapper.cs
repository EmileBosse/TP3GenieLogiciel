

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Data;
using SystèmeGestionPharmacie.Logique;

namespace SystèmeGestionPharmacie.DAL.MSSQL
{
    public class MédicamentMapper : AbstractMapper, IMédicamentMapper
    {

        public MédicamentMapper()
        {
        }

        //--------------------------------------------------------------------
        public Médicament Find(Guid ID)
        {
            Médicament lMédicament = (Médicament)AbstractFind(ID);

            if (Util.isNULL(lMédicament))
            {
                DataRow row = DataBase.SelectID(ID, "[tblMédicament]");
                if (Util.isNULL(row))
                    return null;
                lMédicament = this.FillFields(row);
                LoadedMap.Add(lMédicament.ID, lMédicament); 
            }
            return lMédicament;
        }


        //--------------------------------------------------------------------
        private Médicament FillFields(DataRow pDataRow)
        {
            Médicament lMédicament = new Médicament();
	    
                 lMédicament.Numéro = (string)pDataRow["Numéro"];
		
                 lMédicament.Nom = (string)pDataRow["Nom"];
		
                 lMédicament.ManièreLivraison = (string)pDataRow["ManièreLivraison"];
		
                 lMédicament.Endroit = (string)pDataRow["Endroit"];
		
                  lMédicament.PosologieMédicament.NombreUnitésParJour = (decimal)pDataRow["NombreUnitésParJour"];
	         
                  lMédicament.PosologieMédicament.NombreJours = (int)pDataRow["NombreJours"];
	         
                 lMédicament.QuantitéStock = (decimal)pDataRow["QuantitéStock"];
		
                 lMédicament.PrixVente = (decimal)pDataRow["PrixVente"];
		
            lMédicament.ID = new Guid(pDataRow["ID"].ToString());

	    
            return lMédicament;
        }

        //--------------------------------------------------------------------
        public DataTable FindAll()
        {
            return DataBase.SelectTable("[tblMédicament]", "");
        }


	

        //---------------------------------------------------------------------
        private void FillArray(ref string[] pCols, ref string[] pValues, Médicament pMédicament, bool pIsInsertID)
        {
            int liCpt = 0;
            int liNombre = 6 + 0;
            if (pIsInsertID)
            {
                pCols = new string[liNombre + 1];
                pValues = new string[liNombre + 1];
                pCols[liCpt] = "ID";
                pValues[liCpt++] = "'" + pMédicament.ID.ToString() + "'";
            }
            else
            {
                pCols = new string[liNombre];
                pValues = new string[liNombre];
            }

	    
		pCols[liCpt] = "Numéro";
		
				pValues[liCpt++] = "'" + Util.DoubleQuote(pMédicament.Numéro) + "'";
  			
		pCols[liCpt] = "Nom";
		
				pValues[liCpt++] = "'" + Util.DoubleQuote(pMédicament.Nom) + "'";
  			
		pCols[liCpt] = "ManièreLivraison";
		
				pValues[liCpt++] = "'" + Util.DoubleQuote(pMédicament.ManièreLivraison) + "'";
  			
		pCols[liCpt] = "Endroit";
		
				pValues[liCpt++] = "'" + Util.DoubleQuote(pMédicament.Endroit) + "'";
  			
		  liNombre++;
	          
		pCols[liCpt] = "NombreUnitésParJour";
		
      		      		pValues[liCpt++] = "'" + pMédicament.PosologieMédicament.NombreUnitésParJour.ToString() + "'"; 
			
		  liNombre++;
	          
		pCols[liCpt] = "NombreJours";
		
      		      		pValues[liCpt++] = "'" + pMédicament.PosologieMédicament.NombreJours.ToString() + "'"; 
			
		pCols[liCpt] = "QuantitéStock";
		
      		      		pValues[liCpt++] = "'" + pMédicament.QuantitéStock.ToString() + "'"; 
			
		pCols[liCpt] = "PrixVente";
		
      		      		pValues[liCpt++] = "'" + pMédicament.PrixVente.ToString() + "'"; 
			
        }

        //----------------------------------------------------------------------------------------
        public int Delete(Médicament pMédicament)
        {
            int liErreur = int.MinValue;
            int liTemp;
            int liI = 0;

            liTemp = DataBase.DeleteID(pMédicament.ID, "[tblMédicament]");
            if (liTemp == liErreur)
                liI = liErreur;
            if (liI != liErreur)
                liI += liTemp;
	    
	    
            return liI;
        }

        //--------------------------------------------------------------------

        public int Insert(Médicament pMédicament)
        {
            string[] lsCols = null;
            string[] lsValues = null;
            this.FillArray(ref lsCols, ref lsValues, pMédicament, true);
            return DataBase.Insert("[tblMédicament]", lsCols, lsValues);
        }

        
        //---------------------------------------------------------------------
        public int Update(Médicament pMédicament)
        {
            string[] lsCols = null;
            string[] lsValues = null;

            this.FillArray(ref lsCols, ref lsValues, pMédicament, false);
            return DataBase.UpdateID("tblMédicament", lsCols, lsValues, pMédicament.ID);
        }

    }
}

