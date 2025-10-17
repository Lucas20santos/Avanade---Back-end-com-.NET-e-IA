# Minhas Duvidas

## Pergunta

Nessa parte aqui: "Adicione as referências necessárias (o App e os Testes precisam "enxergar" o Core)" os outros projetos não precisariam "enxergar" o Core também ? Se não, porque não ?

## Resposta

Essa é uma ótima pergunta e demonstra que você está pensando corretamente sobre a arquitetura do projeto e o fluxo de dependências!

Você está no caminho certo. Na verdade, a regra é: **todo projeto que utiliza classes definidas em outro projeto precisa ter uma referência a ele.**

No seu cenário, as referências são estabelecidas da seguinte forma:

1. **`SmartphoneApp` precisa "enxergar" `SmartphoneCore`:**
    * O `SmartphoneApp` (seu projeto de console) é onde você cria instâncias das classes (`Nokia`, `Iphone`, `AppStoreService`, etc.) que estão definidas dentro do `SmartphoneCore`.
    * **Portanto, a referência é obrigatória:** `SmartphoneApp` $\rightarrow$ `SmartphoneCore`.

2. **`SmartphoneCore.Tests` precisa "enxergar" `SmartphoneCore`:**
    * O projeto de testes precisa acessar as classes que ele está testando (como `Smartphone`, `Nokia`, `StorageService`, etc.). Todas elas estão no `SmartphoneCore`.
    * **Portanto, a referência é obrigatória:** `SmartphoneCore.Tests` $\rightarrow$ `SmartphoneCore`.

### Por que o `SmartphoneCore` não precisa enxergar os outros?

O projeto `SmartphoneCore` é a **biblioteca de classes** (DLL) que contém a lógica de negócios, as entidades (Models) e os serviços. Ele é o coração do seu sistema e deve ser o mais independente possível.

* O `SmartphoneCore` **não precisa** de nenhuma referência para `SmartphoneApp` ou `SmartphoneCore.Tests`.
  * Ele não sabe nem precisa saber como a lógica será executada (`SmartphoneApp`).
  * Ele não sabe nem precisa saber como a lógica será testada (`SmartphoneCore.Tests`).

### Por que os outros não precisam se referenciar?

* O **`SmartphoneApp`** não precisa de referência para o **`SmartphoneCore.Tests`**, pois a aplicação de demonstração não se preocupa com os testes.
* O **`SmartphoneCore.Tests`** não precisa de referência para o **`SmartphoneApp`**, pois os testes unitários focam na lógica do Core.

### Resumo das Dependências (a seta indica "depende de")

| Projeto | Depende de | Razão |
| :--- | :--- | :--- |
| **`SmartphoneCore`** | **(Nenhum)** | É o domínio. Deve ser independente. |
| **`SmartphoneApp`** | `SmartphoneCore` | Precisa instanciar as classes de domínio (`Nokia`, `AppStore`, etc.). |
| **`SmartphoneCore.Tests`** | `SmartphoneCore` | Precisa acessar as classes que estão sendo testadas. |

Sua dúvida é muito perspicaz! As referências que sugeri (`dotnet add`) são justamente aquelas necessárias para que a lógica central (`Core`) seja utilizada (e testada) pelos projetos externos.
