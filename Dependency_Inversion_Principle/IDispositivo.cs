namespace Dependency_Inversion_Principle
{
    public interface IDispositivo
    {
        void Desligar();

        void Ligar();

        void Acionar();

        bool Status { get; }
    }
}