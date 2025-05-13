## Desafio Técnico - Desenvolvedor de Sistemas Jr - Target Sistemas

Este repositório contém as soluções para as questões do **Desafio Técnico** proposto para a vaga de **Desenvolvedor de Sistemas Jr**  pela **Target Sistemas**. As questões abordam uma série de problemas de lógica de programação, manipulação de dados e cálculo de percentuais. A seguir, apresento a resolução de cada questão com uma explicação detalhada de como foi abordado cada problema.


## Questões Resolvidas 

### 1 - Cálculo da Soma de uma Sequência de Números

**Problema:**
Calcular a soma de todos os números inteiros de 1 até um valor INDICE dado. No caso do valor de INDICE ser 13, precisamos calcular a soma dos números de 1 a 13.

**Solução:**
Para resolver esse problema, utiliza-se um laço de repetição. Inicialmente, com o valor de K igual a 0 e, em cada iteração, incrementa-se o valor de K em 1, somando-o à variável SOMA. O loop continua até que K seja igual a INDICE (neste caso, 13).

**Resultado Final:**
Após o loop, a variável SOMA terá o valor 91, que é a soma dos números de 1 até 13.

### 2 - Sequência de Fibonacci

**Problema:**
Dado um número informado, calcular a sequência de Fibonacci até o número informado e verificar se esse número pertence à sequência.

**Solução:**
A sequência de Fibonacci é gerada a partir dos números 0 e 1, onde cada número subsequente é a soma dos dois números anteriores. O programa vai gerando a sequência e verifica se o número informado é um dos elementos da sequência.

**Resultado Final:**
O programa retornará uma mensagem dizendo se o número informado pertence ou não à sequência de Fibonacci.

### 3 - Cálculo de Faturamento Diário

**Problema:**
Calcular o menor valor de faturamento diário, o maior valor de faturamento diário e o número de dias em que o faturamento foi superior à média mensal, levando em consideração que alguns dias podem não ter faturamento.

**Solução:**
Primeiramente, lê-se os dados do arquivo `dados.json`, depois calcula o total de faturamento, considerando apenas os dias com faturamento. Em seguida, calcula a média dos valores de faturamento, ignorando os dias sem faturamento. Após isso, busca o menor e maior valor de faturamento, a média de faturamento e calcula o número de dias em que o faturamento foi superior à média mensal.

**Resultado Final:**
O programa fornece quatro resultados:

* O menor valor de faturamento.

* O maior valor de faturamento.

* O valor da média de faturamento.

* O número de dias com faturamento superior à média mensal.

### 4 - Cálculo do Percentual de Faturamento por Estado
**Problema:**
Calcular o percentual de representação de cada estado no faturamento total de uma distribuidora, dado o faturamento de cada estado.

**Solução:**
O programa calcula o total de faturamento somando os valores de cada estado. Em seguida, para cada estado, calcula-se o percentual de contribuição daquele estado para o total, utilizando a fórmula:

**Resultado Final:**
O programa retorna o percentual de faturamento de cada estado, exibindo a representação de cada um em relação ao faturamento total da distribuidora.

### 5 - Inversão de uma String
**Problema:**
Escrever um programa que inverta os caracteres de uma string.

**Solução:**
A string é convertida em um vetor de caracteres, e então esses caracteres são invertidos manualmente. A inversão é realizada sem o uso de funções prontas como `Reverse()`, utilizando manipulação direta do vetor de caracteres.

**Resultado Final:**
O programa exibe a string original com seus caracteres invertidos.

## Conclusão
As soluções fornecem uma abordagem clara e prática para resolver problemas comuns encontrados no desenvolvimento de sistemas. Cada questão foi resolvida de maneira eficiente, utilizando boas práticas de programação e algoritmos bem estabelecidos. As soluções foram elaboradas com foco na legibilidade e modularidade, o que facilita a manutenção e a expansão do código.

### Ferramentas e Tecnologias Utilizadas
**Linguagem de Programação:** C#

**IDE Recomendada:** Visual Studio ou Visual Studio Code

### Instruções para Execução
**Requisitos:**

* .NET 5 ou superior instalado.

* IDE recomendada: Visual Studio, Visual Studio Code, ou qualquer editor de sua escolha que suporte C#.

**Para Executar:**

* Clone este repositório e abra o projeto na sua IDE preferida.

* Compile e execute o código, alterando os valores de entrada conforme necessário para testar as diferentes soluções.