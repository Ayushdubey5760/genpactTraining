using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;

namespace Day_11_Exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter person name and Dob");
            Customer.Customer customer = new Customer.Customer();
            customer.Name = Console.ReadLine();
            customer.Dob = Console.ReadLine();

            string path = "C:\\customer/";
            string fileName = $"{customer.Name}_{customer.Dob}.txt";
            string filePath = path + fileName ;
            File.Create(filePath) = path + fileName ;
            Console.WriteLine("FileCreated");

            Console.WriteLine("Enter User's Id City Address");

            customer.Id = Console.ReadLine();
            customer.City = Console.ReadLine();
            customer.Address = Console.ReadLine();

            if (customer.WRite(filePath, customer))
            {
                customer.Read(filePath);
            };
            
            Console.ReadKey();
        }
    }
}
