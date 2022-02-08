using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate17
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Customer> customers = new List<Customer>();
            customers.Add(new Customer { CustId = 1, CustName = "Lilly", CustType = "Gold", CustLocation = "Dindigul" });
            customers.Add(new Customer { CustId = 2, CustName = "Angel", CustType = "Silver", CustLocation = "Coimbatore" });
            customers.Add(new Customer { CustId = 3, CustName = "Jeba", CustType = "Gold", CustLocation = "Dharapuram" });
            IsCustomerEligible isCustomerEligibleObj = new IsCustomerEligible(CustomerEligible);
            Customer.BestOffersToCustomer(customers, isCustomerEligibleObj);
            Console.ReadKey();
        }

        public static bool CustomerEligible(Customer customer)
        {
            if (customer.CustType == "Gold")
            {
                return true;
            }
            else
            {
                return false;
            }


        }
    }
}
