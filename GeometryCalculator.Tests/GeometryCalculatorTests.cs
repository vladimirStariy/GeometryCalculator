using GeometryCalculator.Figures;

namespace GeometryCalculator.Tests
{
    public class GeometryCalculatorTests
    {
        [Test]
        public void CircleNegativeRadiusTest()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => new Circle(-3));
        }

        [Test]
        public void CircleSquareTest()
        {
            var circle = new Circle(10);
            var square = circle.GetSquare();
            Assert.That(square, Is.EqualTo(314.15926535897931));
        }

        [Test]
        public void TriangleEdgeTest()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => new Triangle(-10, 1, 2));
            Assert.Throws<ArgumentOutOfRangeException>(() => new Triangle(6, -1, 2));
            Assert.Throws<ArgumentOutOfRangeException>(() => new Triangle(6, -1, -2));
            Assert.Throws<ArgumentOutOfRangeException>(() => new Triangle(0, 3, 6));
            Assert.Throws<ArgumentOutOfRangeException>(() => new Triangle(5, 3, 0));
        }

        [Test]
        public void TriangleSquareTest()
        {
            var triangle = new Triangle(2, 8, 7);
            var square = triangle.GetSquare();
            Assert.That(square, Is.EqualTo(6.4371965947918666));
        }

        [Test]
        public void IsRightTriangleTest()
        {
            var triangle = new Triangle(5, 3, 4);
            var isRightTriangle = triangle.IsRightTriangle();
            Assert.That(isRightTriangle, Is.EqualTo(true));
        }

        [Test]
        public void IsNotRightTriangleTest()
        {
            var triangle = new Triangle(5, 6, 9);
            var isRightTriangle = triangle.IsRightTriangle();
            Assert.That(isRightTriangle, Is.EqualTo(false));
        }
    }
}