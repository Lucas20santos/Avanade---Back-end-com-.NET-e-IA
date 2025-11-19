# Destaques

## palavra reserva out

Sim, **`out` é um *keyword* (palavra-chave) da linguagem C#**, usada principalmente em **parâmetros de saída** e também no **pattern matching** moderno.

---

### ✅ **1. `out` como parâmetro de saída**

É o uso mais comum.

Serve para **retornar mais de um valor** de um método.

Exemplo simples:

```csharp
void SomaEProduto(int x, int y, out int soma, out int produto)
{
    soma = x + y;
    produto = x * y;
}

int a = 5, b = 3;
SomaEProduto(a, b, out int s, out int p);

Console.WriteLine(s); // 8
Console.WriteLine(p); // 15
```

### Regras importantes:

* Você **deve atribuir um valor** ao parâmetro `out` dentro do método.
* O chamador **deve usar `out`** ao chamar.
* O valor original passado **não é usado** — ele é substituído.

---

# ❌ **Seu erro no código Fibonacci**

Você tentou:

```csharp
void fibonacci(int a, int b, out int a, out int b)
```

Isso falha porque:

* **Você não pode ter parâmetros com o mesmo nome** (`a` e `b` repetidos).
* E `out` não funciona do jeito que você tentou: ele não “atualiza" as variáveis passadas por valor sem você reatribuir nelas.

---

# ⭕ Como ficaria **correto**:

```csharp
void Fibonacci(in int a, in int b, out int newA, out int newB)
{
    newA = b;
    newB = a + b;
}

int a = 0, b = 1;

Fibonacci(a, b, out a, out b);

Console.WriteLine(a); // 1
Console.WriteLine(b); // 1
```

Note a diferença: os nomes são diferentes.

---

# ✅ **2. `out` também aparece em construtores com pattern matching (C# 8+)**

Exemplo:

```csharp
if (int.TryParse("123", out int n))
{
    Console.WriteLine(n);
}
```

Aqui ele cria a variável `n` dentro do próprio `if`.

---

# 🎯 Resumindo

| Palavra-chave | É operador? | Serve para quê?                                            |
| ------------- | ----------- | ---------------------------------------------------------- |
| `out`         | ❌ Não       | Passar variáveis por referência **como saída obrigatória** |

---

Se quiser, posso te mostrar **quando usar `out` vs `ref` vs `in`**, com exemplos.
