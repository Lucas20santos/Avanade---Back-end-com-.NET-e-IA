# 🚗 Projeto Estacionamento

Este projeto simula o funcionamento de um sistema de estacionamento, permitindo cadastrar, remover e listar veículos, além de gerenciar clientes, custos, pagamentos e históricos de entrada/saída.

## 🏗️ Estrutura de Classes

### 📋 1. `Menu`

Responsável por apresentar as opções do sistema ao usuário, incluindo o menu principal e as formas de pagamento.

- `apresentar()`: Exibe o menu principal.
- `apresetarFormaDePagamento()`: Mostra as opções de pagamento.
- `apresentarFormaDePagamentoCartaoDeCredito()`: Exibe opções de cartão de crédito.

### 👤 2. [`Cliente`](Models/Cliente.cs)

Representa o cliente do estacionamento.

- Propriedades: `Nome`, `Sobrenome`, `CPF`.
- Método: `formaDePagamento()`: (placeholder para lógica de pagamento).

### 🚙 3. [`Estacionamentos`](Models/Estacionamentos.cs)

Gerencia os veículos estacionados.

- Propriedades: `placaVeiculo`, lista privada `veiculos`.
- Métodos:
  - `AdicionarVeiculo(string? placa)`: Adiciona uma placa à lista de veículos.
  - `RemoverVeiculo()`: Remove uma placa informada pelo usuário.
  - `ListarVeiculos()`: Lista todas as placas estacionadas.

### 💸 4. [`Custo`](Models/Custo.cs)

Calcula e armazena os custos do estacionamento.

- Propriedades: `PRECOFIXO`, `PRECOPORHORA`, `precoDoAluguel`.
- Métodos:
  - `CalculoDoEstacionamento(decimal horas)`: Calcula o valor total do estacionamento.
  - `FixarPrecosFixo(decimal fixo)`: Define o preço fixo.
  - `fixarPrecoPorHora(decimal precoPorHora)`: Define o preço por hora.

### 🧾 5. [`Pagamento`](Models/Pagamento.cs)

Gerencia as formas de pagamento.

- Métodos:
  - `Pix()`: Simula pagamento via Pix.
  - `Dinheiro()`: Simula pagamento em dinheiro.
  - `cartaoDeCredito()`: Simula pagamento via cartão de crédito, permitindo escolher entre débito e crédito.

### 📜 6. [`Historico`](Models/Historico.cs)

Armazena o histórico de entrada e saída de veículos.

- Propriedades: `historicoEntrada`, `historicoSaida` (listas de strings).
- Métodos:
  - `atualizarHistoricoEntrada(...)`: Adiciona dados ao histórico de entrada.
  - `atualizarHistoricoSaida(...)`: Adiciona dados ao histórico de saída.
  - `mostrarHistoricoEntrada()`: Exibe o histórico de entrada.
  - `mostrarHistoricoSaida()`: Exibe o histórico de saída.

### 🏁 7. [`Program`](../Program.cs)

Classe principal que executa o sistema, gerenciando o fluxo do menu e integrando todas as funcionalidades.

---

## ▶️ Como usar

1. Execute o projeto.
2. Escolha uma opção no menu para adicionar, remover ou listar veículos.
3. Informe os dados solicitados para cada operação.
4. O sistema calcula custos, registra históricos e simula pagamentos.

---

## 💡 Observações

- O projeto pode ser expandido para incluir persistência de dados e interface gráfica.
- Cada classe pode ser adaptada para novas funcionalidades conforme necessidade.
