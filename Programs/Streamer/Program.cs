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

    static void CreateTXT(List<int> A)
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

    static List<int> CreLis(int a, int b, int c)
    {
        List <int> AList = new List<int>();
        for(int i = 0; i<5; i++)
       {
         AList.Add(i);
       }
       AList.Add(a);
       AList.Add(b);
       AList.Add(c);

        return AList;
    }





    static void Main(string[] args)
    {
      //GetDIRS();

      double [] Ary = {1,2,3,4,5,6,7,8,9};
      List<int> Alist = new List<int>();
      Alist = CreLis(1,5,7);
      CreateTXT(Alist);

      

      Console.WriteLine("Completed Request");

    }
}
