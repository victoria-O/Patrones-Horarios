using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace patronBridge
{
    public class Monovolumen : Vehiculo
    {
        // Atributo propio
        private bool puertaCorrediza;

        // La implementacion de los vehículos se desarrolla de forma independiente
        public Monovolumen(IMotor motor, bool puertaCorrediza)
            : base(motor)
        {
            this.puertaCorrediza = puertaCorrediza;
        }

        // Implementación del método abstracto
        public override void MostrarCaracteristicas()
        {
            Console.WriteLine("Vehiculo de tipo Berlina " + (puertaCorrediza ? "con" : "sin") +
                " puerta corrediza.");
        }
    }
}
