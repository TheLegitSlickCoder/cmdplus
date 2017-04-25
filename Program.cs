using System;

namespace cmd_
{
    class Program
    {
        //Argument Variables:
        static string arg1;
        static string arg2;

        //Class Imports:
        static FileReader fr = new FileReader();
        static DirectoryManager dirmng = new DirectoryManager();
        static FileManager fm = new FileManager();
        static Launcher launcher = new Launcher();

        static void Main(string[] args)
        {
            try
            {
                arg1 = args[0];
                arg2 = args[1];
                executeCommand(arg1, arg2);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }

        //Execute Command:
        private static void executeCommand(string arg1, string arg2)
        {
            //Read Command:
            if (arg1 == "read")
            {
                try
                {
                    string fileText = fr.readFile(arg2);
                    Console.WriteLine(fileText);
                    return;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.ToString());
                    return;
                }
            }

            //Contents Command:
            if (arg1 == "contents")
            {
                try
                {
                    string[] files = dirmng.getFiles(arg2);
                    string[] dirs = dirmng.getDirectories(arg2);

                    int f;
                    int d;

                    for (f = 0; f < files.Length; f++)
                    {
                        Console.WriteLine(files[f]);
                    }

                    for (d = 0; d < dirs.Length; d++)
                    {
                        Console.WriteLine(dirs[d]);
                    }

                    return;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.ToString());
                    return;
                }
            }

            //Createfile Command:
            if (arg1 == "createfile")
            {
                try
                {
                    fm.createFile(arg2);
                    return;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.ToString());
                    return;
                }
            }

            //Launch Command:
            if (arg1 == "launch")
            {
                try
                {
                    launcher.launch(arg2);
                    return;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.ToString());
                    return;
                }
            }

            //Checkpath Command:
            if (arg1 == "checkpath")
            {
                if (fm.pathExists(arg2))
                {
                    Console.WriteLine("Path exists: " + arg2);
                    return;
                }

                Console.WriteLine("Path does not exist: " + arg2);
            }

            //Length Command:
            if (arg1 == "length")
            {
                try
                {
                    int length = fr.readFile(arg2).Length;
                    Console.WriteLine(length.ToString());
                    return;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.ToString());
                    return;
                }
            }

            //If the command is invalid.
            //NOTE: THIS HAS TO BE AT THE BOTTOM OF THE FUNCTION.
            else
            {
                Console.WriteLine("Invalid command.");
                return;
            }
        }
    }
}
