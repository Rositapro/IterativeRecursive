using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IterativeRecursive
{
    internal class Factorial
    {
        // Método iterativo
        public int FactorialIterative(int n)
        {
            int result = 1;
            for (int i = 1; i <= n; i++)
            {
                result *= i;
            }
            return result;
        }

        // Método recursivo
        public int FactorialRecursive(int n)
        {
            if (n == 0 || n == 1)
                return 1;
            return n * FactorialRecursive(n - 1);
        }
    }
}
