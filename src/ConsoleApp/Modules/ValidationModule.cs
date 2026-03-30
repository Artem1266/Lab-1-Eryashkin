using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp.Modules
{
    public static class ValidationModule
    {
        public static bool IsValidNumber(int n, int min, int max)
        {
            return n >= min && n <= max;
        }
    }
}
