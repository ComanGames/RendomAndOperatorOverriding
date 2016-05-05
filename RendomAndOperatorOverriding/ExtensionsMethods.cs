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
        public static void YurasString(this string s)
        {
            Console.WriteLine(s + " Yuras String");
        }
    }
}