using System;

namespace Single_Responsability_Principle
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario func = new Funcionario("johne", new Desenvolvedor(new RegraDosDezPorcento()), 3000.00);

            double salario = CalculadoraDeSalario.CalcularSalario(func);


        }
    }
}
