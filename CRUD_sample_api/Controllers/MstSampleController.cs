using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Diagnostics;
using CRUD_sample_api.Models;
//using Microsoft.AspNet.Identity;

namespace CRUD_sample_api.Controllers
{
    [RoutePrefix("api/Sample")]
    public class MstSampleController : ApiController
    {
        private Data.SampleDataClassDataContext db = new Data.SampleDataClassDataContext();
        //List
        [HttpGet, Route("List")]
        public List<Models.TableOne> GetTableData()
        {
            var TableList = from d in db.Table1s
                            select new Models.TableOne
                            {
                                Id = d.Id,
                                Description = d.Description,
                                Remarks = d.Remarks
                            };
            return TableList.ToList();
        }

    }
}
