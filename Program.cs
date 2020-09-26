using System;

namespace Area_Triangulo_Ret
{
    class Program
    {
        static void Main(string[] args)
        {
            double Base;
            double Altura;
            double Area;

            Console.Write("Digite o valor da base (cm): ");
            Base = double.Parse(Console.ReadLine());

            Console.Write("Digite o valor da altura (cm): ");
            Altura = double.Parse(Console.ReadLine());
            Console.Write("\n");

            Console.WriteLine($"A área do triângulo é: {Area = Base * Altura / 2} (cm²) ");

            Console.WriteLine("Pressione Enter para sair!");
            Console.ReadKey();

        }
    }
}
