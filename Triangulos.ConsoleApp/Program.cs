using System;

namespace Triangulos.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            double ladoA, ladoB, ladoC;
            string opcao;

            do
            {
                Console.Clear();

                Console.WriteLine("1 - Para inserir os números" +
                    "\n2 - Para pegar os exemplos prontos" +
                    "\nS - Para encerrar digite s");
                opcao = Console.ReadLine().ToUpper();

                if (opcao == "S")
                    break;

                else if (EhOpcaoDigitar(opcao))
                {
                    Console.Clear();

                    Console.WriteLine("Insira a medida do lado A");
                    ladoA = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Insira a medida do lado B");
                    ladoB = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Insira a medida do lado C");
                    ladoC = Convert.ToDouble(Console.ReadLine());

                    Triangulo triangulo = new Triangulo(ladoA, ladoB, ladoC);

                    Console.WriteLine(triangulo.validar());

                    Console.ReadLine();
                }
                else if (EhOpcaoVisualizarProntos(opcao))
                {
                    Console.Clear();
                    Triangulo triangulo = MedidasProntas(3, 3, 3);

                    Console.WriteLine("\n---------------------\n");

                    triangulo = MedidasProntas(3, 3, 1);

                    Console.WriteLine("\n---------------------\n");

                    triangulo = MedidasProntas(4, 3, 2);

                    Console.WriteLine("\n---------------------\n");

                    triangulo = MedidasProntas(3, 2, 1);

                    Console.ReadLine();
                }
                else
                {
                    Console.Clear();

                    Console.WriteLine("Opção inválida, tente novamente!!");
                    Console.ReadLine();
                }
            } while (true);
        }

        private static bool EhOpcaoVisualizarProntos(string opcao)
        {
            return opcao == "2";
        }

        private static bool EhOpcaoDigitar(string opcao)
        {
            return opcao == "1";
        }

        private static Triangulo MedidasProntas(double A, double B, double C)
        {
            Console.WriteLine($"Lado A = {A}" +
                                    $"\nLado B = {B}" +
                                    $"\nLado C 'base' = {C}");

            Triangulo triangulo = new Triangulo(A, B, C);
            Console.WriteLine(triangulo.validar());
            return triangulo;
        }
    }
}
