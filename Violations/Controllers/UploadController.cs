﻿using System;
using System.Collections.Generic;
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
    public class UploadController : ApiController
    {

        // post api/upload
        [Route("api/upload")]
        public string Post(List<Attachment> attaches)
        {
            string msg = "";
            foreach (Attachment file in attaches)
            {
                var filePath = "";
                if (file.Path != null)
                {
                    filePath = HttpContext.Current.Server.MapPath("\\UploadedFiles\\" + file.Path.Replace('/', '\\'));
                    Directory.CreateDirectory(filePath);
                    filePath = HttpContext.Current.Server.MapPath("/UploadedFiles/" +file.Path+ "/"+ file.FileName);
                }
                else
                {
                    filePath = HttpContext.Current.Server.MapPath("/UploadedFiles/temp/" + file.FileName);
                }

                

                // strdocPath = "~/uploadedFiles" + file.FileName;
                // var filePath = "~/uploadedFiles/" + file.FileName;
               FileStream objfilestream = new FileStream(filePath, FileMode.Create, FileAccess.ReadWrite);
                // FileStream objfilestream = new FileStream("~/uploadedFiles/temp/" + file.FileName, FileMode.Create, FileAccess.ReadWrite);
                byte[] buffer = Convert.FromBase64String(file.Content);
                objfilestream.Write(buffer, 0, buffer.Length);
                objfilestream.Close();
                msg = filePath;
            }
            return msg;

        }

        [HttpDelete, Route("api/upload")]//, Route("{fileName}")
        public IHttpActionResult Delete(string fileName)
        {
            string msg = "";

            var path = "";

            var filePath = HttpContext.Current.Server.MapPath(fileName);
            if (System.IO.File.Exists(filePath))
            {
                System.IO.File.Delete(filePath);
                msg = "ok";
            }

            return this.Ok();
        }



    }
}