namespace Atv4
{
    public class Program
    {
        public static void Main()
        {
            double[] faturamento = { 67836.43, 36678.66, 29229.88, 27165.48, 19849.53 };
            string[] estados = { "SP", "RJ", "MG", "ES", "Outros" };

            double totalFaturamento = 0;
            foreach (var valor in faturamento)
            {
                totalFaturamento += valor;
            }

            Console.WriteLine("Percentual de representação por estado:");
            for (int i = 0; i < faturamento.Length; i++)
            {
                double percentual = (faturamento[i] / totalFaturamento) * 100;
                Console.WriteLine($"{estados[i]}: {percentual:f2}%");
            }
        }
    }
}