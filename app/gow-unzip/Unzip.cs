using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using gow.tools.Common;
using gow.tools.Unzip;


namespace gow.unzip
    {
    class Unzip
        {
        static void Main(string[] args)
            {

            Extract extract = new Extract();
            Arguments arguments = new Arguments(args);

            extract.ExtractFile(args[0]);

            }


        }
    }
