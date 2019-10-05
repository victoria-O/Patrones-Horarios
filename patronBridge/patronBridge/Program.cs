using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace patronBridge
{
    class Program
    {
        static void Main(string[] args)
        {
            IMotor motorDiesel = new Diesel();
            Vehiculo berlina = new Berlina(motorDiesel, 4);

            berlina.MostrarCaracteristicas();
            Console.WriteLine("-----------------------------------------------------");

            IMotor motorDiesel1 = new Diesel();
            Vehiculo berlina1 = new Berlina(motorDiesel, 4);

            berlina.MostrarCaracteristicas();
            berlina.Acelerar(2.4d);

            Console.ReadKey();
        }
    }
}
