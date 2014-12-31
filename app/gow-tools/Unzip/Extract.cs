using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace gow.tools.Unzip
    {
    public class Extract
        {
        private string localPath = System.Reflection.Assembly.GetExecutingAssembly().Location;
        
        public void ExtractFile(string zipPath,  string extractPath = "")
            {

            if (extractPath == "")
            {
                extractPath = System.IO.Path.GetDirectoryName(zipPath);;
            }

            System.IO.Compression.ZipFile.ExtractToDirectory(zipPath, extractPath);


            }
        }
    }
