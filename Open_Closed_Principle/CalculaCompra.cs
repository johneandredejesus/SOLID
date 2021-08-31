namespace Open_Closed_Principle
{
    public class CalculaCompra
    {
        public double Calcular(ICompra compra, ITabelaDePreco tabela, IFrete frete)
        {
            return tabela.CalculaDesconto(compra) + frete.para(compra.Cidade);
        }
    }
}