using System;

namespace CSharpSort
{
    public static class ArgumentPolicies
    {
        public static bool IsValid(string[] args)
        {
            if (string.IsNullOrEmpty(args[0]))
            {
                Console.WriteLine("método de ordenação não informado");
                return false;
            }

            if (args.Length < 2)
            {
                Console.WriteLine("informe um número de 1 a 100.000");
                return false;
            }

            if (int.Parse(args[1]) > 100000)
            {
                Console.WriteLine("número de entradas permitido é 100.000");
                return false;
            }

            return true;
        }
    }
    
}
        