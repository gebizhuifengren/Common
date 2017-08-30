using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace Webservice_Study
{
    /// <summary>
    /// Rumen 的摘要说明
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // 若要允许使用 ASP.NET AJAX 从脚本中调用此 Web 服务，请取消注释以下行。 
    // [System.Web.Script.Services.ScriptService]
    public class Rumen : System.Web.Services.WebService
    {

        [WebMethod]
        public int Sum(int a, int b)
        {
            return a + b;
        }

        [WebMethod]
        public int Sub(int a, int b)
        {
            return a - b;
        }

        [WebMethod]
        public double Mult(double a, double b)
        {
            return a * b;
        }

        [WebMethod]
        public double Div(double a, double b)
        {
            return a / b;
        }
    }
}
