using System;
using System.Collections.Generic;
using System.Data.OracleClient;
using System.Linq;
using System.Text;

namespace LOOKUPSERVICE.Models
{
    public sealed class Singleton
    {
      //  static readonly Singleton instance = new Singleton();
        static string myConnectionString = "data source=132.136.133.4:1521/hajj;password=ttsafrhajj;persist security info=True;user id=SEJEL1439; Unicode=True";
          
        static readonly OracleConnection con = new OracleConnection(myConnectionString);
      
        
        static Singleton()
        {
        }

        Singleton()
        {
        }

        public static OracleConnection Instance
        {
            get
            {
                return con;
            }
        }
    }
}
