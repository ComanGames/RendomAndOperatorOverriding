using System;

namespace RendomAndOperatorOverriding
{
    public static class ExtensionsMethods
    {
        public static void ArrayToString<T>(this T[] A)
        {
            string result = "{ ";
            for (int i = 0; i < A.Length; i++)
            {
                result += $"{A[i].ToString()}, ";

            }
            result += "}";
            Console.WriteLine(result);

        }

        //Shuffled Array with the same values
        public static T[] ShffleArraySv<T>(this T[] A)
        {
            int randfromArray = 0;
            Random random = new Random();
            T[] result = new T[A.Length];
            //bool[] ordered = new bool[A.Length];

            for (int i = 0; i < result.Length; i++)
            {
                //do
                //{
                    randfromArray = random.Next(A.Length);
                //} while (ordered[randfromArray]);
                //ordered[randfromArray] = true;
                result[i] = A[randfromArray];
            }
            return result;
        }

        //Shuffled Array with constant numbers
        public static T[] ShffleArrayCn<T>(this T[] A)
        {
            int randfromArray = 0;
            Random random = new Random();
            int constnum = 7;
            T[] result = new T[constnum];
            
            //bool[] ordered = new bool[A.Length];

            for (int i = 0; i < constnum; i++)
            {
                //do
                //{
                randfromArray = random.Next(A.Length);
                //} while (ordered[randfromArray]);
                //ordered[randfromArray] = true;
                result[i] = A[randfromArray];
            }
            return result;
        }

        //Shuffled Array with constant numbers
        public static T[] ShffleArrayCnr<T>(this T[] A)
        {
            int randfromArray = 0;
            Random random = new Random();
            int constnum = 7;
            T[] result = new T[constnum];

            bool[] ordered = new bool[A.Length];


            //for (int i = 0; i < result.Length; i++)
            for (int i = 0; i < constnum; i++)
            {
               
                    do
                    {
                        randfromArray = random.Next(A.Length);
                    } while (ordered[randfromArray]);
                    ordered[randfromArray] = true;
                    result[i] = A[randfromArray];
                
            }
            return result;
        }


        //Shuffled Array with all different values
        public static T[] ShffleArray<T>(this T[] A)
        {
            int randfromArray = 0;
            Random random = new Random();
            T[] result = new T[A.Length];
            bool[] ordered = new bool[A.Length];

            for (int i = 0; i < result.Length; i++)
            {
                do
                {
                    randfromArray = random.Next(A.Length);
                } while (ordered[randfromArray]);
                ordered[randfromArray] = true;
                result[i] = A[randfromArray];
            }
            return result;
        }




       /* public static void YurasString(this string s)
        {
            Console.WriteLine(s + " Yuras String");
        }*/
    }
}