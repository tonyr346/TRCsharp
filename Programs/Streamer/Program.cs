using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Streamer;

class Program
{

    static void GetDIRS()
    {
         // Get the directories currently on the C drive.
            DirectoryInfo[] cDirs = new DirectoryInfo(@"/workspaces/TRCsharp/Programs").GetDirectories();

            // Write each directory name to a file.
            using (StreamWriter sw = new StreamWriter("CDriveDirs.txt"))
            {
                foreach (DirectoryInfo dir in cDirs)
                {
                    sw.WriteLine(dir.Name);
                }
            }

            // Read and show each line from the file.
            string line = "";
            using (StreamReader sr = new StreamReader("CDriveDirs.txt"))
            {
                while ((line = sr.ReadLine()!) != null)
                {
                    Console.WriteLine(line);
                }
            }
            return;
    }

    static void CreateTXT(double [] A)
    {
       

       string stpath = (@"/workspaces/TRCsharp/Programs/Streamer/txt");
       
       string fn = "Array.txt";
       string usrFn = "";
       bool isok = true;
       
       Console.Write("Enter File Name:");
       
       usrFn = Console.ReadLine()!;

       isok = string.IsNullOrEmpty(usrFn);

       if (isok == true)
       usrFn = fn;
       else
       usrFn = usrFn +".txt";

       

       using (StreamWriter sw = new StreamWriter(Path.Combine(stpath,usrFn)))
       {
            
         foreach (var i in A)
        {
            sw.WriteLine(i);
        }
       
       return;

       }    
    }





    static void Main(string[] args)
    {
      //GetDIRS();

      double [] Ary = {1,2,3,4,5,6,7,8,9};


      CreateTXT(Ary);

      Console.WriteLine("Completed Request");

    }
}
