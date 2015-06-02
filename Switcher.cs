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

            if (identifier.Contains("\\Template") || identifier.Contains("\\USDemo\\"))
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

        public string GetFriendlyName(string identifier)
        {
            identifier = identifier.Replace("Prod_", string.Empty).Replace("PROD_", string.Empty);
            if (identifier.Contains("Template") || identifier == "USDemo" || identifier == "UAT_RS" || identifier == "WSUAT")
            {
                return "Not Used";
            }

            if (identifier == "Demo")
            {
                return "Demo Self Hosted";
            }

            if (identifier.StartsWith("Test") || identifier == "feature" || identifier == "trunk")
            {
                return "Test IIS " + identifier;
            }

            string name = "unknown";
            if (identifier.Length == 2 || (identifier.Length == 6 && identifier.StartsWith("UAT_")))
            {
                switch (identifier.Replace("UAT_", string.Empty))
                {
                    case "RS":
                        name = "RS Sky Regional";
                        break;
                    case "G4":
                        name = "G4 Allegiant";
                        break;
                    case "SJ":
                        name = "SJ Sriwijaya";
                        break;
                    case "WS":
                        name = "WS Westjet";
                        break;
                    case "XX":
                        name = "ZL(XX) Regional Express";
                        break;
                    case "XY":
                        name = "XY Nas Air";
                        break;
                }

                //return identifier;
            }

            bool ismt = identifier.StartsWith("MT") || identifier == "Multi";
            if (ismt)
            {
                identifier = identifier.Substring(2);
            }

            if (identifier.StartsWith("AirAsia") || identifier.StartsWith("AK"))
            {
                name = "Air Asia";
            }
            else if (identifier.StartsWith("AP") || identifier.StartsWith("SEAsia") || identifier == "MerlotDev" || identifier == "lti")
            {
                name = "SE Asia";
            }
            else if (identifier.StartsWith("HK"))
            {
                name = "Hong Kong";
            }
            else if (identifier.StartsWith("AU"))
            {
                name = "Australia";
            }
            else if (identifier.StartsWith("EU"))
            {
                name = "EU";
                if (identifier.Contains("West"))
                {
                    name += " West";
                }
                else
                {
                    name += " East";
                }
            }
            else if (identifier.StartsWith("US") || identifier.Contains("USC_") || identifier.Contains("USE") || identifier.Contains("USW"))
            {
                name = "US";
                if (identifier.Contains("USC_"))
                {
                    name += " Central";
                }
                else if (identifier.Contains("West") || identifier.Contains("USW") || identifier.Contains("W1") || identifier.Contains("Demo"))
                {
                    name += " West";
                }
                else
                {
                    name += " East";
                }
            }

            name += GetFriendlyNameSuffix(identifier);
            if (ismt && !name.Contains("UAT") && !name.Contains("Dev") && !name.Contains("Demo"))
            {
                name += " MT";
            }
            return name;
        }

        private static string GetFriendlyNameSuffix(string identifier)
        {
            string suffix = string.Empty;
            if (identifier.Contains("UAT"))
            {
                suffix += " UAT";
            }
            else if (identifier.ToUpperInvariant().Contains("DEV"))
            {
                suffix += " Dev";
            }
            else if (identifier.Contains("Demo"))
            {
                suffix += " Demo";
            }

            if (identifier.Contains("Payroll"))
            {
                suffix += " Payroll";
            }
            else if (identifier.Contains("Reports"))
            {
                suffix += " Reports";
            }

            if (identifier.Contains("Lion"))
            {
                suffix += " Lion";
            }

            if (identifier.Contains("DR"))
            {
                suffix += " DR";
            }

            if (identifier.Contains("API"))
            {
                suffix += " API";
            }

            if (identifier.Contains("Optimiser"))
            {
                suffix += " Optimiser";
            }

            return suffix;
        }
    }
}
