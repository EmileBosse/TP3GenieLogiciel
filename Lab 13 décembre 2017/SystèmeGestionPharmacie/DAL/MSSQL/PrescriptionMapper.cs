

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Data;
using Syst�meGestionPharmacie.Logique;

namespace Syst�meGestionPharmacie.DAL.MSSQL
{
    public class PrescriptionMapper : AbstractMapper, IPrescriptionMapper
    {

        public PrescriptionMapper()
        {
        }

        //--------------------------------------------------------------------
        public Prescription Find(Guid ID)
        {
            Prescription lPrescription = (Prescription)AbstractFind(ID);

            if (Util.isNULL(lPrescription))
            {
                DataRow row = DataBase.SelectID(ID, "[tblPrescription]");
                if (Util.isNULL(row))
                    return null;
                lPrescription = this.FillFields(row);
                LoadedMap.Add(lPrescription.ID, lPrescription); 
            }
            return lPrescription;
        }


        //--------------------------------------------------------------------
        private Prescription FillFields(DataRow pDataRow)
        {
            Prescription lPrescription = new Prescription();
	    
                 lPrescription.Num�ro = (string)pDataRow["Num�ro"];
		
                 lPrescription.DatePresciption = (DateTime)pDataRow["DatePresciption"];
		
                 lPrescription.CopiePrescription = (byte[])pDataRow["CopiePrescription"];
		
            lPrescription.ID = new Guid(pDataRow["ID"].ToString());

	    
            return lPrescription;
        }

        //--------------------------------------------------------------------
        public DataTable FindAll()
        {
            return DataBase.SelectTable("[tblPrescription]", "");
        }


	
		//--------------------------------------------------------------------
		public DataTable FindAllM�dicamentTable(Prescription pPrescription)
		{
			return DataBase.Select("SELECT * FROM tblPrescriptionM�dicament WHERE IDPrescription = '" + pPrescription.ID.ToString() + "'");
		}

		//--------------------------------------------------------------------
        	public void FindAllM�dicament(ref Prescription pPrescription)
		{
			DataTable ldtM�dicament = FindAllM�dicamentTable(pPrescription);
			pPrescription.ListM�dicament.Clear();
            		if (Util.isNULL(ldtM�dicament)) return;
            		if (ldtM�dicament.Rows.Count == 0) return;
			DataRow ldrM�dicament;
            		IEnumerator lM�dicamentEnumerator = ldtM�dicament.Rows.GetEnumerator();
            		M�dicament lM�dicament;
            		M�dicamentMapper lM�dicamentMapper = new M�dicamentMapper();
            		while (lM�dicamentEnumerator.MoveNext())
            		{
                		ldrM�dicament = (DataRow)lM�dicamentEnumerator.Current;
                		lM�dicament = lM�dicamentMapper.Find(new Guid(ldrM�dicament["IDM�dicament"].ToString()));
                		pPrescription.ListM�dicament.Add(lM�dicament.ID, lM�dicament);
            		}
			
		}
		
		//--------------------------------------------------------------------
		public int InsertAllM�dicament(Prescription pPrescription)
		{
			
			
            		int liErreur = DataBase.DeleteRecords("PrescriptionM�dicament", "IDPrescription = '" + pPrescription.ID.ToString() + "'");

            		if (pPrescription.ListM�dicament.Count == 0) return liErreur;

            		IDictionaryEnumerator lDictionaryEnumerator = pPrescription.ListM�dicament.GetEnumerator();
            		int liI = 0;
            		string[] lsCols = new string[2];
            		string[] lsValues = new string[2];

            		lsCols[0] = "IDPrescription";
            		lsCols[1] = "IDM�dicament";
            		while (lDictionaryEnumerator.MoveNext())
            		{
                		lsValues[0] = "'" + pPrescription.ID.ToString() + "'";
                		lsValues[1] = "'" + ((M�dicament)lDictionaryEnumerator.Value).ID.ToString() + "'";
                		if (DataBase.Insert("M�dicament", lsCols, lsValues) == liErreur) liI = liErreur;
                		if (liI != liErreur) liI += 1;
            		}
            		return liI;
        	}
	

        //---------------------------------------------------------------------
        private void FillArray(ref string[] pCols, ref string[] pValues, Prescription pPrescription, bool pIsInsertID)
        {
            int liCpt = 0;
            int liNombre = 3 + 0;
            if (pIsInsertID)
            {
                pCols = new string[liNombre + 1];
                pValues = new string[liNombre + 1];
                pCols[liCpt] = "ID";
                pValues[liCpt++] = "'" + pPrescription.ID.ToString() + "'";
            }
            else
            {
                pCols = new string[liNombre];
                pValues = new string[liNombre];
            }

	    
		pCols[liCpt] = "Num�ro";
		
				pValues[liCpt++] = "'" + Util.DoubleQuote(pPrescription.Num�ro) + "'";
  			
		pCols[liCpt] = "DatePresciption";
		
      		      		pValues[liCpt++] = "'" + pPrescription.DatePresciption.ToString() + "'"; 
			
		pCols[liCpt] = "CopiePrescription";
		
      		      		pValues[liCpt++] = "0x" + BitConverter.ToString(pPrescription.CopiePrescription).Replace("-", "");
			
        }

        //----------------------------------------------------------------------------------------
        public int Delete(Prescription pPrescription)
        {
            int liErreur = int.MinValue;
            int liTemp;
            int liI = 0;

            liTemp = DataBase.DeleteID(pPrescription.ID, "[tblPrescription]");
            if (liTemp == liErreur)
                liI = liErreur;
            if (liI != liErreur)
                liI += liTemp;
	    
	    
	    liTemp = DataBase.Delete("DELETE FROM tblPrescriptionM�dicament WHERE IDPrescription ='" + pPrescription.ID + "'");
            if (liTemp == liErreur)
                liI = liErreur;
            if (liI != liErreur)
                liI += liTemp;
	    
            return liI;
        }

        //--------------------------------------------------------------------

        public int Insert(Prescription pPrescription)
        {
            string[] lsCols = null;
            string[] lsValues = null;
            this.FillArray(ref lsCols, ref lsValues, pPrescription, true);
            return DataBase.Insert("[tblPrescription]", lsCols, lsValues);
        }

        
        //---------------------------------------------------------------------
        public int Update(Prescription pPrescription)
        {
            string[] lsCols = null;
            string[] lsValues = null;

            this.FillArray(ref lsCols, ref lsValues, pPrescription, false);
            return DataBase.UpdateID("tblPrescription", lsCols, lsValues, pPrescription.ID);
        }

    }
}

