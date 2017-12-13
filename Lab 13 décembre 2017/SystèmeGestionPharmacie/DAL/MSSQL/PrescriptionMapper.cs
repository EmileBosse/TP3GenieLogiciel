

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Data;
using SystèmeGestionPharmacie.Logique;

namespace SystèmeGestionPharmacie.DAL.MSSQL
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
	    
                 lPrescription.Numéro = (string)pDataRow["Numéro"];
		
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
		public DataTable FindAllMédicamentTable(Prescription pPrescription)
		{
			return DataBase.Select("SELECT * FROM tblPrescriptionMédicament WHERE IDPrescription = '" + pPrescription.ID.ToString() + "'");
		}

		//--------------------------------------------------------------------
        	public void FindAllMédicament(ref Prescription pPrescription)
		{
			DataTable ldtMédicament = FindAllMédicamentTable(pPrescription);
			pPrescription.ListMédicament.Clear();
            		if (Util.isNULL(ldtMédicament)) return;
            		if (ldtMédicament.Rows.Count == 0) return;
			DataRow ldrMédicament;
            		IEnumerator lMédicamentEnumerator = ldtMédicament.Rows.GetEnumerator();
            		Médicament lMédicament;
            		MédicamentMapper lMédicamentMapper = new MédicamentMapper();
            		while (lMédicamentEnumerator.MoveNext())
            		{
                		ldrMédicament = (DataRow)lMédicamentEnumerator.Current;
                		lMédicament = lMédicamentMapper.Find(new Guid(ldrMédicament["IDMédicament"].ToString()));
                		pPrescription.ListMédicament.Add(lMédicament.ID, lMédicament);
            		}
			
		}
		
		//--------------------------------------------------------------------
		public int InsertAllMédicament(Prescription pPrescription)
		{
			
			
            		int liErreur = DataBase.DeleteRecords("PrescriptionMédicament", "IDPrescription = '" + pPrescription.ID.ToString() + "'");

            		if (pPrescription.ListMédicament.Count == 0) return liErreur;

            		IDictionaryEnumerator lDictionaryEnumerator = pPrescription.ListMédicament.GetEnumerator();
            		int liI = 0;
            		string[] lsCols = new string[2];
            		string[] lsValues = new string[2];

            		lsCols[0] = "IDPrescription";
            		lsCols[1] = "IDMédicament";
            		while (lDictionaryEnumerator.MoveNext())
            		{
                		lsValues[0] = "'" + pPrescription.ID.ToString() + "'";
                		lsValues[1] = "'" + ((Médicament)lDictionaryEnumerator.Value).ID.ToString() + "'";
                		if (DataBase.Insert("Médicament", lsCols, lsValues) == liErreur) liI = liErreur;
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

	    
		pCols[liCpt] = "Numéro";
		
				pValues[liCpt++] = "'" + Util.DoubleQuote(pPrescription.Numéro) + "'";
  			
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
	    
	    
	    liTemp = DataBase.Delete("DELETE FROM tblPrescriptionMédicament WHERE IDPrescription ='" + pPrescription.ID + "'");
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

