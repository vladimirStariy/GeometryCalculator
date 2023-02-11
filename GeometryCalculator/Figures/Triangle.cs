using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryCalculator.Figures
{
    public class Triangle : Figure
    {
        private double _firstEdge;
        private double _secondEdge;
        private double _thirdEdge;

        private bool _isRightTriangle;

        public Triangle(double firstEdge, double secondEdge, double thirdEdge)
        {
            if (firstEdge <= 0 || secondEdge <= 0 || thirdEdge <= 0)
                throw new ArgumentOutOfRangeException("Сторона треугольника не может быть меньше или равна нулю");

            _firstEdge = firstEdge;
            _secondEdge = secondEdge;
            _thirdEdge = thirdEdge;

            _isRightTriangle = CheckIsRightTriangle();
        }

        public bool IsRightTriangle()
        {
            return _isRightTriangle;
        }

        private bool CheckIsRightTriangle()
        {
            double hypotenuse = new[] { _firstEdge, _secondEdge, _thirdEdge }.Max();
            double hypotenuseSqr = hypotenuse * hypotenuse;
            return hypotenuseSqr + hypotenuseSqr == _firstEdge * _firstEdge + _secondEdge * _secondEdge + _thirdEdge * _thirdEdge;
        }

        protected sealed override double CalculateSquare()
        {
            double perimeter = (_firstEdge + _secondEdge + _thirdEdge) / 2;

            return Math.Sqrt(perimeter * (perimeter - _firstEdge) * (perimeter - _secondEdge) * (perimeter - _thirdEdge));
        }
    }
}
