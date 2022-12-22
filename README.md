# Boas-vindas ao repositório do projeto Rent Cars 🚗🏍️

# Orientações

<details>
  <summary><strong>‼️ Para executar o projeto</strong></summary><br />

1. Clone o repositório

- Use o comando: `git clone git@github.com:Mathluiz23/rent-cars.git`.
- Entre na pasta do repositório que você acabou de clonar:
  - `cd rent-cars`

2. Instale as dependências

- Entre na pasta `src/`.
- Execute o comando: `dotnet restore`.

</details>

<details>
  <summary><strong>🛠 Testes</strong></summary><br />

### Executando todos os testes

Para executar os testes com o .NET, execute o comando dentro do diretório do projeto `src` ou de seus testes `src/RentCars.Test`!

```
dotnet test
```

</details>

# Projeto

O projeto Rent Cars consiste em um sistema de aluguéis de veículos. Onde é possível selecionar:
- O tipo de veículo que deseja alugar.
- A quantidade de dias que o veículo será locado.
- O tipo do locatário, se é um CPF OU CNPJ.
- O preço do aluguel, que será calculado automaticamente de acordo com o veículo, dias e o tipo de locatário.


O projeto está dividido em partes organizadas. Em `Model` foram realizadas as classes seguindo a seguinte hierarquia:

- `Vehicle.cs` descreve uma classe **abstrata** base para os veículos.

  - `Car.cs` descreve uma classe derivada para **carros**.
  - `Truck.cs` descreve uma classe derivada para **caminhões**.
  - `Motorcycle.cs` descreve uma classe derivada para **motos**.

- `Person.cs` descreve uma classe **abstrata** base para as pessoas clientes do sistema.

  - `PhysicalPerson.cs` descreve uma classe derivada para **pessoas físicas**.
  - `LegalPerson.cs` descreve uma classe derivada para **pessoas jurídicas**.

- `Rent.cs` descreve a classe para um aluguel entre uma **pessoa** e um **veículo**.

## `Struct` para as **Cores**
  Atributo público, criado com os campos Name e Hex do tipo string
<details>
  <summary>Testes</summary><br />
  Implementado Testes para verificar se a struct Color tem o atributo `Name` e `Hex` do tipo `string`.
</details>

## Construtor `Rent` criado seguindo as regras de negócio

<details>
  <summary>O construtor recebe uma instância de Vehicle, uma de Person e um valor inteiro com os dias alugados.</summary><br />

Para calcular o atributo `Price` irá seguir a seguinte regra:

- Para pessoas fisícas o preço deve ser o preço por dia do veículo \* os dias alugados.
- Para pessoas jurídicas o preço deve ser o preço por dia do veículo \* os dias alugados com 10% de desconto.

O status inicial será `RentStatus.Confirmed`.

O construtor irá alterar o atributo `IsRented` do veículo para true.
O construtor irá alterar o atributo `Debit` da pessoa para o Preço calculado.

</details>

<details>
  <summary>Testes</summary><br />

Teste implementado no arquivo `TestCreateRent` para verificar se a classe Rent criou corretamente uma instância com as regras de negócio descritas.

</details>

## Implementado enums com os diferentes parâmetros para a seleção dos veículos e os status do aluguel.

<details>
  <summary>Testes</summary><br />

Teste implementado no arquivo `TestEnums` para verificar se todos os parâmetros informados, correspondem aos parâmetros esperados para a confirmação de aluguel do veículo.

</details>
