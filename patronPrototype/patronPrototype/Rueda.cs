using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace patronPrototype
{
    public class Rueda : ICloneable
    {
        public int Diametro { get; set; }
        public string Llanta { get; set; }
        public string Neumatico { get; set; }

        #region ICloneable Members

        public object Clone()
        {
            return this.MemberwiseClone();
        }

        #endregion
    }
}
