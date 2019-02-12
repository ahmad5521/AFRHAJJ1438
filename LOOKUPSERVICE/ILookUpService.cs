using LOOKUPSERVICE.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace LOOKUPSERVICE
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface ILookUpService
    {
        [OperationContract]
        RESULT SendLookup(LOGIN login, REQUEST_INFO request, DETAILSCELL[] Body);

        [OperationContract]

         RESULT3 SendHajMianifestInfo(SendHajMianifestInfo SendHajMianifestInfo, LOGIN LOGIN);

        [OperationContract]
        RESULT2 SetHajPackageReq(HAJ_GROUP_PACKAGE HAJ_GROUP_PACKAGE, LOGIN LOGIN);

       
        [OperationContract]
        string getDateForTest();
    }
}
