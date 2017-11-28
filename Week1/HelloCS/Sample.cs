using System;

namespace Sup
{
    class Whatever
    {
        public static int SayHi()
        {
            Console.WriteLine("SUP");
            return 1;
        }
        public static void PrintNums(int[] numbers)
        {
            for(int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }
        }
    }
}