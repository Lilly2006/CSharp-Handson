using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqDemo
{
    class Customer
    {
        
        public int custid { get; set; }
        public string name { get; set; }
        public int salary { get; set; }
        public string dept { get; set; }
    }
    class Linq
    {
        public void display()
        {
            List<Customer> customers = new List<Customer>();
            customers.Add(new Customer { custid = 1, name = "Lilly", dept = "IT", salary = 9500 });
            customers.Add(new Customer { custid = 2, name = "Jeba", dept = "Sales", salary = 5500 });
            customers.Add(new Customer { custid = 3, name = "Angel", dept = "IT", salary = 2500 });
            customers.Add(new Customer { custid = 4, name = "Shiny", dept = "Sales", salary = 3000 }); 
            customers.Add(new Customer { custid = 5, name = "Buelah", dept = "IT", salary = 6000 });

            //LINQ FORMAT
            var result = from customerdataObj in customers    //CREATE OBJECT
                         where customerdataObj.salary > 5000
                         //&& customerdataObj.dept=="IT"      //FILTER/WHERE
                         select customerdataObj;              //SELECT COLUMNS/ TABLE OBJECT

            foreach (var item in result)
            {
                Console.Write(item.custid+"\t");
                Console.Write(item.name +"\t");
                Console.WriteLine(item.dept +"\t");
            }

            //IN MYSQL
            //select * from customers where salary>5000 // execute using F5

            //NORMAL WAY OF PRINTING
            //for(int i = 0; i < customers.Count; i++)
            //{
            //    if (customers[i].salary > 5000)
            //    {
            //        Console.WriteLine(customers[i].custid);
            //        Console.WriteLine(customers[i].name);
            //        Console.WriteLine(customers[i].dept);

            //    }
            //}

        }
    }
}
