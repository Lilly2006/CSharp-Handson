using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
//using System.Data.Common;

namespace FileHandlingAss
{
    class FileAss
    {
        public void ReadNetwork()
        {
            Console.Write("Id     \t");
            Console.Write("  Source    \t");
            Console.Write("Destination  \t");
            Console.Write("   Date      \t");
            Console.Write(" Status      \t");
            Console.WriteLine("Network \t");
            FileStream fileStreamObj = new FileStream("C:\\Test\\Network1.txt", FileMode.Open, FileAccess.Read);
            StreamReader streamReaderObj = new StreamReader(fileStreamObj);
            while (streamReaderObj.Peek() > 0)
            {
                string line = streamReaderObj.ReadLine();
                
                if (line.StartsWith("Id"))
                {
                    string[] result = line.Split(':');
                    Console.Write(" " + result[1] + " ");
                    Console.Write(" " + "\t");
                }
                if (line.StartsWith("Source"))
                {
                    string[] result1 = line.Split(':');
                    Console.Write(" " + result1[1] + " ");
                    Console.Write(" " + "\t");
                }
                if (line.StartsWith("Destination"))
                {
                    string[] result2 = line.Split(':');
                    Console.Write(" " + result2[1] + " ");
                    Console.Write(" " + "\t");
                }
                if (line.StartsWith("Date"))
                {
                   
                    string[] result11 = line.Split(' ' );
                    string d = result11[0]; // Date:1/16/2021                  
                    Console.Write(" " + d[5] + d[6] + d[7] + d[8] + d[9] + d[10] + d[11] + d[12] + d[13] + " "); //["D","a","t","e",":","1","/","1","6","/","2","0","2","1"]
                    Console.Write(" " + "\t");

                }
                if (line.StartsWith("Status"))
                {
                    string[] result4 = line.Split(':');
                    Console.Write(" " + result4[1] + " ");
                    Console.Write(" " + "\t");
                }
                if (line.StartsWith("Network"))
                {
                    string[] result5 = line.Split(':');
                    Console.Write(" " + result5[1] + " ");
                    Console.WriteLine(" " + "\t");
                }
            }

            Console.WriteLine();
            Console.ReadKey();
        }
    }
 }

   
