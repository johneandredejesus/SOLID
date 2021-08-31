namespace Dependency_Inversion_Principle
{
    public class Dispositivo
    {
       private IDispositivo dispositivo;

       public Dispositivo(IDispositivo dispositivo)
       {
           this.dispositivo = dispositivo;
       }

       public void Acionar()
       {
           this.dispositivo.Acionar();
       }
    }
}