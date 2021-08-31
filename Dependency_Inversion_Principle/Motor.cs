namespace Dependency_Inversion_Principle
{
    public class Motor : IDispositivo
    {
        public bool Status { get; private set; }

        public void Desligar()
        {
            Status = false;
        }

        public void Ligar()
        {
            Status = true;
        }

        public void Acionar()
        {
            if (Status)
                this.Desligar();
            else
                this.Ligar();
        }

    }
}