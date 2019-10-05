using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace patronBridge
{
    // RefinamientoAbstraccionA
    public class Berlina : Vehiculo
    {
        // Atributo propio
        private int capacidadMaletero;

        // La implementacion de los vehículos se desarrolla de forma independiente
        public Berlina(IMotor motor, int capacidadMaletero) : base(motor)
        {
            this.capacidadMaletero = capacidadMaletero;
        }

        // Implementación del método abstracto
        public override void MostrarCaracteristicas()
        {
            Console.WriteLine("Vehiculo de tipo Berlina con un maletero con una capacidad de " +
                capacidadMaletero + " litros.");
        }
    }
}
