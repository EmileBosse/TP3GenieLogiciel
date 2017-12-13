

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using SystèmeGestionPharmacie.Logique;

namespace SystèmeGestionPharmacie.DAL.MSSQL
{
    public class PrescriptionLignePrescriptionMédicamentMapper : AbstractMapper, IPrescriptionLignePrescriptionMédicamentMapper
    {

        public PrescriptionLignePrescriptionMédicamentMapper()
        {
        }

        //--------------------------------------------------------------------
        public PrescriptionLignePrescriptionMédicament Find(Guid ID)
        {
            PrescriptionLignePrescriptionMédicament lPrescriptionLignePrescriptionMédicament = (PrescriptionLignePrescriptionMédicament)AbstractFind(ID);

            if (Util.isNULL(lPrescriptionLignePrescriptionMédicament))
            {
                DataRow row = DataBase.SelectID(ID, "[tblPrescriptionLignePrescriptionMédicament]");
                if (Util.isNULL(row))
                    return null;
                lPrescriptionLignePrescriptionMédicament = this.FillFields(row);
                LoadedMap.Add(lPrescriptionLignePrescriptionMédicament.ID, lPrescriptionLignePrescriptionMédicament); 
            }
            return lPrescriptionLignePrescriptionMédicament;
        }


        //--------------------------------------------------------------------
        private PrescriptionLignePrescriptionMédicament FillFields(DataRow pDataRow)
        {
            PrescriptionLignePrescriptionMédicament lPrescriptionLignePrescriptionMédicament = new PrescriptionLignePrescriptionMédicament();
	    
                 lPrescriptionLignePrescriptionMédicament.Numéro = (string)pDataRow["Numéro"];
		
                 lPrescriptionLignePrescriptionMédicament.Nom = (string)pDataRow["Nom"];
		
                  lPrescriptionLignePrescriptionMédicament.PosologieLignePrescription.NombreUnitésParJour = (decimal)pDataRow["NombreUnitésParJour"];
	         
                  lPrescriptionLignePrescriptionMédicament.PosologieLignePrescription.NombreJours = (int)pDataRow["NombreJours"];
	         
                 lPrescriptionLignePrescriptionMédicament.Quantité = (decimal)pDataRow["Quantité"];
		
                 lPrescriptionLignePrescriptionMédicament.NombreRenouvellements = (int)pDataRow["NombreRenouvellements"];
		
                 lPrescriptionLignePrescriptionMédicament.NombreRenouvellementsRestants = (int)pDataRow["NombreRenouvellementsRestants"];
		

            lPrescriptionLignePrescriptionMédicament.ID = new Guid(pDataRow["ID"].ToString());
	    lPrescriptionLignePrescriptionMédicament.IDPrescription = new Guid(pDataRow["IDPrescription"].ToString());
	    lPrescriptionLignePrescriptionMédicament.IDMédicament = new Guid(pDataRow["IDMédicament"].ToString());
            return lPrescriptionLignePrescriptionMédicament;
        }

        //--------------------------------------------------------------------
        public DataTable FindAll()
        {
            return DataBase.SelectTable("[tblPrescriptionLignePrescriptionMédicament]", "");
        }


	

        //---------------------------------------------------------------------
        private void FillArray(ref string[] pCols, ref string[] pValues, PrescriptionLignePrescriptionMédicament pPrescriptionLignePrescriptionMédicament, bool pIsInsertID)
        {
            int liCpt = 0;
            int liNombre = 5 + 2;
            if (pIsInsertID)
            {
                pCols = new string[liNombre + 1];
                pValues = new string[liNombre + 1];
                pCols[liCpt] = "ID";
                pValues[liCpt++] = "'" + pPrescriptionLignePrescriptionMédicament.ID.ToString() + "'";
            }
            else
            {
                pCols = new string[liNombre];
                pValues = new string[liNombre];
            }

	    
		pCols[liCpt] = "Numéro";
		
				pValues[liCpt++] = "'" + Util.DoubleQuote(pPrescriptionLignePrescriptionMédicament.Numéro) + "'";
  			
		pCols[liCpt] = "Nom";
		
				pValues[liCpt++] = "'" + Util.DoubleQuote(pPrescriptionLignePrescriptionMédicament.Nom) + "'";
  			
		  liNombre++;
	          
		pCols[liCpt] = "NombreUnitésParJour";
		
      		      		pValues[liCpt++] = "'" + pPrescriptionLignePrescriptionMédicament.PosologieLignePrescription.NombreUnitésParJour.ToString() + "'"; 
			
		  liNombre++;
	          
		pCols[liCpt] = "NombreJours";
		
      		      		pValues[liCpt++] = "'" + pPrescriptionLignePrescriptionMédicament.PosologieLignePrescription.NombreJours.ToString() + "'"; 
			
		pCols[liCpt] = "Quantité";
		
      		      		pValues[liCpt++] = "'" + pPrescriptionLignePrescriptionMédicament.Quantité.ToString() + "'"; 
			
		pCols[liCpt] = "NombreRenouvellements";
		
      		      		pValues[liCpt++] = "'" + pPrescriptionLignePrescriptionMédicament.NombreRenouvellements.ToString() + "'"; 
			
		pCols[liCpt] = "NombreRenouvellementsRestants";
		
      		      		pValues[liCpt++] = "'" + pPrescriptionLignePrescriptionMédicament.NombreRenouvellementsRestants.ToString() + "'"; 
			
	    pCols[liCpt] = "IDPrescription";
            pValues[liCpt++] = "'" + pPrescriptionLignePrescriptionMédicament.IDPrescription.ToString() + "'";
	    pCols[liCpt] = "IDMédicament";
            pValues[liCpt++] = "'" + pPrescriptionLignePrescriptionMédicament.IDMédicament.ToString() + "'";
        }

        //----------------------------------------------------------------------------------------
        public int Delete(PrescriptionLignePrescriptionMédicament pPrescriptionLignePrescriptionMédicament)
        {
            int liErreur = int.MinValue;
            int liTemp;
            int liI = 0;

            liTemp = DataBase.DeleteID(pPrescriptionLignePrescriptionMédicament.ID, "[tblPrescriptionLignePrescriptionMédicament]");
            if (liTemp == liErreur)
                liI = liErreur;
            if (liI != liErreur)
                liI += liTemp;
	    
            return liI;
        }

        //--------------------------------------------------------------------

        public int Insert(PrescriptionLignePrescriptionMédicament pPrescriptionLignePrescriptionMédicament)
        {
            string[] lsCols = null;
            string[] lsValues = null;
            this.FillArray(ref lsCols, ref lsValues, pPrescriptionLignePrescriptionMédicament, true);
            return DataBase.Insert("[tblPrescriptionLignePrescriptionMédicament]", lsCols, lsValues);
        }

        
        //---------------------------------------------------------------------
        public int Update(PrescriptionLignePrescriptionMédicament pPrescriptionLignePrescriptionMédicament)
        {
            string[] lsCols = null;
            string[] lsValues = null;

            this.FillArray(ref lsCols, ref lsValues, pPrescriptionLignePrescriptionMédicament, false);
            return DataBase.UpdateID("tblPrescriptionLignePrescriptionMédicament", lsCols, lsValues, pPrescriptionLignePrescriptionMédicament.ID);
        }

    }
}

