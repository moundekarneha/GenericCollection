using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericCollection
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //generic collection - strongly typed
            List<string> list = new List<string>();
            list.Add("a"); 
            list.Add("b");

            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]); 
            }

            list.Insert(2,"c");
            

            foreach (var item in list)
            {
                Console.WriteLine(item);

            }

            list.Remove("a");
            list.RemoveAt(1);
            Console.ReadLine();
        }
    }
}
