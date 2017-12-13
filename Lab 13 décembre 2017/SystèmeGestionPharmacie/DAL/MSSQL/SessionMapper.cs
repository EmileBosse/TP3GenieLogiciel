

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Data;
using SystèmeGestionPharmacie.Logique;

namespace SystèmeGestionPharmacie.DAL.MSSQL
{
    public class SessionMapper : AbstractMapper, ISessionMapper
    {

        public SessionMapper()
        {
        }

        //--------------------------------------------------------------------
        public Session Find(Guid ID)
        {
            Session lSession = (Session)AbstractFind(ID);

            if (Util.isNULL(lSession))
            {
                DataRow row = DataBase.SelectID(ID, "[tblSession]");
                if (Util.isNULL(row))
                    return null;
                lSession = this.FillFields(row);
                LoadedMap.Add(lSession.ID, lSession); 
            }
            return lSession;
        }


        //--------------------------------------------------------------------
        private Session FillFields(DataRow pDataRow)
        {
            Session lSession = new Session();
	    
                 lSession.DateConnexion = (DateTime)pDataRow["DateConnexion"];
		
                 lSession.DateDeconnexion = (DateTime)pDataRow["DateDeconnexion"];
		
            lSession.ID = new Guid(pDataRow["ID"].ToString());

	    
            return lSession;
        }

        //--------------------------------------------------------------------
        public DataTable FindAll()
        {
            return DataBase.SelectTable("[tblSession]", "");
        }


	
		//--------------------------------------------------------------------
		public DataTable FindAllPrescriptionTable(Session pSession)
		{
			return DataBase.Select("SELECT * FROM tblSessionPrescription WHERE IDSession = '" + pSession.ID.ToString() + "'");
		}

		//--------------------------------------------------------------------
        	public void FindAllPrescription(ref Session pSession)
		{
			DataTable ldtPrescription = FindAllPrescriptionTable(pSession);
			pSession.ListPrescription.Clear();
            		if (Util.isNULL(ldtPrescription)) return;
            		if (ldtPrescription.Rows.Count == 0) return;
			DataRow ldrPrescription;
            		IEnumerator lPrescriptionEnumerator = ldtPrescription.Rows.GetEnumerator();
            		Prescription lPrescription;
            		PrescriptionMapper lPrescriptionMapper = new PrescriptionMapper();
            		while (lPrescriptionEnumerator.MoveNext())
            		{
                		ldrPrescription = (DataRow)lPrescriptionEnumerator.Current;
                		lPrescription = lPrescriptionMapper.Find(new Guid(ldrPrescription["IDPrescription"].ToString()));
                		pSession.ListPrescription.Add(lPrescription.ID, lPrescription);
            		}
			
		}
		
		//--------------------------------------------------------------------
		public int InsertAllPrescription(Session pSession)
		{
			
			
            		int liErreur = DataBase.DeleteRecords("SessionPrescription", "IDSession = '" + pSession.ID.ToString() + "'");

            		if (pSession.ListPrescription.Count == 0) return liErreur;

            		IDictionaryEnumerator lDictionaryEnumerator = pSession.ListPrescription.GetEnumerator();
            		int liI = 0;
            		string[] lsCols = new string[2];
            		string[] lsValues = new string[2];

            		lsCols[0] = "IDSession";
            		lsCols[1] = "IDPrescription";
            		while (lDictionaryEnumerator.MoveNext())
            		{
                		lsValues[0] = "'" + pSession.ID.ToString() + "'";
                		lsValues[1] = "'" + ((Prescription)lDictionaryEnumerator.Value).ID.ToString() + "'";
                		if (DataBase.Insert("Prescription", lsCols, lsValues) == liErreur) liI = liErreur;
                		if (liI != liErreur) liI += 1;
            		}
            		return liI;
        	}
	
		//--------------------------------------------------------------------
		public DataTable FindAllTransactionVenteTable(Session pSession)
		{
			return DataBase.Select("SELECT * FROM tblSessionTransactionVente WHERE IDSession = '" + pSession.ID.ToString() + "'");
		}

		//--------------------------------------------------------------------
        	public void FindAllTransactionVente(ref Session pSession)
		{
			DataTable ldtTransactionVente = FindAllTransactionVenteTable(pSession);
			pSession.ListTransactionVente.Clear();
            		if (Util.isNULL(ldtTransactionVente)) return;
            		if (ldtTransactionVente.Rows.Count == 0) return;
			DataRow ldrTransactionVente;
            		IEnumerator lTransactionVenteEnumerator = ldtTransactionVente.Rows.GetEnumerator();
            		TransactionVente lTransactionVente;
            		TransactionVenteMapper lTransactionVenteMapper = new TransactionVenteMapper();
            		while (lTransactionVenteEnumerator.MoveNext())
            		{
                		ldrTransactionVente = (DataRow)lTransactionVenteEnumerator.Current;
                		lTransactionVente = lTransactionVenteMapper.Find(new Guid(ldrTransactionVente["IDTransactionVente"].ToString()));
                		pSession.ListTransactionVente.Add(lTransactionVente.ID, lTransactionVente);
            		}
			
		}
		
		//--------------------------------------------------------------------
		public int InsertAllTransactionVente(Session pSession)
		{
			
			
            		int liErreur = DataBase.DeleteRecords("SessionTransactionVente", "IDSession = '" + pSession.ID.ToString() + "'");

            		if (pSession.ListTransactionVente.Count == 0) return liErreur;

            		IDictionaryEnumerator lDictionaryEnumerator = pSession.ListTransactionVente.GetEnumerator();
            		int liI = 0;
            		string[] lsCols = new string[2];
            		string[] lsValues = new string[2];

            		lsCols[0] = "IDSession";
            		lsCols[1] = "IDTransactionVente";
            		while (lDictionaryEnumerator.MoveNext())
            		{
                		lsValues[0] = "'" + pSession.ID.ToString() + "'";
                		lsValues[1] = "'" + ((TransactionVente)lDictionaryEnumerator.Value).ID.ToString() + "'";
                		if (DataBase.Insert("TransactionVente", lsCols, lsValues) == liErreur) liI = liErreur;
                		if (liI != liErreur) liI += 1;
            		}
            		return liI;
        	}
	

        //---------------------------------------------------------------------
        private void FillArray(ref string[] pCols, ref string[] pValues, Session pSession, bool pIsInsertID)
        {
            int liCpt = 0;
            int liNombre = 2 + 0;
            if (pIsInsertID)
            {
                pCols = new string[liNombre + 1];
                pValues = new string[liNombre + 1];
                pCols[liCpt] = "ID";
                pValues[liCpt++] = "'" + pSession.ID.ToString() + "'";
            }
            else
            {
                pCols = new string[liNombre];
                pValues = new string[liNombre];
            }

	    
		pCols[liCpt] = "DateConnexion";
		
      		      		pValues[liCpt++] = "'" + pSession.DateConnexion.ToString() + "'"; 
			
		pCols[liCpt] = "DateDeconnexion";
		
      		      		pValues[liCpt++] = "'" + pSession.DateDeconnexion.ToString() + "'"; 
			
        }

        //----------------------------------------------------------------------------------------
        public int Delete(Session pSession)
        {
            int liErreur = int.MinValue;
            int liTemp;
            int liI = 0;

            liTemp = DataBase.DeleteID(pSession.ID, "[tblSession]");
            if (liTemp == liErreur)
                liI = liErreur;
            if (liI != liErreur)
                liI += liTemp;
	    
	    
	    liTemp = DataBase.Delete("DELETE FROM tblSessionPrescription WHERE IDSession ='" + pSession.ID + "'");
            if (liTemp == liErreur)
                liI = liErreur;
            if (liI != liErreur)
                liI += liTemp;
	    
	    liTemp = DataBase.Delete("DELETE FROM tblSessionTransactionVente WHERE IDSession ='" + pSession.ID + "'");
            if (liTemp == liErreur)
                liI = liErreur;
            if (liI != liErreur)
                liI += liTemp;
	    
            return liI;
        }

        //--------------------------------------------------------------------

        public int Insert(Session pSession)
        {
            string[] lsCols = null;
            string[] lsValues = null;
            this.FillArray(ref lsCols, ref lsValues, pSession, true);
            return DataBase.Insert("[tblSession]", lsCols, lsValues);
        }

        
        //---------------------------------------------------------------------
        public int Update(Session pSession)
        {
            string[] lsCols = null;
            string[] lsValues = null;

            this.FillArray(ref lsCols, ref lsValues, pSession, false);
            return DataBase.UpdateID("tblSession", lsCols, lsValues, pSession.ID);
        }

    }
}

