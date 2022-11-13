using System;

namespace Calculator
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Currency : {0:c}", 23.455);
            Console.WriteLine("Pad with 0s : {0:d4}", 23);
            Console.WriteLine("3 Decimals : {0:f3}", 23.45555);
            Console.WriteLine("Commas : {0:n4}", 2300);
            // single-line comments same
            /* multi line comments are the
             * same 
             */
            int i;
            for (i = 0; i < 10; i++)
            {
                Console.WriteLine("ForLoopC#"); 
            }
            // Committed w/ message && pushed through VS Studio
        }
    }
}