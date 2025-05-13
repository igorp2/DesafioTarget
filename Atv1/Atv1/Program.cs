namespace Atv1
{
    public class Program
    {
        public static void Main()
        {
            int indice = 13, soma = 0, k = 0;

            while (k < indice)
            {
                k++;
                soma += k;
            }

            Console.WriteLine("Soma: " + soma);
        }
    }
}