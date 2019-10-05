using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace patronBridge
{
    // Abstracción
    public abstract class Vehiculo
    {
        private IMotor motor;

        public Vehiculo(IMotor motor)
        {
            this.motor = motor;
        }

        // Encapsulamos la funcionalidad de la interfaz IMotor
        public void Acelerar(double combustible)
        {
            motor.InyectarCombustible(combustible);
            motor.ConsumirCombustible();
        }

        public void Frenar()
        {
            Console.WriteLine("El vehículo está frenando.");
        }

        // Método abstracto
        public abstract void MostrarCaracteristicas();
    }
}
