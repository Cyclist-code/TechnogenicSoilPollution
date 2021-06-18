using System;

namespace TechnogenicSoilPollution.Helpers
{
    public class CoordinatesPoint
    {
        public double x { get; set; }
        public double y { get; set; }
        public int numberPoint { get; set; }

        public CoordinatesPoint() { }
        public CoordinatesPoint(double _x, double _y)
        {
            x = _x;
            y = _y;
        }
        public CoordinatesPoint(int number, double _x, double _y)
        {
            numberPoint = number;
            x = _x;
            y = _y;
        }
    }
}
