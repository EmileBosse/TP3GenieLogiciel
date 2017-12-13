

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Data;
using SystèmeGestionPharmacie.Logique;

namespace SystèmeGestionPharmacie.DAL.MSSQL
{
    public class UtilisateurMapper : AbstractMapper, IUtilisateurMapper
    {

        public UtilisateurMapper()
        {
        }

        //--------------------------------------------------------------------
        public Utilisateur Find(Guid ID)
        {
            Utilisateur lUtilisateur = (Utilisateur)AbstractFind(ID);

            if (Util.isNULL(lUtilisateur))
            {
                DataRow row = DataBase.SelectID(ID, "[tblUtilisateur]");
                if (Util.isNULL(row))
                    return null;
                lUtilisateur = this.FillFields(row);
                LoadedMap.Add(lUtilisateur.ID, lUtilisateur); 
            }
            return lUtilisateur;
        }


        //--------------------------------------------------------------------
        private Utilisateur FillFields(DataRow pDataRow)
        {
            Utilisateur lUtilisateur = new Utilisateur();
	    
                 lUtilisateur.NomConnexion = (string)pDataRow["NomConnexion"];
		
                 lUtilisateur.MotDePasse = (string)pDataRow["MotDePasse"];
		
            lUtilisateur.ID = new Guid(pDataRow["ID"].ToString());

	    
            return lUtilisateur;
        }

        //--------------------------------------------------------------------
        public DataTable FindAll()
        {
            return DataBase.SelectTable("[tblUtilisateur]", "");
        }


	

        //---------------------------------------------------------------------
        private void FillArray(ref string[] pCols, ref string[] pValues, Utilisateur pUtilisateur, bool pIsInsertID)
        {
            int liCpt = 0;
            int liNombre = 2 + 0;
            if (pIsInsertID)
            {
                pCols = new string[liNombre + 1];
                pValues = new string[liNombre + 1];
                pCols[liCpt] = "ID";
                pValues[liCpt++] = "'" + pUtilisateur.ID.ToString() + "'";
            }
            else
            {
                pCols = new string[liNombre];
                pValues = new string[liNombre];
            }

	    
		pCols[liCpt] = "NomConnexion";
		
				pValues[liCpt++] = "'" + Util.DoubleQuote(pUtilisateur.NomConnexion) + "'";
  			
		pCols[liCpt] = "MotDePasse";
		
				pValues[liCpt++] = "'" + Util.DoubleQuote(pUtilisateur.MotDePasse) + "'";
  			
        }

        //----------------------------------------------------------------------------------------
        public int Delete(Utilisateur pUtilisateur)
        {
            int liErreur = int.MinValue;
            int liTemp;
            int liI = 0;

            liTemp = DataBase.DeleteID(pUtilisateur.ID, "[tblUtilisateur]");
            if (liTemp == liErreur)
                liI = liErreur;
            if (liI != liErreur)
                liI += liTemp;
	    
	    
            return liI;
        }

        //--------------------------------------------------------------------

        public int Insert(Utilisateur pUtilisateur)
        {
            string[] lsCols = null;
            string[] lsValues = null;
            this.FillArray(ref lsCols, ref lsValues, pUtilisateur, true);
            return DataBase.Insert("[tblUtilisateur]", lsCols, lsValues);
        }

        
        //---------------------------------------------------------------------
        public int Update(Utilisateur pUtilisateur)
        {
            string[] lsCols = null;
            string[] lsValues = null;

            this.FillArray(ref lsCols, ref lsValues, pUtilisateur, false);
            return DataBase.UpdateID("tblUtilisateur", lsCols, lsValues, pUtilisateur.ID);
        }

    }
}

