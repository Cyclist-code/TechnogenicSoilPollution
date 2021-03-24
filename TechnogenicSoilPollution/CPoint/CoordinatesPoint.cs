using System;

namespace TechnogenicSoilPollution.CPoint
{
    // Класс для координат точек пробоотбора
    public class CoordinatesPoint
    {
        public double x { get; set; }
        public double y { get; set; }

        public CoordinatesPoint() { }

        public CoordinatesPoint(double _x, double _y)
        {
            x = _x;
            y = _y;
        }
    }
}
