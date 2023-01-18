using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ShapeLibruary
{
    public class Triangle : AbstactShape
    {
        private readonly double delta;
        /// <param name="a">Сторона A треугольниа(больше нуля) </param>
        /// <param name="b">Сторона B треугольниа(больше нуля) </param>
        /// <param name="c">Сторона C треугольниа(больше нуля)</param>
        /// <param name="delta">Дельта для корректности проверки на то, что треугоьник прямоугольный</param>
        public Triangle(double a, double b, double c, double delta = 1e-9) :base(a, b, c)
        {
            if (delta < 0) throw new ArgumentException("Дельта не может быть меньше нуля");
            this.delta = delta;

            if (parameters[0] >= parameters[1] + parameters[2])
            {
                throw new Exception("Стороны не образуют треугольник");
            }
            
        }
         override protected double[] SortParameters(double[] parameters)
        {
            return parameters.OrderByDescending(x=>x).ToArray() ;

        }

        /// <returns>Возвращает результат проверки на то, что треуголник прямоугольный</returns>
        public bool IsRight()
        {
            var SquareSumLegs = (parameters[1] * parameters[1] + parameters[2] * parameters[2]);
            var SquareHypotenuse = parameters[0] * parameters[0];
            return Math.Abs(SquareSumLegs - SquareHypotenuse) < delta;
        }
       
        public override double GetArea()
        {
            var semiperimeter  = parameters.Sum() / 2;
            return Math.Sqrt(semiperimeter * (semiperimeter - parameters[0]) 
                * (semiperimeter - parameters[1])
                * (semiperimeter - parameters[2]));
        }
    }
}
