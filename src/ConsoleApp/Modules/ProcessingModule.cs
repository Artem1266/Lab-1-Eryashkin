using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp.Modules
{
    public static class ProcessingModule
    {
        public static void PrintSquare(int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(new string('*', n));
            }
        }
    }
}
