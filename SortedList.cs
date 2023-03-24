//Common Programs


using System.Collections.Immutable;
using System.Runtime.Serialization.Formatters;
using System.Security.Cryptography.X509Certificates;

namespace console1
{
    class ArrayProblem
    {

        static void Main(String[] args)
        {
            //SortedList
            SortedList<string, string> sortedList = new SortedList<string, string>();
            sortedList.Add("1", "One");
            sortedList.Add("2", "Two");
            sortedList.Add("3", "Three");
            sortedList.Add("4", "Four");
            sortedList.Add("5", "Five");
            sortedList.Add("6", "Six");
            Console.WriteLine(sortedList.ContainsValue("One"));
            Console.WriteLine(sortedList.Values.ToList().IndexOf("Six"));
            //Sort by Value
            foreach (KeyValuePair<string, string> author in sortedList.OrderBy(key => key.Value))
            {
                Console.WriteLine("Key: {0}, Value: {1}", author.Key, author.Value);
            }

        }

    }
}