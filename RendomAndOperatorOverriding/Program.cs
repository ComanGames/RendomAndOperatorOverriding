using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace RendomAndOperatorOverriding
{
    enum Operations
    {
        Add,
        Minus,
        Multiply, 
        Divide
    } 
    class Program
    {
        public static bool somebool;
        static void Main(string[] args)
        {
//            FirstPartOfLessonRancomClass();
//            SecondPartOfLesson();
            string myString = "Hello";
            int[] numbers = Enumerable.Range(0,11).ToArray();

            /* string[] Students = new[] { "Chirva", "Bubna", "Pika", "Hresta" };
             Console.WriteLine("Original Array of Students");
             Students.ArrayToString();
             Console.WriteLine("Shuffled Array Of Students");
             Thread.Sleep(100);
             Students.ShffleArray().ArrayToString();
             Thread.Sleep(100);
             Students.ShffleArray().ArrayToString();
             Thread.Sleep(100);
             Students.ShffleArray().ArrayToString();
             Console.WriteLine();*/


            /*//print arrays with all indifferent values of array
            Console.WriteLine("Original Array of numbers");
            numbers.ArrayToString();
            Console.WriteLine("Shuffled Array Of numbers");
            Thread.Sleep(100);
            numbers.ShffleArray().ArrayToString();
            Thread.Sleep(100);
            numbers.ShffleArray().ArrayToString();
            Thread.Sleep(100);
            numbers.ShffleArray().ArrayToString();
            Console.ReadKey();*/

           /*//WRITE RANDEM WITH SAME NUMBERS IN ARRAY
            //print arrays with same values of array
            Console.WriteLine("Original Array of numbers");
            numbers.ArrayToString();
            Console.WriteLine("Shuffled Array with same vales Of numbers");
            Thread.Sleep(100);
            numbers.ShffleArraySv().ArrayToString();
            Thread.Sleep(100);
            numbers.ShffleArraySv().ArrayToString();
            Thread.Sleep(100);
            numbers.ShffleArraySv().ArrayToString();
            Console.ReadKey();*/



            //ANOTHER ARRAY WITH CONST NUMBERS OF RETURNED ELEMENTS WITH REGULASHION OF REP AND NOT REP (TRUE/FALSE)
            /*//print arrays with CN
            Console.WriteLine("Original Array of numbers");
            numbers.ArrayToString();
            Console.WriteLine("Shuffled Array with same vales Of numbers");
            Thread.Sleep(100);
            numbers.ShffleArrayCn().ArrayToString();
            Thread.Sleep(100);
            numbers.ShffleArrayCn().ArrayToString();
            Thread.Sleep(100);
            numbers.ShffleArrayCn().ArrayToString();
            Console.ReadKey();*/

            //print arrays with CNr
            Console.WriteLine("Original Array of numbers");
            numbers.ArrayToString();
            Console.WriteLine("Shuffled Array with same vales Of numbers");
            Thread.Sleep(100);
            numbers.ShffleArrayCnr().ArrayToString();
            Thread.Sleep(100);
            numbers.ShffleArrayCnr().ArrayToString();
            Thread.Sleep(100);
            numbers.ShffleArrayCnr().ArrayToString();
            Console.ReadKey();


        }
        
        private static string ArrayToString<T> ( T[] A)
        {
            string result = "{ ";
            for (int i = 0; i < A.Length; i++)
            {
                result += $"{A.ToString()}, ";

            }
            result += "}";
            return result;
        }
        private static void SecondPartOfLesson()
        {
            Random random = new Random();
            string[] Students = new[] {"Chirva", "Bubna", "Pika", "Hresta"};
            bool[] WasInCharge = new bool[4];
            int countWhoWas = 0;
            int randomFromArray;

            while (true)
            {
                do
                {
                    randomFromArray = random.Next(Students.Length);
                } while (WasInCharge[randomFromArray]);
                WasInCharge[randomFromArray] = true;
                string nextWhoGoToClaen = Students[randomFromArray];
                Console.WriteLine($"The next who go {nextWhoGoToClaen}");

                if (++countWhoWas >= 4)
                {
                    countWhoWas = 0;
                    WasInCharge = new bool[4];
                    Console.WriteLine("We do reset");
                }
                Console.ReadKey();
            }
        }

       
        private static void FirstPartOfLessonRancomClass()
        {
            int[] numbers = Enumerable.Range(1, 10).ToArray();
            Operations operation = 0;
            Random random = new Random();
            while (true)
            {
                Console.WriteLine("Give us Seed");
                string seed = Console.ReadLine();
                random = new Random(seed.GetHashCode());
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine($"{i}Rendom Number {(random.Next(10))}");
                }
                Console.ReadKey();
            }
        }
    }
}
