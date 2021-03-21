using System;

namespace Calculadora1
{
    class Program
    {
        static void Main(string[] args)
        {
            double numero, total;
            string op;
            numero = 0;
            total = 0;
            op = "+";


            Console.WriteLine("---------------------------------------");
            Console.WriteLine("------------CALCULADORA C#-------------");
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("Use simbolos matematicos para as contas");

            while (op != "=") 
            {
                Console.WriteLine("Digite um numero qualquer: ");
                numero = Convert.ToDouble(Console.ReadLine());

                switch (op) 
                {
                    case "+":
                        total = total + numero;
                        break;
                    case "-":
                        total = total - numero;
                        break;
                    case "*":
                        total = total * numero;
                        break;
                    case "/":
                        total = total / numero;
                        break;
                }

                Console.Write("Digite a Operaçâo Matematica: ");
                op = Console.ReadLine();

            }

            Console.WriteLine("---------------------------------------");
            Console.WriteLine("O Resultado das operaçôes foi: " + total);
            Console.WriteLine("---------------------------------------");
            Console.ReadKey();
        }
    }
}
