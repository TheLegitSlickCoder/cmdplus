using System;
using System.Diagnostics;

namespace cmd_
{
    class Launcher
    {
        //Launch:
        public void launch(string item)
        {
            Process.Start(item);
        }
    }
}