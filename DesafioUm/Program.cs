using System;

namespace DesafioUm
{
    class Program
    {
        static void Main()
        {
            Console.Clear();

            Console.Write("Digite o número: ");

            int numero = int.Parse(Console.ReadLine());
            bool pertence = PertenceAFibonacci(numero);

            if (pertence)
            {
                Console.WriteLine($"O número {numero} pertence à sequência de Fibonacci.");
            }
            else
            {
                Console.WriteLine($"O número {numero} não pertence à sequência de Fibonacci.");
            }
            Console.ReadKey();
            Main();
        }

        static bool PertenceAFibonacci(int num)
        {
            int a = 0;
            int b = 1;

            while (a < num)
            {
                int temp = a;
                a = b;
                b = temp + b;
            }
            return a == num;
        }
    }
}



