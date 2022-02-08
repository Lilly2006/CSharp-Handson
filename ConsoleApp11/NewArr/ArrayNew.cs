using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace NewArr
{
    class ArrayNew
    {
        public void ReadArr()
        {
            Console.Write("  Id  ");
            Console.Write("  Source  ");
            Console.Write("   Destination ");
            Console.Write("    Date      ");
            Console.Write("     Status   ");
            Console.WriteLine(" Network");
            FileStream fileStreamObj = new FileStream("C:\\Test\\Network1.txt", FileMode.Open, FileAccess.Read);
            StreamReader streamReaderObj = new StreamReader(fileStreamObj);           
         
            while (streamReaderObj.Peek() > 0)
            {
                string line = streamReaderObj.ReadLine();
                if (line.StartsWith("Id") || line.StartsWith("Source") || line.StartsWith("Destination") || line.StartsWith("Status") || line.StartsWith("Network"))
                   
                {
                    string[] result = line.Split(':' );
                    
                    Console.Write("  " + result[1] + " ");
                    
                    if (line.StartsWith("Network"))
                    {
                        Console.WriteLine(" \t");
                    }
                    Console.Write(" " );
                    

                }
                if (line.StartsWith("Date"))
                {

                    string[] result11 = line.Split(' ');
                    string d = result11[0]; // Date:1/16/2021                  
                    Console.Write(" " + d[5] + d[6] + d[7] + d[8] + d[9] + d[10] + d[11] + d[12] + d[13] + " "); //["D","a","t","e",":","1","/","1","6","/","2","0","2","1"]
                    Console.Write(" \t" );

                }

            }
        }
    }
}
