using System.Text.Json;

namespace Atv3
{
    public class DiaFaturamento
    {
        public int dia { get; set; }
        public double valor { get; set; }
    }
    public class Program
    {
        public static void Main()
        {
            //Garantir que acesse a pasta do projeto
            string diretórioProjeto = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName;

            string caminhoArquivo = Path.Combine(diretórioProjeto, "dados.json");

            // Verifica se o arquivo existe
            if (File.Exists(caminhoArquivo))
            {
                try
                {               
                    string conteudo = File.ReadAllText(caminhoArquivo);

                    // Desserializa o conteúdo para lista de objetos
                    List<DiaFaturamento> dados = JsonSerializer.Deserialize<List<DiaFaturamento>>(conteudo);

                    // Filtra apenas os dias com faturamento maior que 0
                    var diasComFaturamento = dados.Where(d => d.valor > 0).ToList();

                    // Calcula o menor, maior e a média
                    double menorFaturamento = diasComFaturamento.Min(d => d.valor);
                    double maiorFaturamento = diasComFaturamento.Max(d => d.valor);
                    double mediaFaturamento = diasComFaturamento.Average(d => d.valor);
                    int diasAcimaMedia = diasComFaturamento.Count(d => d.valor > mediaFaturamento);

                    // Exibe os resultados
                    Console.WriteLine();
                    Console.WriteLine($"Menor faturamento excluindo dias sem faturamento: R$ {menorFaturamento:f2}");
                    Console.WriteLine($"Maior faturamento: R$ {maiorFaturamento:f2}");
                    Console.WriteLine($"Média mensal excluindo dias sem faturamento: R$ {mediaFaturamento:f2}");
                    Console.WriteLine($"Dias com faturamento acima da média: {diasAcimaMedia}");
                }
                catch (Exception ex)
                {
                    // Caso ocorra algum erro ao ler o arquivo
                    Console.WriteLine($"Ocorreu um erro ao ler o arquivo: {ex.Message}");
                }
            }
            else
            {
                Console.WriteLine($"O arquivo {caminhoArquivo} não foi encontrado.");
            }
        }
    }
}