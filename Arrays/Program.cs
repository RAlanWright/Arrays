using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This program will allow you to output a chosen index of an array.");

            int[] luckyNumbers = {4, 8, 15, 16, 23, 42};

                        
     
            Console.WriteLine("The array 'luckNumbers' contains {0}", string.Join(", ", luckyNumbers) + ".");
            Console.Write("What index position would you like to see from this array? ");
            string index = Console.ReadLine();
            
            Console.WriteLine(luckyNumbers[Convert.ToInt32(index)]);


            string[] friends = new string[5];
            friends[0] = "Jim";
            friends[1] = "Kelly";


            //for (int i = 1; i <= friends.Length; i++)
            //{
            //    Console.ReadLine(friends.Append<string>);
            //}


            Console.ReadLine();
        }
    }
}
