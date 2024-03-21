using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternTH3.BuilderPattern
{
    internal class MotorCycle : IBuilder
    {
        private string brandName;
        private Product product;
        public MotorCycle(string brand)
        {
            product = new Product();
            this.brandName = brand;
        }
        public void StartUpOperations()
        {
            //
        }
        public void BuildBody()
        {
            product.Add("This is a body of a Motorcycle");
        }
        public void InsertWheels()
        {
            product.Add("2 Wheels are added");
        }
        public void AddHeadlights()
        {
            product.Add("1 Headlights are added");
        }
        public void EndOperations()
        {
            //Finishing up with brandname
            product.Add(string.Format("Motorcycle Model name: {0}", this.brandName));
        }
        public Product GetVehical()
        {
            return  product;
        }

    }
}
