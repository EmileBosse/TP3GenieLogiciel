

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Syst�meGestionPharmacie.Logique;

namespace Syst�meGestionPharmacie.DAL.MSSQL
{
    public class PrescriptionLignePrescriptionM�dicamentMapper : AbstractMapper, IPrescriptionLignePrescriptionM�dicamentMapper
    {

        public PrescriptionLignePrescriptionM�dicamentMapper()
        {
        }

        //--------------------------------------------------------------------
        public PrescriptionLignePrescriptionM�dicament Find(Guid ID)
        {
            PrescriptionLignePrescriptionM�dicament lPrescriptionLignePrescriptionM�dicament = (PrescriptionLignePrescriptionM�dicament)AbstractFind(ID);

            if (Util.isNULL(lPrescriptionLignePrescriptionM�dicament))
            {
                DataRow row = DataBase.SelectID(ID, "[tblPrescriptionLignePrescriptionM�dicament]");
                if (Util.isNULL(row))
                    return null;
                lPrescriptionLignePrescriptionM�dicament = this.FillFields(row);
                LoadedMap.Add(lPrescriptionLignePrescriptionM�dicament.ID, lPrescriptionLignePrescriptionM�dicament); 
            }
            return lPrescriptionLignePrescriptionM�dicament;
        }


        //--------------------------------------------------------------------
        private PrescriptionLignePrescriptionM�dicament FillFields(DataRow pDataRow)
        {
            PrescriptionLignePrescriptionM�dicament lPrescriptionLignePrescriptionM�dicament = new PrescriptionLignePrescriptionM�dicament();
	    
                 lPrescriptionLignePrescriptionM�dicament.Num�ro = (string)pDataRow["Num�ro"];
		
                 lPrescriptionLignePrescriptionM�dicament.Nom = (string)pDataRow["Nom"];
		
                  lPrescriptionLignePrescriptionM�dicament.PosologieLignePrescription.NombreUnit�sParJour = (decimal)pDataRow["NombreUnit�sParJour"];
	         
                  lPrescriptionLignePrescriptionM�dicament.PosologieLignePrescription.NombreJours = (int)pDataRow["NombreJours"];
	         
                 lPrescriptionLignePrescriptionM�dicament.Quantit� = (decimal)pDataRow["Quantit�"];
		
                 lPrescriptionLignePrescriptionM�dicament.NombreRenouvellements = (int)pDataRow["NombreRenouvellements"];
		
                 lPrescriptionLignePrescriptionM�dicament.NombreRenouvellementsRestants = (int)pDataRow["NombreRenouvellementsRestants"];
		

            lPrescriptionLignePrescriptionM�dicament.ID = new Guid(pDataRow["ID"].ToString());
	    lPrescriptionLignePrescriptionM�dicament.IDPrescription = new Guid(pDataRow["IDPrescription"].ToString());
	    lPrescriptionLignePrescriptionM�dicament.IDM�dicament = new Guid(pDataRow["IDM�dicament"].ToString());
            return lPrescriptionLignePrescriptionM�dicament;
        }

        //--------------------------------------------------------------------
        public DataTable FindAll()
        {
            return DataBase.SelectTable("[tblPrescriptionLignePrescriptionM�dicament]", "");
        }


	

        //---------------------------------------------------------------------
        private void FillArray(ref string[] pCols, ref string[] pValues, PrescriptionLignePrescriptionM�dicament pPrescriptionLignePrescriptionM�dicament, bool pIsInsertID)
        {
            int liCpt = 0;
            int liNombre = 5 + 2;
            if (pIsInsertID)
            {
                pCols = new string[liNombre + 1];
                pValues = new string[liNombre + 1];
                pCols[liCpt] = "ID";
                pValues[liCpt++] = "'" + pPrescriptionLignePrescriptionM�dicament.ID.ToString() + "'";
            }
            else
            {
                pCols = new string[liNombre];
                pValues = new string[liNombre];
            }

	    
		pCols[liCpt] = "Num�ro";
		
				pValues[liCpt++] = "'" + Util.DoubleQuote(pPrescriptionLignePrescriptionM�dicament.Num�ro) + "'";
  			
		pCols[liCpt] = "Nom";
		
				pValues[liCpt++] = "'" + Util.DoubleQuote(pPrescriptionLignePrescriptionM�dicament.Nom) + "'";
  			
		  liNombre++;
	          
		pCols[liCpt] = "NombreUnit�sParJour";
		
      		      		pValues[liCpt++] = "'" + pPrescriptionLignePrescriptionM�dicament.PosologieLignePrescription.NombreUnit�sParJour.ToString() + "'"; 
			
		  liNombre++;
	          
		pCols[liCpt] = "NombreJours";
		
      		      		pValues[liCpt++] = "'" + pPrescriptionLignePrescriptionM�dicament.PosologieLignePrescription.NombreJours.ToString() + "'"; 
			
		pCols[liCpt] = "Quantit�";
		
      		      		pValues[liCpt++] = "'" + pPrescriptionLignePrescriptionM�dicament.Quantit�.ToString() + "'"; 
			
		pCols[liCpt] = "NombreRenouvellements";
		
      		      		pValues[liCpt++] = "'" + pPrescriptionLignePrescriptionM�dicament.NombreRenouvellements.ToString() + "'"; 
			
		pCols[liCpt] = "NombreRenouvellementsRestants";
		
      		      		pValues[liCpt++] = "'" + pPrescriptionLignePrescriptionM�dicament.NombreRenouvellementsRestants.ToString() + "'"; 
			
	    pCols[liCpt] = "IDPrescription";
            pValues[liCpt++] = "'" + pPrescriptionLignePrescriptionM�dicament.IDPrescription.ToString() + "'";
	    pCols[liCpt] = "IDM�dicament";
            pValues[liCpt++] = "'" + pPrescriptionLignePrescriptionM�dicament.IDM�dicament.ToString() + "'";
        }

        //----------------------------------------------------------------------------------------
        public int Delete(PrescriptionLignePrescriptionM�dicament pPrescriptionLignePrescriptionM�dicament)
        {
            int liErreur = int.MinValue;
            int liTemp;
            int liI = 0;

            liTemp = DataBase.DeleteID(pPrescriptionLignePrescriptionM�dicament.ID, "[tblPrescriptionLignePrescriptionM�dicament]");
            if (liTemp == liErreur)
                liI = liErreur;
            if (liI != liErreur)
                liI += liTemp;
	    
            return liI;
        }

        //--------------------------------------------------------------------

        public int Insert(PrescriptionLignePrescriptionM�dicament pPrescriptionLignePrescriptionM�dicament)
        {
            string[] lsCols = null;
            string[] lsValues = null;
            this.FillArray(ref lsCols, ref lsValues, pPrescriptionLignePrescriptionM�dicament, true);
            return DataBase.Insert("[tblPrescriptionLignePrescriptionM�dicament]", lsCols, lsValues);
        }

        
        //---------------------------------------------------------------------
        public int Update(PrescriptionLignePrescriptionM�dicament pPrescriptionLignePrescriptionM�dicament)
        {
            string[] lsCols = null;
            string[] lsValues = null;

            this.FillArray(ref lsCols, ref lsValues, pPrescriptionLignePrescriptionM�dicament, false);
            return DataBase.UpdateID("tblPrescriptionLignePrescriptionM�dicament", lsCols, lsValues, pPrescriptionLignePrescriptionM�dicament.ID);
        }

    }
}

