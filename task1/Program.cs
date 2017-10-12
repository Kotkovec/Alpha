using System;

namespace Ex1
{
    class Program
    {
        public static int bsearch(int[] array, int x)
        {
            Array.Sort(array);
            Array.Reverse(array);

            int min = -1;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < x)
                {
                    min = i;
                    break;
                }
            }
            return min;                     
        }
       
        static void Main()
        {
            int[] array = { 2, 4, 5, 6, 1, 3, 7 };
            int x = 4;

            Console.Write(bsearch(array, x));  
        }
    }
}