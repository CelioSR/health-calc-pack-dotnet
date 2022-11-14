using health_calc_pack_dotnet;
IMC objIMC = new IMC();
var Altura = "";
var Peso = "";
string resultado = "";
Double ValorIMC = new double();
Console.WriteLine("Entre com o vosso pesso e altura, para efetuarmos o IMC!");
Console.WriteLine("OBS.: Ao utilizar, levar em consideração sua região, utilizar ',' e nao '.'");

Console.Write("Digite a altura: ");
Altura = Console.ReadLine();

Console.Write("Digite a Peso: ");
Peso = Console.ReadLine();

ValorIMC =  objIMC.Calc(double.Parse(Altura), double.Parse(Peso));
resultado = objIMC.GetIMCClass(ValorIMC);
Console.Write("Digite a Peso: " + resultado);