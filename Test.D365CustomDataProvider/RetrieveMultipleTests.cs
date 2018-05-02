using System;
using D365CustomDataProvider;
using FakeXrmEasy;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Query;
using Xunit;

namespace Test.D365CustomDataProvider
{
    public class RetrieveMultipleTests
    {
        [Fact]
        public void Call_Plugin_First_Time()
        {
            var context = new XrmFakedContext();

            QueryExpression queryExpression = new QueryExpression("complaint");

            ParameterCollection inputParameters = new ParameterCollection
            {
                { "Query", queryExpression }
            };

            XrmFakedPluginExecutionContext pluginCtx = context.GetDefaultPluginContext();
            pluginCtx.Stage = 20;
            pluginCtx.MessageName = "RetrieveMultiple";
            pluginCtx.InputParameters = inputParameters;

            Exception ex = Record.Exception(() => context.ExecutePluginWithConfigurations<CdpRetrieveMultiple>(pluginCtx, null, null));
            Assert.Null(ex);
        }
    }
}
