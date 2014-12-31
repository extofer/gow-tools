using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using gow.tools.Unzip;
using gow.tools.Common;

namespace gow_tools_ut
    {
    [TestClass]
    public class UnitTestUnzip
        {
        [TestMethod]
        public void TestMethod1()
            {

            //string args = @"c:\temp\ncat-portable-5.59BETA1.zip";
            Extract extract = new Extract();
            //Arguments arguments = new Arguments(args);

            string zipPath = @"c:\temp\ncat-portable-5.59BETA1.zip";
                                  
            //string extractPath = @"c:\example\extract";

            extract.ExtractFile(zipPath);
                                    
            }
        }
    }
