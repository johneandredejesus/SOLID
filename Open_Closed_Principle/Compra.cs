namespace Open_Closed_Principle
{
   public class Compra: ICompra
{
      string cidade;

      double valor;

      public Compra(string cidade, double valor)
      {
          this.cidade = cidade;
          this.valor = valor;
      }

    public string Cidade { get => cidade; }
    public double Valor { get => valor; }
}
}