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
            //Dictionary
            Dictionary<string, string> dict = new Dictionary<string, string>();
            dict.Add("1", "One");
            dict.Add("2", "Two");
            dict.Add("3", "Three");
            dict.Add("4", "Four");
            dict.Add("5", "Five");
            dict.Add("6", "Six");
            Console.WriteLine(dict.ContainsValue("One"));
            Console.WriteLine(dict.Values.ToList().IndexOf("Two"));

            //SortedDictionary
            SortedDictionary<string, string> sortedDict = new SortedDictionary<string, string>();
            sortedDict.Add("1", "One");
            sortedDict.Add("2", "Two");
            sortedDict.Add("3", "Three");
            sortedDict.Add("4", "Four");
            sortedDict.Add("5", "Five");
            sortedDict.Add("6", "Six");
            Console.WriteLine(sortedDict.ContainsValue("One"));
            Console.WriteLine(sortedDict.Values.ToList().IndexOf("Six"));
            //Sort by Value
            foreach (KeyValuePair<string, string> author in dict.OrderBy(key => key.Value))
            {
                Console.WriteLine("Key: {0}, Value: {1}", author.Key, author.Value);
            }

        }

    }
}