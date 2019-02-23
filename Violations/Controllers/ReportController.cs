using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.Hosting;
using System.Web.Http;
using Violations.Models;
namespace Violations.Controllers
{
    public class ReportController : ApiController
    {
          // post api/upload
           [Route("api/report")]
        public IHttpActionResult Post(ReportInfo report)
           //public ActionResult Index()
            {

                DataAccessBase base2 = new DataAccessBase();
                string[] strArray = report.ReportName.Split(new char[] { ',' });
                object[] parameterValues = new object[strArray.Length - 1];
                string sPName = strArray[0].ToString();
                for (int i = 1; i < strArray.Length; i++)
                {
                    parameterValues[i - 1] = strArray[i].ToString();
                }
              
                DataSet ds = base2.ReaderSp(sPName, parameterValues);

                return Ok(ds.Tables[0]);
            }
    
    }
}
