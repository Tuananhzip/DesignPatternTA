using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternTH3.BuilderPattern
{
    internal interface IBuilder
    {
        void AddHeadlights();
        void BuildBody();
        void EndOperations();
        void StartUpOperations();
        void InsertWheels();
        Product GetVehical();

    }
}
