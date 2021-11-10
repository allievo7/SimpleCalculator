using System;

namespace SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero1int = Convert.ToInt32(args[0]);
            int numero2int = Convert.ToInt32(args[1]);
            Console.WriteLine("la somma è: " + (numero1int + numero2int));
        }
    }
}
