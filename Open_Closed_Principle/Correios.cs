namespace Open_Closed_Principle
{
    public class Correios : IFrete
    {
        public double para(string cidade)
        {
            cidade = cidade.ToLower();

            if (cidade == "teresopolis")
                return 5.00;
            else if (cidade == "rio de janeiro")
                return 30.00;
            else if (cidade == "sao paulo")
                return 60.00;

            return 100.00;
        }
    }
}