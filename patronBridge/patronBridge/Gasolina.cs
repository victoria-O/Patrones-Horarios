using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace patronBridge
{
    // ImplementorConcretoB
    public class Gasolina : IMotor
    {
        #region IMotor Members

        public void InyectarCombustible(double cantidad)
        {
            Console.WriteLine("Inyectando " + cantidad + " ml. de Gasolina");
        }

        public void ConsumirCombustible()
        {
            RealizarCombustion();
        }

        #endregion

        private void RealizarCombustion()
        {
            Console.WriteLine("Realizada la combustión de la Gasolina");
        }
    }
}
