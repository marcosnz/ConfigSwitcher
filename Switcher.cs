using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConfigSwitcher
{
  public class Switcher
  {

    static void Main(string[] args)
    {
      var prog = new Switcher();
      prog.GetTargetType("AKDEV");
    }

    public SecurityContext GetTargetType(string identifier)
    {

      if (identifier.Contains("\\Template"))
      {
        return SecurityContext.Ignore;
      }

      if (identifier.Contains("\\AirAsia") || identifier.Contains("\\MT") || identifier.Contains("\\Multi") || identifier.ToLowerInvariant().Contains("\\prod_") || identifier.Contains("\\Production\\"))
      {
        if (!identifier.Contains("UAT") && !identifier.Contains("DEV") && !identifier.Contains("Demo"))
        {
          return SecurityContext.Prod;
        }
      }

      if (identifier.Contains("UAT"))
      {
        return SecurityContext.Uat;
      }

      if (identifier.Contains("\\Test\\Deployments") || identifier.ToUpperInvariant().Contains("DEV") || identifier.Contains("Demo"))
      {
        return SecurityContext.Dev;
      }

      return SecurityContext.Unknown;
    }

    public string AddTargetIfMissing(string current, string target)
    {
      var rootElement = XElement.Parse(current);
      XNamespace ns = rootElement.GetDefaultNamespace();
      //if (! element.Descendants("target")
      //XNamespace ns = XNamespace.Get("http://schemas.microsoft.com/developer/msbuild/2003");
      var groupElement = rootElement.Element(ns + "PropertyGroup");
      if (groupElement != null)
      {
        groupElement.AddFirst(new XElement(ns + "target", target));
      }
      else
      {
        throw new Exception("PropertyGroup element not found");
      }

      return rootElement.ToString();
    }

    public string GetFriendlyName(string fileName)
    {
      if (fileName.Contains("\\Template"))
      {
        return "Unused";
      }

      if (fileName.Contains("\\AirAsia") || fileName.Contains("\\MT") || fileName.Contains("\\Multi") || fileName.ToLowerInvariant().Contains("\\prod_") || fileName.Contains("\\Production\\"))
      {
        if (!fileName.Contains("UAT") && !fileName.Contains("DEV") && !fileName.Contains("Demo"))
        {
          return SecurityContext.Prod;
        }
      }

      if (fileName.Contains("UAT"))
      {
        return SecurityContext.Uat;
      }

      if (fileName.Contains("\\Test\\Deployments") || fileName.ToUpperInvariant().Contains("DEV") || fileName.Contains("Demo"))
      {
        return SecurityContext.Dev;
      }

      return SecurityContext.Unknown;
    }
  }
}
