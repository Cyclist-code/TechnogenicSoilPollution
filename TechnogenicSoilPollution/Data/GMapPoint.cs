using System;
using System.Drawing;
using GMap.NET;
using GMap.NET.WindowsForms;

namespace TechnogenicSoilPollution.Data
{
    public class GMapPoint : GMapMarker
    {
        private PointLatLng point_;
        private float size_ = 2;
        private Brush brush;
        public PointLatLng Point
        {
            get
            {
                return point_;
            }
            set
            {
                point_ = value;
            }
        }

        public GMapPoint(PointLatLng p, double qt)
            : base(p)
        {
            point_ = p;
            if (qt > 12)
            {
                brush = new SolidBrush(Color.FromArgb(80, 255, 0, 0));
            }
            else if (qt > 10.5)
            {
                brush = new SolidBrush(Color.FromArgb(80, 255, 128, 0));
            }
            else if (qt > 9)
            {
                brush = new SolidBrush(Color.FromArgb(80, 255, 255, 0));
            }
            else if (qt > 7.5)
            {
                brush = new SolidBrush(Color.FromArgb(80, 0, 255, 0));
            }
            else if (qt > 6)
            {
                brush = new SolidBrush(Color.FromArgb(80, 0, 190, 50));
            }
            else if (qt > 4.5)
            {
                brush = new SolidBrush(Color.FromArgb(80, 0, 150, 120));
            }
            else if (qt > 3)
            {
                brush = new SolidBrush(Color.FromArgb(80, 50, 160, 210));
            }
            else
            {
                brush = new SolidBrush(Color.FromArgb(80, 50, 200, 240));
            }
        }

        public override void OnRender(Graphics g)
        {
            g.FillRectangle(brush, LocalPosition.X, LocalPosition.Y, size_, size_);
        }
    }
}
