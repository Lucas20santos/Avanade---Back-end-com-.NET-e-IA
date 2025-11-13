# Fundamentos Parte 2

```cs
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace HelloWorld
{
public class Program
{
    public static void Main(string[] args)
    {
        /* Tipo null
        *
        * A interrogação indicar que a minha variável valor, 
        *  apeser de ser booleano, tbm pode aceitar o valor null.
        */
        bool? valor = true;

        if(valor.HasValue && valor.Value)
        {
            Console.WriteLine("O usuario optou por receber e-mail.");
        }
        else
        {
            Console.WriteLine("O usuário optou por não receber email ou não respondeu.");
        }
        
        /* Tipo Anonimo
        *
        * Os tipos anonimos fornecem um modo conveniente de encapsulamr propriedade
        * somente de leitura. 
        */
        
        var tipoAnonimo = new { Nome = "Lucas", Sobrenome = "De Souza Santos", Idade = 32};
        Console.WriteLine(tipoAnonimo.Nome);
        
        List<object[]> valores = new List<object[]>
        {
            new object[] {
            1, "Material de Escritorio", 25, null
            }
        };
    
    object[] Item1 = valores[0];
    
    object Id = Item1[0];
    
    Console.WriteLine(valores[0][0]);
    
    var listaAnonima = valores.Select(x => new 
    {
    Id = x[0],             // Propriedade chamada 'Id'
    Descricao = x[1],      // Propriedade chamada 'Descricao'
    Quantidade = x[2],     // Propriedade chamada 'Quantidade'
    Status = x[3]          // Propriedade chamada 'Status'
    });


foreach(var item in listaAnonima)
{
    Console.WriteLine($"{item.Id}");
}
        
    /*
        Variáveis Dinâmicas
    */  
        
dynamic variavelDinamica = 8;
Console.WriteLine($"Variavel Dinamica antes: {variavelDinamica}");
variavelDinamica = "Lucas";
Console.WriteLine($"Variavel Dinamica depois: {variavelDinamica}");

/*
    Classes genericas
    
    As classes genéricas encapsulam operações que não são especificas de um 
    determinado tipo de dados.
    
    List<tipo> lista = new List<tipo>();
    
*/

        
    MeuArray<int> arrayInteiro = new MeuArray<int>();
    
    arrayInteiro.AdicionarElementoArray(30);
    Console.WriteLine(arrayInteiro[0]);
    
    /*
    * Métodos de extensões:
        Os métodos de extensões permite que você "adicione" tipos existente
        sem criar um novo tipo derivado, recopilar ou, caso contrário, modificar
        o tipo original.
    */
    
    int numero = 20;
    bool par = false;
    
    
    par = numero.EhPar();
    
    string mensagem = "O numero " + numero + " é " + (par ? "Par": "Impar");
    Console.WriteLine(mensagem);
    }
}
}
```

```cs
using System;

namespace HelloWorld
{
public class MeuArray<T>
{
    private static int capacidade = 10;
private int contador = 0;
private T[] array = new T[capacidade];

public void AdicionarElementoArray(T elemento)
{
    if(contador + 1 < 11)
    {
    array[contador] = elemento;
    contador++;
    }
}

public T this[int index]
{
    get { return array[index]; }
    set { array[index] = value; }
}
}
}
```

```cs
using System;

namespace HelloWorld
{
public static class IntExtensao
{
public static bool EhPar(this int numero)
{
    return numero % 2 == 0;
}
}
}
```
