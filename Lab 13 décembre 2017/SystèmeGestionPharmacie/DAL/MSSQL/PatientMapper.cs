

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Data;
using Syst�meGestionPharmacie.Logique;

namespace Syst�meGestionPharmacie.DAL.MSSQL
{
    public class PatientMapper : AbstractMapper, IPatientMapper
    {

        public PatientMapper()
        {
        }

        //--------------------------------------------------------------------
        public Patient Find(Guid ID)
        {
            Patient lPatient = (Patient)AbstractFind(ID);

            if (Util.isNULL(lPatient))
            {
                DataRow row = DataBase.SelectID(ID, "[tblPatient]");
                if (Util.isNULL(row))
                    return null;
                lPatient = this.FillFields(row);
                LoadedMap.Add(lPatient.ID, lPatient); 
            }
            return lPatient;
        }

        public List<Patient> Find(string nom, string prenom)
        {
            List<Patient> lPatient = new List<Patient>();
            Patient p;

                DataTable table = DataBase.Select("SELECT * FROM [tblPatient] WHERE Nom='"+nom+"' and Pr�nom='"+prenom+"'");
                if (Util.isNULL(table))
                    return null;

            DataRow[] dr = table.Select();
            for(int i=0;i<dr.Length ;i++)
            {
                p = this.FillFields(dr.ElementAt(i));
                lPatient.Add(p);
                LoadedMap.Add(p.ID, p);
            }
            if(lPatient.Count()>0)
                 return lPatient;

            return null;
        }


        //--------------------------------------------------------------------
        private Patient FillFields(DataRow pDataRow)
        {
            Patient lPatient = new Patient();
	    
                 lPatient.Num�roAssuranceMaladie = (string)pDataRow["Num�roAssuranceMaladie"];
		
                 lPatient.Nom = (string)pDataRow["Nom"];
		
                 lPatient.Pr�nom = (string)pDataRow["Pr�nom"];
		
                 lPatient.Adresse = (string)pDataRow["Adresse"];
		
                 lPatient.Num�roT�l�phone = (string)pDataRow["Num�roT�l�phone"];
		
                 lPatient.DateNaissance = (DateTime)pDataRow["DateNaissance"];
		
            lPatient.ID = new Guid(pDataRow["ID"].ToString());

	    
            return lPatient;
        }

        //--------------------------------------------------------------------
        public DataTable FindAll()
        {
            return DataBase.SelectTable("[tblPatient]", "");
        }


	

        //---------------------------------------------------------------------
        private void FillArray(ref string[] pCols, ref string[] pValues, Patient pPatient, bool pIsInsertID)
        {
            int liCpt = 0;
            int liNombre = 6 + 0;
            if (pIsInsertID)
            {
                pCols = new string[liNombre + 1];
                pValues = new string[liNombre + 1];
                pCols[liCpt] = "ID";
                pValues[liCpt++] = "'" + pPatient.ID.ToString() + "'";
            }
            else
            {
                pCols = new string[liNombre];
                pValues = new string[liNombre];
            }

	    
		pCols[liCpt] = "Num�roAssuranceMaladie";
		
				pValues[liCpt++] = "'" + Util.DoubleQuote(pPatient.Num�roAssuranceMaladie) + "'";
  			
		pCols[liCpt] = "Nom";
		
				pValues[liCpt++] = "'" + Util.DoubleQuote(pPatient.Nom) + "'";
  			
		pCols[liCpt] = "Pr�nom";
		
				pValues[liCpt++] = "'" + Util.DoubleQuote(pPatient.Pr�nom) + "'";
  			
		pCols[liCpt] = "Adresse";
		
				pValues[liCpt++] = "'" + Util.DoubleQuote(pPatient.Adresse) + "'";
  			
		pCols[liCpt] = "Num�roT�l�phone";
		
				pValues[liCpt++] = "'" + Util.DoubleQuote(pPatient.Num�roT�l�phone) + "'";
  			
		pCols[liCpt] = "DateNaissance";
		
      		      		pValues[liCpt++] = "'" + pPatient.DateNaissance.ToString() + "'"; 
			
        }

        //----------------------------------------------------------------------------------------
        public int Delete(Patient pPatient)
        {
            int liErreur = int.MinValue;
            int liTemp;
            int liI = 0;

            liTemp = DataBase.DeleteID(pPatient.ID, "[tblPatient]");
            if (liTemp == liErreur)
                liI = liErreur;
            if (liI != liErreur)
                liI += liTemp;
	    
	    
            return liI;
        }

        //--------------------------------------------------------------------

        public int Insert(Patient pPatient)
        {
            string[] lsCols = null;
            string[] lsValues = null;
            this.FillArray(ref lsCols, ref lsValues, pPatient, true);
            return DataBase.Insert("[tblPatient]", lsCols, lsValues);
        }

        
        //---------------------------------------------------------------------
        public int Update(Patient pPatient)
        {
            string[] lsCols = null;
            string[] lsValues = null;

            this.FillArray(ref lsCols, ref lsValues, pPatient, false);
            return DataBase.UpdateID("tblPatient", lsCols, lsValues, pPatient.ID);
        }

    }
}

