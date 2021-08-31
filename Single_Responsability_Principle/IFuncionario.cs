namespace Single_Responsability_Principle
{
    public interface IFuncionario
    {
         string Nome { get; }
         double Salario { get; }
         ICargo Cargo { get; }
    }
}