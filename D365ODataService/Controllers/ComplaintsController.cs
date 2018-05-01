using System.Linq;
using System.Web.Http;
using System.Web.OData;
using D365ODataService.DataSource;

namespace D365ODataService.Controllers
{
    [EnableQuery]
    public class ComplaintsController : ODataController
    {
        public IHttpActionResult Get()
        {
            return Ok(DemoDataSource.Instance.Complaints.AsQueryable());
        }
    }
}
