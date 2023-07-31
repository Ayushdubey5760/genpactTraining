using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Day_11_Exercise
{
    internal class Class1
    {

        public string Name { get; set; }
        public string Dob { get; set; }
        public string Address { get; set; }
        public string Id { get; set; }
        public string City { get; set; }

        public bool Write(string filePath, object customer)
        {
            try 
            {
                IFormatter formatter = new BinaryFormatter();
                Stream stream = new FileStream(filePath.FileMode.Create, FileAccess.Write);
                formatter.Serialize(stream, customer);
                Console.WriteLine("Written Inside File");
                stream.Closer();
                return true;
            }
            catch (Exception ex) 
            {
                Console.WriteLine("Error" + ex.Message);
                return false
            }

        }

        public bool Read(string filePath) 
        {
            try
            {
                IFormatter formatter = new BinaryFormatter();
                Stream stream = new FileStream(filePath.FileMode.Open, FileAccess.Read);
                Customer cus = (Customer)formatter.Deserialize(stream);
                Console.WriteLine("ID -- " + cus.Id);
                Console.WriteLine("Name -- " + cus.Name);
                Console.WriteLine("Dob -- " + cus.Dob);
                Console.WriteLine("City -- " + cus.City);
                return true;
            }
            catch { Exception ex}
            {
                Console.WriteLine("Error" + ex.Message);
                return false;
            }
        }

    }
}
