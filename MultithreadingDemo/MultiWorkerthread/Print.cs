using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace MultiWorkerthread
{
    class Print
    {     
            public void PrintJob(object data)
            {
                Console.WriteLine("Background PrintJob started.");
                Thread.Sleep(1000);
                Console.WriteLine("PrintJob still printing...");
                Console.WriteLine($"Data: {data}");
                Thread.Sleep(1000);
                Console.WriteLine("PrintJob finished.");
            }

            public void PrintPerson(object data)
            {
                Console.WriteLine("Background PrintPerson started.");
                Thread.Sleep(1000);
                Console.WriteLine("PrintPerson still printing...");
                Person p = (Person)data;
                Console.WriteLine($"Person {p.Name} is a {p.Sex} of {p.Age} age.");
                Thread.Sleep(1000);
                Console.WriteLine("PrintPerson finished.");
            }
        }
        public class Person
        {
            public string Name { get; set; }
            public int Age { get; set; }
            public string Sex { get; set; }

            public Person(string name, int age, string sex)
            {
                this.Name = name;
                this.Age = age;
                this.Sex = sex;
            }
        }
    }

