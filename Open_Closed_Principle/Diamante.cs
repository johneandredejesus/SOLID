namespace Open_Closed_Principle
{
    public class Diamante : ITabelaDePreco
    {
        public double CalculaDesconto(ICompra compra)
        {
            if (compra.Valor >= 1000)
            {
                return compra.Valor * 0.90;
            }
            return compra.Valor;
        }
    }
}