using NUnit.Framework;
using ShapeLibruary;
using System.Data;

namespace TestShape
{

    public class TestsCircle
    {
        [Test]
        public void TestCreateCircle()
        {
            Circle circle = new Circle(1);
            Assert.NotNull(circle);
         
        }
        
       [Test]
        public void TestCreateCircleWithException()
        {
            Assert.Throws<ArgumentException>(() => { new Circle(-4); });

        }

        [Test]
        public void TestGetAreaCircle()
        {
            double[] resultArea =  { 50.26, 38.48 } ;
            const double delta = 0.02;
          
            Assert.AreEqual(new Circle(4).GetArea(), resultArea[0], delta);
            Assert.AreEqual(new Circle(3.5).GetArea(), resultArea[1], delta);
        }

    }
}