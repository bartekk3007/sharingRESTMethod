using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Xml;

namespace strona3
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class strona3Server : Istrona3
    {
        private string html = "C:\\Users\\48571\\OneDrive\\Pulpit\\COMLab6\\_WCF_3_lab_files\\index.xhtml";
        private string js = "C:\\Users\\48571\\OneDrive\\Pulpit\\COMLab6\\_WCF_3_lab_files\\scripts.js";

        public XmlDocument GetHtml()
        {
            var xml = new XmlDocument();
            xml.Load(html);
            return xml;
        }

        public Stream GetScript()
        {
            if (File.Exists(js))
            {
                return new FileStream(js, FileMode.Open);
            }

            return null;
        }
    }
}

