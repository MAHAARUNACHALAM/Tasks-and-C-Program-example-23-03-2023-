//Try Catch

namespace console1
{
    class SortedSet
    {
        static void Main(String[] args)
        {
            SortedSet<string> cp = new SortedSet<string>();
            cp.Add("Hello");
            cp.Add("World");
            cp.Add("!");
            foreach (string s in cp)
            {
                Console.WriteLine(s);
            }
            var exset = new SortedSet<int>() { 10, 20, 5, 3, 2, 1 };
            foreach (int s in exset)
            {
                Console.WriteLine(s);
            }

        }

    }
}