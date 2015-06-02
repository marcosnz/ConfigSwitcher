using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ConfigSwitcher.Test
{
    [TestClass]
    public class TestSwitcher
    {
        [TestMethod]
        public void TestMethod1()
        {
            var sut = new Switcher();
            Assert.AreEqual(SecurityContext.Dev, sut.GetTargetType(@"C:\Temp\ProductionConfigs\Azure\Deployments\AKDEV\Build\DeployProperties.proj"));
            Assert.AreEqual(SecurityContext.Dev, sut.GetTargetType(@"C:\Temp\ProductionConfigs\Azure\Deployments\AKDEVPayroll\Build\DeployProperties.proj"));
            Assert.AreEqual(SecurityContext.Dev, sut.GetTargetType(@"C:\Temp\ProductionConfigs\Azure\Deployments\AKDEVReports\Build\DeployProperties.proj"));
            Assert.AreEqual(SecurityContext.Dev, sut.GetTargetType(@"C:\Temp\ProductionConfigs\Azure\Deployments\APDemo\Build\DeployProperties.proj"));
            Assert.AreEqual(SecurityContext.Dev, sut.GetTargetType(@"C:\Temp\ProductionConfigs\Azure\Deployments\APDemoLion\Build\DeployProperties.proj"));
            Assert.AreEqual(SecurityContext.Dev, sut.GetTargetType(@"C:\Temp\ProductionConfigs\Azure\Deployments\AUDemo\Build\DeployProperties.proj"));
            Assert.AreEqual(SecurityContext.Prod, sut.GetTargetType(@"C:\Temp\ProductionConfigs\Azure\Deployments\AirAsia\Build\DeployProperties.proj"));
            Assert.AreEqual(SecurityContext.Prod, sut.GetTargetType(@"C:\Temp\ProductionConfigs\Azure\Deployments\AirAsiaAPI\Build\DeployProperties.proj"));
            Assert.AreEqual(SecurityContext.Prod, sut.GetTargetType(@"C:\Temp\ProductionConfigs\Azure\Deployments\AirAsiaDR\Build\DeployProperties.proj"));
            Assert.AreEqual(SecurityContext.Prod, sut.GetTargetType(@"C:\Temp\ProductionConfigs\Azure\Deployments\AirAsiaDRAPI\Build\DeployProperties.proj"));
            Assert.AreEqual(SecurityContext.Prod, sut.GetTargetType(@"C:\Temp\ProductionConfigs\Azure\Deployments\AirAsiaOptimiser\Build\DeployProperties.proj"));
            Assert.AreEqual(SecurityContext.Prod, sut.GetTargetType(@"C:\Temp\ProductionConfigs\Azure\Deployments\AirAsiaReports\Build\DeployProperties.proj"));
            Assert.AreEqual(SecurityContext.Uat, sut.GetTargetType(@"C:\Temp\ProductionConfigs\Azure\Deployments\AirAsiaUAT\Build\DeployProperties.proj"));
            Assert.AreEqual(SecurityContext.Dev, sut.GetTargetType(@"C:\Temp\ProductionConfigs\Azure\Deployments\EUWestDemo\Build\DeployProperties.proj"));
            Assert.AreEqual(SecurityContext.Prod, sut.GetTargetType(@"C:\Temp\ProductionConfigs\Azure\Deployments\MTEUWest\Build\DeployProperties.proj"));
            Assert.AreEqual(SecurityContext.Uat, sut.GetTargetType(@"C:\Temp\ProductionConfigs\Azure\Deployments\MTEUWestUAT\Build\DeployProperties.proj"));
            Assert.AreEqual(SecurityContext.Prod, sut.GetTargetType(@"C:\Temp\ProductionConfigs\Azure\Deployments\MTHK\Build\DeployProperties.proj"));
            Assert.AreEqual(SecurityContext.Uat, sut.GetTargetType(@"C:\Temp\ProductionConfigs\Azure\Deployments\MTHKUAT\Build\DeployProperties.proj"));
            Assert.AreEqual(SecurityContext.Uat, sut.GetTargetType(@"C:\Temp\ProductionConfigs\Azure\Deployments\MTSEAsiaUAT\Build\DeployProperties.proj"));
            Assert.AreEqual(SecurityContext.Dev, sut.GetTargetType(@"C:\Temp\ProductionConfigs\Azure\Deployments\MTUSWestDEV\Build\DeployProperties.proj"));
            Assert.AreEqual(SecurityContext.Dev, sut.GetTargetType(@"C:\Temp\ProductionConfigs\Azure\Deployments\MTUSWestDemo\Build\DeployProperties.proj"));
            Assert.AreEqual(SecurityContext.Dev, sut.GetTargetType(@"C:\Temp\ProductionConfigs\Azure\Deployments\MerlotDev\Build\DeployProperties.proj"));
            Assert.AreEqual(SecurityContext.Prod, sut.GetTargetType(@"C:\Temp\ProductionConfigs\Azure\Deployments\Multi\Build\DeployProperties.proj"));
            Assert.AreEqual(SecurityContext.Prod, sut.GetTargetType(@"C:\Temp\ProductionConfigs\Azure\Deployments\PROD_RS\Build\DeployProperties.proj"));
            Assert.AreEqual(SecurityContext.Prod, sut.GetTargetType(@"C:\Temp\ProductionConfigs\Azure\Deployments\Prod_MTUSE\Build\DeployProperties.proj"));
            Assert.AreEqual(SecurityContext.Prod, sut.GetTargetType(@"C:\Temp\ProductionConfigs\Azure\Deployments\Prod_MTUSW1\Build\DeployProperties.proj"));
            Assert.AreEqual(SecurityContext.Ignore, sut.GetTargetType(@"C:\Temp\ProductionConfigs\Azure\Deployments\Template_6.0\Build\DeployProperties.proj"));
            Assert.AreEqual(SecurityContext.Ignore, sut.GetTargetType(@"C:\Temp\ProductionConfigs\Azure\Deployments\Template_6.1\Build\DeployProperties.proj"));
            Assert.AreEqual(SecurityContext.Ignore, sut.GetTargetType(@"C:\Temp\ProductionConfigs\Azure\Deployments\Template_6.1.HF3\Build\DeployProperties.proj"));
            Assert.AreEqual(SecurityContext.Ignore, sut.GetTargetType(@"C:\Temp\ProductionConfigs\Azure\Deployments\Template_6.1.HF4\Build\DeployProperties.proj"));
            Assert.AreEqual(SecurityContext.Ignore, sut.GetTargetType(@"C:\Temp\ProductionConfigs\Azure\Deployments\Template_6.2\Build\DeployProperties.proj"));
            Assert.AreEqual(SecurityContext.Ignore, sut.GetTargetType(@"C:\Temp\ProductionConfigs\Azure\Deployments\Template_6.2.1\Build\DeployProperties.proj"));
            Assert.AreEqual(SecurityContext.Ignore, sut.GetTargetType(@"C:\Temp\ProductionConfigs\Azure\Deployments\Template_6.2.2\Build\DeployProperties.proj"));
            Assert.AreEqual(SecurityContext.Ignore, sut.GetTargetType(@"C:\Temp\ProductionConfigs\Azure\Deployments\Template_6.3.1\Build\DeployProperties.proj"));
            Assert.AreEqual(SecurityContext.Uat, sut.GetTargetType(@"C:\Temp\ProductionConfigs\Azure\Deployments\UAT_MTUSC_Payroll\Build\DeployProperties.proj"));
            Assert.AreEqual(SecurityContext.Uat, sut.GetTargetType(@"C:\Temp\ProductionConfigs\Azure\Deployments\UAT_MTUSE\Build\DeployProperties.proj"));
            Assert.AreEqual(SecurityContext.Uat, sut.GetTargetType(@"C:\Temp\ProductionConfigs\Azure\Deployments\UAT_MTUSW1\Build\DeployProperties.proj"));
            Assert.AreEqual(SecurityContext.Uat, sut.GetTargetType(@"C:\Temp\ProductionConfigs\Azure\Deployments\UAT_RS\Build\DeployProperties.proj"));
            Assert.AreEqual(SecurityContext.Dev, sut.GetTargetType(@"C:\Temp\ProductionConfigs\Azure\Deployments\USDemo\Build\DeployProperties.proj"));
            Assert.AreEqual(SecurityContext.Dev, sut.GetTargetType(@"C:\Temp\ProductionConfigs\Azure\Deployments\USWMerlotDev\Build\DeployProperties.proj"));
            Assert.AreEqual(SecurityContext.Dev, sut.GetTargetType(@"C:\Temp\ProductionConfigs\Production\Deployments\Demo\Build\DeployProperties.proj"));
            Assert.AreEqual(SecurityContext.Prod, sut.GetTargetType(@"C:\Temp\ProductionConfigs\Production\Deployments\G4\Build\DeployProperties.proj"));
            Assert.AreEqual(SecurityContext.Prod, sut.GetTargetType(@"C:\Temp\ProductionConfigs\Production\Deployments\SJ\Build\DeployProperties.proj"));
            Assert.AreEqual(SecurityContext.Prod, sut.GetTargetType(@"C:\Temp\ProductionConfigs\Production\Deployments\WS\Build\DeployProperties.proj"));
            Assert.AreEqual(SecurityContext.Ignore, sut.GetTargetType(@"C:\Temp\ProductionConfigs\Production\Deployments\WSUAT\Build\DeployProperties.proj"));
            Assert.AreEqual(SecurityContext.Prod, sut.GetTargetType(@"C:\Temp\ProductionConfigs\Production\Deployments\XX\Build\DeployProperties.proj"));
            Assert.AreEqual(SecurityContext.Prod, sut.GetTargetType(@"C:\Temp\ProductionConfigs\Production\Deployments\XY\Build\DeployProperties.proj"));
            Assert.AreEqual(SecurityContext.Dev, sut.GetTargetType(@"C:\Temp\ProductionConfigs\Test\Deployments\MerlotDev\Build\DeployProperties.proj"));
            Assert.AreEqual(SecurityContext.Dev, sut.GetTargetType(@"C:\Temp\ProductionConfigs\Test\Deployments\Test1\Build\DeployProperties.proj"));
            Assert.AreEqual(SecurityContext.Dev, sut.GetTargetType(@"C:\Temp\ProductionConfigs\Test\Deployments\Test2\Build\DeployProperties.proj"));
            Assert.AreEqual(SecurityContext.Dev, sut.GetTargetType(@"C:\Temp\ProductionConfigs\Test\Deployments\Test3\Build\DeployProperties.proj"));
            Assert.AreEqual(SecurityContext.Dev, sut.GetTargetType(@"C:\Temp\ProductionConfigs\Test\Deployments\feature\Build\DeployProperties.proj"));
            Assert.AreEqual(SecurityContext.Dev, sut.GetTargetType(@"C:\Temp\ProductionConfigs\Test\Deployments\trunk\Build\DeployProperties.proj"));
        }

        [TestMethod]
        public void TestMethod2()
        {
            string current =
              "<Project xmlns=\"http://schemas.microsoft.com/developer/msbuild/2003\"><!-- This file holds the settings for the Azure Publication (used by AzureDeploy.proj). --><PropertyGroup><subscriptionId>07e80c50-7275-4635-95e7-012471a27d57</subscriptionId></PropertyGroup></Project>";
            var sut = new Switcher();
            string actual = sut.AddTargetIfMissing(current, "Azure");
            Assert.IsTrue(actual.Contains("<target>Azure</target>"));
        }

        private static void TestFriendlyName(string expected, string identifier)
        {
            var sut = new Switcher();
            Assert.AreEqual(expected, sut.GetFriendlyName(identifier), identifier);
        }
        [TestMethod]
        public void TestMethod3()
        {
            TestFriendlyName("Air Asia Dev", "AKDEV");
            TestFriendlyName("Air Asia Dev Payroll", "AKDEVPayroll");
            TestFriendlyName("Air Asia Dev Reports", "AKDEVReports");
            TestFriendlyName("SE Asia Demo", "APDemo");
            TestFriendlyName("SE Asia Demo Lion", "APDemoLion");
            TestFriendlyName("Australia Demo", "AUDemo");
            TestFriendlyName("Air Asia", "AirAsia");
            TestFriendlyName("Air Asia API", "AirAsiaAPI");
            TestFriendlyName("Air Asia DR", "AirAsiaDR");
            TestFriendlyName("Air Asia DR API", "AirAsiaDRAPI");
            TestFriendlyName("Air Asia Optimiser", "AirAsiaOptimiser");
            TestFriendlyName("Air Asia Reports", "AirAsiaReports");
            TestFriendlyName("Air Asia UAT", "AirAsiaUAT");
            TestFriendlyName("EU West Demo", "EUWestDemo");
            TestFriendlyName("EU West MT", "MTEUWest");
            TestFriendlyName("EU West UAT", "MTEUWestUAT");
            TestFriendlyName("Hong Kong MT", "MTHK");
            TestFriendlyName("Hong Kong UAT", "MTHKUAT");
            TestFriendlyName("SE Asia UAT", "MTSEAsiaUAT");
            TestFriendlyName("US West Dev", "MTUSWestDEV");
            TestFriendlyName("US West Demo", "MTUSWestDemo");
            TestFriendlyName("SE Asia Dev", "MerlotDev");
            TestFriendlyName("SE Asia MT", "Multi");
            TestFriendlyName("RS Sky Regional", "PROD_RS");
            TestFriendlyName("US East MT", "Prod_MTUSE");
            TestFriendlyName("US West MT", "Prod_MTUSW1");
            TestFriendlyName("Not Used", "Template_6.0");
            TestFriendlyName("Not Used", "Template_6.1");
            TestFriendlyName("Not Used", "Template_6.1.HF3");
            TestFriendlyName("Not Used", "Template_6.1.HF4");
            TestFriendlyName("Not Used", "Template_6.2");
            TestFriendlyName("Not Used", "Template_6.2.1");
            TestFriendlyName("Not Used", "Template_6.2.2");
            TestFriendlyName("Not Used", "Template_6.3.1");
            TestFriendlyName("US Central UAT Payroll", "UAT_MTUSC_Payroll");
            TestFriendlyName("US East UAT", "UAT_MTUSE");
            TestFriendlyName("US West UAT", "UAT_MTUSW1");
            TestFriendlyName("Not Used", "UAT_RS");
            TestFriendlyName("Not Used", "USDemo");
            TestFriendlyName("US West Dev", "USWMerlotDev");
            TestFriendlyName("Demo Self Hosted", "Demo");
            TestFriendlyName("G4 Allegiant", "G4");
            TestFriendlyName("SJ Sriwijaya", "SJ");
            TestFriendlyName("WS Westjet", "WS");
            TestFriendlyName("Not Used", "WSUAT");
            TestFriendlyName("ZL(XX) Regional Express", "XX");
            TestFriendlyName("XY Nas Air", "XY");
            TestFriendlyName("Test IIS Test1", "Test1");
            TestFriendlyName("Test IIS Test2", "Test2");
            TestFriendlyName("Test IIS Test3", "Test3");
            TestFriendlyName("Test IIS feature", "feature");
            TestFriendlyName("Test IIS trunk", "trunk");
        }
    }
}
