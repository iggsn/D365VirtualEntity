using D365CustomDataProvider;
using FakeXrmEasy;
using Microsoft.Xrm.Sdk;
using Xunit;

namespace Test.D365CustomDataProvider
{
    public class RetrieveTests
    {
        [Fact]
        public void Call_Plugin_First_Time()
        {
            var context = new XrmFakedContext();

            var account = new Entity("account");
            account["name"] = "Hello World";
            account["address1_postcode"] = "1234";

            ParameterCollection inputParameters = new ParameterCollection();
            inputParameters.Add("Target", account);

            var pluginCtx = context.GetDefaultPluginContext();
            pluginCtx.Stage = 20;
            pluginCtx.MessageName = "Create";
            pluginCtx.InputParameters = inputParameters;

            var ex = Record.Exception(() => context.ExecutePluginWithConfigurations<CdpRetrieve>(pluginCtx, null, null));
            Assert.Null(ex);
        }
    }
}
