using System;

namespace Dependency_Inversion_Principle
{

  
    class Program
    {
        static void Main(string[] args)
        {
            IDispositivo motor = new Motor();

            Dispositivo dispositivo = new Dispositivo(motor);

            dispositivo.Acionar();
        }
    }
}
