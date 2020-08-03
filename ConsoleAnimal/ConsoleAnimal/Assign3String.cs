using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAnimal
{
    class Assign3String
    {
        static void Main()
        {
            Console.WriteLine("Enter First String");
            string s1 = Console.ReadLine();
            Console.WriteLine("Enter Second String");
            string s2 = Console.ReadLine();
            int opt;
            opt = Convert.ToInt32(Console.ReadLine());
            switch (opt)
            {
                case 1:
                    Console.WriteLine("Concate the string:");
                    Console.WriteLine(string.Concat(s1, s2));
                    break;

                case 2:
                    Console.WriteLine("Length of the string:");
                    Console.WriteLine("length of the string is {0} and {1}", s1.Length, s2.Length);
                    break;

                case 3:
                    Console.WriteLine("Sub string the strings:");
                    Console.WriteLine(s1.Substring(0, 8));
                    Console.WriteLine(s2.Substring(0, 6));
                    break;
                case 4:
                    Console.WriteLine("Replace the string:");
                    Console.WriteLine(s1.Replace(s1, "My name is"));
                    break;
                case 5:
                    Console.WriteLine("uppercase the string:");
                    Console.WriteLine(s1.ToUpper());
                    break;
                case 6:
                    Console.WriteLine("Lower case the string:");
                    Console.WriteLine(s2.ToLower());
                    break;
                case 7:
                    Console.WriteLine("trim  the string:");
                    Console.WriteLine(s1.Trim());
                    break;
                case 8:
                    Console.WriteLine("Concate the string:");
                    Console.WriteLine(s1.Split(' '));
                    break;
                default:
                    Console.Write("Input correct option\n");
                    break;
            }
            Console.Read();
        }
    }
}
