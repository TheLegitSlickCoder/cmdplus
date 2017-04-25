using System;
using System.IO;

namespace cmd_
{
    class DirectoryManager
    {
        //Get Contents:
        public string[] getFiles(string path)
        {
            string[] files = Directory.GetFiles(path);
            return files;
        }

        //Get Directories:
        public string[] getDirectories(string path)
        {
            string[] dirs = Directory.GetDirectories(path);
            return dirs;
        }
    }
}