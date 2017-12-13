
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystèmeGestionPharmacie
{
    public static class Util
    {
        //Double le caractère ' dans une chaîne
        public static string DoubleQuote(string psString)
        {
            if (isNULL(psString))
                return "";
            if (psString == "")
                return "";
            return psString.Replace("'", "''");
        }
        #region Conversion

        public static int StringToInt(string psString)
        {
            if (isNULL(psString))
                return int.MinValue;
            if (psString.Length == 0)
                return int.MinValue;
            try
            {
                int liTemp = int.Parse(psString);

                return liTemp;
            }
            catch
            {
                return int.MinValue;
            }
        }

        #endregion

        #region TraitementChaine

        public static string RemoveDoubleSpaces(string psString)
        {
            string lsTemp = "";

            psString = psString.Trim();
            while (lsTemp != psString)
            {
                lsTemp = psString;
                psString = psString.Replace("  ", " ");
            }
            return psString;
        }

        public static string FillLenghtString(string psStringToBeFilled, int piLenght, bool pbFromStart, char pcFillingChar)
        {
            int liLenght = psStringToBeFilled.Length;

            while (piLenght > liLenght)
            {
                if (pbFromStart)
                    psStringToBeFilled = pcFillingChar + psStringToBeFilled;
                else
                    psStringToBeFilled += pcFillingChar;
                liLenght += 1;
            }
            return psStringToBeFilled;
        }

        public static string ZeroFill(int piNumber, int piQtyOfZero)
        {
            return ZeroFill(piNumber.ToString(), piQtyOfZero);
        }

        public static string ZeroFill(string psToBeFilled, int piQtyOfZero)
        {
            if (isNULL(psToBeFilled))
                return null;
            while (psToBeFilled.Length < piQtyOfZero)
                psToBeFilled = "0" + psToBeFilled;
            return psToBeFilled;
        }

        #endregion

        #region Validation

        public static bool isNULL(object pNullableObj)
        {
            return (pNullableObj == null);
        }

        public static bool isValidGuid(string psGuid)
        {
            if (isNULL(psGuid))
                return false;
            if (psGuid == "")
                return false;
            try
            {
                Guid lGuid = new Guid(psGuid);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static bool isCharAlphaNum(char pcChar)
        {
            if (isNULL(pcChar))
                return false;

            int liChar = Convert.ToInt32(pcChar);

            //48..57         
            //65..90         
            //97..122        
            //128..154      
            //160..165      
            //181..183      
            //198           
            //199           
            //210..212      
            //214..216      
            //222           
            //224           
            //226..229      
            //233..237      
            return ((liChar >= 48 && liChar <= 57) || (liChar >= 65 && liChar <= 90) || (liChar >= 97 && liChar <= 122) ||
                    (liChar >= 128 && liChar <= 154) || (liChar >= 160 && liChar <= 165) || (liChar >= 181 && liChar <= 183) ||
                    (liChar == 198) || (liChar == 199) || (liChar >= 210 && liChar <= 212) ||
                    (liChar >= 214 && liChar <= 216) || (liChar == 222) || (liChar == 224) ||
                    (liChar >= 226 && liChar <= 229) || (liChar >= 233 && liChar <= 237));
        }

        #endregion

    }
}


       