namespace Atv5
{
    public class Program
    {
        public static void Main()
        {
            Console.Write("Informe uma palavra ou frase para obter seu inverso: ");
            string texto = Console.ReadLine();
            string inversoTexto = "";

            for(int i = texto.Length - 1; i >= 0; i--)
            {
                inversoTexto += texto[i];
            }

            Console.WriteLine($"O inverso de {texto} é {inversoTexto}");
        }
    }
}