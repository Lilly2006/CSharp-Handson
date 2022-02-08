using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate17
{
    
    //DELEGATE
    delegate bool IsCustomerEligible(Customer customer);
    class Customer
    {
        public int CustId { get; set; }
        public string CustName { get; set; }
        public string CustType { get; set; }
        public string CustLocation { get; set; }
        public static void BestOffersToCustomer(List<Customer> customerList, IsCustomerEligible isCustomerEligible)
        {
            foreach (var customer in customerList)
            {
                if(isCustomerEligible(customer))
                {
                    Console.WriteLine("50% Offer");
                   
                }
            }
        }
    }
    }


