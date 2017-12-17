using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Data;
using SystèmeGestionPharmacie.Logique;

namespace SystèmeGestionPharmacie.DAL.MSSQL
{
    public class MédecinMapper : AbstractMapper, IMédecinMapper
    {

        public MédecinMapper()
        {
        }

        //--------------------------------------------------------------------
        public Médecin Find(Guid ID)
        {
            Médecin lMédecin = (Médecin)AbstractFind(ID);

            if (Util.isNULL(lMédecin))
            {
                DataRow row = DataBase.SelectID(ID, "[tblMédecin]");
                if (Util.isNULL(row))
                    return null;
                lMédecin = this.FillFields(row);
                LoadedMap.Add(lMédecin.ID, lMédecin); 
            }
            return lMédecin;
        }

        public List<Médecin> Find(String numero, String nom, String prenom)
        {
            String where = "";
            bool ajouterAnd = false;
            if (numero != "" || nom != "" || prenom != "")
            {
                where = "WHERE ";
                if (numero != "") { where += ("numéroLicense='"+numero+"'"); ajouterAnd = true; }
                if (nom != "") { if (ajouterAnd) { where += ("and nom='"+nom+"'"); } else { where += ("nom='"+nom+"'"); } ajouterAnd = true; }
                if (prenom != "") { if (ajouterAnd) { where += ("and prénom='"+prenom+"'"); } else { where += ("prénom='"+prenom+"'"); } }
            }
            
            DataTable table = DataBase.Select("SELECT * FROM dbo.tblMédecin "+where+"ORDER BY nom");
            if (Util.isNULL(table))
                return null;

            DataRow[] t = table.Select();
            List<Médecin> ms = new List<Médecin>();
            for (int i = 0; i < t.Length; i++)
            {
                ms.Add(this.FillFields(t[i]));
            }

            return ms;
        }


        //--------------------------------------------------------------------
        private Médecin FillFields(DataRow pDataRow)
        {
            Médecin lMédecin = new Médecin();
	    
                 lMédecin.NuméroLicense = (string)pDataRow["NuméroLicense"];
		
                 lMédecin.Nom = (string)pDataRow["Nom"];
		
                 lMédecin.Prénom = (string)pDataRow["Prénom"];
		
                 lMédecin.Adresse = (string)pDataRow["Adresse"];
		
                 lMédecin.NuméroTéléphone = (string)pDataRow["NuméroTéléphone"];
		
            lMédecin.ID = new Guid(pDataRow["ID"].ToString());

	    
            return lMédecin;
        }

        //--------------------------------------------------------------------
        public DataTable FindAll()
        {
            return DataBase.SelectTable("[tblMédecin]", "");
        }


	

        //---------------------------------------------------------------------
        private void FillArray(ref string[] pCols, ref string[] pValues, Médecin pMédecin, bool pIsInsertID)
        {
            int liCpt = 0;
            int liNombre = 5 + 0;
            if (pIsInsertID)
            {
                pCols = new string[liNombre + 1];
                pValues = new string[liNombre + 1];
                pCols[liCpt] = "ID";
                pValues[liCpt++] = "'" + pMédecin.ID.ToString() + "'";
            }
            else
            {
                pCols = new string[liNombre];
                pValues = new string[liNombre];
            }

	    
		pCols[liCpt] = "NuméroLicense";
		
				pValues[liCpt++] = "'" + Util.DoubleQuote(pMédecin.NuméroLicense) + "'";
  			
		pCols[liCpt] = "Nom";
		
				pValues[liCpt++] = "'" + Util.DoubleQuote(pMédecin.Nom) + "'";
  			
		pCols[liCpt] = "Prénom";
		
				pValues[liCpt++] = "'" + Util.DoubleQuote(pMédecin.Prénom) + "'";
  			
		pCols[liCpt] = "Adresse";
		
				pValues[liCpt++] = "'" + Util.DoubleQuote(pMédecin.Adresse) + "'";
  			
		pCols[liCpt] = "NuméroTéléphone";
		
				pValues[liCpt++] = "'" + Util.DoubleQuote(pMédecin.NuméroTéléphone) + "'";
  			
        }

        //----------------------------------------------------------------------------------------
        public int Delete(Médecin pMédecin)
        {
            int liErreur = int.MinValue;
            int liTemp;
            int liI = 0;

            liTemp = DataBase.DeleteID(pMédecin.ID, "[tblMédecin]");
            if (liTemp == liErreur)
                liI = liErreur;
            if (liI != liErreur)
                liI += liTemp;
	    
	    
            return liI;
        }

        //--------------------------------------------------------------------

        public int Insert(Médecin pMédecin)
        {
            string[] lsCols = null;
            string[] lsValues = null;
            this.FillArray(ref lsCols, ref lsValues, pMédecin, true);
            return DataBase.Insert("[tblMédecin]", lsCols, lsValues);
        }

        
        //---------------------------------------------------------------------
        public int Update(Médecin pMédecin)
        {
            string[] lsCols = null;
            string[] lsValues = null;

            this.FillArray(ref lsCols, ref lsValues, pMédecin, false);
            return DataBase.UpdateID("tblMédecin", lsCols, lsValues, pMédecin.ID);
        }

    }
}

