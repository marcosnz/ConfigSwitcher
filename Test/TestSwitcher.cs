using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ConfigSwitcher.Test
{
    using System.Linq;
    using System.Xml.Linq;

    [TestClass]
    public class TestSwitcher
    {
        [TestMethod]
        public void TestMethod1()
        {
            var sut = new Switcher();
            Assert.AreEqual(Switcher.SecurityLevel.Dev, sut.GetTargetType(@"C:\Dev\ProductionConfigs\Azure\Deployments\AKDEV\Build\DeployProperties.proj"));
            Assert.AreEqual(Switcher.SecurityLevel.Dev, sut.GetTargetType(@"C:\Dev\ProductionConfigs\Azure\Deployments\AKDEVPayroll\Build\DeployProperties.proj"));
            Assert.AreEqual(Switcher.SecurityLevel.Dev, sut.GetTargetType(@"C:\Dev\ProductionConfigs\Azure\Deployments\AKDEVReports\Build\DeployProperties.proj"));
            Assert.AreEqual(Switcher.SecurityLevel.Dev, sut.GetTargetType(@"C:\Dev\ProductionConfigs\Azure\Deployments\APDemo\Build\DeployProperties.proj"));
            Assert.AreEqual(Switcher.SecurityLevel.Dev, sut.GetTargetType(@"C:\Dev\ProductionConfigs\Azure\Deployments\APDemoLion\Build\DeployProperties.proj"));
            Assert.AreEqual(Switcher.SecurityLevel.Dev, sut.GetTargetType(@"C:\Dev\ProductionConfigs\Azure\Deployments\AUDemo\Build\DeployProperties.proj"));
            Assert.AreEqual(Switcher.SecurityLevel.Prod, sut.GetTargetType(@"C:\Dev\ProductionConfigs\Azure\Deployments\AirAsia\Build\DeployProperties.proj"));
            Assert.AreEqual(Switcher.SecurityLevel.Prod, sut.GetTargetType(@"C:\Dev\ProductionConfigs\Azure\Deployments\AirAsiaAPI\Build\DeployProperties.proj"));
            Assert.AreEqual(Switcher.SecurityLevel.Prod, sut.GetTargetType(@"C:\Dev\ProductionConfigs\Azure\Deployments\AirAsiaDR\Build\DeployProperties.proj"));
            Assert.AreEqual(Switcher.SecurityLevel.Prod, sut.GetTargetType(@"C:\Dev\ProductionConfigs\Azure\Deployments\AirAsiaDRAPI\Build\DeployProperties.proj"));
            Assert.AreEqual(Switcher.SecurityLevel.Prod, sut.GetTargetType(@"C:\Dev\ProductionConfigs\Azure\Deployments\AirAsiaOptimiser\Build\DeployProperties.proj"));
            Assert.AreEqual(Switcher.SecurityLevel.Prod, sut.GetTargetType(@"C:\Dev\ProductionConfigs\Azure\Deployments\AirAsiaReports\Build\DeployProperties.proj"));
            Assert.AreEqual(Switcher.SecurityLevel.Uat, sut.GetTargetType(@"C:\Dev\ProductionConfigs\Azure\Deployments\AirAsiaUAT\Build\DeployProperties.proj"));
            Assert.AreEqual(Switcher.SecurityLevel.Dev, sut.GetTargetType(@"C:\Dev\ProductionConfigs\Azure\Deployments\EUWestDemo\Build\DeployProperties.proj"));
            Assert.AreEqual(Switcher.SecurityLevel.Prod, sut.GetTargetType(@"C:\Dev\ProductionConfigs\Azure\Deployments\MTEUWest\Build\DeployProperties.proj"));
            Assert.AreEqual(Switcher.SecurityLevel.Uat, sut.GetTargetType(@"C:\Dev\ProductionConfigs\Azure\Deployments\MTEUWestUAT\Build\DeployProperties.proj"));
            Assert.AreEqual(Switcher.SecurityLevel.Prod, sut.GetTargetType(@"C:\Dev\ProductionConfigs\Azure\Deployments\MTHK\Build\DeployProperties.proj"));
            Assert.AreEqual(Switcher.SecurityLevel.Uat, sut.GetTargetType(@"C:\Dev\ProductionConfigs\Azure\Deployments\MTHKUAT\Build\DeployProperties.proj"));
            Assert.AreEqual(Switcher.SecurityLevel.Uat, sut.GetTargetType(@"C:\Dev\ProductionConfigs\Azure\Deployments\MTSEAsiaUAT\Build\DeployProperties.proj"));
            Assert.AreEqual(Switcher.SecurityLevel.Dev, sut.GetTargetType(@"C:\Dev\ProductionConfigs\Azure\Deployments\MTUSWestDEV\Build\DeployProperties.proj"));
            Assert.AreEqual(Switcher.SecurityLevel.Dev, sut.GetTargetType(@"C:\Dev\ProductionConfigs\Azure\Deployments\MTUSWestDemo\Build\DeployProperties.proj"));
            Assert.AreEqual(Switcher.SecurityLevel.Dev, sut.GetTargetType(@"C:\Dev\ProductionConfigs\Azure\Deployments\MerlotDev\Build\DeployProperties.proj"));
            Assert.AreEqual(Switcher.SecurityLevel.Prod, sut.GetTargetType(@"C:\Dev\ProductionConfigs\Azure\Deployments\Multi\Build\DeployProperties.proj"));
            Assert.AreEqual(Switcher.SecurityLevel.Prod, sut.GetTargetType(@"C:\Dev\ProductionConfigs\Azure\Deployments\PROD_RS\Build\DeployProperties.proj"));
            Assert.AreEqual(Switcher.SecurityLevel.Prod, sut.GetTargetType(@"C:\Dev\ProductionConfigs\Azure\Deployments\Prod_MTUSE\Build\DeployProperties.proj"));
            Assert.AreEqual(Switcher.SecurityLevel.Prod, sut.GetTargetType(@"C:\Dev\ProductionConfigs\Azure\Deployments\Prod_MTUSW1\Build\DeployProperties.proj"));
            Assert.AreEqual(Switcher.SecurityLevel.Ignore, sut.GetTargetType(@"C:\Dev\ProductionConfigs\Azure\Deployments\Template_6.0\Build\DeployProperties.proj"));
            Assert.AreEqual(Switcher.SecurityLevel.Ignore, sut.GetTargetType(@"C:\Dev\ProductionConfigs\Azure\Deployments\Template_6.1\Build\DeployProperties.proj"));
            Assert.AreEqual(Switcher.SecurityLevel.Ignore, sut.GetTargetType(@"C:\Dev\ProductionConfigs\Azure\Deployments\Template_6.1.HF3\Build\DeployProperties.proj"));
            Assert.AreEqual(Switcher.SecurityLevel.Ignore, sut.GetTargetType(@"C:\Dev\ProductionConfigs\Azure\Deployments\Template_6.1.HF4\Build\DeployProperties.proj"));
            Assert.AreEqual(Switcher.SecurityLevel.Ignore, sut.GetTargetType(@"C:\Dev\ProductionConfigs\Azure\Deployments\Template_6.2\Build\DeployProperties.proj"));
            Assert.AreEqual(Switcher.SecurityLevel.Ignore, sut.GetTargetType(@"C:\Dev\ProductionConfigs\Azure\Deployments\Template_6.2.1\Build\DeployProperties.proj"));
            Assert.AreEqual(Switcher.SecurityLevel.Ignore, sut.GetTargetType(@"C:\Dev\ProductionConfigs\Azure\Deployments\Template_6.2.2\Build\DeployProperties.proj"));
            Assert.AreEqual(Switcher.SecurityLevel.Ignore, sut.GetTargetType(@"C:\Dev\ProductionConfigs\Azure\Deployments\Template_6.3.1\Build\DeployProperties.proj"));
            Assert.AreEqual(Switcher.SecurityLevel.Uat, sut.GetTargetType(@"C:\Dev\ProductionConfigs\Azure\Deployments\UAT_MTUSC_Payroll\Build\DeployProperties.proj"));
            Assert.AreEqual(Switcher.SecurityLevel.Uat, sut.GetTargetType(@"C:\Dev\ProductionConfigs\Azure\Deployments\UAT_MTUSE\Build\DeployProperties.proj"));
            Assert.AreEqual(Switcher.SecurityLevel.Uat, sut.GetTargetType(@"C:\Dev\ProductionConfigs\Azure\Deployments\UAT_MTUSW1\Build\DeployProperties.proj"));
            Assert.AreEqual(Switcher.SecurityLevel.Uat, sut.GetTargetType(@"C:\Dev\ProductionConfigs\Azure\Deployments\UAT_RS\Build\DeployProperties.proj"));
            Assert.AreEqual(Switcher.SecurityLevel.Dev, sut.GetTargetType(@"C:\Dev\ProductionConfigs\Azure\Deployments\USDemo\Build\DeployProperties.proj"));
            Assert.AreEqual(Switcher.SecurityLevel.Dev, sut.GetTargetType(@"C:\Dev\ProductionConfigs\Azure\Deployments\USWMerlotDev\Build\DeployProperties.proj"));
            Assert.AreEqual(Switcher.SecurityLevel.Dev, sut.GetTargetType(@"C:\Dev\ProductionConfigs\Production\Deployments\Demo\Build\DeployProperties.proj"));
            Assert.AreEqual(Switcher.SecurityLevel.Prod, sut.GetTargetType(@"C:\Dev\ProductionConfigs\Production\Deployments\G4\Build\DeployProperties.proj"));
            Assert.AreEqual(Switcher.SecurityLevel.Prod, sut.GetTargetType(@"C:\Dev\ProductionConfigs\Production\Deployments\SJ\Build\DeployProperties.proj"));
            Assert.AreEqual(Switcher.SecurityLevel.Prod, sut.GetTargetType(@"C:\Dev\ProductionConfigs\Production\Deployments\WS\Build\DeployProperties.proj"));
            Assert.AreEqual(Switcher.SecurityLevel.Uat, sut.GetTargetType(@"C:\Dev\ProductionConfigs\Production\Deployments\WSUAT\Build\DeployProperties.proj"));
            Assert.AreEqual(Switcher.SecurityLevel.Prod, sut.GetTargetType(@"C:\Dev\ProductionConfigs\Production\Deployments\XX\Build\DeployProperties.proj"));
            Assert.AreEqual(Switcher.SecurityLevel.Prod, sut.GetTargetType(@"C:\Dev\ProductionConfigs\Production\Deployments\XY\Build\DeployProperties.proj"));
            Assert.AreEqual(Switcher.SecurityLevel.Dev, sut.GetTargetType(@"C:\Dev\ProductionConfigs\Test\Deployments\MerlotDev\Build\DeployProperties.proj"));
            Assert.AreEqual(Switcher.SecurityLevel.Dev, sut.GetTargetType(@"C:\Dev\ProductionConfigs\Test\Deployments\Test1\Build\DeployProperties.proj"));
            Assert.AreEqual(Switcher.SecurityLevel.Dev, sut.GetTargetType(@"C:\Dev\ProductionConfigs\Test\Deployments\Test2\Build\DeployProperties.proj"));
            Assert.AreEqual(Switcher.SecurityLevel.Dev, sut.GetTargetType(@"C:\Dev\ProductionConfigs\Test\Deployments\Test3\Build\DeployProperties.proj"));
            Assert.AreEqual(Switcher.SecurityLevel.Dev, sut.GetTargetType(@"C:\Dev\ProductionConfigs\Test\Deployments\feature\Build\DeployProperties.proj"));
            Assert.AreEqual(Switcher.SecurityLevel.Dev, sut.GetTargetType(@"C:\Dev\ProductionConfigs\Test\Deployments\trunk\Build\DeployProperties.proj"));
        }

        [TestMethod]
        public void TestMethod2()
        {
            string current =
              "<Project xmlns=\"http://schemas.microsoft.com/developer/msbuild/2003\"><!-- This file holds the settings for the Azure Publication (used by AzureDeploy.proj). --><PropertyGroup><subscriptionId>07e80c50-7275-4635-95e7-012471a27d57</subscriptionId></PropertyGroup></Project>";
            var sut = new Switcher();
            string actual = sut.AddTargetIfMissing(current, "Azure");
            var rootElement = XElement.Parse(actual);
            XNamespace ns = rootElement.GetDefaultNamespace();
            var groupElement = rootElement.Element(ns + "PropertyGroup");
            Assert.IsNotNull(groupElement);
            var targetElement = groupElement.Element(ns + "target");
            Assert.IsNotNull(targetElement);
            Assert.AreEqual("Azure", targetElement.Value);
            Assert.IsTrue(actual.Contains("<target>Azure</target>"));

            actual = sut.AddTargetIfMissing(actual, "Test");
            rootElement = XElement.Parse(actual);
            ns = rootElement.GetDefaultNamespace();
            groupElement = rootElement.Element(ns + "PropertyGroup");
            Assert.IsNotNull(groupElement);
            var descendants = groupElement.Descendants(ns + "target").ToArray();
            Assert.IsNotNull(descendants);
            Assert.AreEqual(1, descendants.Count());
            Assert.AreEqual("Azure", descendants.First().Value);
            Assert.IsTrue(actual.Contains("<target>Azure</target>"));
        }
    }
}
