using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace LOOKUPSERVICE.Models
{

    [DataContract]
    public class SendHajMianifestInfo
    {

        public SendHajMianifestInfo()
        {
            MANIFEST_BI_ID = "0";
            MANIFEST_DI_ID = "0";
            MANIFEST_PRT_ID = 0;
            MANIFEST_LTC_ID = "0";
            MANIFEST_ROUTE_ID = 0;


        }
        [DataMember]
        public string MANIFEST_ID { get; set; }
        [DataMember]
        public long MANIFEST_PRT_ID { get; set; }
        [DataMember(IsRequired = false)]
      
        public string MANIFEST_LTC_ID { get; set; }
        [DataMember]
        public long MANIFEST_ROUTE_ID { get; set; }
        [DataMember]
        public DateTime MANIFEST_TRIP_DATE { get; set; }
        [DataMember]
        public long MANIFEST_TRIP_DATE_HIJ { get; set; }
        [DataMember(IsRequired = false)]
        public string MANIFEST_BI_ID { get; set; }
        [DataMember(IsRequired = false)]
        public string MANIFEST_DI_ID { get; set; }
        [DataMember]
        public long MANIFEST_HOUSE_ID { get; set; }
        [DataMember]
        public long MANIFEST_STATE { get; set; }
        [DataMember(IsRequired = false)]
        public string MANIFEST_EST_ID { get; set; }
        [DataMember(IsRequired = false)]
        public string MANIFEST_HEB_ID { get; set; }


        [DataMember(IsRequired = false)]
        public string VEHICLE_TYPE { get; set; }

        [DataMember(IsRequired = false)]
        public string NATIONALITY_BUS_ID { get; set; }
        [DataMember(IsRequired = false)]
        public string MANIFEST_TYPE { get; set; }


        [DataMember]
        public DETAILS[] MANIFEST_DETAILS { get; set; }

    }







    [DataContract]
    public class DETAILS
    {

        public DETAILS()
        {
            MAINFEST_DEPENDENT_NO = " 0";
            GROUP_ID = 0;
            MANIFEST_PASSPORT_NO = "0 ";

                
        }
        [DataMember]
        public string MANIFEST_PASSPORT_NO { get; set; }
        [DataMember]
        public long MANIFEST_NT_ID { get; set; }
        [DataMember(IsRequired = false)]
        public string MANIFEST_HD_ID { get; set; }
        [DataMember(IsRequired = false)]
        public string MANIFEST_HAJ_TYPE { get; set; }

        [DataMember(IsRequired = false)]
        public string MAINFEST_DEPENDENT_NO { get; set; }

        [DataMember]
        public long GROUP_ID { get; set; }
       
    }

    [DataContract]
    public class RESULT3 : RESULT
    {
        [DataMember]
        public long ReferenceID { get; set; }
    }



    [DataContract]
    public partial class DETAILSCELL
    {
         [DataMember]
        public string CNAME { get; set; }
         [DataMember]
        public string CTYPE { get; set; }
         [DataMember]
        public string CVALUE { get; set; }
    }

    [DataContract]
    public partial class REQUEST_INFO
    {
         [DataMember]
        public long ENTITY_ID { get; set; }
         [DataMember]
        public long RECORD_ID { get; set; }
         [DataMember]
         public int Opreation { get; set; }
    }

    [DataContract]
    public partial class RESULT {
        [DataMember] 
       public string ERROR_CODE{get;set;}
         [DataMember]
       public string ERROR_DESC { get; set; }
    }

    [DataContract]
     public partial class LOGIN {
         [DataMember]
        public string USER_NAME  {get;set;}
         [DataMember]
        public string PASSWORD {get;set;}
            
        }
     [DataContract]
    public class HAJ_GROUP_PACKAGE
    {
          [DataMember]
        public int HGP_ID { get; set; }
          [DataMember(IsRequired = false)]
          public string REQUEST_ID { get; set; }
         [DataMember(IsRequired = false)]
        public string  HGP_HM_ID { get; set; }
         [DataMember(IsRequired = false)]
         public string  HGP_HC_ID { get; set; }
         [DataMember(IsRequired = false)]
         public string GROUP_ID { get; set; }
         [DataMember(IsRequired = false)]
         public string GROUP_NAME { get; set; }
          [DataMember]
        public int HGP_HAJJ_COUNT { get; set; }
          [DataMember]
        public HGP_DETAILS HGP_DETAILS { get; set; }
    }
     [DataContract]
    public class HGP_DETAILS
    {
          [DataMember]
        public FLIGTH_CONTRACTS FLIGTH_CONTRACTS { get; set; }
          [DataMember]
        public HOUSING_CONTRACTS HOUSING_CONTRACTS { get; set; }
          [DataMember]
        public FOOD_CONTRACTS FOOD_CONTRACTS { get; set; }
    }
     [DataContract]
    public class FLIGTH_CONTRACTS
    {
          [DataMember]
        public long[] HHBF_ID { get; set; }
    }


    [DataContract]
    public class HOUSING_CONTRACT
    {
        [DataMember]
        public long HC_ID { get; set; }
        [DataMember]
        public DateTime START_DATE { get; set; }
        [DataMember]
        public DateTime END_DATE { get; set; }

    }

    [DataContract]
    public class HOUSING_CONTRACTS
    {
          [DataMember]
        public HOUSING_CONTRACT[] HOUSING_CONTRACT { get; set; }
     

    }


     [DataContract]
    public class FOOD_CONTRACTS
    {
          [DataMember]
        public long[] FC_ID { get; set; }
    }


    //result 
     [DataContract]
    public class HAJ_GROUP_PACKAGE_RESPONSE
    {
          [DataMember]
        public int HGP_ID { get; set; }
          [DataMember(IsRequired = false)]
          public string HGP_BRANCH_ID { get; set; }
          [DataMember(IsRequired = false)]
          public string HGP_MENA_CAMP_ID { get; set; }
          [DataMember(IsRequired = false)]
        public string HGP_ARAFA_CAMP_ID { get; set; }
           [DataMember(IsRequired = false)]
        public string TARADODIA { get; set; }
           [DataMember(IsRequired = false)]
        public string ADELLA_BARNCH_ID { get; set; }

       
    }

     [DataContract]
     public partial class RESULT2
     {
         [DataMember]
         public string ERROR_CODE { get; set; }
         [DataMember]
         public string ERROR_DESC { get; set; }
         [DataMember]
         public HAJ_GROUP_PACKAGE_RESPONSE  HAJ_GROUP_PACKAGE_RESPONSE{get;set;}
     }



}



namespace sendHajjTrip
{


    [DataContract]
    public class SendHajjTrip
    {
      

        [DataMember(IsRequired = false)]
        public string SHT_TAFWEEJ_ID { get; set; }
        [DataMember(IsRequired = false)]
        public string SHT_NAQABA_CONFIRM_NO { get; set; }
        [DataMember(IsRequired = false)]
        public string SHT_EST_ID{ get; set; }
        [DataMember(IsRequired = false)]
        public string SHT_HEB_ID{ get; set; }
        [DataMember(IsRequired = false)]
        public string SHT_TRIP_ID { get; set; }
        [DataMember(IsRequired = false)]
        public string SHT_LTC_ID { get; set; }
        [DataMember(IsRequired = false)]
        public string SHT_BUS_ID { get; set; }
        [DataMember(IsRequired = false)]
        public string SHT_DRIVER_ID { get; set; }
        [DataMember(IsRequired = false)]
        public string SHT_STATE { get; set; }
        [DataMember(IsRequired = false)]
        public string SHT_TYPE { get; set; }
        [DataMember(IsRequired = false)]
        public DateTime SHT_TRIP_DATE { get; set; }
        [DataMember]
        public Details Details { get; set; }

        [DataMember]
        public string DRIVER_NAME { get;  set; }
        [DataMember]
        public string DRIVER_IDENTIFICATION_NO { get;  set; }
        [DataMember]
        public string PLATE_NO { get;  set; }
        [DataMember]
        public string VEHICLE_TYPE_ID { get; set; }

        [DataMember]
        public string SHT_PATH_ID  { get; set; }

        [DataMember(IsRequired = false)]
        public string SHT_PATH_TYPE_ID { get; set; }



        [DataMember(IsRequired = false)]
        public string SHT_TO_EST_ID { get; set; }

        }


    [DataContract]
    public class Details
    {
        [DataMember]
        public Flight[] Flights { get; set; }

        [DataMember]
        public House[] Houses { get; set; }
    }

    [DataContract]
    public class Flight
    {
        [DataMember]
        public long SHT_FD_ID { get; set; }
        [DataMember]
        public HAJJS[] HAJJS { get; set; }
    }
    [DataContract]
    public class HAJJS
    {
        [DataMember]
        public string SHT_HD_ID { get; set; }
        [DataMember]
        public string SHT_NT_ID { get; set; }
        [DataMember(IsRequired = false)]
        public string SHT_TAFWEEJ_ID { get; set; }
        [DataMember]
        public string SHT_HEB_ID { get; set; }
    }

    [DataContract]
    public class House
    {
        [DataMember]
        public long HT_HC_ID { get; set; }
        [DataMember]
       public HAJJS[] HAJJS { get; set; }

    }



}