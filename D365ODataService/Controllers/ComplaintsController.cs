using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web.Http;
using System.Web.OData;
using D365ODataService.DataSource;
using D365ODataService.Models;

namespace D365ODataService.Controllers
{
    [EnableQuery]
    public class ComplaintsController : ODataController
    {
        public IHttpActionResult Get()
        {
            return Ok(DemoDataSource.Instance.Complaints.AsQueryable());
        }

        public IHttpActionResult Get([FromODataUri] Guid key)
        {
            IEnumerable<Complaint> complaints = DemoDataSource.Instance.Complaints.Where(m => m.Id == key);
            if (!complaints.Any())
                return NotFound();

            return Ok(complaints.FirstOrDefault());
        }
    }
}
