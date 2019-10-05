using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace patronBridge
{
    // Implementor
    public interface IMotor
    {
        void InyectarCombustible(double cantidad);
        void ConsumirCombustible();
    }
}
