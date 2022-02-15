using System;

namespace Multiplicacao
{
    class ProgramaMultiplicacao
    {
        static void Main(string[] args)

        {
            int numero1;
            int numero2;
            int multiplicacao;

            Console.WriteLine("Digite o primeiro número: "
            var primeiroNumero = Console.ReadLine();

            Console.WriteLine("Digite o segundo número: ");
            var segundoNumero = Console.ReadLine();

            numero1 = Int32.Parse(primeiroNumero);
            numero2 = Int32.Parse(segundoNumero);

            multiplicacao = numero1 * numero2;

            Console.WriteLine($"O resultado da multiplicação dos números {primeiroNumero} e {segundoNumero} é {multiplicacao}!");

        }
    }
}
