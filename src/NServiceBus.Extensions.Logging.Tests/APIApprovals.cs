namespace NServiceBus.Extensions.Logging.Tests
{
    using Logging;
    using NUnit.Framework;
    using Particular.Approvals;
    using PublicApiGenerator;

    [TestFixture]
    public class APIApprovals
    {
        [Test]
        public void Approve_NServiceBusExtensionsLogging()
        {
            var options = new ApiGeneratorOptions
            {
                ExcludeAttributes = new[] { "System.Runtime.Versioning.TargetFrameworkAttribute" }
            };

            var publicApi = ApiGenerator.GeneratePublicApi(typeof(ExtensionsLoggerFactory).Assembly, options);
            Approver.Verify(publicApi);
        }
    }
}