using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
            Random random = new Random();
            string[] Students = new[] {"Chirva", "Bubna", "Pika", "Hresta"};
            bool[] WasInCharge = new bool[4];
            int countWhoWas = 0;
            int randomFromArray ;
            
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

        public static T ShffleArray<T>(T[] A)
        {
            
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
