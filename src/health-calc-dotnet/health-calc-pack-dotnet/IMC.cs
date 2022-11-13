using health_calc_pack_dotnet.Interfaces;

namespace health_calc_pack_dotnet
{
    public class IMC :  InterfaceIMC
    {
        public double Calc(double Height, double Weight)
        {
            if (!IsValidData(Height, Weight))
                throw new Exception("Parametros invalidos.");

            return Math.Round(Weight / (Math.Pow(Height, 2)), 2);
        }

        public string GetIMCClass(double IMC)
        {
            var Result = string.Empty;
            if (IMC < 18.5)
                Result = "Abaixo do Peso";
            else if (IMC >= 18.5  && IMC < 25)
                Result = "SAUDAVEL";
            else if (IMC >= 25  && IMC < 30)
                Result = "Pre-Obeso";
            else if (IMC >= 30  && IMC < 35)
                Result = "Obesidade nivel 1";
            else if (IMC >= 35  && IMC < 40)
                Result = "Obesidade nivel 2";
            else if (IMC >= 40 )
                Result = "Obesidade nivel 3";

            return Result;
        }

        public bool IsValidData(double Height, double Weigth)
        {
            if (Height <= 0 || Weigth <= 0)
                return false;

            return true;
        }
    }

    public class InterfaceIMC
    {
    }
}