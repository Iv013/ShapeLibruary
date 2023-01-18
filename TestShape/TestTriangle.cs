using NUnit.Framework;
using ShapeLibruary;

namespace TestShape
{

    public class TestTriangle
    {

        [Test]
        public void TestCreateTriangle()
        {
            Triangle triangle = new Triangle(1 , 4, 3.7);
            Assert.NotNull(triangle);
        }

        [Test]
        public void TestCreateTriangleWithException()
        {
            Assert.Throws<ArgumentException>(() => { new Triangle(-4, 1, 4); });
            Assert.Throws<ArgumentException>(() => { new Triangle(4, 0, 4); });
            Assert.Throws<ArgumentException>(() => { new Triangle(4, 1, -4); });
            Assert.Throws<Exception>(() => { new Triangle(4, 6, 11); });
        }

        [Test]
        public void GetAreaTriangleTest()
        {
            double resultArea =1.81;
            const double delta = 0.02;

            Assert.That(resultArea, Is.EqualTo(new Triangle(1, 4, 3.7).GetArea()).Within(delta));
            Assert.That(new Triangle(3, 4, 5).GetArea(), Is.EqualTo(6.0));
        }

        [Test]
        public void IsRightTriangleTest()
        {
            var triangle = new Triangle(3, 4, 5);
            Assert.True(triangle.IsRight());

             triangle = new Triangle(3, 4, 6);
           Assert.False(triangle.IsRight());

             triangle = new Triangle(5, 6, 7.81);
            Assert.False(triangle.IsRight());

            triangle = new Triangle(5, 6, 7.81, 0.01);
            Assert.True(triangle.IsRight());
        }

    }
}