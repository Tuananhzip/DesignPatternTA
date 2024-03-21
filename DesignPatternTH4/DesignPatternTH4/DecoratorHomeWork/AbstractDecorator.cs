using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternTH4.DecoratorHomeWork
{
    internal class AbstractDecorator : Component
    {
        protected Component component;
        public void SetComponent(Component component)
        {
            this.component = component;
        }
        public override void DiHoc()
        {
            if(component != null)
            {
                component.DiHoc();
            }
        }
    }
}
