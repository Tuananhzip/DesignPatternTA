using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternTH2.Design_Pattern.Prototype
{
    internal class Ford : BasicCar
    {
        public Ford(string modelName)
        {
            ModelName = modelName;
        }
        public override BasicCar Clone()
        {
            return (Ford)this.MemberwiseClone();// shallow clone
        }
    }
}
