using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryCalculator
{
    public abstract class Figure
    {
        private readonly Lazy<double> _square;

        public double Square => _square.Value;

        public double GetSquare()
        {
            return new Lazy<double>(CalculateSquare()).Value;
        }

        protected abstract double CalculateSquare();
    }
}
