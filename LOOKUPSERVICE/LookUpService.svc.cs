using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using LOOKUPSERVICE.Models;
using System.Net;
using System.Data.OracleClient;
using System.Data;

namespace LOOKUPSERVICE
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class LookUpService : ILookUpService
    {
        public RESULT SendLookup(LOGIN login, REQUEST_INFO request, DETAILSCELL[] Body)
        {

            
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
            if (LogingISvalid(login))
                return Utility.setData(request, Body);
            else
                return new RESULT { ERROR_CODE = "1", ERROR_DESC = "Not Authorized" };
        }
        private bool LogingISvalid(LOGIN login)
        {
            if (login.USER_NAME == "AfricaNonArab" && login.PASSWORD == "AfricaNonArab")
                return true;
            else
                return false;
        }



       
        public RESULT2 SetHajPackageReq(HAJ_GROUP_PACKAGE HAJ_GROUP_PACKAGE, LOGIN LOGIN)
        {
            RESULT2 result;
            if (LogingISvalid(LOGIN))
            {
                OracleConnection myConnection = Utility.connection();




                try
                {
                    int delreader = 0;
                    OracleCommand delcomm;
                    string delpkg = "delete from AFR_PKG where HGP_ID=" + HAJ_GROUP_PACKAGE.HGP_ID;
                    string delFlight = "delete from AFR_FLIGHTS where  PKG_ID=" + HAJ_GROUP_PACKAGE.HGP_ID;
                    string delFood = "delete from AFR_FOOD_CONTRACTS where  PKG_ID=" + HAJ_GROUP_PACKAGE.HGP_ID;
                    string delhouse = "delete from AFR_HOUSE_CONTRACTS where  PKG_ID=" + HAJ_GROUP_PACKAGE.HGP_ID;
                    delcomm = new OracleCommand(delpkg, myConnection);
                    delreader = delcomm.ExecuteNonQuery();
                    delcomm = new OracleCommand(delFlight, myConnection);
                    delreader = delcomm.ExecuteNonQuery();
                    delcomm = new OracleCommand(delFood, myConnection);
                    delreader = delcomm.ExecuteNonQuery();
                    delcomm = new OracleCommand(delhouse, myConnection);
                    delreader = delcomm.ExecuteNonQuery();


                    //  string updatequery="UPDATE SEJEL1436.AFR_PKG SET  HGP_HM_ID = :HGP_HM_ID, HGP_HC_ID = :HGP_HC_ID, HGP_HAJJ_COUNT = :HGP_HAJJ_COUNT,"+
                    //                    "HGP_BRANCH_ID = :HGP_BRANCH_ID, HGP_MENA_CAMP_ID  = :HGP_MENA_CAMP_ID, HGP_ARAFA_CAMP_ID = :HGP_ARAFA_CAMP_ID,  TARADOD_ID = :TARADOD_ID, ADELLA_BARNCH_ID= :ADELLA_BARNCH_ID, STATUS = :STATUS, REQUEST_ID = :REQUEST_ID,"+
                    //                    "GROUP_ID  = :GROUP_ID,GROUP_NAME  = :GROUP_NAME WHERE  HGP_ID = :HGP_ID";

                    string PkgQuery = "INSERT INTO AFR_PKG (HGP_ID,HGP_HM_ID,HGP_HC_ID,HGP_HAJJ_COUNT,REQUEST_ID,GROUP_ID,GROUP_NAME) VALUES (:HGP_ID,:HGP_HM_ID,:HGP_HC_ID,:HGP_HAJJ_COUNT,:REQUEST_ID,:GROUP_ID,:GROUP_NAME)";


                    OracleCommand command = new OracleCommand(PkgQuery, myConnection);
                    command.Parameters.Add(new OracleParameter { ParameterName = "HGP_ID", Value = HAJ_GROUP_PACKAGE.HGP_ID });
                    command.Parameters.Add(new OracleParameter { ParameterName = "HGP_HAJJ_COUNT", Value = HAJ_GROUP_PACKAGE.HGP_HAJJ_COUNT });

                    if (HAJ_GROUP_PACKAGE.HGP_HM_ID == null || HAJ_GROUP_PACKAGE.HGP_HM_ID == "")
                        command.Parameters.Add(new OracleParameter { ParameterName = "HGP_HM_ID", Value = 0 });
                    else
                        command.Parameters.Add(new OracleParameter { ParameterName = "HGP_HM_ID", Value = HAJ_GROUP_PACKAGE.HGP_HM_ID });

                    if (HAJ_GROUP_PACKAGE.REQUEST_ID == null || HAJ_GROUP_PACKAGE.REQUEST_ID == "")
                        command.Parameters.Add(new OracleParameter { ParameterName = "REQUEST_ID", Value = 0 });
                    else
                        command.Parameters.Add(new OracleParameter { ParameterName = "REQUEST_ID", Value = HAJ_GROUP_PACKAGE.REQUEST_ID });

                    if (HAJ_GROUP_PACKAGE.HGP_HC_ID == null || HAJ_GROUP_PACKAGE.HGP_HC_ID == "")
                        command.Parameters.Add(new OracleParameter { ParameterName = "HGP_HC_ID", Value = 0 });
                    else
                        command.Parameters.Add(new OracleParameter { ParameterName = "HGP_HC_ID", Value = HAJ_GROUP_PACKAGE.HGP_HC_ID });

                    if (HAJ_GROUP_PACKAGE.GROUP_ID == null || HAJ_GROUP_PACKAGE.GROUP_ID == "")
                        command.Parameters.Add(new OracleParameter { ParameterName = "GROUP_ID", Value = 0 });
                    else
                        command.Parameters.Add(new OracleParameter { ParameterName = "GROUP_ID", Value = HAJ_GROUP_PACKAGE.GROUP_ID });

                    if (HAJ_GROUP_PACKAGE.GROUP_NAME == null || HAJ_GROUP_PACKAGE.GROUP_NAME == "")
                        command.Parameters.Add(new OracleParameter { ParameterName = "GROUP_NAME", Value = 0 });
                    else
                        command.Parameters.Add(new OracleParameter { ParameterName = "GROUP_NAME", Value = HAJ_GROUP_PACKAGE.GROUP_NAME });


                    int reader;
                    reader = command.ExecuteNonQuery();

                   
                        try
                        {
                            foreach (var item in HAJ_GROUP_PACKAGE.HGP_DETAILS.FOOD_CONTRACTS.FC_ID)
                            {
                                string foodQuery = "INSERT INTO AFR_FOOD_CONTRACTS (PKG_ID, FC_ID) VALUES (:PKG_ID, :FC_ID)";
                                command = new OracleCommand(foodQuery, myConnection);
                                command.Parameters.Add(new OracleParameter { ParameterName = "PKG_ID", Value = HAJ_GROUP_PACKAGE.HGP_ID });
                                command.Parameters.Add(new OracleParameter { ParameterName = "FC_ID", Value = item });

                                reader = command.ExecuteNonQuery();
                            }

                        }
                        catch (Exception ex)
                        {

                            result = new RESULT2
                            {
                                ERROR_CODE = "1",
                                ERROR_DESC = ex.Message + " Food contract issue "
                            };
                        }
                       
                    
                      try
                        {
                            foreach (var item in HAJ_GROUP_PACKAGE.HGP_DETAILS.HOUSING_CONTRACTS.HOUSING_CONTRACT)
                            {
                                string houseQuery = "INSERT INTO AFR_HOUSE_CONTRACTS (PKG_ID, HC_ID,START_DATE,END_DATE) VALUES (:PKG_ID,:HC_ID,:START_DATE,:END_DATE )";
                                command = new OracleCommand(houseQuery, myConnection);
                                command.Parameters.Add(new OracleParameter { ParameterName = "PKG_ID", Value = HAJ_GROUP_PACKAGE.HGP_ID });
                                command.Parameters.Add(new OracleParameter { ParameterName = "START_DATE", Value = item.START_DATE });
                                command.Parameters.Add(new OracleParameter { ParameterName = "END_DATE", Value = item.END_DATE });

                                command.Parameters.Add(new OracleParameter { ParameterName = "HC_ID", Value = item.HC_ID });

                                reader = command.ExecuteNonQuery();
                            }

                        }
                        catch (Exception ex)
                        {
                            result = new RESULT2
                            {
                                ERROR_CODE = "1",
                                ERROR_DESC = ex.Message + " House  contract issue "
                            };

                        }
                       
                    
                        try
                        {
                            foreach (var item in HAJ_GROUP_PACKAGE.HGP_DETAILS.FLIGTH_CONTRACTS.HHBF_ID)
                            {
                                string flightQurey = " INSERT INTO AFR_FLIGHTS (PKG_ID, HHBF_ID) VALUES (:PKG_ID, :HHBF_ID )";
                                command = new OracleCommand(flightQurey, myConnection);
                                command.Parameters.Add(new OracleParameter { ParameterName = "PKG_ID", Value = HAJ_GROUP_PACKAGE.HGP_ID });
                                command.Parameters.Add(new OracleParameter { ParameterName = "HHBF_ID", Value = item });

                                reader = command.ExecuteNonQuery();

                            }


                        }
                        catch (Exception ex)
                        {

                            result = new RESULT2
                            {
                                ERROR_CODE = "1",
                                ERROR_DESC = ex.Message + " flight  contract issue "
                            };
                        }
                    
                  
                    result = new RESULT2
                    {
                        ERROR_CODE = "0",
                        ERROR_DESC = "",
                        HAJ_GROUP_PACKAGE_RESPONSE = new HAJ_GROUP_PACKAGE_RESPONSE { HGP_ID = HAJ_GROUP_PACKAGE.HGP_ID }

                    };


                }
                catch (Exception ex)
                {

                    result = new RESULT2
                    {
                        ERROR_CODE = "1",
                        ERROR_DESC = ex.Message
                    };
                }


            }
            else
            {
                result = new RESULT2 { ERROR_CODE = "1", ERROR_DESC = "Not Authorized" };
            }

            return result;
        }





        public string getDateForTest()
        {
            return "hello sejel";
        }

  public RESULT3 SendHajMianifestInfo(SendHajMianifestInfo SendHajMianifestInfo, LOGIN LOGIN)
        {
            RESULT3 result;
            if (LogingISvalid(LOGIN))
            {
                OracleConnection myConnection = Utility.connection();




                try
                {




                    string PkgQuery = "INSERT INTO HAJMIANIFEST (MANIFEST_ID,MANIFEST_PRT_ID,MANIFEST_LTC_ID,MANIFEST_ROUTE_ID,MANIFEST_TRIP_DATE,MANIFEST_TRIP_DATE_HIJ,MANIFEST_BI_ID,MANIFEST_DI_ID,MANIFEST_HOUSE_ID,MANIFEST_STATE,MANIFEST_EST_ID,MANIFEST_HEB_ID,VEHICLE_TYPE,NATIONALITY_BUS_ID,MANIFEST_TYPE) VALUES" +
                        " (:MANIFEST_ID,:MANIFEST_PRT_ID,:MANIFEST_LTC_ID,:MANIFEST_ROUTE_ID,:MANIFEST_TRIP_DATE,:MANIFEST_TRIP_DATE_HIJ,:MANIFEST_BI_ID,:MANIFEST_DI_ID,:MANIFEST_HOUSE_ID,:MANIFEST_STATE,:MANIFEST_EST_ID,:MANIFEST_HEB_ID,:VEHICLE_TYPE,:NATIONALITY_BUS_ID,:MANIFEST_TYPE)";


                    OracleCommand command = new OracleCommand(PkgQuery, myConnection);
                    command.Parameters.Add(new OracleParameter { ParameterName = "MANIFEST_ID", Value = SendHajMianifestInfo.MANIFEST_ID });
                    command.Parameters.Add(new OracleParameter { ParameterName = "MANIFEST_PRT_ID", Value = SendHajMianifestInfo.MANIFEST_PRT_ID });
                    command.Parameters.Add(new OracleParameter { ParameterName = "MANIFEST_LTC_ID", Value = SendHajMianifestInfo.MANIFEST_LTC_ID });
                    command.Parameters.Add(new OracleParameter { ParameterName = "MANIFEST_ROUTE_ID", Value = SendHajMianifestInfo.MANIFEST_ROUTE_ID });
                    command.Parameters.Add(new OracleParameter { ParameterName = "MANIFEST_TRIP_DATE", Value = SendHajMianifestInfo.MANIFEST_TRIP_DATE, DbType = DbType.Date });
                    command.Parameters.Add(new OracleParameter { ParameterName = "MANIFEST_TRIP_DATE_HIJ", Value = SendHajMianifestInfo.MANIFEST_TRIP_DATE_HIJ });
                    command.Parameters.Add(new OracleParameter { ParameterName = "MANIFEST_BI_ID", Value = SendHajMianifestInfo.MANIFEST_BI_ID });
                    command.Parameters.Add(new OracleParameter { ParameterName = "MANIFEST_DI_ID", Value = SendHajMianifestInfo.MANIFEST_DI_ID });
                    command.Parameters.Add(new OracleParameter { ParameterName = "MANIFEST_HOUSE_ID", Value = SendHajMianifestInfo.MANIFEST_HOUSE_ID });
                    command.Parameters.Add(new OracleParameter { ParameterName = "MANIFEST_STATE", Value = SendHajMianifestInfo.MANIFEST_STATE });
                    command.Parameters.Add(new OracleParameter { ParameterName = "MANIFEST_EST_ID", Value = SendHajMianifestInfo.MANIFEST_EST_ID == String.Empty ? "0" : SendHajMianifestInfo.MANIFEST_EST_ID });
                    command.Parameters.Add(new OracleParameter { ParameterName = "MANIFEST_HEB_ID", Value = SendHajMianifestInfo.MANIFEST_HEB_ID==String.Empty? "0":SendHajMianifestInfo.MANIFEST_HEB_ID });

                    command.Parameters.Add(new OracleParameter { ParameterName = "VEHICLE_TYPE", Value = SendHajMianifestInfo.VEHICLE_TYPE });
                    command.Parameters.Add(new OracleParameter { ParameterName = "NATIONALITY_BUS_ID", Value = SendHajMianifestInfo.NATIONALITY_BUS_ID });
                    command.Parameters.Add(new OracleParameter { ParameterName = "MANIFEST_TYPE", Value = SendHajMianifestInfo.MANIFEST_TYPE});



                    // command.Parameters.Add(new OracleParameter { ParameterName = "MANIFEST_BAG_NO", Value = SendHajMianifestInfo.MANIFEST_BAG_NO });


                    int reader;
                    reader = command.ExecuteNonQuery();

                    foreach (var item in SendHajMianifestInfo.MANIFEST_DETAILS)
                    {
                        string foodQuery = "INSERT INTO HAJMIANIFEST_DETAIL (MAINIFEST_ID,MANIFEST_NT_ID,MANIFEST_HD_ID,MANIFEST_HAJ_TYPE,GROUP_ID) " +
                            "VALUES (:MANIFEST_ID,:MANIFEST_NT_ID,:MANIFEST_HD_ID,:MANIFEST_HAJ_TYPE,:GROUP_ID)";
                        command = new OracleCommand(foodQuery, myConnection);
                        command.Parameters.Add(new OracleParameter { ParameterName = "MANIFEST_ID", Value = SendHajMianifestInfo.MANIFEST_ID });
                        command.Parameters.Add(new OracleParameter { ParameterName = "MANIFEST_PASSPORT_NO", Value = item.MANIFEST_PASSPORT_NO });
                        command.Parameters.Add(new OracleParameter { ParameterName = "MANIFEST_NT_ID", Value = item.MANIFEST_NT_ID });
                        command.Parameters.Add(new OracleParameter { ParameterName = "MANIFEST_HD_ID", Value = item.MANIFEST_HD_ID == string.Empty ? "0" : item.MANIFEST_HD_ID });
                        command.Parameters.Add(new OracleParameter { ParameterName = "MANIFEST_HAJ_TYPE", Value = item.MANIFEST_HAJ_TYPE == string.Empty ? "0" : item.MANIFEST_HAJ_TYPE });
                        command.Parameters.Add(new OracleParameter { ParameterName = "MAINFEST_DEPENDENT_NO", Value = item.MAINFEST_DEPENDENT_NO });
                        command.Parameters.Add(new OracleParameter { ParameterName = "GROUP_ID", Value = item.GROUP_ID });


                        try
                        {




                            reader = command.ExecuteNonQuery();
                        }
                        catch (Exception ex)
                        {


                            result = new RESULT3
                            {
                                ERROR_CODE = "1",
                                ERROR_DESC = ex.Message + foodQuery + LookupUtility.Serialize<DETAILS>(item)
                            };
                            return result;
                        }
                    }


                    result = new RESULT3
                    {
                        ERROR_CODE = "0",
                        ERROR_DESC = "Valid",
                        ReferenceID = 0


                    };

                }
                catch (Exception ex)
                {

                    result = new RESULT3
                    {
                        ERROR_CODE = "1",
                        ERROR_DESC = ex.Message
                    };

                }

            }
            else
            {
                result = new RESULT3 { ERROR_CODE = "1", ERROR_DESC = "Not Authorized" };
            }

            return result;

        }
    }
}
