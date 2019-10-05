using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace patronBridge
{
    // ImplementorConcretoA
public class Diesel : IMotor
    {
        #region IMotor Members

        public void InyectarCombustible(double cantidad)
        {
            Console.WriteLine("Inyectando " + cantidad + " ml. de Gasoil");
        }

        public void ConsumirCombustible()
        {
            RealizarExplosion();
        }

        #endregion

        private void RealizarExplosion()
        {
            Console.WriteLine("Realizada la explosión del Gasoil");
        }
    }
}
