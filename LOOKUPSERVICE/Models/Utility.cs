
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Data;
using System.Data.OracleClient;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Hosting;

namespace LOOKUPSERVICE.Models
{
    public static class extensons
    {
        public static string  checknull(this string str)
        {
            if(str ==" ")
                return "0";
            if (str == null)
                return "0";
            else
                return (str==String.Empty ? "0" :str);

        }
       

    }

    public class Utility
    {


        public static RESULT setData(REQUEST_INFO info,DETAILSCELL[] body)
        {
            RESULT result=new RESULT();



            string sql = "select * from Table_RELATION where ENTITYID=:ENTITYID";




            switch (info.ENTITY_ID)
            {
                case 1:
                    result = info.Opreation == 1000 ? insertObject("LU_HAJ_ESTS", body,info) : updateObject("LU_HAJ_ESTS", body,info);
                    break;
                case 2:
                    result = info.Opreation == 1000 ? insertObject("LU_HAJ_MISSIONS", body,info) : updateObject("LU_HAJ_MISSIONS", body,info);
                    break;
                case 3:
                    result = info.Opreation == 1000 ? insertObject("LU_HAJ_COMPANIES", body, info) : updateObject("LU_HAJ_COMPANIES", body, info);
                    break;
                case 4:
                    result = info.Opreation == 1000 ? insertObject("LU_HOUSES", body, info) : updateObject("LU_HOUSES", body, info);
                    break;
                case 5:
                    result = info.Opreation == 1000 ? insertObject("LU_FOOD_COMPANIES", body, info) : updateObject("LU_FOOD_COMPANIES", body, info);
                   break;
                case 6:
                   result = info.Opreation == 1000 ? insertObject("LU_REPRESENTATIVES", body, info) : updateObject("LU_REPRESENTATIVES", body, info);
                   break;
                case 7:
                   result = info.Opreation == 1000 ? insertObject("LU_NATIONALITIES", body, info) : updateObject("LU_NATIONALITIES", body, info);
                   break;
                case 8:
                   result = info.Opreation == 1000 ? insertObject("LU_CITIES", body, info) : updateObject("LU_CITIES", body, info);
                   break;
                case 9:
                   result = info.Opreation == 1000 ? insertObject("LU_HM_HC_REP_MAPING", body, info) : updateObject("LU_HM_HC_REP_MAPING", body, info);
                   break;
                case 10:
                   result = info.Opreation == 1000 ? insertObject("LU_HOUSE_FOOD_REP_MAP", body, info) : updateObject("LU_HOUSE_FOOD_REP_MAP", body, info);
                   break;
                case 11:
                   result = info.Opreation == 1000 ? insertObject("SPICAL_SERVICES", body, info) : updateObject("SPICAL_SERVICES", body, info);
                   break;
                case 12:
                   result = info.Opreation == 1000 ? insertObject("LIFTING_COMPANIES", body, info) : updateObject("LIFTING_COMPANIES", body, info);
                  break;
                case 13:
                  result = info.Opreation == 1000 ? insertObject("LU_BANKS", body, info) : updateObject("LU_BANKS", body, info);
                  break;
                case 14:
                  result = info.Opreation == 1000 ? insertObject("LU_BANK_WARRANTIES_TYPES", body, info) : updateObject("LU_BANK_WARRANTIES_TYPES", body, info);
                  break;
                case 15:
                  result = info.Opreation == 1000 ? insertObject("LU_COUNTRIES", body, info) : updateObject("LU_COUNTRIES", body, info);
                  break;
                case 16:
                  result = info.Opreation == 1000 ? insertObject("LU_PORTS", body, info) : updateObject("LU_PORTS", body, info);
                  break;
                case 17:
                  result = info.Opreation == 1000 ? insertObject("LU_TICKETS_ROUTES", body, info) : updateObject("LU_TICKETS_ROUTES", body, info);
                  break;
                case 18:
                  result = info.Opreation == 1000 ? insertObject("FOOD_CONTRACTS", body, info) : updateObject("FOOD_CONTRACTS", body, info);
                  break;
                case 19:
                  result = info.Opreation == 1000 ? insertObject("HM_HC_BANK_WARRANTIES", body, info) : updateObject("HM_HC_BANK_WARRANTIES", body, info);
                  break;
                case 20:
                  result = info.Opreation == 1000 ? insertObject("HOUSES_CONTRACTS", body, info) : updateObject("HOUSES_CONTRACTS", body, info);
                  break;
                case 21:
                  result = info.Opreation == 1000 ? insertObject("LU_BANK_WARRANTIES_CATEGORIES", body, info) : updateObject("LU_BANK_WARRANTIES_CATEGORIES", body, info);
                  break;
                case 22:
                  result = info.Opreation == 1000 ? insertObject("LU_COUNTRIES_QUOTA", body, info) : updateObject("LU_COUNTRIES_QUOTA", body, info);
                  break;
                case 23:
                  result = info.Opreation == 1000 ? insertObject("HOUSES_CONTRACTS_PAYMENTS", body, info) : updateObject("HOUSES_CONTRACTS_PAYMENTS", body, info);
                  break;
                case 24:
                  result = info.Opreation == 1000 ? insertObject("HOUSES_CONTRACTS_WARRANTIES", body, info) : updateObject("HOUSES_CONTRACTS_WARRANTIES", body, info);
                  break;
                case 25:
                  result = info.Opreation == 1000 ? insertObject("HOUSES_CONTRACTS_REQUEST", body, info) : updateObject("HOUSES_CONTRACTS_REQUEST", body, info);
                  break;
                case 26:
                  result = info.Opreation == 1000 ? insertObject("LU_HOUSES_TYPES", body, info) : updateObject("LU_HOUSES_TYPES", body, info);
                  break;
                case 27:
                  result = info.Opreation == 1000 ? insertObject("LU_AVIATION_MEMBERSHIP", body, info) : updateObject("LU_AVIATION_MEMBERSHIP", body, info);
                  break;
                case 28:
                  result = info.Opreation == 1000 ? insertObject("LU_FOODS_WARRANTIES_TYPES", body, info) : updateObject("LU_FOODS_WARRANTIES_TYPES", body, info);
                  break;
                case 29:
                  result = info.Opreation == 1000 ? insertObject("LU_HAJ_COMPANIES_TYPES", body, info) : updateObject("LU_HAJ_COMPANIES_TYPES", body, info);
                  break;
                case 30:
                  result = info.Opreation == 1000 ? insertObject("LU_HAJ_ESTS_COUNTRIES_MAP", body, info) : updateObject("LU_HAJ_ESTS_COUNTRIES_MAP", body, info);
                  break;
                case 31:
                  result = info.Opreation == 1000 ? insertObject("LU_HOUSE_AGENT_TYPES", body, info) : updateObject("LU_HOUSE_AGENT_TYPES", body, info);
                  break;
                case 32:
                  result = info.Opreation == 1000 ? insertObject("LU_HOUSE_BENEFIT_TYPES", body, info) : updateObject("LU_HOUSE_BENEFIT_TYPES", body, info);
                  break;
                case 33:
                  result = info.Opreation == 1000 ? insertObject("LU_HOUSE_FOOD_REP_MAP", body, info) : updateObject("LU_HOUSE_FOOD_REP_MAP", body, info);
                  break;
                case 34:
                  result = info.Opreation == 1000 ? insertObject("LU_HOUSE_INVESTOR_TYPES", body, info) : updateObject("LU_HOUSE_INVESTOR_TYPES", body, info);
                  break;
                case 35:
                  result = info.Opreation == 1000 ? insertObject("LU_LIFTING_COMPANIES", body, info) : updateObject("LU_LIFTING_COMPANIES", body, info);
                  break;
                case 36:
                  result = info.Opreation == 1000 ? insertObject("LU_PAYMENT_METHODS", body, info) : updateObject("LU_PAYMENT_METHODS", body, info);
                  break;
                case 37:
                  result = info.Opreation == 1000 ? insertObject("FOODS_CONTRACTS_WARRANTIES", body, info) : updateObject("FOODS_CONTRACTS_WARRANTIES", body, info);
                  break;
                case 38:
                  result = info.Opreation == 1000 ? insertObject("FOOD_CONTRACTS_PAYMENTS", body, info) : updateObject("FOOD_CONTRACTS_PAYMENTS", body, info);
                  break;
                case 39:
                  result = info.Opreation == 1000 ? insertObject("HM_HC_BANK_LETTERS", body, info) : updateObject("HM_HC_BANK_LETTERS", body, info);
                  break;
                case 40:
                  result = info.Opreation == 1000 ? insertObject("HM_HC_BANK_WARRANTY_LETTERS", body, info) : updateObject("HM_HC_BANK_WARRANTY_LETTERS", body, info);
                  break;
                case 41:
                  result = info.Opreation == 1000 ? insertObject("HM_HC_TRANSPORT_CONTRACTS", body, info) : updateObject("HM_HC_TRANSPORT_CONTRACTS", body, info);
                  break;
                case 42:
                  result = info.Opreation == 1000 ? insertObject("LIFTING_CONTRACTS", body, info) : updateObject("LIFTING_CONTRACTS", body, info);
                  break;
                case 43:
                  result = info.Opreation == 1000 ? insertObject("LIFTING_CONTRACTS_PAYMENTS", body, info) : updateObject("LIFTING_CONTRACTS_PAYMENTS", body, info);
                  break;
                case 44:
                  result = info.Opreation == 1000 ? insertObject("LIFTING_CONTRACTS_WARRANTIES", body, info) : updateObject("LIFTING_CONTRACTS_WARRANTIES", body, info);
                  break;
                case 45:
                  result = info.Opreation == 1000 ? insertObject("LU_FINANCIAL_INFORMATIONS", body, info) : updateObject("LU_FINANCIAL_INFORMATIONS", body, info);
                  break;
                case 46:
                  result = info.Opreation == 1000 ? insertObject("LU_FOOD_FINANCIAL_INFO", body, info) : updateObject("LU_FOOD_FINANCIAL_INFO", body, info);
                  break;
                case 47:
                  result = info.Opreation == 1000 ? insertObject("LU_HAJ_COMPANY_FINANCIAL_INFO", body, info) : updateObject("LU_HAJ_COMPANY_FINANCIAL_INFO", body, info);
                  break;
                case 48:
                  result = info.Opreation == 1000 ? insertObject("LU_HAJ_MISSIONS_FINANCIAL_INFO", body, info) : updateObject("LU_HAJ_MISSIONS_FINANCIAL_INFO", body, info);
                  break;
                case 50:
                  result = info.Opreation == 1000 ? insertObject("LU_HAJJ_EST_BRANCHES", body, info) : updateObject("LU_HAJJ_EST_BRANCHES", body, info);
                  break;
                 case 51:
                  result = info.Opreation == 1000 ? insertObject("HM_HC_BARCODES", body, info) : updateObject("HM_HC_BARCODES", body, info);
                  break;
                 case 52:
                  result = info.Opreation == 1000 ? insertObject("LU_HOUSE_OWNER_TYPES", body, info) : updateObject("LU_HOUSE_OWNER_TYPES", body, info);
                  break;
                 case 54:
                  result = info.Opreation == 1000 ? insertObject("HAJJ_FLIGHTS_DETAILS", body, info) : insertObject("HAJJ_FLIGHTS_DETAILS", body, info);
                  break;
                 case 55:
                  result = info.Opreation == 1000 ? insertObject("HM_HC_PACKAGES", body, info) : updateObject("HM_HC_PACKAGES", body, info);
                  break;
                 case 56:
                  result = info.Opreation == 1000 ? insertObject("HAJJ_COURTESY", body, info) : updateObject("HAJJ_COURTESY", body, info);
                  break;
                 case 57:
                  result = info.Opreation == 1000 ? insertObject("LU_LAND_TRAN_COMPANIES", body, info) : updateObject("LU_LAND_TRAN_COMPANIES", body, info);
                  break;
                 case 58:
                  result = info.Opreation == 1000 ? insertObject("CAR_TYPES", body, info) : updateObject("CAR_TYPES", body, info);
                  break;
                 case 59:
                  result = info.Opreation == 1000 ? insertObject("LU_PATHS", body, info) : updateObject("LU_PATHS", body, info);
                  break;
                 case 60:
                  result = info.Opreation == 1000 ? insertObject("LU_TERMINALS", body, info) : updateObject("LU_TERMINALS", body, info);
                  break;
                 case 61:
                  result = info.Opreation == 1000 ? insertObject("LU_CAR_TYPES", body, info) : updateObject("LU_CAR_TYPES", body, info);
                  break;
                 case 62:
                  result = info.Opreation == 1000 ? insertObject("LU_CARRIERS_IATA", body, info) : insertObject("LU_CARRIERS_IATA", body, info);
                  break;
                 case 63:
                  result = info.Opreation == 1000 ? insertObject("NAQABA_CONFIRMS", body, info) : insertObject("NAQABA_CONFIRMS", body, info);
                  break;
                 case 64:
                  result = info.Opreation == 1000 ? insertObject("CIVIL_DEFENSE_VIOLATORS", body, info) : insertObject("CIVIL_DEFENSE_VIOLATORS", body, info);
                  break;
                 case 65:
                  result = info.Opreation == 1000 ? insertObject("LU_RELATIVITY_RELATION ", body, info) : insertObject("LU_RELATIVITY_RELATION", body, info);
                  break;
                 case 98:
                  result = info.Opreation == 1000 ? insertObject("HM_HC_PRE_ARRIVAL_DATA", body, info) : insertObject("HM_HC_PRE_ARRIVAL_DATA", body, info);
                  break;
                 case 99:
                  result = info.Opreation == 1000 ? insertObject("LU_EMBASSIES", body, info) : insertObject("LU_EMBASSIES", body, info);
                  break;
                 case 103:
                  result = info.Opreation == 1000 ? insertObject("HAJJ_DATA_GULF", body, info) : insertObject("HAJJ_DATA_GULF", body, info);
                  break;
                 case 104:
                  result = info.Opreation == 1000 ? insertObject("LU_ROUTES", body, info) : insertObject("LU_ROUTES", body, info);
                  break;
                 case 105:
                  result = info.Opreation == 1000 ? insertObject("LU_TICKETS_ROUTES_DETAILS", body, info) : insertObject("LU_TICKETS_ROUTES_DETAILS", body, info);
                  break;
                 case 106:
                  result = info.Opreation == 1000 ? insertObject("LU_BUS_TYPES", body, info) : insertObject("LU_BUS_TYPES", body, info);
                  break;
                 case 107:
                  result = info.Opreation == 1000 ? insertObject("LU_BUSES_INFOS", body, info) : insertObject("LU_BUSES_INFOS", body, info);
                  break;
                 case 108:
                  result = info.Opreation == 1000 ? insertObject("LU_DRIVERS_INFOS", body, info) : insertObject("LU_DRIVERS_INFOS", body, info);
                  break;
                 case 110:
                  result = info.Opreation == 1000 ? insertObject("LU_AGE_STAGES", body, info) : insertObject("LU_AGE_STAGES", body, info);
                  break;
                case 113:
                  result = info.Opreation == 1000 ? insertObject("HAJ_GROUP", body, info) : insertObject("HAJ_GROUP", body, info);
                  break;
                case 114:
                  result = info.Opreation == 1000 ? insertObject("LU_HAJ_TYPES", body, info) : insertObject("LU_AGE_STAGES", body, info);
                 break;
                case 115:
                 result = info.Opreation == 1000 ? insertObject("LU_HOUSES_MAP_COORDINATES", body, info) : insertObject("LU_HOUSES_MAP_COORDINATES", body, info);
                 break;
                case 116:
                 result = info.Opreation == 1000 ? insertObject("LU_FOOD_MAP_COORDINATES", body, info) : insertObject("LU_FOOD_MAP_COORDINATES", body, info);
                 break;
                case 117:
                 result = info.Opreation == 1000 ? insertObject("LU_HOUSES_CONTRACTS_TYPES", body, info) : insertObject("LU_HOUSES_CONTRACTS_TYPES", body, info);
                 break;
                case 128:
                    result = info.Opreation == 1000 ? insertObject("TAFWEEJ_EMPLOYEE_BUS", body, info) : insertObject("TAFWEEJ_EMPLOYEE_BUS", body, info);

                    break;
                case 129:
                    result = info.Opreation == 1000 ? insertObject("TAFWEEJ_DEPORTATION_ORDER", body, info) : insertObject("TAFWEEJ_DEPORTATION_ORDER", body, info);

                    break;
                case 130:
                    result = info.Opreation == 1000 ? insertObject("TAFWEEJ_NAQABA_CONF_ORDER_MAP", body, info) : insertObject("TAFWEEJ_NAQABA_CONF_ORDER_MAP", body, info);

                    break;
                case 172:
                    result = info.Opreation == 1000 ? insertObject("EST_SERVICE_ITEM", body, info) : insertObject("EST_SERVICE_ITEM", body, info);
                   break;
                case 173:
                    result = info.Opreation == 1000 ? insertObject("LU_EST_SERVICE_ITEM_TYPES", body, info) : insertObject("LU_EST_SERVICE_ITEM_TYPES", body, info);
                    break;
                case 174:
                    result = info.Opreation == 1000 ? insertObject("LU_EST_SERVICE_LOCATIONS", body, info) : insertObject("LU_EST_SERVICE_LOCATIONS", body, info);
                    break;
                case 175:
                    result = info.Opreation == 1000 ? insertObject("EST_SERVICE_PACKAGE_ITEM_MAP", body, info) : insertObject("EST_SERVICE_PACKAGE_ITEM_MAP", body, info);
                    break;
                case 156:
                    result = info.Opreation == 1000 ? insertObject("EST_SERVICE_PACKAGES", body, info) : insertObject("EST_SERVICE_PACKAGES", body, info);
                    break;
                case 166:
                    result = info.Opreation == 1000 ? insertObject("EST_SERVICE_PACK_SPC_CONT", body, info) : insertObject("EST_SERVICE_PACK_SPC_CONT", body, info);
                    break;
                case 176:
                    result = info.Opreation == 1000 ? insertObject("LU_EST_SERVICE_CLASSIFICATIONS", body, info) : insertObject("LU_EST_SERVICE_CLASSIFICATIONS", body, info);
                    break;
                case 177:
                    result = info.Opreation == 1000 ? insertObject("EST_SERVICE_PACKAGE_AVAIL_TYPE", body, info) : insertObject("EST_SERVICE_PACKAGE_AVAIL_TYPE", body, info);
                    break;
                case 178:
                    result = info.Opreation == 1000 ? insertObject("EST_SERVICE_PACKAGE_AVALABILTY", body, info) : insertObject("EST_SERVICE_PACKAGE_AVALABILTY", body, info);
                    break;
                case 183:
                    result = info.Opreation == 1000 ? insertObject("V_HAJ_DATA_EST_REQUEST", body, info) : insertObject("V_HAJ_DATA_EST_REQUEST", body, info);
                    break;
                case 188:
                    result = info.Opreation == 1000 ? insertObject("V_EST_CONT_FINANCIAL_DETAILS", body, info) : insertObject("V_EST_CONT_FINANCIAL_DETAILS", body, info);
                    break;
                //for test only
                case 500:
                    result = info.Opreation == 1000 ? insertObject("TEST", body, info) : insertObject("TEST", body, info);
                    break;

                default:
                  result = new RESULT { ERROR_CODE = "02", ERROR_DESC = "Invalid Entity" };
                    break;
            }
            
            return result;

        }

      
       
  


        public static RESULT updateObject(string TableName, DETAILSCELL[] arr,REQUEST_INFO info)
        {
            return insertObject(TableName, arr, info);
        }

        private static string getWhere(string TableName,REQUEST_INFO info)
        {
            string where = "";
            switch (info.ENTITY_ID)
            {
                case 1:
                    where = "EST_ID=" + info.RECORD_ID;
                    break;
                case 2:
                    where = "HM_ID=" + info.RECORD_ID;
                    break;
                case 3:
                    where = "HC_ID=" + info.RECORD_ID;
                    break;
                case 4:
                    where = "HOUSE_ID=" + info.RECORD_ID;
                    break;
                case 5:
                    where = "FC_ID=" + info.RECORD_ID;
                    break;
                case 6:
                    where = "REP_ID=" + info.RECORD_ID;
                    break;
                case 7:
                    where = "NT_ID=" + info.RECORD_ID;
                    break;
                case 8:
                    where = "CT_ID=" + info.RECORD_ID;
                    break;
                case 9:
                    where = "HHRM_ID=" + info.RECORD_ID;
                    break;
                case 10:
                    where = "HFRM_ID=" + info.RECORD_ID;
                    break;
                case 11:
                    where = "SPS_ID=" + info.RECORD_ID;
                    break;
                case 12:
                    where = "LC_ID=" + info.RECORD_ID;
                    break;
                case 13:
                    where = "BNK_ID=" + info.RECORD_ID;
                    break;
                case 14:
                    where = "BWT_ID=" + info.RECORD_ID;
                    break;
                case 15:
                    where = "CNTRY_ID=" + info.RECORD_ID;
                    break;
                case 16:
                    where = "PRT_ID=" + info.RECORD_ID;
                    break;
                case 17:
                   where = "TR_ID=" + info.RECORD_ID;
                    break;
                case 18:
                    where = "FC_ID=" + info.RECORD_ID;
                    break;
                case 19:
                    where = "HHBW_ID=" + info.RECORD_ID;
                    break;
                case 20:
                    where = "HC_ID=" + info.RECORD_ID;
                    break;
                case 21:
                    where = "BWC_ID=" + info.RECORD_ID;
                    break;
                case 22:
                    where = "CQ_ID=" + info.RECORD_ID;
                    break;
                case 23:
                    where = "HCP_ID=" + info.RECORD_ID;
                    break;
                case 24:
                    where = "HCC_ID=" + info.RECORD_ID;
                    break;
                case 25:
                    where = "HC_ID=" + info.RECORD_ID;
                    break;
                case 26:
                    where = "HT_ID=" + info.RECORD_ID;
                    break;
                case 27:
                    where = "AM_ID=" + info.RECORD_ID;
                    break;
                case 28:
                    where = "FWT_ID=" + info.RECORD_ID;
                    break;
                case 29:
                    where = "HCT_ID=" + info.RECORD_ID;
                    break;
                case 30:
                    where = "HECM_ID=" + info.RECORD_ID;
                    break;
                case 31:
                    where = "HAT_ID=" + info.RECORD_ID;
                    break;
                case 32:
                    where = "HBT_ID=" + info.RECORD_ID;
                    break;
                case 33:
                    where = "HFRM_ID=" + info.RECORD_ID;
                    break;
                case 34:
                    where = "HIT_ID=" + info.RECORD_ID;
                    break;
                case 35:
                    where = "LC_ID=" + info.RECORD_ID;
                    break;
                case 36:
                    where = "PM_ID=" + info.RECORD_ID;
                    break;
                case 37:
                    where = "FCC_ID=" + info.RECORD_ID;
                    break;
                case 38:
                    where = "FCP_ID=" + info.RECORD_ID;
                    break;
                case 39:
                    where = "HHBL_ID=" + info.RECORD_ID;
                    break;
                case 40:
                    where = "HHBWL_ID=" + info.RECORD_ID;
                    break;
                case 41:
                    where = "HHTC_ID=" + info.RECORD_ID;
                    break;
                case 42:
                    where = "LC_ID=" + info.RECORD_ID;
                    break;
                case 43:
                    where = "LCP_ID=" + info.RECORD_ID;
                    break;
                case 44:
                    where = "LCW_ID=" + info.RECORD_ID;
                    break;
                case 45:
                    where = "FI_ID=" + info.RECORD_ID;
                    break;
                case 46:
                    where = "FFI_ID=" + info.RECORD_ID;
                    break;
                case 47:
                    where = "HCFI_ID=" + info.RECORD_ID;
                    break;
                case 48:
                    where = "HMFI_ID=" + info.RECORD_ID;
                    break;
                case 50:
                    where = "HEB_ID=" + info.RECORD_ID;
                    break;
                case 51:
                    where = "HHB_ID=" + info.RECORD_ID;
                    break;
                case 52:
                    where = "HOT_ID=" + info.RECORD_ID;
                    break;
                case 54:
                    where = "HFD_ID=" + info.RECORD_ID;
                    break;
                case 55:
                    where = "HHP_ID=" + info.RECORD_ID;
                    break;
                case 56:
                    where = "HCA_ID=" + info.RECORD_ID;
                    break;
                case 57:
                    where = "LTC_ID=" + info.RECORD_ID;
                    break;
                case 58:
                    where = "CAR_TYPE=" + info.RECORD_ID;
                    break;
                case 59:
                    where = "PATH_ID=" + info.RECORD_ID;
                    break;
                case 60:
                    where = "TERMINAL_ID=" + info.RECORD_ID;
                    break;
                case 61:
                    where = "CT_ID=" + info.RECORD_ID;
                    break;
                case 62:
                    where = "AT_ID=" + info.RECORD_ID;
                    break;
                case 63:
                    where = "NC_ID=" + info.RECORD_ID;
                    break;
                case 64:
                    where = "CDV_ID=" + info.RECORD_ID;
                    break;
                case 65:
                    where = "RR_RELATION_ID=" + info.RECORD_ID;
                    break;
                case 66:
                    where = "LC_ID=" + info.RECORD_ID;
                    break;
                case 98:
                    where = "HHPAD_ID=" + info.RECORD_ID;
                    break;
                case 99:
                    where = "EMB_ID=" + info.RECORD_ID;
                    break;
                case 103:
                    where = "HD_ID =" + info.RECORD_ID;
                    break;
                case 104:
                    where = "ROUTE_ID =" + info.RECORD_ID;
                    break;
                case 105:
                    where = "TRD_ID =" + info.RECORD_ID;
                    break;
                case 106:
                    where = "BT_ID =" + info.RECORD_ID;
                    break;
                case 107:
                    where = "BI_ID =" + info.RECORD_ID;
                    break;
                case 108:
                    where = "DI_ID =" + info.RECORD_ID;
                    break;
                case 110:
                    where = "AGE_STAGE_ID =" + info.RECORD_ID;
                    break;
                case 113:
                    where = "REQUEST_ID =" + info.RECORD_ID;
                    break;
                case 114:
                    where = "HT_ID =" + info.RECORD_ID;
                    break;
                case 115:
                    where = "HMC_ID=" + info.RECORD_ID;
                    break;
                case 116:
                    where = "FMC_ID=" + info.RECORD_ID;
                    break;
                case 117:
                    where = "HCT_ID=" + info.RECORD_ID;
                    break;
                case 128:
                    where = "TEB_ID=" + info.RECORD_ID;
                    break;
                case 129:
                    where = "TDO_ID=" + info.RECORD_ID;
                    break;
                case 130:
                    where = "TNCOM_ID=" + info.RECORD_ID;
                    break;
                case 172:
                    where = "ESI_ID=" + info.RECORD_ID;
                    break;
                case 173:
                    where = "ESIT_ID=" + info.RECORD_ID;
                    break;
                case 174:
                    where = "ESL_ID=" + info.RECORD_ID;
                    break;
                case 175:
                    where = "ESPIM_ID=" + info.RECORD_ID;
                    break;
                case 156:
                    where = "ESP_ID=" + info.RECORD_ID;
                    break;
                case 166:
                    where = "ESPSC_ID=" + info.RECORD_ID;
                    break;
                case 176:
                    where = "CLASS_ID=" + info.RECORD_ID;
                    break;
                case 177:
                    where = "ESPAT_ID=" + info.RECORD_ID;
                    break;
                case 178:
                    where = "ESPA_ID=" + info.RECORD_ID;
                    break;
                case 183:
                    where = "HDHM_ID=" + info.RECORD_ID;
                    break;
                case 188:
                    where = "BT_ID=" + info.RECORD_ID;
                    break;

                default:
                    break;
            }
            return where;
        }

        public static RESULT insertObject(string TableName, DETAILSCELL[] arr,REQUEST_INFO info)
        {
            DeleteObject(TableName, info);
            
          OracleConnection myConnection=  connection();

            
            string query = "INSERT INTO "+TableName+"({0}) VALUES({1})";
            string coulums = "";
            string values = "";

          List<OracleParameter> col = new List< OracleParameter>();
            foreach (var item in arr)
            {
                if (!string.IsNullOrEmpty(item.CVALUE))
                {

//                    item.CVALUE=item.CVALUE.Replace("'","\'");

                    if (item.CTYPE == "DATE")
                    {
                        DateTime dt = DateTime.Parse(item.CVALUE);
                        coulums += item.CNAME + ",";
                        values += "TO_DATE('" + dt.ToString("yyyy-MM-dd HH:mm:ss") + "','yyyy-mm-dd hh24:mi:ss'),";

                      //  col.Add(new OracleParameter { OracleType=OracleType.DateTime, ParameterName = item.CNAME, Value = dt});
                    }
                    else if(item.CTYPE=="BLOB")
                    {
                        try
                        {
                        Byte[] bytes = Convert.FromBase64String(item.CVALUE);
                        string phyiscalPath = HostingEnvironment.MapPath("/Images/" + info.RECORD_ID +".jpg");
                        File.WriteAllBytes(phyiscalPath, bytes);
                        }
                        catch (Exception)
                        {

                            
                        }
                        continue;
                       
                    }
                    else
                    {
                        coulums += item.CNAME + ",";
                        values += ":" + item.CNAME + ",";
                        col.Add(new OracleParameter { ParameterName = item.CNAME, Value = item.CVALUE });
                    }
                 
                }
            }

            coulums = coulums.Substring(0, coulums.Length-1);
            values = values.Substring(0, values.Length-1);
            string finalQuery=string.Format(query,coulums,values);
            OracleCommand command = new OracleCommand(finalQuery, myConnection);
            command.Parameters.AddRange(col.ToArray());
            
            int reader;
            try
            {
                reader = command.ExecuteNonQuery();
                return new RESULT { ERROR_CODE = "0", ERROR_DESC = "valid" };
            }
            catch (Exception ex)
            {
                return new RESULT { ERROR_CODE = "2", ERROR_DESC = "Invalid Request " + ex.Message + "\""+finalQuery +col.ToArray().FirstOrDefault().Value + "\"" };
                
            }
        }


        public static void DeleteObject(string TableName, REQUEST_INFO info)
        {
            string Query = "delete from " + TableName + " where " + getWhere(TableName, info);
            OracleConnection myConnection = connection();
           
            OracleCommand command = new OracleCommand(Query, myConnection);
            int reader;
            try
            {
                reader = command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                
            }         

        }
        public static OracleConnection connection()
        {
          //  string myConnectionString = "data source=HAJJ;password=ttsafrhajj;persist security info=True;user id=SEJEL1436; Unicode=True";
            OracleConnection myConnection = Singleton.Instance;
            if (myConnection.State == ConnectionState.Closed || myConnection.State == ConnectionState.Broken)
            {
                myConnection.Open();

            }

            return myConnection;
           
        }

        //public static OracleConnection connection2()
        //{
        //    string myConnectionString = "data source=HAJJ;password=ttsafrhajj;persist security info=True;user id=HAJJ1436; Unicode=True";
        //    OracleConnection myConnection = new OracleConnection();

        //    myConnection.ConnectionString = myConnectionString;
        //    return myConnection;
        //}

        internal static void Log(HttpRequest httpRequest, RESULT result, DETAILSCELL[] Body, REQUEST_INFO request)
        {

            OracleConnection myConnection = connection();
          

         //   string Request = (from c in httpRequest.ServerVariables.AllKeys select new { Values =httpRequest.ServerVariables[c] });



        }


        internal static string RequestVaribe(HttpRequest requet)
        {

            string result = "";
            int loop1, loop2;
            NameValueCollection coll = requet.ServerVariables;
            // Get names of all keys into a string array. 
            String[] arr1 = coll.AllKeys;
            for (loop1 = 0; loop1 < arr1.Length; loop1++)
            {
                
                String[] arr2 = coll.GetValues(arr1[loop1]);
                for (loop2 = 0; loop2 < arr2.Length; loop2++)
                {
                 //   Response.Write("Value " + loop2 + ": " + Server.HtmlEncode(arr2[loop2]) + "<br>");
                }
            }
            return result;

        }


        public static int parseInt(string value)
        {

            int n;
            bool isNumeric = int.TryParse(value, out n);

            if (isNumeric)
                return int.Parse(value);
            else
                return 0;
        }
        public static int parseDate(string value)
        {
            if (value != "")
            {
                string[] ar = value.Split('-');

                string date = ar[2] + ar[1] + ar[0];

                return parseInt(date);

            }
            else
                return 0;
        }


        public static long parseLong(string value)
        {

            long n;
            bool isNumeric = long.TryParse(value, out n);

            if (isNumeric)
                return long.Parse(value);
            else
                return 0;
        }
        public static decimal parseDecimal(string value)
        {

            decimal n;
            bool isNumeric = decimal.TryParse(value, out n);

            if (isNumeric)
                return decimal.Parse(value);
            else
                return 0;
        }






        internal static void WriteLogs(string p)
        {
           // throw new NotImplementedException();
        }
    }
}