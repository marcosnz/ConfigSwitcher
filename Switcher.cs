using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConfigSwitcher
{
  public class Switcher
  {
    public enum TargetType
    {
      Dev,
      UAT,
      Prod,
      Ignore
    }
    static void Main(string[] args)
    {
      var prog = new Switcher();
      prog.Switch("AKDEV");
    }

    public TargetType Switch(string identifier)
    {
      if (identifier.ToUpperInvariant().Contains("DEV") || identifier.Contains("Demo"))
      {
        return TargetType.Dev;
      }

      if (identifier.Contains("UAT"))// || identifier.Contains("Demo"))
      {
        return TargetType.UAT;
      }

      if (identifier.StartsWith("Template"))
      {
        return TargetType.Ignore;
      }

      switch (identifier)
      {
        case "Test1":
        case "Test2":
        case "Test3":
        case "feature":
        case "trunk":
          return TargetType.Dev;
        default:
          return TargetType.Prod;
      }


    }
  }
}
