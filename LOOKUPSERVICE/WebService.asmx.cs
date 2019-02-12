using LOOKUPSERVICE.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OracleClient;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace LOOKUPSERVICE
{
    /// <summary>
    /// Summary description for WebService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService : System.Web.Services.WebService
    {
        private bool LogingISvalid(LOGIN login)
        {
            if (login.USER_NAME == "AfricaNonArab" && login.PASSWORD == "AfricaNonArab")
                return true;
            else
                return false;
        }


        [WebMethod]
        public RESULT3 SendHajMianifestInfo(SendHajMianifestInfo SendHajMianifestInfo, LOGIN LOGIN)
        {
            RESULT3 result;
            if (LogingISvalid(LOGIN))
            {
                OracleConnection myConnection = Utility.connection();




                try
                {


                             string PkgQuery = "INSERT INTO HAJMIANIFEST (MANIFEST_ID,MANIFEST_PRT_ID,MANIFEST_LTC_ID,MANIFEST_ROUTE_ID,MANIFEST_TRIP_DATE,MANIFEST_TRIP_DATE_HIJ,MANIFEST_BI_ID,MANIFEST_DI_ID,MANIFEST_HOUSE_ID,MANIFEST_STATE,MANIFEST_EST_ID,MANIFEST_HEB_ID,VEHICLE_TYPE,NATIONALITY_BUS_ID,MANIFEST_TYPE) VALUES" +
                                                               "(:MANIFEST_ID,:MANIFEST_PRT_ID,:MANIFEST_LTC_ID,:MANIFEST_ROUTE_ID,:MANIFEST_TRIP_DATE,:MANIFEST_TRIP_DATE_HIJ,:MANIFEST_BI_ID,:MANIFEST_DI_ID,:MANIFEST_HOUSE_ID,:MANIFEST_STATE,:MANIFEST_EST_ID,:MANIFEST_HEB_ID,:VEHICLE_TYPE,:NATIONALITY_BUS_ID,:MANIFEST_TYPE)";


                    OracleCommand command = new OracleCommand(PkgQuery, myConnection);
                   
                    command.Parameters.Add(new OracleParameter { ParameterName = "MANIFEST_ID", Value = SendHajMianifestInfo.MANIFEST_ID });
                    command.Parameters.Add(new OracleParameter { ParameterName = "MANIFEST_PRT_ID", Value = SendHajMianifestInfo.MANIFEST_PRT_ID });
                    command.Parameters.Add(new OracleParameter { ParameterName = "MANIFEST_LTC_ID", Value = SendHajMianifestInfo.MANIFEST_LTC_ID.checknull() });
                    command.Parameters.Add(new OracleParameter { ParameterName = "MANIFEST_ROUTE_ID", Value = SendHajMianifestInfo.MANIFEST_ROUTE_ID });
                    command.Parameters.Add(new OracleParameter { ParameterName = "MANIFEST_TRIP_DATE", Value = SendHajMianifestInfo.MANIFEST_TRIP_DATE, DbType = DbType.Date });
                    command.Parameters.Add(new OracleParameter { ParameterName = "MANIFEST_TRIP_DATE_HIJ", Value = SendHajMianifestInfo.MANIFEST_TRIP_DATE_HIJ });
                    command.Parameters.Add(new OracleParameter { ParameterName = "MANIFEST_BI_ID", Value = SendHajMianifestInfo.MANIFEST_BI_ID.checknull() });
                    command.Parameters.Add(new OracleParameter { ParameterName = "MANIFEST_DI_ID", Value = SendHajMianifestInfo.MANIFEST_DI_ID.checknull() });
                    command.Parameters.Add(new OracleParameter { ParameterName = "MANIFEST_HOUSE_ID", Value = SendHajMianifestInfo.MANIFEST_HOUSE_ID });
                    command.Parameters.Add(new OracleParameter { ParameterName = "MANIFEST_STATE", Value = SendHajMianifestInfo.MANIFEST_STATE });
                    command.Parameters.Add(new OracleParameter { ParameterName = "MANIFEST_EST_ID", Value = SendHajMianifestInfo.MANIFEST_EST_ID.checknull() });
                    command.Parameters.Add(new OracleParameter { ParameterName = "MANIFEST_HEB_ID", Value = SendHajMianifestInfo.MANIFEST_HEB_ID.checknull() });
                   // command.Parameters.Add(new OracleParameter { ParameterName = "VEHICLE_TYPE", Value = SendHajMianifestInfo.VEHICLE_TYPE.checknull() });


                  //  command.Parameters.Add(new OracleParameter { ParameterName = "NATIONALITY_BUS_ID", Value = SendHajMianifestInfo.NATIONALITY_BUS_ID.checknull()});
                    command.Parameters.Add(new OracleParameter { ParameterName = "MANIFEST_TYPE", Value = SendHajMianifestInfo.MANIFEST_TYPE.checknull() });
                

                  int reader;
                    reader = command.ExecuteNonQuery();



                    
                    foreach (var item in SendHajMianifestInfo.MANIFEST_DETAILS)
                    {
                        string foodQuery = "INSERT INTO HAJMIANIFEST_DETAIL (MAINIFEST_ID, MANIFEST_PASSPORT_NO,MANIFEST_NT_ID,MANIFEST_HD_ID,MANIFEST_HAJ_TYPE,MAINFEST_DEPENDENT_NO,GROUP_ID) VALUES" +
                                                                          " (:MANIFEST_ID, :MANIFEST_PASSPORT_NO,:MANIFEST_NT_ID,:MANIFEST_HD_ID,:MANIFEST_HAJ_TYPE,:MAINFEST_DEPENDENT_NO,:GROUP_ID)";
                        command = new OracleCommand(foodQuery, myConnection);
                        command.Parameters.Add(new OracleParameter { ParameterName = "MANIFEST_ID", Value = SendHajMianifestInfo.MANIFEST_ID });
                        command.Parameters.Add(new OracleParameter { ParameterName = "MANIFEST_PASSPORT_NO", Value = item.MANIFEST_PASSPORT_NO.checknull() });
                        command.Parameters.Add(new OracleParameter { ParameterName = "MANIFEST_NT_ID", Value = item.MANIFEST_NT_ID });
                        command.Parameters.Add(new OracleParameter { ParameterName = "GROUP_ID", Value = item.GROUP_ID });
                        command.Parameters.Add(new OracleParameter { ParameterName = "MANIFEST_HD_ID", Value = item.MANIFEST_HD_ID.checknull() });
                        command.Parameters.Add(new OracleParameter { ParameterName = "MANIFEST_HAJ_TYPE", Value = item.MANIFEST_HAJ_TYPE.checknull() });
                      
                        command.Parameters.Add(new OracleParameter { ParameterName = "MAINFEST_DEPENDENT_NO", Value = item.MAINFEST_DEPENDENT_NO.checknull() });


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

        [WebMethod]
        public RESULT HajjTrip(sendHajjTrip.SendHajjTrip[] SendHajjTrip, LOGIN LOGIN)
        {

            RESULT result ;
            if (LogingISvalid(LOGIN))
            {
                OracleConnection myConnection = Utility.connection();
                try
                {


                    foreach (var item in SendHajjTrip)
                    {
                        string cmd = "delete  from  hajj1439.HAJJTRIP where SHT_TRIP_ID=" + item.SHT_TRIP_ID;
                        OracleCommand command = new OracleCommand(cmd, myConnection);

                        int a = command.ExecuteNonQuery();

                       // cmd = "delete from hajj1438.HAJJTRIPFLIGHT where SHT_TRIP_ID=" + item.SHT_TRIP_ID;
                   //     command = new OracleCommand(cmd, myConnection);
                     //   a = command.ExecuteNonQuery();

                      //  cmd = "delete from hajj1438.HAJJTRIPHOUSE where SHT_TRIP_ID=" + item.SHT_TRIP_ID;
                     //   command = new OracleCommand(cmd, myConnection);
                      //  a = command.ExecuteNonQuery();


                         cmd = "insert into hajj1439.HAJJTRIP(SHT_TRIP_ID,SHT_TYPE,SHT_STATE,SHT_DRIVER_ID,SHT_TAFWEEJ_ID,SHT_BUS_ID,SHT_NAQABA_CONFIRM_NO,SHT_EST_ID,SHT_LTC_ID,SHT_HEB_ID,SHT_TRIP_DATE,DRIVER_NAME,DRIVER_IDENTIFICATION_NO,PLATE_NO,VEHICLE_TYPE_ID,SHT_PATH_ID,SHT_PATH_TYPE_ID,SHT_TO_EST_ID) values" +
                            "(:SHT_TRIP_ID, :SHT_TYPE, :SHT_STATE, :SHT_DRIVER_ID, :SHT_TAFWEEJ_ID, :SHT_BUS_ID, :SHT_NAQABA_CONFIRM_NO, :SHT_EST_ID, :SHT_LTC_ID, :SHT_HEB_ID, :SHT_TRIP_DATE,:DRIVER_NAME,:DRIVER_IDENTIFICATION_NO,:PLATE_NO,:VEHICLE_TYPE_ID,:SHT_PATH_ID,:SHT_PATH_TYPE_ID,:SHT_TO_EST_ID)";
                         command = new OracleCommand(cmd, myConnection);
                           
                            command.Parameters.Add(new OracleParameter { ParameterName = "SHT_TRIP_ID", Value = item.SHT_TRIP_ID });
                            command.Parameters.Add(new OracleParameter { ParameterName = "SHT_TYPE", Value = item.SHT_TYPE.checknull() });
                            command.Parameters.Add(new OracleParameter { ParameterName = "SHT_STATE", Value = item.SHT_STATE.checknull() });
                            command.Parameters.Add(new OracleParameter { ParameterName = "SHT_DRIVER_ID", Value = item.SHT_DRIVER_ID.checknull() });
                            command.Parameters.Add(new OracleParameter { ParameterName = "SHT_TAFWEEJ_ID", Value = item.SHT_TAFWEEJ_ID.checknull() });
                            command.Parameters.Add(new OracleParameter { ParameterName = "SHT_BUS_ID", Value = item.SHT_BUS_ID.checknull() });
                            command.Parameters.Add(new OracleParameter { ParameterName = "SHT_NAQABA_CONFIRM_NO", Value = item.SHT_NAQABA_CONFIRM_NO.checknull() });
                            command.Parameters.Add(new OracleParameter { ParameterName = "SHT_EST_ID", Value = item.SHT_EST_ID.checknull() });
                            command.Parameters.Add(new OracleParameter { ParameterName = "SHT_LTC_ID", Value = item.SHT_LTC_ID.checknull() });
                            command.Parameters.Add(new OracleParameter { ParameterName = "SHT_HEB_ID", Value = item.SHT_HEB_ID.checknull() });
                            command.Parameters.Add(new OracleParameter { ParameterName = "SHT_TRIP_DATE", Value = item.SHT_TRIP_DATE, DbType = DbType.Date });
                        command.Parameters.Add(new OracleParameter { ParameterName = "DRIVER_NAME", Value = item.DRIVER_NAME.checknull() });
                        command.Parameters.Add(new OracleParameter { ParameterName = "DRIVER_IDENTIFICATION_NO", Value = item.DRIVER_IDENTIFICATION_NO.checknull() });
                        command.Parameters.Add(new OracleParameter { ParameterName = "PLATE_NO", Value = item.PLATE_NO.checknull() });
                        command.Parameters.Add(new OracleParameter { ParameterName = "VEHICLE_TYPE_ID", Value = item.VEHICLE_TYPE_ID.checknull() });
                        command.Parameters.Add(new OracleParameter { ParameterName = "SHT_PATH_ID", Value = item.SHT_PATH_ID.checknull() });
                        command.Parameters.Add(new OracleParameter { ParameterName = "SHT_PATH_TYPE_ID", Value = item.SHT_PATH_TYPE_ID.checknull() });
                        command.Parameters.Add(new OracleParameter { ParameterName = "SHT_TO_EST_ID", Value = item.SHT_TO_EST_ID.checknull() });

                        


                             a = command.ExecuteNonQuery();


                       
                       
                        if (item.Details.Flights != null)
                        {

                            foreach (var f in item.Details.Flights)
                            {
                                foreach (var hajjs in f.HAJJS)
                                {

                                    cmd = "delete from  hajj1439.HAJJTRIPFLIGHT where SHT_HD_ID=" + hajjs.SHT_HD_ID.checknull();
                                    command = new OracleCommand(cmd, myConnection);
                                    a = command.ExecuteNonQuery();

                                    cmd = "insert into hajj1439.HAJJTRIPFLIGHT(SHT_FD_ID,SHT_TRIP_ID,SHT_HD_ID,SHT_NT_ID,SHT_HEB_ID,SHT_TAFWEEJ_ID)values(:SHT_FD_ID,:SHT_TRIP_ID,:SHT_HD_ID,:SHT_NT_ID,:SHT_HEB_ID,:SHT_TAFWEEJ_ID)";
                                    command = new OracleCommand(cmd,myConnection);
                                    command.Parameters.Add(new OracleParameter { ParameterName = "SHT_FD_ID", Value = f.SHT_FD_ID });
                                    command.Parameters.Add(new OracleParameter { ParameterName = "SHT_TRIP_ID", Value = item.SHT_TRIP_ID });
                                    command.Parameters.Add(new OracleParameter { ParameterName = "SHT_HD_ID", Value = hajjs.SHT_HD_ID.checknull() });
                                    command.Parameters.Add(new OracleParameter { ParameterName = "SHT_NT_ID", Value = hajjs.SHT_NT_ID.checknull()});
                                    command.Parameters.Add(new OracleParameter { ParameterName = "SHT_HEB_ID", Value = hajjs.SHT_HEB_ID.checknull()});
                                    command.Parameters.Add(new OracleParameter { ParameterName = "SHT_TAFWEEJ_ID", Value = hajjs.SHT_TAFWEEJ_ID.checknull() });

                                    a = command.ExecuteNonQuery();
                                }
                            }
                        }
                        if (item.Details.Houses != null)
                        {
                            foreach (var h in item.Details.Houses)
                            {
                                foreach (var hajjs in h.HAJJS)
                                {

                                    cmd = "delete from  hajj1439.HAJJTRIPHOUSE where SHT_HD_ID=" + hajjs.SHT_HD_ID.checknull();
                                    command = new OracleCommand(cmd, myConnection);
                                    a = command.ExecuteNonQuery();


                                    cmd = "insert into hajj1439.HAJJTRIPHOUSE(SHT_HC_ID,SHT_TRIP_ID,SHT_HD_ID,SHT_NT_ID,SHT_HEB_ID,SHT_TAFWEEJ_ID)values(:SHT_HC_ID,:SHT_TRIP_ID,:SHT_HD_ID,:SHT_NT_ID,:SHT_HEB_ID,:SHT_TAFWEEJ_ID)";
                                        command = new OracleCommand(cmd, myConnection);
                                        command.Parameters.Add(new OracleParameter { ParameterName = "SHT_HC_ID", Value = h.HT_HC_ID });
                                        command.Parameters.Add(new OracleParameter { ParameterName = "SHT_TRIP_ID", Value = item.SHT_TRIP_ID });
                                        command.Parameters.Add(new OracleParameter { ParameterName = "SHT_HD_ID", Value = hajjs.SHT_HD_ID.checknull() });
                                        command.Parameters.Add(new OracleParameter { ParameterName = "SHT_NT_ID", Value = hajjs.SHT_NT_ID.checknull() });
                                     command.Parameters.Add(new OracleParameter { ParameterName = "SHT_HEB_ID", Value = hajjs.SHT_HEB_ID.checknull()});
                                    command.Parameters.Add(new OracleParameter { ParameterName = "SHT_TAFWEEJ_ID", Value = hajjs.SHT_TAFWEEJ_ID.checknull() });

                                    a = command.ExecuteNonQuery();
                                    

                                    
                                }
                            }
                        }

                    }




                    result = new RESULT
                    {
                       ERROR_CODE = "0",
                       ERROR_DESC = "Valid",
                   };
                }
                catch (Exception ex )
                {

                    result = new RESULT
                    {
                        ERROR_CODE = "1",
                        ERROR_DESC = ex.Message ,
                    };
                }
            }
            else
            {
                result = new RESULT { ERROR_CODE = "1", ERROR_DESC = "Not Authorized" };
            }
            return result;
        }

        [WebMethod]
        public RESULT SendHajjTrip(sendHajjTrip.SendHajjTrip[] SendHajjTrip, LOGIN LOGIN)
        {


            return HajjTrip(SendHajjTrip, LOGIN);
            RESULT result=new RESULT();
            //if (LogingISvalid(LOGIN))
            //{
            //    OracleConnection myConnection = Utility.connection();




            //    try
            //    {




            //        string PkgQuery = "INSERT INTO HAJJ1438.SENDHAJJTRIP (   HT_ID, HT_EST_ID, HT_EST_BRANCH_NO,HT_BUS_TRIP_NO, HT_PORT_ID, HT_LTC_ID,HT_TRIP_DATE, HT_BUS_SER_NO, HT_BUS_SEATS," +
            //         "HT_CAR_TYPE_ID, HT_DRIVER_ID, HT_DRIVER_NAME,    HT_DRIVER_NAT_ID, HT_PATH_ID, HT_HAJJ_TOTALS,    HT_STATE, HT_TIMESTAMP, HT_TIMESTAMP_HIJRI,TDO_ID,NAQABA_CONFIRMATION) VALUES ( :HT_ID ,  :HT_EST_ID ,  :HT_EST_BRANCH_NO ," +
            //       " :HT_BUS_TRIP_NO ,  :HT_PORT_ID ,  :HT_LTC_ID ,  :HT_TRIP_DATE ,  :HT_BUS_SER_NO , :HT_BUS_SEATS ,  :HT_CAR_TYPE_ID ,  :HT_DRIVER_ID  ,:HT_DRIVER_NAME,  :HT_DRIVER_NAT_ID ,  :HT_PATH_ID ," +
            //        ":HT_HAJJ_TOTALS ,  :HT_STATE ,  :HT_TIMESTAMP ,  :HT_TIMESTAMP_HIJRI,:TDO_ID,:NAQABA_CONFIRMATION  )";


            //        OracleCommand command = new OracleCommand(PkgQuery, myConnection);
            //        command.Parameters.Add(new OracleParameter { ParameterName = "HT_ID", Value = SendHajjTrip.HT_ID.checknull() });
            //        command.Parameters.Add(new OracleParameter { ParameterName = "HT_EST_ID", Value = SendHajjTrip.HT_EST_ID.checknull() });
            //        command.Parameters.Add(new OracleParameter { ParameterName = "HT_EST_BRANCH_NO", Value = SendHajjTrip.HT_EST_BRANCH_NO.checknull() });
            //        command.Parameters.Add(new OracleParameter { ParameterName = "HT_BUS_TRIP_NO", Value = SendHajjTrip.HT_BUS_TRIP_NO.checknull() });
            //        command.Parameters.Add(new OracleParameter { ParameterName = "HT_PORT_ID", Value = SendHajjTrip.HT_PORT_ID .checknull() });
            //        command.Parameters.Add(new OracleParameter { ParameterName = "HT_LTC_ID", Value = SendHajjTrip.HT_LTC_ID .checknull() });
            //        command.Parameters.Add(new OracleParameter { ParameterName = "HT_TRIP_DATE", Value = SendHajjTrip.HT_TRIP_DATE });
            //        command.Parameters.Add(new OracleParameter { ParameterName = "HT_BUS_SER_NO", Value = SendHajjTrip.HT_BUS_SER_NO.checknull() });
            //        command.Parameters.Add(new OracleParameter { ParameterName = "HT_BUS_SEATS", Value = SendHajjTrip.HT_BUS_SEATS.checknull() });
            //        command.Parameters.Add(new OracleParameter { ParameterName = "HT_CAR_TYPE_ID", Value = SendHajjTrip.HT_CAR_TYPE_ID.checknull() });
            //        command.Parameters.Add(new OracleParameter { ParameterName = "HT_DRIVER_ID", Value = SendHajjTrip.HT_DRIVER_ID.checknull() });
            //        command.Parameters.Add(new OracleParameter { ParameterName = "HT_DRIVER_NAME", Value = SendHajjTrip.HT_DRIVER_NAME.checknull() });
            //        command.Parameters.Add(new OracleParameter { ParameterName = "HT_DRIVER_NAT_ID", Value = SendHajjTrip.HT_DRIVER_NAT_ID.checknull()});
            //        command.Parameters.Add(new OracleParameter { ParameterName = "HT_PATH_ID", Value = SendHajjTrip.HT_PATH_ID.checknull() });

            //        command.Parameters.Add(new OracleParameter { ParameterName = "HT_HAJJ_TOTALS", Value = SendHajjTrip.HT_HAJJ_TOTALS.checknull() });
            //        command.Parameters.Add(new OracleParameter { ParameterName = "HT_STATE", Value = SendHajjTrip.HT_STATE.checknull() });
            //        command.Parameters.Add(new OracleParameter { ParameterName = "HT_TIMESTAMP", Value = SendHajjTrip.HT_TIMESTAMP });
            //        command.Parameters.Add(new OracleParameter { ParameterName = "HT_TIMESTAMP_HIJRI", Value = SendHajjTrip.HT_TIMESTAMP_HIJRI.checknull() });
            //        command.Parameters.Add(new OracleParameter { ParameterName = "TDO_ID", Value = SendHajjTrip.TDO_ID.checknull() });
            //        command.Parameters.Add(new OracleParameter { ParameterName = "NAQABA_CONFIRMATION", Value = SendHajjTrip.NAQABA_CONFIRMATION.checknull() });

            //        int reader;
            //        reader = command.ExecuteNonQuery();
            //        if (SendHajjTrip.Details.Flights != null)
            //        {
            //            foreach (var item in SendHajjTrip.Details.Flights)
            //            {
            //                string foodQuery = "INSERT INTO HAJJ1438.SENDHAJJTRIPFLIGHT (HT_ID, HT_FD_ID, HT_HD_ID)VALUES (:HT_ID ,:HT_FD_ID , :HT_HD_ID  )";
            //                command = new OracleCommand(foodQuery, myConnection);
            //                command.Parameters.Add(new OracleParameter { ParameterName = "HT_ID", Value = SendHajjTrip.HT_ID.checknull() });
            //                command.Parameters.Add(new OracleParameter { ParameterName = "HT_FD_ID", Value = item.HT_FD_ID });
            //                command.Parameters.Add(new OracleParameter { ParameterName = "HT_HD_ID", Value = item.HT_HD_ID });
            //                reader = command.ExecuteNonQuery();
            //            }
            //        }
            //        if (SendHajjTrip.Details.Houses != null)
            //        {
            //            foreach (var item in SendHajjTrip.Details.Houses)
            //            {
            //                string foodQuery = "INSERT INTO HAJJ1438.SENDHAJJTRIPHOUSE (HT_ID, HT_HC_ID, HT_HD_ID)VALUES (:HT_ID ,:HT_HC_ID , :HT_HD_ID  )";
            //                command = new OracleCommand(foodQuery, myConnection);
            //                command.Parameters.Add(new OracleParameter { ParameterName = "HT_ID", Value = SendHajjTrip.HT_ID });
            //                command.Parameters.Add(new OracleParameter { ParameterName = "HT_HC_ID", Value = item.HT_HC_ID });
            //                command.Parameters.Add(new OracleParameter { ParameterName = "HT_HD_ID", Value = item.HT_HD_ID });
            //                reader = command.ExecuteNonQuery();
            //            }
            //        }



            //        result = new RESULT
            //        {
            //            ERROR_CODE = "0",
            //            ERROR_DESC = "Valid",
            //        };

            //    }
            //    catch (Exception ex)
            //    {

            //        result = new RESULT
            //        {
            //            ERROR_CODE = "1",
            //            ERROR_DESC = ex.Message
            //        };

            //    }

            //}
            //else
            //{
            //    result = new RESULT { ERROR_CODE = "1", ERROR_DESC = "Not Authorized" };
            //}

            return result;



        }



    }
}
