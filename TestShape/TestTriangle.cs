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



    }
}