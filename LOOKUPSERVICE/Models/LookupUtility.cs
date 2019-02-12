using System;
using System.Collections.Generic;
using System.Data.OracleClient;
using System.Linq;
using System.Web;
using System.Xml.Serialization;

namespace LOOKUPSERVICE.Models
{
    public class DPModule
    {
        public string ID { get; set; }
        public string Name { get; set; }

    }
    public class LookupUtility
    {

        public static string Serialize<T>(T dataToSerialize)
        {
            try
            {
                var stringwriter = new System.IO.StringWriter();
                var serializer = new XmlSerializer(typeof(T));
                serializer.Serialize(stringwriter, dataToSerialize);
                return stringwriter.ToString();
            }
            catch
            {
                
            }
            return "";
        }
        public static List<DPModule> GetLookupOfTable(string Table)
        {
            var myConnection = Utility.connection();
           

            string finalQuery = "SELECT * FROM "+Table;
            OracleCommand command = new OracleCommand(finalQuery, myConnection);

            OracleDataReader reader = command.ExecuteReader();
            List<DPModule> REPlist = new List<DPModule>();
            while (reader.Read())
            {
                REPlist.Add(new DPModule { ID = reader.GetValue(0).ToString(), Name = reader.GetValue(1).ToString() });

            }
           
            return REPlist;
        }
        public static List<DPModule> GetLookupOfQuery(string Query)
        {
            var myConnection = Utility.connection();
          

            string finalQuery = Query;
            OracleCommand command = new OracleCommand(finalQuery, myConnection);

            OracleDataReader reader = command.ExecuteReader();
            List<DPModule> REPlist = new List<DPModule>();
            while (reader.Read())
            {
                REPlist.Add(new DPModule { ID = reader.GetValue(0).ToString(), Name = reader.GetValue(1).ToString() });

            }
           
            return REPlist;
        }
    }
}