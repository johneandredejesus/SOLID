namespace Single_Responsability_Principle
{

    public  class Funcionario:IFuncionario
    {
        string nome;
        ICargo cargo;

        double salario;

        public Funcionario(string nome, ICargo cargo, double salario)
        {
            this.nome = nome;
            this.cargo = cargo;
            this.salario = salario;
        }

        public string Nome { get => nome; }
        public double Salario { get => salario; }
        public ICargo Cargo { get => cargo; }
    }
}