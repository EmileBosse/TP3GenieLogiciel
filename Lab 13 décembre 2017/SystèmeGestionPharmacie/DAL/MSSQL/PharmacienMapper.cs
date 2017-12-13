

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Data;
using Syst�meGestionPharmacie.Logique;

namespace Syst�meGestionPharmacie.DAL.MSSQL
{
    public class PharmacienMapper : AbstractMapper, IPharmacienMapper
    {

        public PharmacienMapper()
        {
        }

        //--------------------------------------------------------------------
        public Pharmacien Find(Guid ID)
        {
            Pharmacien lPharmacien = (Pharmacien)AbstractFind(ID);

            if (Util.isNULL(lPharmacien))
            {
                DataRow row = DataBase.SelectID(ID, "[tblPharmacien]");
                if (Util.isNULL(row))
                    return null;
                lPharmacien = this.FillFields(row);
                LoadedMap.Add(lPharmacien.ID, lPharmacien); 
            }
            return lPharmacien;
        }


        //--------------------------------------------------------------------
        private Pharmacien FillFields(DataRow pDataRow)
        {
            Pharmacien lPharmacien = new Pharmacien();
	    
                 lPharmacien.Num�roLicense = (string)pDataRow["Num�roLicense"];
		
                 lPharmacien.Nom = (string)pDataRow["Nom"];
		
                 lPharmacien.Pr�nom = (string)pDataRow["Pr�nom"];
		
                 lPharmacien.Adresse = (string)pDataRow["Adresse"];
		
                 lPharmacien.Num�roT�l�phone = (string)pDataRow["Num�roT�l�phone"];
		
            lPharmacien.ID = new Guid(pDataRow["ID"].ToString());

	    
            return lPharmacien;
        }

        //--------------------------------------------------------------------
        public DataTable FindAll()
        {
            return DataBase.SelectTable("[tblPharmacien]", "");
        }


	

        //---------------------------------------------------------------------
        private void FillArray(ref string[] pCols, ref string[] pValues, Pharmacien pPharmacien, bool pIsInsertID)
        {
            int liCpt = 0;
            int liNombre = 5 + 0;
            if (pIsInsertID)
            {
                pCols = new string[liNombre + 1];
                pValues = new string[liNombre + 1];
                pCols[liCpt] = "ID";
                pValues[liCpt++] = "'" + pPharmacien.ID.ToString() + "'";
            }
            else
            {
                pCols = new string[liNombre];
                pValues = new string[liNombre];
            }

	    
		pCols[liCpt] = "Num�roLicense";
		
				pValues[liCpt++] = "'" + Util.DoubleQuote(pPharmacien.Num�roLicense) + "'";
  			
		pCols[liCpt] = "Nom";
		
				pValues[liCpt++] = "'" + Util.DoubleQuote(pPharmacien.Nom) + "'";
  			
		pCols[liCpt] = "Pr�nom";
		
				pValues[liCpt++] = "'" + Util.DoubleQuote(pPharmacien.Pr�nom) + "'";
  			
		pCols[liCpt] = "Adresse";
		
				pValues[liCpt++] = "'" + Util.DoubleQuote(pPharmacien.Adresse) + "'";
  			
		pCols[liCpt] = "Num�roT�l�phone";
		
				pValues[liCpt++] = "'" + Util.DoubleQuote(pPharmacien.Num�roT�l�phone) + "'";
  			
        }

        //----------------------------------------------------------------------------------------
        public int Delete(Pharmacien pPharmacien)
        {
            int liErreur = int.MinValue;
            int liTemp;
            int liI = 0;

            liTemp = DataBase.DeleteID(pPharmacien.ID, "[tblPharmacien]");
            if (liTemp == liErreur)
                liI = liErreur;
            if (liI != liErreur)
                liI += liTemp;
	    
	    
            return liI;
        }

        //--------------------------------------------------------------------

        public int Insert(Pharmacien pPharmacien)
        {
            string[] lsCols = null;
            string[] lsValues = null;
            this.FillArray(ref lsCols, ref lsValues, pPharmacien, true);
            return DataBase.Insert("[tblPharmacien]", lsCols, lsValues);
        }

        
        //---------------------------------------------------------------------
        public int Update(Pharmacien pPharmacien)
        {
            string[] lsCols = null;
            string[] lsValues = null;

            this.FillArray(ref lsCols, ref lsValues, pPharmacien, false);
            return DataBase.UpdateID("tblPharmacien", lsCols, lsValues, pPharmacien.ID);
        }

    }
}

