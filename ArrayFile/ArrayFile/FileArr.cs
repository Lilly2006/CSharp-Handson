using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ArrayFile
{
    class FileArr
    {
        public void ReadNetworkArr()
        {

            /* Console.Write("Enter a file name : ");
             string path = Console.ReadLine();*/

            FileStream fileStreamobj = new FileStream("C:\\Test\\network1.txt", FileMode.Open, FileAccess.Read);
            StreamReader streamReaderobj = new StreamReader(fileStreamobj);
            //Console.WriteLine("ID\tSource\t\tDestination\tDate\t\tStatus\t\tNetwork");
            string[] ida = new string[15];
            string[] sourcea = new string[15];
            string[] desa = new string[15];
            string[] datea = new string[15];
            string[] statusa = new string[15];
            string[] neta = new string[15];


            int i = 0;
            while (streamReaderobj.Peek() > 0)
            {
                string line = streamReaderobj.ReadLine();
                if (line.Contains(":"))
                {
                    if (line.StartsWith("Id"))
                    {
                        string[] id = line.Split(':');
                        ida[i] = id[1];

                    }
                    else if (line.StartsWith("Source"))
                    {
                        string[] source = line.Split(':');
                        sourcea[i] = source[1];

                    }
                    else if (line.StartsWith("Destination"))
                    {
                        string[] des = line.Split(':');
                        desa[i] = des[1];

                    }
                    else if (line.StartsWith("Date"))
                    {
                        string[] date = line.Split(':');
                        string[] datep = date[1].Split(' ');
                        datea[i] = datep[0];

                    }
                    else if (line.StartsWith("Status"))
                    {
                        string[] status = line.Split(':');
                        statusa[i] = status[1];

                    }
                    else if (line.StartsWith("Network"))
                    {
                        string[] network = line.Split(':');
                        neta[i] = network[1];
                        i++;
                    }
                }



            }
            int c;
            do
            {
                Console.WriteLine(" ");

                Console.WriteLine("1.Id");
                Console.WriteLine("2.Source");
                Console.WriteLine("3.Destination");
                Console.WriteLine("4.Date");
                Console.WriteLine("5.Status");
                Console.WriteLine("6.Network");
                Console.WriteLine("7.Exit");
                Console.Write("Enter a option :");
                c = Convert.ToInt32(Console.ReadLine());
                switch (c)
                {
                    case 1: Id(); break;
                    case 2: Source(); break;
                    case 3: Des(); break;
                    case 4: Date(); break;
                    case 5: Status(); break;
                    case 6: Network(); break;
                    case 7: Console.WriteLine("Exiting...."); break;
                    default: Console.WriteLine("Noting Selected.."); break;

                }
            } while (c != 7);


            void Id()
            {
                Console.WriteLine("ID");

                for (int j = 0; j < 12; j++)
                {

                    if (j == 0)
                    {
                        Console.Write("[");

                    }

                    Console.Write(ida[j]);
                    if (j < 11)
                    {
                        Console.Write(",");

                    }

                    if (j == 11)
                    {
                        Console.WriteLine("]");

                    }
                }
            }

            void Source()
            {
                Console.WriteLine("Source");

                for (int j = 0; j < 12; j++)
                {

                    if (j == 0)
                    {
                        Console.Write("[");

                    }

                    Console.Write(sourcea[j]);
                    if (j < 11)
                    {
                        Console.Write(",");

                    }

                    if (j == 11)
                    {
                        Console.WriteLine("]");

                    }
                }
            }

            void Des()
            {
                Console.WriteLine("Designation");

                for (int j = 0; j < 12; j++)
                {

                    if (j == 0)
                    {
                        Console.Write("[");

                    }

                    Console.Write(desa[j]);
                    if (j < 11)
                    {
                        Console.Write(",");

                    }

                    if (j == 11)
                    {
                        Console.WriteLine("]");

                    }
                }
            }
            void Date()
            {
                Console.WriteLine("Date");

                for (int j = 0; j < 12; j++)
                {

                    if (j == 0)
                    {
                        Console.Write("[");

                    }

                    Console.Write(datea[j]);
                    if (j < 11)
                    {
                        Console.Write(",");

                    }

                    if (j == 11)
                    {
                        Console.WriteLine("]");

                    }
                }
            }
            void Status()
            {
                Console.WriteLine("Status");

                for (int j = 0; j < 12; j++)
                {

                    if (j == 0)
                    {
                        Console.Write("[");

                    }

                    Console.Write(statusa[j]);
                    if (j < 11)
                    {
                        Console.Write(",");

                    }

                    if (j == 11)
                    {
                        Console.WriteLine("]");

                    }
                }
            }
            void Network()
            {
                Console.WriteLine("Network");

                for (int j = 0; j < 12; j++)
                {

                    if (j == 0)
                    {
                        Console.Write("[");

                    }

                    Console.Write(neta[j]);
                    if (j < 11)
                    {
                        Console.Write(",");

                    }

                    if (j == 11)
                    {
                        Console.WriteLine("]");

                    }
                }
            }


            /*Console.Write(sourcea[j] + "\t");
            Console.Write(desa[j] + "\t");
            Console.Write(datea[j] + "\t");
            Console.Write(statusa[j] + "\t\t");
            Console.WriteLine(neta[j] + "\t");*/
        }
    }
}
