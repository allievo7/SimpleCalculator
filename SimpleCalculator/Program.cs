using System;

namespace SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string numero1 = args[0];
            int numero1int = Convert.ToInt32(numero1);
            string numero2 = args[1];
            int numero2int = Convert.ToInt32(numero2);
            int somma = numero1int + numero2int;
            Console.WriteLine("la somma di " + numero1 + " + " + numero2  + " è uguale a: " + somma);
        }
    }
}
