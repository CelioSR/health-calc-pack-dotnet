namespace health_calc_pack_dotnet.Interfaces
{
    public interface IMC
    {
        double Calc(double Height, double Weigth);

        string GetBMIClass(double IMC);

        bool IsValidData(double Height, double Weigth);


    }
}
