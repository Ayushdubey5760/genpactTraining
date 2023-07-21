using Assignment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    public class LargeDataCollection : IDisposable
    {
        private List<object> data;

        public LargeDataCollection(IEnumerable<object> initialData)
        {
            data = new List<object>(initialData);
        }

        public void Add(object item)
        {
            data.Add(item);
        }

        public void Remove(object item)
        {
            data.Remove(item);
        }

        public void AccessElement(int index)
        {

            if (index >= 0 && index < data.Count)
            {
                Console.WriteLine("Elements at index {0}: {1}", index, data[index]);

            }

            else
            {
                Console.WriteLine("Invalid index.");
            }

        }
        public void Dispose()
        {

            data.Clear();
            data = null;
        }
    }

        class Program
        {
            static void Main()
            {
                using (var collection = new LargeDataCollection(new List<object> { 1, 2, 3, "Hello", "World" }))
                {
                    collection.Add(4);
                    collection.AccessElement(0);

                    collection.Remove("World");
                    collection.AccessElement(4);
                Console.ReadKey();


                }


            }
        }
    }
