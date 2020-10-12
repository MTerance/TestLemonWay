using System;
using System.Xml;
using Newtonsoft.Json;
using log4net;
namespace XmlToJsonLibrary
{
    public class XmlToJsonLogic
    {
        private static readonly ILog log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public string XmlJson(string xml)
        {
            if (string.IsNullOrEmpty(xml))
                return "Bad Xml format";

            XmlDocument doc = new XmlDocument();
            try
            {
                doc.LoadXml(xml);

                string jsonResult = JsonConvert.SerializeXmlNode(doc);
                return jsonResult;
            }
            catch (Exception exception)
            {
                log.Error(exception.Message, exception);
                return "Bad Xml format";
            }
        }
    }
}
