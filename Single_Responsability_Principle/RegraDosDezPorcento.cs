namespace Single_Responsability_Principle
{
    public class RegraDosDezPorcento : IRegraDeCalculo
    {
        public double Calcular(IFuncionario funcionario)
        {
            return funcionario.Salario * 0.90;
        }
    }
}