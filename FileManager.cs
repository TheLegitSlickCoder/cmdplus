using System;
using System.IO;

namespace cmd_
{
    class FileManager
    {
        //Create File:
        public void createFile(string path)
        {
            File.Create(path);
        }

        //Check Path:
        public bool pathExists(string path)
        {
            if (File.Exists(path) || Directory.Exists(path))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}