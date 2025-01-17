﻿using System;
using Extensions;

namespace ExtensionMethod
{
    class Program
    {
        static void doWork()
        {
            //prints out all number bases between 2 and 10 for int x
            int x = 591;
            for (int i = 2; i <= 10 ; i++)
            {
                Console.WriteLine($"{x} in base {i} is {x.ConvertToBase(i)}");
            }
        }

        static void Main()
        {
            try
            {
                doWork();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception: {0}", ex.Message);
            }
        }
    }
}
