using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;


namespace gow.unzip
    {
    class Unzip
        {
        static void Main(string[] args)
            {

            string startPath = @"c:\example\start";
            string zipPath = @"c:\example\result.zip";
            string extractPath = @"c:\example\extract";

            System.IO.Compression.ZipFile.CreateFromDirectory(startPath, zipPath);
            System.IO.Compression.ZipFile.ExtractToDirectory(zipPath, extractPath);

            }
        }
    }
