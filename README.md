# health-calc-pack-dotnet
## Curso de Pós-Graduação em Engenharia de Software da PUC-MG

### Disciplina Projeto Integrado em Engenharia de Software

Objetivo: 

Uma biblioteca que permite cálculo de IMC e Macronutrientes, baseados nos dados inseridos pelo usuário.

# Utilização:

Instanciar um novo objeto do tipo IMC 

Methodos disponiveis > 
- Calc (Responsavél por retornar o numero IMC)
  - Parametros: Altura(Tipo Double) e Peso(Tipo Double)
  - Exemplo return Double RetornoIMC = ObjectIMC.Calc(Altura,Peso);
- IsValidData (Responsavél validar os dados informados)
  - Parametros: Altura(Tipo Double) e Peso(Tipo Double)
  - Exemplo: return bool RetornoIMC = ObjectIMC.IsValidData(Altura,Peso);
- GetIMCClass (Respponsavel por retornar a classe que o individo se encontra)
  - Parametros: IMC(Double)
  - Exemplo: return string RetornoIMC = ObjectIMC.GetIMCClass(IMC);
# Arquitetura

<img src='nutrition-calc-diagram.jpg' alt='Diagrama'>

# Tecnologias Utilizadas

- IDE

  - [Visual Studio](https://visualstudio.microsoft.com/pt-br/downloads/)

- Framework

  - .NET 6.0

- Testing

  - [XUnit.net](https://xunit.net/)

- Distribuição

  - [NuGet](https://www.nuget.org/)