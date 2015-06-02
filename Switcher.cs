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
        public enum SecurityLevel
        {
            /// <summary>Developer level.</summary>
            Dev,

            /// <summary>UAT level.</summary>
            Uat,

            /// <summary>Production level.</summary>
            Prod,

            /// <summary>Known but ignoring.</summary>
            Ignore,
        }
        static void Main(string[] args)
        {
            var prog = new Switcher();
            prog.GetTargetType("AKDEV");
        }

        public SecurityLevel GetTargetType(string fileName)
        {
            fileName = fileName.ToLowerInvariant();
            fileName = fileName.Replace("\\dev\\", "\\");
            if (fileName.Contains("\\template"))
            {
                return SecurityLevel.Ignore;
            }

            if (fileName.Contains("\\airasia") || fileName.Contains("\\mt") || fileName.Contains("\\multi") || fileName.ToLowerInvariant().Contains("\\prod_") || fileName.Contains("\\production\\"))
            {
                if (!fileName.Contains("uat") && !fileName.Contains("dev") && !fileName.Contains("demo"))
                {
                    return SecurityLevel.Prod;
                }
            }

            if (fileName.Contains("uat"))
            {
                return SecurityLevel.Uat;
            }

            if (fileName.Contains("\\test\\deployments") || fileName.Contains("dev") || fileName.Contains("demo"))
            {
                return SecurityLevel.Dev;
            }

            throw new Exception(string.Format("Unable to determine if this file is DEV/UAT/PROD: '{0}", fileName));
        }

    }
}
