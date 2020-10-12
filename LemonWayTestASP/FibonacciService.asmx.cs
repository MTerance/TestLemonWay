using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using FibonacciLibrary;
using XmlToJsonLibrary;
using log4net;

namespace LemonWayTestASP
{
    /// <summary>
    /// Description résumée de FibonacciService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Pour autoriser l'appel de ce service Web depuis un script à l'aide d'ASP.NET AJAX, supprimez les marques de commentaire de la ligne suivante. 
    // [System.Web.Script.Services.ScriptService]
    public class FibonacciService : System.Web.Services.WebService
    {

        private static readonly ILog log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        [WebMethod]
        public int Fibonacci(int n)
        {
            int result = 0;

            log.Info("new Incoming Request : Fibonacci");
            if (n < 1 || n > 100)
                result = -1;
            else
            {
                FibonacciLogic logic = new FibonacciLogic();
                result = logic.ComputeFibonacci(n);
                log.Info(String.Format("Result Fibonacci : {0} ", result));
            }
            return result;
        }

        public string XmlToJson(string xml)
        {
            log.Info("new Incoming Request : XmlToJson");

            XmlToJsonLogic lib = new XmlToJsonLogic();

            string result =  lib.XmlJson(xml);
            log.Info(String.Format("Result XmlToJson : {0} ", result));
            return result;
        }
    }
}
