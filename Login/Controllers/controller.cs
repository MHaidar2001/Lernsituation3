using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Login
{
    public class controller
    {

        #region Eigenschaften
        #endregion

        #region Accessoren/Modifier
        #endregion

        #region Konstruktoren
        #endregion

        #region Worker
        public string ueberpruefen(string text1, string text2)
        {
            Login user = new Login(-1,text1,text2,"");
            user.ueberpruefenInAPI();
            string index = user.ueberpruefenInAPI();
            
            return index;
        }
        #endregion
      
    }
}