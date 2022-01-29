using System;
using System.Globalization;

namespace CalculaAreaTriangulo
{
    internal class Program
    {
        static void Main(string[] args)
        {

            AreaTriangulo triangulo = new AreaTriangulo();
            inicio:
            string opcaoMenu = "";

            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("Olá! Bem-vindo(a) ao calculador de Área do Triângulo...");
            Console.WriteLine("Nós usamos a Fórmula de Heron para calcular a Área do Triângulo, com ele não é necessár  io saber a altura do mesmo.");
            Console.WriteLine("Entre com o valor dos três lados do Triângulo e receba o valor de sua área calculada.");
            Console.WriteLine("Digite apenas números.");
            Console.WriteLine("----------------------------------------------");
            Console.Write("Digite o valor do lado A: ");
            triangulo.LadoA = double.Parse(ChecaCaracteres.ChecaVirgula(Console.ReadLine()));
            Console.WriteLine("----------------------------------------------");
            Console.Write("Digite o valor do lado B: ");
            triangulo.LadoB = double.Parse(ChecaCaracteres.ChecaVirgula(Console.ReadLine()));
            Console.WriteLine("----------------------------------------------");
            Console.Write("Digite o valor do lado C: ");
            triangulo.LadoC = double.Parse(ChecaCaracteres.ChecaVirgula(Console.ReadLine()));
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("A Área do Triângulo é: {0}", triangulo.CalculaAreaTriangulo().ToString("F4", CultureInfo.InvariantCulture));
            voltaMenu:
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine();
            Console.WriteLine("Desejada fazer outro cálculo: \ns - Sim\nn - Não");
            opcaoMenu = Console.ReadLine();

            switch(opcaoMenu)
            {
                case "s":
                case "S":
                    goto inicio;
                case "n":
                case "N":
                    break;
                default:
                    Console.WriteLine("Opção errada, tente novamente...");
                    Console.WriteLine("----------------------------------------------");
                    Console.WriteLine();
                    goto voltaMenu;
            }
        }
    }
}
