namespace Single_Responsability_Principle
{
    public class CalculadoraDeSalario
    {
        public static double CalcularSalario(Funcionario funcionario)
        {
            return funcionario.Cargo.RegraDeCalculo.Calcular(funcionario);
        }
    }
}