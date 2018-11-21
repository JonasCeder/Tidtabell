using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Results;
using System.Web.Mvc;
using Tidtabell.Helpers;

namespace Tidtabell.Controllers
{
    public class SLController : ApiController
    {
        TimeTableHelper timeTableHelper = new TimeTableHelper();
        public JsonResult<string> GetTimeTable()
        {
            var currentTimeTable = timeTableHelper.GetTimeTable();

            return Json(currentTimeTable);
        }
    }
}
