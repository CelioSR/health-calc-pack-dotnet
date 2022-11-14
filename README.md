# health-calc-pack-dotnet
## Curso de Pós-Graduação em Engenharia de Software da PUC-MG

### Disciplina Projeto Integrado em Engenharia de Software

Objetivo: 

Uma biblioteca que permite cálculo de IMC e Macronutrientes, baseados nos dados inseridos pelo usuário.

# Utilização:

Instanciar um novo objeto do tipo IMC 
**Version: 1.0.0:**
#### Methodos disponiveis > 
- Calc (Responsavél por retornar o numero IMC)
  - Parametros: ![#1589F0]Altura(Tipo Double)`#1589F0` e ![#1589F0]Peso(Tipo Double)`#1589F0`
  - Exemplo return Double RetornoIMC = ObjectIMC.Calc(![#1589F0]Altura `#1589F0`,![#1589F0]Peso`#1589F0`);
- IsValidData (Responsavél validar os dados informados)
  - Parametros: Altura(Tipo Double) e Peso(Tipo Double)
  - Exemplo: return bool RetornoIMC = ObjectIMC.IsValidData(![#1589F0]Altura`#1589F0`,![#1589F0]Peso`#1589F0`);
- GetIMCClass (Respponsavel por retornar a classe que o individo se encontra)
  - Parametros: IMC(Double)
  - Exemplo: return string RetornoIMC = ObjectIMC.GetIMCClass(![#1589F0]IMC`#1589F0`);
**Version: 1.0.1:**
- *Correção de bug no calculo de IMC, o qual estava estourando o tamanho da variavel, retornando erro nao  tratado ao cliente*;
**Version: 1.1.1:**
Methodos add:
- Calc (Responsavél por retornar os valores de micronutrientes com base no tipo de operação)
  - Parametros: 
    ![#1589F0]Sexo(int = 0 (Masculino) int = 1 (Feminino))`#1589F0`
    ![#1589F0]Altura(Tipo Double)`#1589F0`;
    ![#1589F0]Peso(Tipo Double)`#1589F0`;
    ![#1589F0]NivelAtividadeFisica(int = 0 (Sedentario) 
                         int = 1 (ModeradamenteAtivo)
                         int = 2 (BastanteAtivo)
                         int = 3 (ExtremamenteAtivo))`#1589F0`;
    ![#1589F0]ObjetivoFisico(int = 0 (Bulking) 
                   int = 1 (Cutting)
                   int = 2 (Maintenence))
  - Exemplo return Double RetornoIMC = ObjectIMC.Calc(Altura,Peso)`#1589F0`;
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