using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeLibruary
{
    public class Circle : AbstactShape
    { 
      /// <param name="Radius">Радиус круга(Должен быть больше нуля)</param>
        public Circle(double Radius):base(Radius)
        {
           
        }

        public override double GetArea( ) => parameters[0] * parameters[0] *Math.PI;
    }
}
