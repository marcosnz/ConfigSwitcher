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
    public enum TargetType
    {
      Dev,
      UAT,
      Prod,
      Ignore,
      Unknown
    }
    static void Main(string[] args)
    {
      var prog = new Switcher();
      prog.GetTargetType("AKDEV");
    }

    public TargetType GetTargetType(string identifier)
    {

      if (identifier.Contains("\\Template"))
      {
        return TargetType.Ignore;
      }

      if (identifier.Contains("\\AirAsia") || identifier.Contains("\\MT") || identifier.Contains("\\Multi") || identifier.ToLowerInvariant().Contains("\\prod_") || identifier.Contains("\\Production\\"))
      {
        if (!identifier.Contains("UAT") && !identifier.Contains("DEV") && !identifier.Contains("Demo"))
        {
          return TargetType.Prod;
        }
      }

      if (identifier.Contains("UAT"))
      {
        return TargetType.UAT;
      }

      if (identifier.Contains("\\Test\\Deployments") || identifier.ToUpperInvariant().Contains("DEV") || identifier.Contains("Demo"))
      {
        return TargetType.Dev;
      }

      return TargetType.Unknown;
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
  }
}
