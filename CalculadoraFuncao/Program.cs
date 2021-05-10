using System;

namespace CalculadoraFuncao
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Olá! Qual operação matemática deseja realizar?");
            Console.WriteLine("digite: (+) soma| (-) subtração| (*) multiplicação| (/) divisão|");
            string resposta = Console.ReadLine() .ToLower();

            Console.WriteLine("Insira o primeiro número: ");
            double n1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Insira o segundo número: ");
            double n2 = double.Parse(Console.ReadLine());

            switch (resposta)
            {
                case "+":
                Console.WriteLine($"Resultado da soma: {Soma(n1, n2)}");
                    break;
                case "-":
                Console.WriteLine($"Resultado da subtração: {Subtracao(n1, n2)}");
                    break;
                case "*":
                Console.WriteLine($"Resultado da multiplicação: {Multiplicacao(n1, n2)}");
                    break;
                case "/":
                Console.WriteLine($"Resultado da divisão: {Divisao(n1, n2)}");
                    break;
                default:
                Console.WriteLine("OPERAÇÃO INVÁLIDA");
                    break;
            }
            
        }

        static double Soma(double primeiroNumero, double segundoNumero)
        {
            return primeiroNumero + segundoNumero;
        }

        static double Subtracao(double primeiroNumero, double segundoNumero)
        {
            return primeiroNumero - segundoNumero;
        }

        static double Multiplicacao(double primeiroNumero, double segundoNumero)
        {
            return primeiroNumero * segundoNumero;
        }

        static double Divisao(double primeiroNumero, double segundoNumero)
        {
            return primeiroNumero / segundoNumero;
        }
    }
}
