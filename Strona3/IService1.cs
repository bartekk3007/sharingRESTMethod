using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Xml;

namespace strona3
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface Istrona3
    {
        [OperationContract]
        [WebGet(UriTemplate = "index.html")]
        [XmlSerializerFormat]
        XmlDocument GetHtml();

        [OperationContract]
        [WebGet(UriTemplate = "scripts.js")]
        Stream GetScript();
    }
}