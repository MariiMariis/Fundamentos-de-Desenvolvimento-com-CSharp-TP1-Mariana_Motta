using System;

namespace Subtracao
{
    class ProgramaSubtracao
    {
        static void Main(string[] args)

        {
            int numero1;
            int numero2;
            int subtracao;

            Console.WriteLine("Digite o primeiro número: ");
            var primeiroNumero = Console.ReadLine();

            Console.WriteLine("Digite o segundo número: ");
            var segundoNumero = Console.ReadLine();

            numero1 = Int32.Parse(primeiroNumero);
            numero2 = Int32.Parse(segundoNumero);

            subtracao = numero1 - numero2;

            Console.WriteLine($"O resultado da subtração dos números {primeiroNumero} e {segundoNumero} é {subtracao}!");

        }
    }
}
