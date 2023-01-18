using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeLibruary
{
    public class Triangle : AbstactShape
    {

        private readonly double epsilon;
        /// <param name="a">Сторона A треугольниа(больше нуля) </param>
        /// <param name="b">Сторона B треугольниа(больше нуля) </param>
        /// <param name="c">Сторона C треугольниа(больше нуля)</param>
        /// <param name="epsilon">Дельта для корректности проверки на то, что треугоьник прямоугольный(по умолчанию 1е-9)</param>
        public Triangle(double a, double b, double c, double epsilon = 1e-9) :base(a , b, c)
        {
            this.epsilon = epsilon;
            if (parameters[0] >= parameters[1] + parameters[2])
            {
                throw new Exception("Стороны не образуют треугольник");
            }
            
        }



        /// <returns>Возвращает результат проверки на то, что треуголник прямоугольный</returns>
        public bool IsRight()
        {
            var SquareSumLegs = (parameters[1] * parameters[1] + parameters[2] * parameters[2]);
            var Squarehypotenuse = parameters[0] * parameters[0];
            return Math.Abs(SquareSumLegs - Squarehypotenuse) < epsilon;
        }
       


        public override double GetArea()
        {
            var semiperimeter  = parameters.Sum() / 2;
            return Math.Sqrt(semiperimeter * (semiperimeter - parameters[0]) * (semiperimeter - parameters[1]) * (semiperimeter - parameters[2]));
        }
    }
}
