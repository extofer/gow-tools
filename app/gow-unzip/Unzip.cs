using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using gow.tools.Common;
using gow.tools.Unzip;


namespace gow.unzip
    {
    class Unzip : AppVersion
        {
        public override void GetTest()
            {
            throw new NotImplementedException();
            }


        static void Main(string[] args)
            {


            //if (Services.IsVersion(args))
            //    {
            //        Console.WriteLine("\t" + Services.GetVersion(Services.AssemblyInfo.Title) + " version: " + Services.GetVersion(Services.AssemblyInfo.Version));
            //        Console.WriteLine("\t" + Services.GetVersion(Services.AssemblyInfo.Company));
            //        Console.ReadLine();
            //    }

                    Extract extract = new Extract();
                    Arguments arguments = new Arguments(args);

                    extract.ExtractFile(args[0]);


            }

        }
    }
