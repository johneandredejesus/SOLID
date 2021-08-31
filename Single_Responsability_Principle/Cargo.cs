namespace Single_Responsability_Principle
{
    public abstract class Cargo : ICargo
    {
        IRegraDeCalculo regraDeCalculo;
        public Cargo(IRegraDeCalculo regraDeCalculo)
        {
            this.regraDeCalculo = regraDeCalculo;
        }
        public IRegraDeCalculo RegraDeCalculo { get => regraDeCalculo; }
    }
}