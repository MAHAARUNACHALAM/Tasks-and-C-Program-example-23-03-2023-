//Common Programs

//Write a program in C# Sharp to count a total number of duplicate elements in an array.

//Write a program in C# Sharp to merge two arrays of same size sorted in ascending order.
//Write a program in C# Sharp to separate odd and even integers in separate arrays


//Write a program in C# Sharp to count a total number of duplicate elements in an array.

using System.Collections.Immutable;
using System.Runtime.Serialization.Formatters;
using System.Security.Cryptography.X509Certificates;

namespace console1
{
    class ArrayProblem
    {

        public static void DuplicateCount(int[] a)
        {
            if (a.Length != 0)
            {
                //To Find the number of duplicate elements
                var groups = a.GroupBy(v => v);
                int duplicatecount = 0;
                foreach (var group in groups)
                    if (group.Count() > 1)
                    {
                        Console.WriteLine("Value {0} has {1} items", group.Key, group.Count());
                        duplicatecount++;
                    }
                Console.WriteLine("Total number of duplicate count is" + duplicatecount);

            }
        }
        public static void MergeArray(int[] a, int[] b)
        {
            int[] c=new int[10];
            foreach (var c2 in b)
            {
                c.Append(c2);
            }
            foreach (var c2 in a)
            {
                c.Append(c2);
            }
            Array.Sort(c);
            foreach (var c1 in c)
            {
                Console.WriteLine(c1.ToString());
            }

        }

        static void Main(String[] args)
        {
            int[] a = new int[5];
            int[] b = new int[5];
            int[] c = new int[5];
            int[] d = new int[5];
            Console.WriteLine("Do You want to enter the array 1 or 2");
            int choice = Convert.ToInt32(Console.ReadLine());
            if(choice == 1) {
                for(int i=0; i<5; i++)
                {
                    a[i]= Convert.ToInt32(Console.ReadLine());
                }
            }
            else if(choice == 2)
            {
                Console.WriteLine("Enter array 1");
                for (int i = 0; i < 5; i++)
                {
                    a[i] = Convert.ToInt32(Console.ReadLine());
                }
                Console.WriteLine("Enter array 2");
                for (int i = 0; i < 5; i++)
                {
                    a[i] = Convert.ToInt32(Console.ReadLine());
                }
            }
            else
            {
                Console.WriteLine("Enter a valid choice");
                goto end;
            }
            Console.WriteLine("Enter operation Do you want to perform\n1.Count Duplicate\n2.Merge Array\n3.Separate even and odd");
            choice= Convert.ToInt32(Console.ReadLine());
            
            switch(choice)
            {
                case 1:
                    DuplicateCount(a);
                    break;
                case 2:
                    MergeArray(a,b);
                    break;
                case 3:
                   // SeparateEvenOdd();
                    break;
                default: goto end;
            }
            end:
            Console.WriteLine("Program ended");
           
        }

    }
}