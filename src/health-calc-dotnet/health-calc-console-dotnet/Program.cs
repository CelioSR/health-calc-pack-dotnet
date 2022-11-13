using health_calc_pack_dotnet;

Console.WriteLine("Entre com o vosso pesso e altura, para efetuarmos o IMC!");
Console.WriteLine("OBS.: Ao utilizar, levar em consideração sua região, utilizar ',' e nao '.'");

Console.Write("Digite a altura: ");
var Altura = Console.ReadLine();

Console.Write("Digite a Peso: ");
var Peso = Console.ReadLine();
//Altura = "1,87";
//Peso = "187";
IMC objIMC = new IMC();

Double ValorIMC = objIMC.Calc(double.Parse(Altura), double.Parse(Peso));
string resultado = objIMC.GetIMCClass(ValorIMC);
Console.Write("Digite a Peso: "+ resultado);