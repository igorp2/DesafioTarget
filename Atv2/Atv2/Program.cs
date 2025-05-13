using System;

namespace Atv2
{
    public class Program
    {
        public static bool VerificarFibonacci(int numero)
        {
            int elementoSeq = 2;
            int elementoAnt = 1;

            // Se o número for 0 ou 1, já pertence à sequência
            if (numero == 0 || numero == 1)
            {
                return true;
            }

            // Gerar a sequência até o número informado
            while (elementoSeq < numero)
            {
                int temp = elementoAnt + elementoSeq;
                elementoAnt = elementoSeq;
                elementoSeq = temp;
            }

            return elementoSeq == numero;
        }

        public static void Main()
        {
            int numero;

            //Garantir que a entrada seja um número válido
            while (true)
            {
                Console.Write("Informe um número inteiro positivo: ");
                string entrada = Console.ReadLine();

                if (int.TryParse(entrada, out numero) && numero >= 0)
                    break;

                Console.WriteLine("\nValor inválido!");
            }

            bool pertenceFibonacci = VerificarFibonacci(numero);

            Console.WriteLine(pertenceFibonacci
            ? $"O número {numero} pertence à sequência de Fibonacci."
            :$"O número {numero} não pertence à sequência de Fibonacci.");
        }
    }
}