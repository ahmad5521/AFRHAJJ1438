using AFRHAJJ1438._2wayWSDL;
using AFRHAJJ1438.ServiceReference1;
using LOOKUPSERVICE.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AFRHAJJ1438
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            ServiceReference2.WebServiceSoapClient client = new ServiceReference2.WebServiceSoapClient();
            ServiceReference2.SendHajMianifestInfo info = new ServiceReference2.SendHajMianifestInfo();
            info.MANIFEST_ID ="110367";
            info.MANIFEST_PRT_ID =50;
            info.MANIFEST_LTC_ID = 24;
            info.MANIFEST_ROUTE_ID = 1;
            info.MANIFEST_TRIP_DATE_HIJ = 14391105;
            info.MANIFEST_TRIP_DATE = DateTime.Now;
            info.MANIFEST_BI_ID = 27395;
            info.MANIFEST_DI_ID = 26761;
            info.MANIFEST_STATE = 0;
            info.MANIFEST_HOUSE_ID = 1020494;
            info.MANIFEST_EST_ID = "3";
            info.MANIFEST_HEB_ID = "3021";
            info.MANIFEST_TYPE = "1";
            List<ServiceReference2.DETAILS> list = new List<ServiceReference2.DETAILS>();
            list.Add(new ServiceReference2.DETAILS { GROUP_ID = 147709, MANIFEST_HAJ_TYPE = "1", MAINFEST_DEPENDENT_NO = "0", MANIFEST_PASSPORT_NO = "0", MANIFEST_HD_ID = "5883505", MANIFEST_NT_ID = 27 });
            info.MANIFEST_DETAILS = list.ToArray();

            
     ServiceReference2.RESULT res=  client.SendHajMianifestInfo(info, new ServiceReference2.LOGIN { USER_NAME = "AfricaNonArab", PASSWORD = "AfricaNonArab" });

            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls
                                                    | SecurityProtocolType.Tls11
                                                    | SecurityProtocolType.Tls12 
                                                    | SecurityProtocolType.Ssl3;
            ServicePointManager.ServerCertificateValidationCallback = new RemoteCertificateValidationCallback(delegate { return true; });
        }

        protected  void Button1_Click(object sender, EventArgs e)
        {
            List<DETAILSCELL> cells = new  List<DETAILSCELL>();
            DETAILSCELL cel1=new DETAILSCELL { CNAME = "ESP_ID", CTYPE = "NUMBER", CVALUE = "999" };
            DETAILSCELL cel2 = new DETAILSCELL { CNAME = "ESP_DESC_AR", CTYPE = "VARCHAR2", CVALUE = "ESP_DESC_AR" };
            DETAILSCELL cel3 = new DETAILSCELL { CNAME = "ESP_DESC_LA", CTYPE = "VARCHAR2", CVALUE = "ESP_DESC_AR" };
            DETAILSCELL cel4 = new DETAILSCELL { CNAME = "ESP_NAME_AR", CTYPE = "VARCHAR2", CVALUE = "ESP_DESC_AR" };


            Utility.setData(new REQUEST_INFO { ENTITY_ID = 156, Opreation = 1001, RECORD_ID = 999 }, cells.ToArray());

           // GetLookups.RESULT res;
           // GetLookups.PortTypeClient client = new GetLookups.PortTypeClient();
           // //GetLookups.DETAILSCELL[] result=client.GetLookupDetails(new GetLookups.LOGIN { USER_NAME = "EST3_INTG", PASSWORD = "4sle4gxi" }, new GetLookups.REQUEST_INFO { ENTITY_ID = 54, RECORD_ID = 1220787 }, out res);

           // LOGIN login = new LOGIN { USER_NAME = "AfricaNonArab", PASSWORD = "AfricaNonArab" };

           // Details d = new Details();
           // HAJJS hh = new HAJJS { SHT_HD_ID = "232", SHT_NT_ID = "27" };
         
           // House h = new House();
           // h.HT_HC_ID = 232;
           // h.HAJJS = new HAJJS[1];
           // h.HAJJS[0] = hh;
           // d.Houses = new House[1];
           // d.Houses[0] = h;


          
          

           // SendHajjTrip[] obj = new SendHajjTrip[1];
           // SendHajjTrip o = new SendHajjTrip  {Details=d,  SHT_BUS_ID = "2", SHT_DRIVER_ID = "3", SHT_EST_ID = "3", SHT_HEB_ID = "3", SHT_NAQABA_CONFIRM_NO = "2", SHT_LTC_ID = "9", SHT_STATE = "4", SHT_TAFWEEJ_ID = "2", SHT_TRIP_DATE = DateTime.Now, SHT_TRIP_ID = "323", SHT_TYPE = "2" };
           // obj[0] = o;

           // WebServiceSoapClient sevice = new WebServiceSoapClient();
            

           //RESULT re= sevice.HajjTrip(obj,login);

            Label1.Text = "jlkj";
         //   SendHajMianifestInfo master = new SendHajMianifestInfo
         //   {
         //       MANIFEST_BI_ID = 9038,
         //       MANIFEST_DI_ID = 1691,
         //       MANIFEST_EST_ID = "3",
         //       MANIFEST_HEB_ID = "3049",

         //       MANIFEST_HOUSE_ID = 1020494,
         //       MANIFEST_ID = "49673",
         //       MANIFEST_LTC_ID = 19,
         //       MANIFEST_PRT_ID = 50,
         //       MANIFEST_ROUTE_ID = 1,
         //       MANIFEST_STATE = 0,
         //       MANIFEST_TRIP_DATE = DateTime.Now,
         //       MANIFEST_TRIP_DATE_HIJ = 14381104,
         //       MANIFEST_TYPE = "1"
          
         //        , MANIFEST_DETAILS = new DETAILS[1] 
         //   };
         //   master.MANIFEST_DETAILS[0] = new DETAILS { GROUP_ID = 88931,  MANIFEST_HAJ_TYPE = "2", MANIFEST_HD_ID = "2",  MANIFEST_NT_ID = 4 };

         //  RESULT3 resultofGetLookup= sevice.SendHajMianifestInfo(master, );

            
         //   try
         //   {
         //       PortTypeClient client1 = new PortTypeClient();
         //       Result result2= new Result();

         //    //   ServiceReference1.LookUpServiceClient client1 = new ServiceReference1.LookUpServiceClient();

         ////  string text=     client1.getDateForTest();
         //       result2 = client1.Operation();

         //       Label1.Text = result2.ERROR_CODE;
         //       Label2.Text = result2.ERROR_DESC;
         //   }
         //   catch (Exception err)
         //   {
         //       Label1.Text = "InnerException : " + err.InnerException.Message.ToString();
         //       Label1.ForeColor = System.Drawing.Color.Red;

         //       Label2.Text = "Exception : " + err.Message.ToString();
         //       Label2.ForeColor = System.Drawing.Color.Red;
         //   }

        }

    }
}
