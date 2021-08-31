using System;


namespace Open_Closed_Principle
{
    class Program
    {
        static void Main(string[] args)
        {
            CalculaCompra calcula = new CalculaCompra();
        
            calcula.Calcular(new Compra("teresopolis", 1000), new Diamante(), new Correios());

        }
    }
}
