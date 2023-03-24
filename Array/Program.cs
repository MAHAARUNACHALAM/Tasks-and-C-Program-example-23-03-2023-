//Common Programs

//Write a C# Sharp program to exchange the first and last characters in a given string and return the new string


using System.Collections.Immutable;
using System.Runtime.Serialization.Formatters;
using System.Security.Cryptography.X509Certificates;

namespace console1
{
    class ArrayProblem
    {

        static void Main(String[] args)
        {

            string str = "Maha";
            string newStr = str.Substring(str.Length - 1) + str.Substring(1, str.Length - 2) + str.Substring(0, 1);
            Console.WriteLine(newStr);

            //Write a C# Sharp program to create a new string with the last char added at the front and back of a given string of length 1 or more.
            string str1 = "Maha";
            if(str1.Length>1) { 
            string newStr1 = str1.Substring(str1.Length - 1) + str1 + str1.Substring(str1.Length - 1);
            Console.WriteLine(newStr1);
                }
            else
            {
                Console.WriteLine("String length is less than or equal to 1");
            }
            //Write a C# Sharp program to check if a string 'ok' appears in a given string. If it appears return a string without 'ok' otherwise return the original string.
            string str2 = "Mahaokok";
            //without using Replace
           while(str2.Contains("ok"))
            {
                string newStr2 = str2.Substring(0, str2.IndexOf("ok")) + str2.Substring(str2.IndexOf("ok") + 2);
                str2 = newStr2;
               
            }
            Console.WriteLine(str2);
            /* if (str2.Contains("ok"))
             {
                 string newStr2 = str2.Replace("ok", "");
                 Console.WriteLine(newStr2);
             }
             else
             {
                 Console.WriteLine(str2);
             } */


        }

    }
}

/*What is IEnumerable in C#?
What is Constructor Chaining in C#?
Can you use a "this" command within a static method? Why?
Name some access modifiers available in C#
Why does C# not support multiple inheritances?*/