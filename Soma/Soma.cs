using System;

namespace Soma
{
    class ProgramaSoma
    {
        static void Main()

        {
            int numero1;
            int numero2;
            int soma;

            Console.WriteLine("Digite o primeiro número: ");
            var primeiroNumero = Console.ReadLine();

            Console.WriteLine("Digite o segundo número: ");
            var segundoNumero = Console.ReadLine();

            numero1 = Int32.Parse(primeiroNumero);
            numero2 = Int32.Parse(segundoNumero);

            soma = numero1 + numero2;

            Console.WriteLine($"O resultado da soma dos números {primeiroNumero} e {segundoNumero} é {soma}!");

        }
    }
}
