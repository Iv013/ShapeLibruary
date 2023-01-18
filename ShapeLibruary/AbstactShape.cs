using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeLibruary
{
    public abstract class AbstactShape
    {
        private protected List<double> parameters { get; set; }
       
        /// <summary>
        /// Возвращает площадь фигуры
        /// </summary>
        /// <returns></returns>
        public abstract double GetArea();

        public   AbstactShape(params double[] parameters)
        {
            this.parameters = new List<double>();
            foreach (var parameter in SortParameters(parameters))
            {
                if (parameter <= 0) throw new ArgumentException("Параметры фигуры должны быть больше нуля");
                this.parameters.Add(parameter);
            }
        }

        protected virtual double[] SortParameters(double[] parameters) => parameters;
      
    }
}
