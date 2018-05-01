using System.Web.Http;
using System.Web.OData.Batch;
using System.Web.OData.Builder;
using System.Web.OData.Extensions;
using D365ODataService.Models;
using Microsoft.OData.Edm;

namespace D365ODataService
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            config.MapODataServiceRoute("odata", null, GetEdmModel(), new DefaultODataBatchHandler(GlobalConfiguration.DefaultServer));
            config.EnsureInitialized();
        }

        private static IEdmModel GetEdmModel()
        {
            ODataConventionModelBuilder builder = new ODataConventionModelBuilder
            {
                Namespace = "Demos",
                ContainerName = "DefaultContainer"
            };

            builder.EntitySet<Complaint>("Complaints");

            var edmModel = builder.GetEdmModel();
            return edmModel;
        }
    }
}
