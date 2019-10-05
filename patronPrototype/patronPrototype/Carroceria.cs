using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace patronPrototype
{
    public class Carroceria : ICloneable
    {
        public bool HabitaculoReforzado { get; set; }
        public string Material { get; set; }
        public string TipoCarroceria { get; set; }

        #region ICloneable Members

        public object Clone()
        {
            return this.MemberwiseClone();
        }

        #endregion
    }
}
