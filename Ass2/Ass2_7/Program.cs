using System;

namespace Ass2_7
{
    class Program
    {
        static void Main(string[] args)
        {
            string a,b;
           


             a = "Divyan shu";
             b = "Divyanshujain";


            Console.WriteLine(a.Clone());
            // Make String Clone
            Console.WriteLine(a.CompareTo(b));
            //Compare two string value 
            Console.WriteLine(a.Contains("shu")); //Check whether specified value exists or not in string

              Console.WriteLine(a.EndsWith("u")); //Check whether specified value is the last character of string
                        Console.WriteLine(a.Equals(b));
            //Compare two string and returns true and false

            Console.WriteLine(b.IndexOf("a")); //Returns the first index position of specified value
            

              Console.WriteLine(a.ToLower());
            //Covert string into lower case

            Console.WriteLine(a.ToUpper());
            //Convert string into Upper case

            Console.WriteLine(a.Insert(0, "Hello")); //Insert substring into string

         
            Console.WriteLine(a.Length);
            //Returns the Length of String


            Console.WriteLine(a.Substring(2, 5));
            //Returns substring

            Console.WriteLine(a.ToCharArray());
            //Converts an string into char array.

            Console.WriteLine(a.Trim());
            //It removes starting and ending white spaces from
          


        }
    }
}
