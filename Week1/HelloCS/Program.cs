using System;
using System.Collections.Generic;
using Sup;
namespace HelloCS
{
    class Program
    {
        static void Main(string[] args)
        {
            Int32 y = 6;
            int x = 5;
            x = x+5;

            float floaty = 5.00000000000000002f;
            double doubly = 5.000000000003;

            string name = "Cool Man Guy";
            char character = 'd';

            bool isCool = true;

            int[] nums = new int[5];
            nums[0] = 100;

            int[] numys = {10,234,45,34,6,34,45,3245,345};

            int result = Whatever.SayHi();

            Whatever.PrintNums(numys);

            List<string> names = new List<string>();
            names.Add("Hans");
            names.Add("Elva");
            names.Add("Devon");

        }
    }
}
