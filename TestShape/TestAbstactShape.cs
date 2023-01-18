using NUnit.Framework;
using ShapeLibruary;
using System.Data;
using System.Globalization;

namespace TestShape
{
    public class TestAbstactShape
    {
        [Test]
        public void TestGetAreaCircle()
        {
          
            List<double> resultArea = new List<double> { 50.26, 38.48 , 6 } ;

            AbstactShape[] shapes =
            {
                new Circle(4),
                new Circle(3.5),
                new Triangle (3, 4, 5)
            };

            var ShapesAriaResult = new List<double>();
            foreach (var shape in shapes)
            {
                ShapesAriaResult.Add(shape.GetArea());
            }

            CollectionAssert.AreEqual(ShapesAriaResult, resultArea, new MyComparer());
           
        }

    }

}