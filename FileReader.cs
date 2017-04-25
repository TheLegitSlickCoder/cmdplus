using System;
using System.IO;

namespace cmd_
{
    class FileReader
    {
        //Read File:
        public string readFile(string path)
        {
            string fileText = "";
            StreamReader sr = new StreamReader(path);

            while (!sr.EndOfStream)
            {
                string line = sr.ReadLine();
                fileText = fileText + line + "\n";
            }

            sr.Dispose();
            return fileText;
        }
    }
}