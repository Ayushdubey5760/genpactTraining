using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day_9
{
    internal class Program
    {
        static void Main()
        {
            // Creating Employee Folder
            string folderPath = "C:\\";
            Directory.CreateDirectory(folderPath);

            //Ask Employee Name DOB 
            Console.WriteLine("Enter Employee Name");
            string empName = Console.ReadLine();

            Console.WriteLine("Enter Date of birth (YYYY-MM-DD)");
            string dateOfBirth = Console.ReadLine();
           
            string fileName = $"{empName}_{dateOfBirth.Replace("-", " ")}.txt";
            string filePath = Path.Combine(folderPath, fileName);

            //Ask Employee other Details
            Console.WriteLine("Enter Employee ID: ");
            string empId = Console.ReadLine();

            Console.WriteLine("Enter City: ");
            string city = Console.ReadLine();

            Console.WriteLine("Enter Address: ");
            string address = Console.ReadLine();

            using (StreamWriter writer = new StreamWriter(filePath))
            {
                writer.WriteLine("Employee Name: {empName}");
                writer.WriteLine("Date of Birth: {dateOfBirth}");
                writer.WriteLine("Employee ID: {empID}");
                writer.WriteLine("City: {city}");
                writer.WriteLine("Address: {address}");
            }

            // Display saved info
            Console.WriteLine("\nEmployee information saved successfully:");
            Console.WriteLine("\nEmployee Name: {empName}");
            Console.WriteLine("\nDate of Birth: {dateOfBirth}");
            Console.WriteLine("\nEmployee ID: {empId}");
            Console.WriteLine("\nCity: {city}");
            Console.WriteLine("\nAddress: {address}");
        }
    }
}
