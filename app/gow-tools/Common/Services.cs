using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.Diagnostics;
using System.Globalization;


namespace gow.tools.Common
    {
    public class Services
        {

        public enum AssemblyInfo
            {
            Version,
            Title,
            Company
            }

        public static string GetVersion(AssemblyInfo info)
            {
            Assembly assembly = Assembly.GetExecutingAssembly();
            FileVersionInfo fvi = FileVersionInfo.GetVersionInfo(assembly.Location);
            try
                {
                switch (info)
                    {
                    case AssemblyInfo.Title:
                        return fvi.ProductName;
                    case AssemblyInfo.Version:

                        int major = fvi.FileMajorPart;
                        int minor = fvi.FileMinorPart;
                        int rev = fvi.FileBuildPart;

                        string version =
                            major.ToString(CultureInfo.InvariantCulture) + "." +
                            minor.ToString(CultureInfo.InvariantCulture) + "." +
                            rev.ToString(CultureInfo.InvariantCulture);
                        return version;

                    case AssemblyInfo.Company:
                        return fvi.CompanyName;
                    }
                }
            catch (Exception)
                {
                return null;
                }
            return null;
            }

        public static bool IsVersion(string[] args)
            {
            foreach (string txt in args)
                {
                switch (txt)
                    {
                    case "-v":
                        return true;
                    case "-version":
                        return true;
                    }
                }
            return false;
            }

        }
    }
