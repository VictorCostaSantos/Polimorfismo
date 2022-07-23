using System;
using FormasGeoMetricas.src;

namespace FormasGeoMetricas
{

    internal class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Encontre a área geométrica\n" +
                "=== 1 - Quadrado  ===\n" +
                "=== 2 - Retangulo ===\n" +
                "=== 3 - Triangulo ===\n" +
                "=== 0 - Desligar  ===\n" +
                "Qual opção deseja encontrar ?\n");
            int opcao = int.Parse(Console.ReadLine());

            if (opcao == 1)
            {
                Console.WriteLine("=== Área do Quadrado ===");
                Console.Write("Digite o valor da Base: ");
                double Base = double.Parse(Console.ReadLine());

                Console.Write("Digite o valor da Altura: ");
                double Altura = double.Parse(Console.ReadLine());
                Quadrado quadrado = new Quadrado(Base, Altura);

                Console.WriteLine($"Total da área do Quadrado é: {quadrado.Areatotal()}");

            }
            else if (opcao == 2)
            {
                Console.WriteLine("=== Área do Retangulo ===");
                Console.Write("Digite o valor da Base: ");
                double Base = double.Parse(Console.ReadLine());

                Console.Write("Digite o valor da Altura: ");
                double Altura = double.Parse(Console.ReadLine());
                Retangulo retangulo = new Retangulo(Base, Altura);

                Console.WriteLine($"Total da área do Retangulo é: {retangulo.Areatotal()}");
            }
            else if (opcao == 3)
            {
                Console.WriteLine("=== Área do Triangulo ===");
                Console.Write("Digite o valor da Base: ");
                double Base = double.Parse(Console.ReadLine());

                Console.Write("Digite o valor da Altura: ");
                double Altura = double.Parse(Console.ReadLine());
                Triangulo triangulo = new Triangulo(Base, Altura);

                Console.WriteLine($"Total da área do Triangulo é: {triangulo.Areatotal()}");
            }
            else
            {
                Console.WriteLine("Desligando o programa.");
            }
        }

    }
}



