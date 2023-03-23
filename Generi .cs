//Try Catch

namespace console1
{
    class Generic<t>


    {

        public Generic(t message)
        {
            Console.WriteLine(message);
        }
        /*public Test1<t>(t message)
        {
            Console.WriteLine(message);
        }*/

    }
    class Test
    {
        static void Main(String[] args)
        {
            Generic<string> cp = new TryCatch<String>("Hello");
        }

    }
}