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
      Assert.AreEqual(SecurityContext.Uat, sut.GetTargetType(@"C:\Temp\ProductionConfigs\Production\Deployments\WSUAT\Build\DeployProperties.proj"));
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

    [TestMethod]
    public void TestMethod3()
    {
      var sut = new Switcher();
      Assert.AreEqual("AK Dev", sut.GetFriendlyName(@"C:\Temp\ProductionConfigs\Azure\Deployments\AKDEV\Build\DeployProperties.proj"));
      Assert.AreEqual("AK Dev Payroll", sut.GetFriendlyName(@"C:\Temp\ProductionConfigs\Azure\Deployments\AKDEVPayroll\Build\DeployProperties.proj"));
      Assert.AreEqual("AK Dev Reports", sut.GetFriendlyName(@"C:\Temp\ProductionConfigs\Azure\Deployments\AKDEVReports\Build\DeployProperties.proj"));
      Assert.AreEqual("Asia Pacific Demo", sut.GetFriendlyName(@"C:\Temp\ProductionConfigs\Azure\Deployments\APDemo\Build\DeployProperties.proj"));
      Assert.AreEqual("Asia Pacific Demo Lion", sut.GetFriendlyName(@"C:\Temp\ProductionConfigs\Azure\Deployments\APDemoLion\Build\DeployProperties.proj"));
      Assert.AreEqual("Australia Demo", sut.GetFriendlyName(@"C:\Temp\ProductionConfigs\Azure\Deployments\AUDemo\Build\DeployProperties.proj"));
      Assert.AreEqual("Air Asia", sut.GetFriendlyName(@"C:\Temp\ProductionConfigs\Azure\Deployments\AirAsia\Build\DeployProperties.proj"));
      Assert.AreEqual("Air Asia API", sut.GetFriendlyName(@"C:\Temp\ProductionConfigs\Azure\Deployments\AirAsiaAPI\Build\DeployProperties.proj"));
      Assert.AreEqual("Air Asia DR", sut.GetFriendlyName(@"C:\Temp\ProductionConfigs\Azure\Deployments\AirAsiaDR\Build\DeployProperties.proj"));
      Assert.AreEqual("Air Asia DR API", sut.GetFriendlyName(@"C:\Temp\ProductionConfigs\Azure\Deployments\AirAsiaDRAPI\Build\DeployProperties.proj"));
      Assert.AreEqual("Air Asia Optimiser", sut.GetFriendlyName(@"C:\Temp\ProductionConfigs\Azure\Deployments\AirAsiaOptimiser\Build\DeployProperties.proj"));
      Assert.AreEqual("Air Asia Reports", sut.GetFriendlyName(@"C:\Temp\ProductionConfigs\Azure\Deployments\AirAsiaReports\Build\DeployProperties.proj"));
      Assert.AreEqual("Air Asia UAT", sut.GetFriendlyName(@"C:\Temp\ProductionConfigs\Azure\Deployments\AirAsiaUAT\Build\DeployProperties.proj"));
      Assert.AreEqual("EU West Demo", sut.GetFriendlyName(@"C:\Temp\ProductionConfigs\Azure\Deployments\EUWestDemo\Build\DeployProperties.proj"));
      Assert.AreEqual("EU West MT", sut.GetFriendlyName(@"C:\Temp\ProductionConfigs\Azure\Deployments\MTEUWest\Build\DeployProperties.proj"));
      Assert.AreEqual("EU West UAT", sut.GetFriendlyName(@"C:\Temp\ProductionConfigs\Azure\Deployments\MTEUWestUAT\Build\DeployProperties.proj"));
      Assert.AreEqual("Hong Kong MT", sut.GetFriendlyName(@"C:\Temp\ProductionConfigs\Azure\Deployments\MTHK\Build\DeployProperties.proj"));
      Assert.AreEqual("Hong Kong UAT", sut.GetFriendlyName(@"C:\Temp\ProductionConfigs\Azure\Deployments\MTHKUAT\Build\DeployProperties.proj"));
      Assert.AreEqual("", sut.GetFriendlyName(@"C:\Temp\ProductionConfigs\Azure\Deployments\MTSEAsiaUAT\Build\DeployProperties.proj"));
      Assert.AreEqual("", sut.GetFriendlyName(@"C:\Temp\ProductionConfigs\Azure\Deployments\MTUSWestDEV\Build\DeployProperties.proj"));
      Assert.AreEqual("", sut.GetFriendlyName(@"C:\Temp\ProductionConfigs\Azure\Deployments\MTUSWestDemo\Build\DeployProperties.proj"));
      Assert.AreEqual("", sut.GetFriendlyName(@"C:\Temp\ProductionConfigs\Azure\Deployments\MerlotDev\Build\DeployProperties.proj"));
      Assert.AreEqual("", sut.GetFriendlyName(@"C:\Temp\ProductionConfigs\Azure\Deployments\Multi\Build\DeployProperties.proj"));
      Assert.AreEqual("", sut.GetFriendlyName(@"C:\Temp\ProductionConfigs\Azure\Deployments\PROD_RS\Build\DeployProperties.proj"));
      Assert.AreEqual("", sut.GetFriendlyName(@"C:\Temp\ProductionConfigs\Azure\Deployments\Prod_MTUSE\Build\DeployProperties.proj"));
      Assert.AreEqual("", sut.GetFriendlyName(@"C:\Temp\ProductionConfigs\Azure\Deployments\Prod_MTUSW1\Build\DeployProperties.proj"));
      Assert.AreEqual("Not Used", sut.GetFriendlyName(@"C:\Temp\ProductionConfigs\Azure\Deployments\Template_6.0\Build\DeployProperties.proj"));
      Assert.AreEqual("Not Used", sut.GetFriendlyName(@"C:\Temp\ProductionConfigs\Azure\Deployments\Template_6.1\Build\DeployProperties.proj"));
      Assert.AreEqual("Not Used", sut.GetFriendlyName(@"C:\Temp\ProductionConfigs\Azure\Deployments\Template_6.1.HF3\Build\DeployProperties.proj"));
      Assert.AreEqual("Not Used", sut.GetFriendlyName(@"C:\Temp\ProductionConfigs\Azure\Deployments\Template_6.1.HF4\Build\DeployProperties.proj"));
      Assert.AreEqual("Not Used", sut.GetFriendlyName(@"C:\Temp\ProductionConfigs\Azure\Deployments\Template_6.2\Build\DeployProperties.proj"));
      Assert.AreEqual("Not Used", sut.GetFriendlyName(@"C:\Temp\ProductionConfigs\Azure\Deployments\Template_6.2.1\Build\DeployProperties.proj"));
      Assert.AreEqual("Not Used", sut.GetFriendlyName(@"C:\Temp\ProductionConfigs\Azure\Deployments\Template_6.2.2\Build\DeployProperties.proj"));
      Assert.AreEqual("Not Used", sut.GetFriendlyName(@"C:\Temp\ProductionConfigs\Azure\Deployments\Template_6.3.1\Build\DeployProperties.proj"));
      Assert.AreEqual("", sut.GetFriendlyName(@"C:\Temp\ProductionConfigs\Azure\Deployments\UAT_MTUSC_Payroll\Build\DeployProperties.proj"));
      Assert.AreEqual("", sut.GetFriendlyName(@"C:\Temp\ProductionConfigs\Azure\Deployments\UAT_MTUSE\Build\DeployProperties.proj"));
      Assert.AreEqual("", sut.GetFriendlyName(@"C:\Temp\ProductionConfigs\Azure\Deployments\UAT_MTUSW1\Build\DeployProperties.proj"));
      Assert.AreEqual("", sut.GetFriendlyName(@"C:\Temp\ProductionConfigs\Azure\Deployments\UAT_RS\Build\DeployProperties.proj"));
      Assert.AreEqual("", sut.GetFriendlyName(@"C:\Temp\ProductionConfigs\Azure\Deployments\USDemo\Build\DeployProperties.proj"));
      Assert.AreEqual("", sut.GetFriendlyName(@"C:\Temp\ProductionConfigs\Azure\Deployments\USWMerlotDev\Build\DeployProperties.proj"));
      Assert.AreEqual("", sut.GetFriendlyName(@"C:\Temp\ProductionConfigs\Production\Deployments\Demo\Build\DeployProperties.proj"));
      Assert.AreEqual("", sut.GetFriendlyName(@"C:\Temp\ProductionConfigs\Production\Deployments\G4\Build\DeployProperties.proj"));
      Assert.AreEqual("", sut.GetFriendlyName(@"C:\Temp\ProductionConfigs\Production\Deployments\SJ\Build\DeployProperties.proj"));
      Assert.AreEqual("", sut.GetFriendlyName(@"C:\Temp\ProductionConfigs\Production\Deployments\WS\Build\DeployProperties.proj"));
      Assert.AreEqual("", sut.GetFriendlyName(@"C:\Temp\ProductionConfigs\Production\Deployments\WSUAT\Build\DeployProperties.proj"));
      Assert.AreEqual("", sut.GetFriendlyName(@"C:\Temp\ProductionConfigs\Production\Deployments\XX\Build\DeployProperties.proj"));
      Assert.AreEqual("", sut.GetFriendlyName(@"C:\Temp\ProductionConfigs\Production\Deployments\XY\Build\DeployProperties.proj"));
      Assert.AreEqual("", sut.GetFriendlyName(@"C:\Temp\ProductionConfigs\Test\Deployments\MerlotDev\Build\DeployProperties.proj"));
      Assert.AreEqual("", sut.GetFriendlyName(@"C:\Temp\ProductionConfigs\Test\Deployments\Test1\Build\DeployProperties.proj"));
      Assert.AreEqual("", sut.GetFriendlyName(@"C:\Temp\ProductionConfigs\Test\Deployments\Test2\Build\DeployProperties.proj"));
      Assert.AreEqual("", sut.GetFriendlyName(@"C:\Temp\ProductionConfigs\Test\Deployments\Test3\Build\DeployProperties.proj"));
      Assert.AreEqual("", sut.GetFriendlyName(@"C:\Temp\ProductionConfigs\Test\Deployments\feature\Build\DeployProperties.proj"));
      Assert.AreEqual("", sut.GetFriendlyName(@"C:\Temp\ProductionConfigs\Test\Deployments\trunk\Build\DeployProperties.proj"));
    }
  }
}
