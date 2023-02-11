namespace GeometryCalculator.Figures
{
    public class Circle : Figure
    {
        public double Radius { get; }

        public Circle(double radius)
        {
            if (radius < 0)
                throw new ArgumentOutOfRangeException("Радиус не может быть меньше нуля");
            Radius = radius;
        }

        protected sealed override double CalculateSquare()
        {
            return Math.PI * Radius * Radius;
        }
    }
}
