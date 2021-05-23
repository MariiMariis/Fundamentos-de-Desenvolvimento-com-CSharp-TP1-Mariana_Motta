using System;

namespace Divisao
{
    class ProgramaDivisao
    {
        static void Main(string[] args)

        {
            decimal numero1;
            decimal numero2;
            decimal divisao;

            Console.WriteLine("Digite o primeiro número: ");
            var primeiroNumero = Console.ReadLine();

            Console.WriteLine("Digite o segundo número: ");
            var segundoNumero = Console.ReadLine();

            numero1 = decimal.Parse(primeiroNumero);
            numero2 = decimal.Parse(segundoNumero);

            divisao = numero1 / numero2;

            Console.WriteLine($"O resultado da divisão dos números {primeiroNumero} e {segundoNumero} é {divisao}!");

        }
    }
}
