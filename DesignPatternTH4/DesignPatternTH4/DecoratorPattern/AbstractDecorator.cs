using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternTH4.DecoratorPattern
{
    internal abstract class AbstractDecorator : Component
    {
        protected Component component;
        public void SetTheComponent(Component component)
        {
            this.component = component;
        }
        public override void MakeHouse()
        {
            if (component != null)
            {
                component.MakeHouse(); 
            }
        }
    }
}
