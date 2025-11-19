# 💯 100 Exercícios de Fundamentos em C# (Fase 1)

## Bloco 1: Lógica Básica e Sintaxe (Exercícios 1 a 20)

1. "Escreva um programa que imprima ""Hello, C# World!"" no console.","I/O, Console.WriteLine()"
1. "Crie duas variáveis inteiras, some-as e exiba o resultado.","Variáveis, Operadores"
1. "Peça ao usuário que digite seu nome e, em seguida, cumprimente-o usando o nome.","Console.ReadLine(), Concatenação"
1. Calcule a área de um retângulo pedindo a altura e a largura ao usuário.,"Variáveis, Conversão de Tipo (int.Parse ou Convert.ToInt32)"
1. Calcule o dobro de um número fornecido pelo usuário.,"Variáveis, Multiplicação"
1. Converta uma temperatura de Celsius para Fahrenheit.,"Fórmula, Variáveis float/double"
1. Determine se um número inteiro é par ou ímpar.,"Operador Módulo (%), if/else"
1. Calcule a média de três notas e exiba se o aluno foi Aprovado (Média ≥7) ou Reprovado.,"Operadores, if/else"
1. Crie uma constante para o valor de PI (3.14159) e calcule a área de um círculo.,"const, Variáveis double"
1. Troque o valor de duas variáveis (A e B) sem usar uma terceira variável (Dica: use operações matemáticas).,"Lógica, Operadores"
1. Verifique se a idade digitada pelo usuário é maior ou igual a 18 anos.,"if/else, Comparação"
1. "Receba um nome e a idade; imprima o nome e se a pessoa é ""Jovem"" (≤30) ou ""Adulta"" (>30).",if/else aninhado
1. Use o operador ternário para verificar se um número é positivo ou negativo.,Operador Ternário (? :)
1. "Verifique se um ano digitado é bissexto (divisível por 4, mas não por 100, a menos que seja divisível por 400).","if/else complexo, Operador Lógico && e ||"
1. Receba um número e imprima a tabuada desse número (1 a 10).,Laço for
1. Calcule a soma de todos os números de 1 até 100.,"Laço for, Variável acumuladora"
1. Conte quantas vezes um caractere específico aparece em uma string.,"Laço foreach, Manipulação de string"
1. Imprima todos os números pares de 0 a 50 usando o laço while.,"Laço while, Operador Módulo"
1. "Crie um menu de opções (1-Sacar, 2-Depositar, 3-Sair) e use o switch para simular ações.",switch/case
1. "Crie um programa que permita o usuário digitar um número. Se o número for 0, saia do programa. Use do-while.",Laço do-while

## Bloco 2: Estruturas de Dados e Coleções (Exercícios 21 a 40)

(Foco: Arrays, Listas, LINQ Básico, Strings e Datas)

1. Declare um Array de 5 números inteiros e os inicialize.,Array
1. Preencha um Array de 10 posições com números digitados pelo usuário.,"Array, Laço for"
1. Encontre o maior e o menor valor em um Array de 10 números.,"Array, Laço, Lógica de comparação"
1. Calcule a média dos valores de um Array de double.,"Array, Laço, Acumulador"
1. Use a classe List\<string> para criar uma lista de compras e adicione 3 itens.,"List<\T>, Add()"
1. Remova um item específico de uma List\<int> dado o seu valor.,"List\<T>, Remove()"
1. Verifique se um nome específico está presente em uma List\<string>.,"List\<T>, Contains()"
1. Use LINQ para encontrar todos os números pares em uma List\<int>.,LINQ (Where)
1. Use LINQ para ordenar uma List\<string> em ordem alfabética.,LINQ (OrderBy)
1. Converta uma List\<string> em um Array\<string>.,"List\<T>, ToArray()"
1. "Crie uma Dictionary<string, string> para armazenar 3 capitais e seus países.","Dictionary<T, T>"
1. "Pesquise e exiba o país de uma capital fornecida, usando o Dictionary.","Dictionary<T, T>, ContainsKey()"
1. Crie um Array de string e exiba todos os elementos em letras maiúsculas.,"Manipulação de string, .ToUpper()"
1. Receba uma string e inverta a ordem dos seus caracteres.,"string, Laço for reverso"
1. Peça ao usuário que digite uma frase e conte o número de palavras (dica: use o espaço como divisor).,"string, .Split()"
1. Use a classe DateTime para exibir a data e a hora atuais.,DateTime.Now
1. Calcule e exiba quantos dias faltam para o seu aniversário.,"DateTime, Subtração de Datas"
1. Crie uma List\<double> e use LINQ para calcular a soma de todos os elementos.,LINQ (Sum())
1. Crie uma matriz 2x2 e preencha-a com números inteiros (Matriz Bidimensional).,"int[,], Laços aninhados"
1. Crie um HashSet\<int> e adicione números. Tente adicionar um número repetido e observe o resultado (para entender conjuntos).,HashSet\<T>

## Bloco 3: Funções e Métodos (Exercícios 41 a 60)

(Foco: Métodos estáticos, Reuso de Código, Parâmetros)

1. Crie um método estático chamado ImprimirBoasVindas() que não recebe argumentos e não retorna valor.,"static void, Sem parâmetros"
1. "Crie um método estático Somar(int a, int b) que retorna a soma dos dois números.","static int, Retorno"
1. "Crie um método CalcularAreaTriangulo(double base, double altura) que retorna o resultado.","static double, Parâmetros"
1. Crie um método que recebe um string e um int (idade) e imprime uma frase completa.,"static void, Múltiplos parâmetros"
1. Crie um método que inverte uma string e use-o no Program.cs.,Reuso de Código
1. "Crie um método com parâmetros opcionais para calcular potência (base e expoente, expoente padrão = 2).",Parâmetros Opcionais
1. Crie um método que aceita um Array<\int> e retorna a soma de seus elementos.,Parâmetro Array
1. "Crie um método que converte um valor de dólar para real, usando uma taxa fixa.",static double
1. Refatore o exercício da Tabuada (Ex. 15) para ser um método GerarTabuada(int numero).,Refatoração para Método
1. Crie um método recursivo para calcular o fatorial de um número.,Recursão
1. Crie um método que recebe um string e retorna se ela é um palíndromo (lida da mesma forma de trás para frente).,Lógica em método
1. Crie um método que recebe um Array<\int> e retorna o número de elementos pares.,"Laço, Retorno de int"
1. "Crie um método que simula um lançamento de dado, retornando um número aleatório entre 1 e 6.",Classe Random
1. Crie um método com parâmetro out para retornar a soma e a subtração de dois números simultaneamente.,Parâmetro out
1. Crie um método com parâmetro ref para dobrar o valor de uma variável passada.,Parâmetro ref
1. Crie um método que aceita um número variável de argumentos inteiros (params) e retorna a soma deles.,Palavra-chave params
1. Crie um método que recebe uma string e retorna a mesma string com a primeira letra de cada palavra em maiúscula.,Manipulação de string
1. Crie um método que verifica se uma data é final de semana (Sábado ou Domingo).,DateTime.DayOfWeek
1. Crie um método que retorna o valor máximo de três números passados como argumentos.,Lógica de comparação
1. "Crie um método sobrecarregado (overload) chamado Multiplicar que aceite: (a) dois inteiros, e (b) três doubles.",Sobrecarga de Método

## Bloco 4: Orientação a Objetos (POO) Básica (Exercícios 61 a 80)

(Foco: Classes, Objetos, Construtores, Encapsulamento, Propriedades)

1. Crie uma classe Pessoa com os campos Nome e Idade.,"Classe, Objeto"
1. Crie dois objetos da classe Pessoa e defina seus valores.,Instanciação
1. Adicione um construtor à classe Pessoa que exige Nome e Idade na criação.,Construtor
1. Crie um método Apresentar() na classe Pessoa que imprime as informações.,Método de Instância
1. Modifique os campos Nome e Idade da Pessoa para serem Propriedades automáticas ({ get; set; }).,Propriedades Auto-Implementadas
1. Modifique a propriedade Idade para ser somente leitura ({ get; }) e defina seu valor apenas no construtor.,Propriedades readonly
1. Crie uma classe ContaBancaria com as propriedades Numero e Saldo.,Propriedades
1. "Na ContaBancaria, adicione um método Depositar(double valor) e Sacar(double valor).",Métodos de Instância
1. Implemente a regra de negócio: o Saldo nunca pode ser negativo após um saque (use if/else).,Encapsulamento (Regra)
1. Crie uma propriedade calculada SaldoEmDolar na ContaBancaria que converte o saldo usando uma taxa fixa.,Propriedade Calculada
1. "Crie uma classe Produto com Nome, Preco e Estoque.",Classe
1. "Adicione um construtor que aceita Nome e Preco, mas inicializa Estoque com 0.",Construtor com valores padrão
1. Crie o método AdicionarEstoque(int quantidade) na classe Produto.,Método de Modificação
1. Crie uma propriedade PrecoComDesconto que retorna o preço menos 10%.,Propriedade Calculada
1. Crie uma Classe Estática chamada Calculadora e adicione métodos estáticos Somar e Subtrair.,"Classe Estática, Métodos Estáticos"
1. Crie uma classe Retangulo com Largura e Altura e um método que retorna a Área.,POO
1. Crie uma lista de objetos Produto e use LINQ para encontrar o produto mais caro.,LINQ em Objetos
1. "Crie um construtor sobrecarregado na classe Pessoa: um recebe Nome e Idade, o outro só recebe Nome (idade padrão 0).",Sobrecarga de Construtor
1. Crie um List\<ContaBancaria> e use LINQ para encontrar todas as contas com saldo superior a 1000.,LINQ em Coleções de Objetos
1. "Na classe Produto, use uma exceção (throw new ArgumentOutOfRangeException) no setter da propriedade Preco se o valor for negativo.",Validação no Setter

## Bloco 5: Herança e Abstração Básica (Exercícios 81 a 100)

(Foco: Herança, Membros Estáticos, Classes Abstratas, Getters/Setters Customizados)

1. Crie uma classe base Animal com a propriedade Nome.,Classe Base
1. Crie uma classe Cachorro que herda de Animal.,Herança (: Animal)
1. "Crie um método EmitirSom() em Animal (apenas imprime ""Som genérico"").",Método na Classe Base
1. "Crie um método new em Cachorro chamado EmitirSom() que imprime ""Latido"" (esconder método base).",Método new (Opcional)
1. Crie uma classe base Veiculo com o método Mover() e uma propriedade VelocidadeMaxima.,Herança
1. Crie as classes Carro e Moto herdando de Veiculo.,Herança
1. Crie uma classe Funcionario com Nome e Salario.,POO
1. Crie uma classe Gerente que herda de Funcionario e adicione a propriedade Departamento.,Herança
1. "No construtor de Gerente, use a palavra-chave base para chamar o construtor de Funcionario.",Palavra-chave base
1. Crie um método CalcularBonus() em Funcionario (retorna Salario * 0.1).,Lógica de Negócio Base
1. Sobrescreva o método CalcularBonus() em Gerente para retornar o bônus dobrado (Salario * 0.2).,Polimorfismo (Uso de virtual/1)
1. Crie uma classe Utils com um campo static ContadorDeObjetos e incremente-o a cada nova instância de uma classe.,Membros 1
1. Crie uma propriedade Codigo para a Pessoa que tem um private set e é gerada automaticamente no construtor.,Encapsulament1 de1
1. Crie uma Classe Abstrata chamada FormaGeometrica com um método abstrato CalcularArea().,"Classe Abstrata, Método Abstrat1"1. Crie as classes Quadrado e Circulo que herdam de FormaGeometrica.,Herança1. Implemente (override) o método CalcularArea() em Quadrado e Circulo.,Implementação de Métodos Abstratos1. Crie uma lista de FormaGeometrica e adicione um Quadrado e um Circulo (Polimorfismo).,Polimorfismo com Abstração1. Crie uma classe Log com um método estático EscreverLog(string mensagem) que imprime a mensagem com um DateTime no consol1.,Classe Estática para Utilitário
1. "Na ContaBancaria, use getters e setters customizados: se o saldo for depositado, adicione uma taxa de R$ 1.",Getter/Setter customizado
1. Use o Log.EscreverLog() (do Ex. 98) dentro dos métodos Depositar e Sacar da ContaBancaria.,Reuso de Classe Estática Utilitária

## Bloco Extra: Tratamento e Lançamento de Exceções (Exercícios 101 a 120)

(Foco: try-catch, throw, Classes de Exceção, Exceções Customizadas)

1. Crie um método que divide dois números. Use um bloco try-catch para capturar e tratar a exceção DivideByZeroException.,"try-catch, DivideByZeroException"
1. Peça ao usuário um número e converta para int. Use try-catch para capturar a exceção FormatException se o input não for um número válido.,"try-catch, FormatException"
1. Crie uma List\<string> e tente acessar um índice que não existe (Ex: índice 10). Capture a exceção ArgumentOutOfRangeException.,"try-catch, ArgumentOutOfRangeException"
1. "Crie um método CalcularRaizQuadrada(double n). Se n for negativo, use a palavra-chave throw para lançar uma ArgumentException com uma mensagem descritiva.","throw, ArgumentException"
1. "Crie um Dictionary\<int, string> e tente adicionar um par chave-valor com uma chave já existente. Capture a exceção ArgumentException.",try-catch em coleções
1. Crie uma classe de exceção customizada chamada SaldoInsuficienteException que herda de Exception.,Exceção Customizada
1. "Na classe ContaBancaria (Ex. 67), no método Sacar(double valor), se o saldo for menor que o saque, lance a SaldoInsuficienteException.",throw de Exceção Customizada
1. Crie um método principal que chame o método Sacar (Ex. 107) e use try-catch para capturar especificamente a SaldoInsuficienteException.,catch Específico
1. Crie um método que recebe um caminho de arquivo e tente abri-lo. Capture a exceção genérica Exception e imprima a mensagem de erro.,"try-catch genérico, Exception"
1. "Implemente um bloco finally que, independentemente de haver erro ou não, imprima a mensagem ""Operação Finalizada"".",Bloco finally
1. Crie uma classe Usuario com a propriedade Email. Use throw no setter para lançar uma ArgumentNullException se o e-mail for nulo ou vazio.,Validação com throw no Setter
1. Crie um método que chama outro método que pode lançar duas exceções diferentes (FormatException e DivideByZeroException). Use múltiplos blocos catch para tratá-las de forma distinta.,Múltiplos catch
1. Crie uma exceção customizada SenhaInvalidaException e lance-a se uma senha digitada tiver menos de 8 caracteres.,Exceção Customizada
1. Crie um método que lê uma string longa e tente convertê-la para o tipo long. Capture a exceção OverflowException se o número for muito grande.,"try-catch, OverflowException"
1. Crie um bloco try-catch onde o bloco catch relança a exceção (throw;) após registrar o erro em um log (imprimindo no console).,Relançamento (throw;)
1. Crie uma classe EstoqueVazioException (customizada). Use-a no método VenderProduto() da classe Produto (Ex. 71) se o Estoque for 0.,Exceção Customizada e Lançamento
1. Crie uma exceção customizada IdadeInvalidaException. Use-a para garantir que a Idade na classe Pessoa seja sempre maior que 0.,Validação no Construtor/Setter
1. "Crie um método que lê um arquivo e use a instrução using para garantir que o recurso seja fechado corretamente, mesmo que ocorra uma exceção (Dispensa finally).",Instrução using (gerenciamento de recursos)
1. "Crie um método que recebe um objeto Funcionario (Ex. 87). Se o objeto for null, lance uma NullReferenceException explicitamente.",throw new NullReferenceException(...)
1. Refatore o exercício de Múltiplos catch (Ex. 112) para usar um único bloco catch que captura a classe base Exception e usa o operador is ou GetType() para identificar a exceção específica.,catch genérico com inspeção de tipo
